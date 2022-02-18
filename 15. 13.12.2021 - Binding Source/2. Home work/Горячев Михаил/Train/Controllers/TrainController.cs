using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using Train.Models;             // модели
using Train.Utilities;          // утилиты

/*
 * Задача 1.Требуется спроектировать и разработать приложение-макет для продажи 
 * билетов на поезд. Это должно быть приложение Windows Forms с использованием 
 * изученных элементов интерфейса (DataGridView, BindingSource). 
 * 
 * Разработайте классы для прикладной части приложения. 
 * Класс Поезд, хранящий коллекцию объектов класса Вагон. Максимальное количество 
 * вагонов в поезде 20. Поезд характеризуется номером (цифры и буквы), пунктом 
 * отправления и пунктом назначения. 
 * Класс Вагон характеризуется номером вагона, количеством купе, массивом купе, 
 * максимальной вместимостью купе (типом купе).
 * Класс Купе характеризуется типом (СВ, купе, плацкарт), количеством мест, списком 
 * мест.
 * Класс Место характеризуется номером и состоянием – продано или свободно 
 * (не продано).
 * 
 * В главной форме разместить TreeView, отображающий поезд. Корнем дерева является
 * номер поезда, узлами – вагоны, подузлами – купе, листьями – места. 
 * 
 * В DataGridView по клику в TreeView на вагон выводить текущее состояние мест 
 * выбранного вагона.
 * 
 * Учтите, что Вагоны всегда состоят из 9 купе, отличаются количеством мест в купе:
 * •	СВ			– 2 места
 * •	Купейный		– 4 места 
 * •	Плацкартный 	– 6 мест
 * При помощи меню, контекстных меню, кнопок панели инструментов реализуйте 
 * следующий функционал:
 * •	добавление вагона(тип вагона задаем в меню или соответствующей кнопкой)
 * •	удаление вагона
 * •	покупка билета
 * •	возврат билета
 * •	сохранение данных поезда в файл (JSON)
 * •	чтение данных поезда из файла (JSON)
 * 
 * И сохранение в файл и чтение из файла реализуйте при помощи диалогов выбора 
 * файлов и техники Drag'n'Drop.
 * 
 * В строку состояния главного окна выводить информацию:
 * 1.Всего вагонов в поезде
 * 2.	Всего мест в поезде/продано билетов
 * 3.	СВ: вагонов / мест / продано билетов
 * 4.купейный: вагонов / мест / продано билетов
 * 5.плацкарт: вагонов / мест / продано билетов
 * 
 * В меню и контекстных меню по Вашему выбору включите команды выхода, вывода 
 * окна со сведениями о программе и ее разработчике.
*/


namespace Train.Controllers
{
    // Класс Обработчик поезда по заданию
    internal class TrainController
    {
        // поезд
        private TrainModel _train;

        public TrainModel Train
        {
            get => _train; 
            set => _train = value; 
        }


        // навзание файла для сохранения
        private string _saveFile;

        public string SaveFile
        {
            get => _saveFile; 
            set => _saveFile = value;
        }


        // текущий выбранный вагон для работы
        public Wagon CurrentWagon { get; set; }

        #region Свойства

        // получение коллекции вагонов
        public List<Wagon> Wagons => _train.Wagons;


        // количество вагонов
        public int CountWagons => _train.CountWagons;


        // количество вагонов по типам
        public (int Amount, int Sleeper, int Corridor, int Reserved) CountWagonsTypes => _train.CountWagonsTypes;


        // количество купе
        public int CountCoupe => _train.CountCoupe;


        // количество купе по типам
        public (int Amount, int Sleeper, int Corridor, int Reserved) CountCoupeTypes => _train.CountCoupeTypes;


        // количество мест (общее, свободно, занято)
        public (int amount, int busy, int free) CountSeats => _train.CountSeats;


        // количество мест СВ
        public (int amount, int busy, int free) CountSeatsSleeper => _train.CountSeatsSleeper;


        // количество мест купейный
        public (int amount, int busy, int free) CountSeatsCorridor => _train.CountSeatsCorridor;


        // количество мест плацкарт
        public (int amount, int busy, int free) CountSeatsReserved => _train.CountSeatsReserved;

        #endregion

        #region Конструкторы

        // конструктор по умолчанию
        public TrainController() :
            this(FactoryMethodTrain(), ".\\App_Data\\train.json")
        { }



        // конструктор инициализирующий
        public TrainController(TrainModel train, string saveFile)
        {
            // установка значений 
            _train = train;
            _saveFile = saveFile;

            // проверка/создание файла
            if (!CheckFileSave())
                // инициализация коллекции животными
                Serialization();

            // загрузка из файла
            Deserialization();

            // установка вагона для работы
            CurrentWagon = _train.Wagons.Count == 0 ? null : _train.Wagons[0];
        }

        #endregion

        #region Методы

        // проверка на наличие в папке исполняемого файла папки App_Data и файла 
        // train.json с данными о квартире.Если папки и/или файл нет, то
        // создать папку, заполнить начальными данными объект, описывающий
        // поезд, сериализовать данные в формате JSON Возвращает true, если файл существует,
        // иначе false, если он был создан
        public bool CheckFileSave()
        {
            // если не существует файла для сохранения 
            if (!File.Exists(_saveFile))
            {
                // путь к файлу
                string path = Path.GetDirectoryName(_saveFile);

                // если не существует папка для сохранения
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                // создание файла 
                using (File.Create(_saveFile)) { };

                return false;
            }

            return true;
        } // CheckFileSave


        // фабричный метод создания поезда
        public static TrainModel FactoryMethodTrain()
        {
            // поезд
            TrainModel train = new TrainModel { Number = Utils.GenerateNumberTrain() };

            // количество вагонов
            int n = Utils.GetRand(10, 16);

            // добавление вагонов
            for (int i = 0; i < n; i++)
                train.AddWagon((Wagon.TypeWagon)Utils.GetRand((int)Wagon.TypeWagon.Sleeper, (int)Wagon.TypeWagon.Reserved + 1));

            return train;
        }


        // добавление вагона 
        public void AddWagon(Wagon wagon) => _train.AddWagon(wagon);


        // добавление вагона 
        public void AddWagon(Wagon.TypeWagon typeWagon) => _train.AddWagon(typeWagon);


        // удаление вагона 
        public void Remove(Wagon wagon) => _train.Remove(wagon);


        // удаление вагона 
        public void RemoveAt(int index) => _train.RemoveAt(index);


        // удаление всех вагонов
        public void Clear() => _train.Clear();


        // обмена вагонов местами
        public void SwapWagons(Wagon wagon1, Wagon wagon2) => _train.SwapWagons(wagon1, wagon2);


        // обмен вагонов местами
        public void SwapWagons(int index1, int index2) => _train.SwapWagons(index1, index2);


        // сохранение данных в файл – сериализация в формате JSON
        public void Serialization()
        {
            // форматтер 
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TrainModel));

            using (FileStream fs = new FileStream(_saveFile, FileMode.Create, FileAccess.Write))
                serializer.WriteObject(fs, _train);
        } // Serialization


        // загрузка данных из файла, десериализация в формате JSON
        public bool Deserialization()
        {

            // форматтер 
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TrainModel));

            try
            {
                // десериализация
                using (FileStream fs = new FileStream(_saveFile, FileMode.Open, FileAccess.Read))
                    _train = (TrainModel)serializer.ReadObject(fs);
            }
            catch { return false; }

            return true;
        } // Deserialization


        // загрузка из файла 
        public bool LoadToFile(string fileName, BindingSource source)
        {
            // старое название файла
            string oldFile = _saveFile;

            // установка названия файла
            _saveFile = fileName;

            // успешность десериализации
            bool flag = Deserialization();

            // десериализация из файла
            // если неудачно, то установка прошлого файла
            _saveFile = flag ? fileName : oldFile;

            // обновление информации в DataGridView
            if (flag)
                source.ResetBindings(false);

            return flag;
        }


        // сохранение в файл
        public void SaveToFile(string fileName)
        {
            // установка названия файла
            _saveFile = fileName;

            // сериализация в файл
            Serialization();
        }


        // заполнение DataTreeView
        public void ShowTreeView(TreeView view)
        {
            // очистка дерева
            view.Nodes.Clear();

            // заполенение дерева
            view.Nodes.Add(_train.GetTreeNode());
        }

        #endregion
    }
}
