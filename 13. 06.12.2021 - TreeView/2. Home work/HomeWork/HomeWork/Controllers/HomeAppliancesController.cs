using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;            // потоки данных
using Appliances.Models;      // модели
using Appliances.Utilities;   // утилиты
using System.Windows.Forms;

/*
 *      •	Проверка на наличие в папке исполняемого файла папки App_Data и файла 
 *          appliances.json с данными о квартире. Если папки и/или файл нет, то 
 *          создать папку, заполнить начальными данными объект, описывающий 
 *          электрооборудование квартиры, сериализовать данные в формате JSON
 *      •	Сохранение данных в файл – сериализация в формате JSON. 
 *      •	Загрузка данных из файла, десериализация в формате JSON. 
 *      •	Добавление электроприбора в коллекцию сериализация данных
 *      •	Удаление электроприбора из коллекции, сериализация данных
 *      •	Включение/выключение выбранного электроприбора
 *      •	Включение/выключение всех электроприборов квартиры
 *      •	Упорядочивание копии коллекции электроприборов
 *          o	По названию
 *          o	По состоянию
 *          o	По мощности
 *          o	По убыванию цены
 *      •	Выборка коллекции электроприборов, с заданным названием.
 *      •	Выборка коллекции электроприборов заданного состояния.
 */

namespace Appliances.Controllers
{
    // Класс Контроллер объекта HomeAppliances (дом с приборами)
    internal class HomeAppliancesController
    {
        // дом для обработки
        private HomeAppliances _home;

        // текущая коллекция приборов для работы
        private List<ElectricalAppliance> _currentAppliances; 

        // навзание файла для сохранения
        private string _saveFile;

        #region Свойства

        // доступ к полю _home
        public HomeAppliances Home { get => _home; set => _home = value ?? _home; }

        // доступ к полю _saveFile
        public string SaveFile
        {
            get => _saveFile;
            set => _saveFile = value;
        } // SaveFile

        // размер коллекции приборов
        public int Count => _home.Count;

        // коллекция приборов
        public List<ElectricalAppliance> Appliances { 
            get => _home.Appliances; 
            set => _home.Appliances = value ?? _home.Appliances;
        } // Appliances

        // коллекция приборов для работы
        public List<ElectricalAppliance> CurrentAppliances { 
            get => _currentAppliances; 
            set => _currentAppliances = value ?? _currentAppliances;
        } // Appliances

        // получение названия комнат
        public string[] Rooms {
            get
            {
                // коллекция с уникальными комнатами 
                SortedSet<string> set = new SortedSet<string>();

                // получение уникальных названий комнат
                _home.Appliances.ForEach(item => set.Add(item.Room));

                // массив с комнатами
                string[] rooms = new string[set.Count];

                // копирование комнат в массив
                set.CopyTo(rooms);

                return rooms;
            }
        }

        #endregion

        #region Конструкторы 

        // конструктор по умолчанию
        public HomeAppliancesController() : 
            this(new HomeAppliances { Address = "Петровского 254/8", Title = "Зелёный дом" }, ".\\App_Data\\appliances.json") { }

        // констркутор инициализирующий
        public HomeAppliancesController(HomeAppliances home, string saveFile)
        {
            // установка значений
            _home = home;
            _saveFile = saveFile;
            _currentAppliances = home.Appliances;

            // заполнение дома коллекцией приборов
            Initialization();

            // проверка/создание файла
            CheckFileSave();

            // считывание из файла в файл
            Deserialization();

        } // HomeAppliancesController

        #endregion

        #region Методы

        #region Инициализация

        // коды электроприборов для фабричного метода
        public enum ApplianceCode
        {
            // пылесос
            VacuumCleaner,
            // утюг
            FlatIron,
            // тостер
            Toaster,
            // фен 
            HairDryer,
            // чайник
            ElectricKettle
        } // ApplianceCode

        // инициализация
        public void Initialization(int n = 15)
        {
            // заполнение коллекции
            for (int i = 0; i < n; i++)
                _home.Appliances.Add(FactoryMethod(Utils.GetRand(1, 6)));
        } // Initialization

        // получение коллекции созданных Appliances
        public static List<ElectricalAppliance> GenerateAppliancesCollection(int n = 15)
        {
            List<ElectricalAppliance> appliances = new List<ElectricalAppliance>();

            for (int i = 0; i < n; i++)
                appliances.Add(FactoryMethod(Utils.GetRand(1, 6)));

            return appliances;
        }

        // фабричный метод элекстроприборов
        static public ElectricalAppliance FactoryMethod(int code)
        {
            switch (code)
            {
                // пылесос
                case (int)ApplianceCode.VacuumCleaner:
                    return new ElectricalAppliance {
                        Name = "Пылесос",
                        Power = Utils.GetRand(16, 22) * 100,
                        Price = Utils.GetRand(50, 120) * 100,
                        Room  = Utils.Rooms[Utils.GetRand(0, Utils.Rooms.Length)]
                    };
                // утюг
                case (int)ApplianceCode.FlatIron:
                    return new ElectricalAppliance {
                        Name = "Утюг",
                        Power = Utils.GetRand(12, 16) * 100,
                        Price = Utils.GetRand(50, 120) * 100,
                        Room = Utils.Rooms[Utils.GetRand(0, Utils.Rooms.Length)]
                    };
                // тостер
                case (int)ApplianceCode.Toaster:
                    return new ElectricalAppliance {
                        Name = "Тостер",
                        Power = Utils.GetRand(5, 10) * 100,
                        Price = Utils.GetRand(15, 90) * 100,
                        Room = Utils.Rooms[Utils.GetRand(0, Utils.Rooms.Length)]
                    };
                // фен 
                case (int)ApplianceCode.HairDryer:
                    return new ElectricalAppliance {
                        Name = "Фен",
                        Power = Utils.GetRand(14, 18) * 100,
                        Price = Utils.GetRand(30, 80) * 100,
                        Room = Utils.Rooms[Utils.GetRand(0, Utils.Rooms.Length)]
                    };
                // чайник
                case (int)ApplianceCode.ElectricKettle:
                    return new ElectricalAppliance {
                        Name = "Чайник",
                        Power = 800,
                        Price = 1_500,
                        Room = Utils.Rooms[Utils.GetRand(0, Utils.Rooms.Length)]
                    };
                default:
                    goto case (int)ApplianceCode.VacuumCleaner;
            } // switch
        } // FactoryMethod

        #endregion

        // проверка на наличие в папке исполняемого файла папки App_Data и файла 
        // appliances.json с данными о квартире.Если папки и/или файл нет, то
        // создать папку, заполнить начальными данными объект, описывающий
        // электрооборудование квартиры, сериализовать данные в формате JSON
        public void CheckFileSave()
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

                // сериализация в файл
                Serialization();
            }
        } // CheckFileSave

        // добавление элемента в коллекцию
        public void Add(ElectricalAppliance appliance) => _home.Add(appliance);

        // удаление элемента из коллекции по индексу
        public void RemoveAt(int index) => _home.RemoveAt(index);

        // удаление элемента из коллекции по ссылке
        public void Remove(ElectricalAppliance appliance) => _home.Remove(appliance);

        // удалание всех приборов
        public void Clear() => _home.Appliances.Clear();

        // сохранение данных в файл – сериализация в формате JSON
        public void Serialization() {            
            using (FileStream fs = new FileStream(_saveFile, FileMode.Create, FileAccess.Write))
                _home.Serialization(fs);
        } // Serialization

        // загрузка данных из файла, десериализация в формате JSON
        public bool Deserialization() {

            try
            {
                // десериализация
                using (FileStream fs = new FileStream(_saveFile, FileMode.Open, FileAccess.Read))
                    _home = HomeAppliances.Deserilization(fs);

                // установка рабочей коллекции
                _currentAppliances = _home.Appliances;
            }
            catch { return false; }



            return true;
        } // Deserialization

        // включение/выключение выбранного электроприбора
        public void TurnPower(int index, bool state) => _currentAppliances[index].TurnPower(state);

        // включение/выключение выбранного электроприбора
        public void TurnPower(ElectricalAppliance appliance, bool state) => appliance.TurnPower(state);

        // включение/выключение всех электроприборов
        public void TurnPowerAll(bool state) => _home.TurnPowerAll(state);

        // упорядочивание копии коллекции электроприборов по названию       
        public List<ElectricalAppliance> OrderByName() =>
            _home.SortBy((item1, item2) => item1.Name.CompareTo(item2.Name));

        // упорядочивание копии коллекции электроприборов по состоянию
        public List<ElectricalAppliance> OrderByState() =>
            _home.SortBy((item1, item2) => item1.StateActive.CompareTo(item2.StateActive));

        // упорядочивание копии коллекции электроприборов по мощности
        public List<ElectricalAppliance> OrderByPower() =>
            _home.SortBy((item1, item2) => item2.Power.CompareTo(item1.Power));

        // упорядочивание копии коллекции электроприборов по убыванию цены
        public List<ElectricalAppliance> OrderByPrice() =>
            _home.SortBy((item1, item2) => item2.Price.CompareTo(item1.Price));

        // выборка коллекции электроприборов, с заданным названием.
        public List<ElectricalAppliance> SelectionWhereName(string name) =>
            _home.SelectWhere(item => item.Name == name);

        // выборка коллекции электроприборов заданного состояния.
        public List<ElectricalAppliance> SelectionWhereState(bool state) =>
            _home.SelectWhere(item => item.StateActive == state);

        // выборка коллекции электроприборов по названию комнаты
        public List<ElectricalAppliance> SelectionWhereRoom(string room) =>
            _home.SelectWhere(item => item.Room == room);

        // заполнение TreeView данными 
        public void FillTreeView(TreeView treeView, ContextMenuStrip CmsApp)
        {
            // очистка TreeView
            treeView.Nodes.Clear();

            // создание корня с названием квартиры
            treeView.Nodes.Add(new TreeNode(_home.Title, 0, 0));

            // если в коллекции приборов нет элементов
            if (_home.Appliances.Count == 0) return;

            // получение названий комнат
            List<string> rooms = new List<string>(Rooms);

            // добавление комнат в корень 
            rooms.ForEach(item => treeView.Nodes[0].Nodes.Add(new TreeNode(item, 1, 2)));

            // заполнение комнат
            foreach (TreeNode node in treeView.Nodes[0].Nodes)
            {
                // добавление электроприборов в комнату
                var items = _home.Appliances.FindAll(item => item.Room.Equals(node.Text));

                foreach (var item in items)
                {
                    // получение новой Node
                    var newNode = item.GetTreeNode();

                    // установка ContextMenuStrip
                    newNode.ContextMenuStrip = CmsApp;

                    // добавление Node
                    node.Nodes.Add(newNode);
                }
            }

            // развернуть корень 
            treeView.ExpandAll();
        }

        // изменение комнаты приборов
        public void ChangeRoom(string room, List<ElectricalAppliance> appliances) => appliances.ForEach(item => item.Room = room);

        #endregion

    }
}
