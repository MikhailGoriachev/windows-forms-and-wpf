using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;         // для сериализации
using System.Runtime.Serialization.Json;    // для сериализации
using System.IO;

using HomeWork.Models;              // модели 
using HomeWork.Models.Task1;        // модели для задания 1

/*    
 *  Задача 1. Разработайте приложение Windows Presentation Foundation 
 *  для закрепления изученных тем. 
 *  Разработайте класс с использованием свойств зависимости для 
 *  представления данных сотрудника: фамилия, имя, отчество, возраст,
 *  оклад, город проживания. Используйте корректирующие валидаторы для 
 *  возраста (от 0 до 190), оклада (от 0 до 1 000 000).
 *  
 *  В главном окне разместите кнопку для добавления данных сотрудника
 *  в коллекцию, коллекцию отображайте в DataGrid с форматированием 
 *  ячеек, заданием шаблонов ячеек, заголовков.
 *  
 *  Коллекцию упорядочивайте по фамилии, имени, отчества сотрудника.
 *  
 *  Добавление данных сотрудника реализуйте в отдельном окне с 
 *  использованием привязки, свойств зависимости.
 *  
 *  Для выбранной строки в DataGrid реализуйте редактирование в том же 
 *  окне, что и добавление, удаление записи из коллекции (это может быть 
 *  контекстное меню или другая реализация по Вашему выбору).
*/

namespace HomeWork.Controllers
{
    // Класс Контроллер обработки персон по заданию 1
    public class Task1Controller
    {
        // коллекция сотрудников 
        private List<EmployeeModel> _employees;

        public List<EmployeeModel> Employees
        {
            get => _employees;
            set => _employees = value;
        }


        // файл для сохранения/загрузки данных
        private string _saveFile;

        public string SaveFile
        {
            get => _saveFile;
            set => _saveFile = value;
        }


        #region Конструкторы


        // конструктор по умолчанию
        public Task1Controller() : this(new List<EmployeeModel>().GetEmployees(), "./App_data/employees.json") { }


        // конструктор инициализирующий
        public Task1Controller(List<EmployeeModel> employees, string saveFile)
        {
            // установка значений
            _employees = employees;
            _saveFile = saveFile;

            // стартовая загрузка
            StartLoad();
        }


        #endregion

        #region Методы


        // формирование коллекции сотрудников
        public void Initialization() { _employees = new List<EmployeeModel>().GetEmployees(); Save(); }


        // добавление сотрудника
        public void Add(EmployeeModel employee) { _employees.Add(employee); Save(); }


        // удаление сотрудника
        public void Remove(EmployeeModel employee) { _employees.Remove(employee); Save(); }


        // удаление сотрудника по индексу
        public void RemoveAt(int index) {  _employees.RemoveAt(index); Save(); }


        // очистка списка сотрудников
        public void Clear() { _employees.Clear(); Save(); }


        // добавление коллекции сотрудников
        public void AddRange(int n = 15) { _employees.AddRange(new List<EmployeeModel>().GetEmployees(n)); Save(); }


        // сортировка по полю Фамилия
        public void SortBySurname() { _employees = _employees.OrderBy(e => e.Surname).ToList(); Save(); }


        // сортировка по полю Имя
        public void SortByName() { _employees = _employees.OrderBy(e => e.Name).ToList(); Save(); }


        // сортировка по полю Отчество
        public void SortByPatronymic() { _employees = _employees.OrderBy(e => e.Patronymic).ToList(); Save(); }


        // сортировка по убыванию оклада сотрудника
        public void SortBySalaryDesc() { _employees = _employees.OrderByDescending(e => e.Salary).ToList(); Save(); }



        #region Загрузка/сохранение данных


        // стартовая загрузка (проверяет наличие папки "App_Data" и файла "employees.json", если их нет, то создаёт их)
        public void StartLoad()
        {
            // информация о папке и файле
            DirectoryInfo directory = new DirectoryInfo("./App_Data");
            FileInfo file = new FileInfo("./App_Data/employees.json");

            // если нет папки "App_Data"
            if (!directory.Exists)
                directory.Create();

            // если нет файла "employees.json"
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
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<EmployeeSaveModel>));

                // чтение данных
                _employees = (serializer.ReadObject(st) as List<EmployeeSaveModel>).Select(e => e.GetEmployeeModel()).ToList();
            }
        }


        // сохранение данных в файл
        public void Save()
        {
            using (Stream st = new FileStream(_saveFile, FileMode.Create))
            {
                // сериализатор
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<EmployeeSaveModel>));

                // запись данных
                serializer.WriteObject(st, _employees.Select(e => new EmployeeSaveModel(e)).ToList());
            }
        }

        #endregion

        #endregion
    }
}
