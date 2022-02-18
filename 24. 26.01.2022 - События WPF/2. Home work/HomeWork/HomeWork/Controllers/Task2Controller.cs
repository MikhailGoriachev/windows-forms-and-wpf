using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

using HomeWork.Models.Task2;            // модели для задания 2
using HomeWork.Models;                  // модели

/*
 * Задача 2 (дополнительная задача, реализуйте ее только после выполнения задачи 1 
 * в полном объеме). Разработайте в технологии Windows Presentation Foundation (WPF)
 * макет приложения для учета подписок на периодические издания. Необходимо хранить
 * фамилию и инициалы подписчика, его адрес (улицу, дом и квартиру), название 
 * издания, тип издания, индекс издания, дату начала подписки и период подписки.
 * 
 * •	В главном окне, в отдельной вкладке выводите в DataGrid выводите данные о 
 *      подписке – фамилия и инициалы подписчика, индекс и название издания, улицу из 
 *      адреса подписчика.
 * •	В детальной информации для выбранной подписки выводите всю информацию о 
 *      подписчике и издании.
 * •	Используйте шаблоны ячеек для отображения данных о подписке.
 * •	При помощи отдельного окна добавляйте и изменяйте подписки – подписка 
 *      выполняется на 1, 3, 6 или 12 месяцев.
 * •	Хранение данных организовать с применением файла типа JSON, файлы выбирать 
 *      стандартным диалогом.
 *      
 * Используйте контекстное меню, главное меню, панели инструментов, вкладки и другие 
 * изученные элементы интерфейса пользователя.
 * Реализуйте сортировку копии коллекции и вывод этой копии в отдельной вкладке в 
 * DataGrid для следующих запросов:
 * •	Упорядочивание по индексу издания
 * •	Упорядочивание по адресу подписчика
 * •	Упорядочивание по убыванию периода подписки
 * 
 * Реализуйте выборку данных о подписках, вывод выборки в отдельную вкладку, в DataGrid:
 * •	Подписки по выбранному типу издания
 * •	Подписки по выбранному периоду
 * •	Подписки по выбранной фамилии и инициалам подписчика
*/

namespace HomeWork.Controllers
{
    // Класс Контроллер обработки периодический изданий по заданию 2
    public class Task2Controller
    {
        // коллекция периодический изданий
        private List<PeriodicalModel> _periodicals;

        public List<PeriodicalModel> Periodicals
        {
            get => _periodicals;
            set => _periodicals = value;
        }


        // файл для сохранения/загрузки данных
        private string _saveFile;

        public string SaveFile
        {
            get => _saveFile;
            set => _saveFile = value;
        }


        // количество элементов в коллекции
        public int Count => _periodicals.Count;


        // полчить типы изданий
        public List<string> TypesEdition => Utilities.Utils.TypesOfEdition.ToList();


        // получить периоды подписки
        public List<int> Periods => new List<int>(new int[] { 1, 3, 6, 12 });


        // получить фамилии и инициалы подписчиков
        public List<string> FullNameSubscribers => _periodicals.Select(p => p.FullName).Distinct().ToList();


        // получить названия изданий
        public List<string> Titles => _periodicals.Select(p => p.Title).Distinct().ToList();

        #region Конструкторы


        // конструктор по умолчанию
        public Task2Controller() : this(new List<PeriodicalModel>().GetPeriodicals(), "./App_Data/periodicals.json") { }


        // конструктор инициализирующий
        public Task2Controller(List<PeriodicalModel> periodicals, string saveFile)
        {
            // установка значений
            _periodicals = periodicals;
            _saveFile = saveFile;

            // стартовая загрузка
            StartLoad();
        }


        #endregion


        #region Методы

        // формирование коллекции подписок
        public void Initialization() { _periodicals = new List<PeriodicalModel>().GetPeriodicals(); Save(); }


        // добавление коллекции подписок
        public void AddRange(int n = 15) { _periodicals.AddRange(new List<PeriodicalModel>().GetPeriodicals(n)); Save(); }


        // очистка списка подписок
        public void Clear() { _periodicals.Clear(); Save(); }


        #region Загрузка/сохранение данных


        // стартовая загрузка (проверяет наличие папки "App_Data" и файла "periodicals.json", если их нет, то создаёт их)
        public void StartLoad()
        {
            // информация о папке и файле
            DirectoryInfo directory = new DirectoryInfo("./App_Data");
            FileInfo file = new FileInfo("./App_Data/periodicals.json");

            // если нет папки "App_Data"
            if (!directory.Exists)
                directory.Create();

            // если нет файла "periodicals.json"
            if (!file.Exists)
            {
                // создание файла
                using (file.Create()) ;

                // сохранение данных
                Save();
            }

            // загрузка данных из файла
            Load();
        }


        // загрузка данных из файла
        public void Load()
        {
            using (Stream st = new FileStream(_saveFile, FileMode.Open))
            {
                // сериализатор
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<PeriodicalSaveModel>));

                // чтение данных
                _periodicals = (serializer.ReadObject(st) as List<PeriodicalSaveModel>).Select(p => p.GetPeriodicalModel()).ToList();
            }
        }


        // сохранение данных в файл
        public void Save()
        {
            using (Stream st = new FileStream(_saveFile, FileMode.Create))
            {
                // сериализатор
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<PeriodicalSaveModel>));

                // запись данных
                serializer.WriteObject(st, _periodicals.Select(p => new PeriodicalSaveModel(p)).ToList());
            }
        }

        #endregion


        #region CRUD - операции


        // добавление издания 
        public void Add(PeriodicalModel periodical) { _periodicals.Add(periodical); Save(); }


        // удаление издания
        public void Remove(PeriodicalModel periodical) { _periodicals.Remove(periodical); Save(); }


        // удаление издания по индексу 
        public void RemoveAt(int index) { _periodicals.RemoveAt(index); Save(); }


        #endregion


        #region Сортировки 


        // сортировка копии по индексу издания
        public List<PeriodicalModel> OrderByIndex() => _periodicals.OrderBy(p => p.Index).ToList();


        // сортировка копии по адресу подписчика
        public List<PeriodicalModel> OrderByAddress() => _periodicals.OrderBy(p => $"{p.Apartment} {p.Home} {p.Apartment}").ToList();


        // сортировка копии по убыванию периода подписки
        public List<PeriodicalModel> OrderByDuration() => _periodicals.OrderByDescending(p => p.Duration).ToList();


        // сортировка копии по типу издания
        public List<PeriodicalModel> OrderByTypeEdition() => _periodicals.OrderByDescending(p => p.TypeEdition).ToList();



        #endregion


        #region Выборки


        // выборка по выбранному типу издания
        public List<PeriodicalModel> SelectionWhereTypeEdition(string typeEdition) => _periodicals.Where(p => p.TypeEdition == typeEdition).ToList();


        // выборка по выбранному периоду
        public List<PeriodicalModel> SelectionWhereDuration(int duration) => _periodicals.Where(p => p.Duration == duration).ToList();


        // выборка по выбранной фамилии и инициалам подписчика
        public List<PeriodicalModel> SelectionWhereFullName(string fullName) => _periodicals.Where(p => p.FullName == fullName).ToList();


        // выборка по выбранному названию издания
        public List<PeriodicalModel> SelectionWhereTitle(string title) => _periodicals.Where(p => p.Title == title).ToList();


        #endregion

        #endregion

    }
}
