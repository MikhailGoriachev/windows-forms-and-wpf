using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Utilities;                       // утилиты
using System.IO;                                // потоки данных

namespace HomeWork.Models
{
    // Класс Мастерская
    public class RepairShopModel
    {
        // адрес 
        private string _address;

        // название
        private string _name;

        // коллекция телевизоров
        private List<TelevisionModel> _televisions;

        #region Свойства 

        // доступ к полю _televisions
        public List<TelevisionModel> Televisions { get => _televisions; set => _televisions = value; }

        // доступ к полю _address
        public string Address
        {
            get { return _address; }
            set
            {
                _address = !string.IsNullOrWhiteSpace(value)
                  ? value
                  : throw new Exception("RepairShop: Поле Address не может быть пустым!");
            }
        }

        // доступ к полю _name
        public string Name
        {
            get { return _name; }
            set
            {
                _name = !string.IsNullOrWhiteSpace(value)
                  ? value
                  : throw new Exception("RepairShop: Поле Name не может быть пустым!");
            }
        }


        // размер коллекции
        public int Count => _televisions.Count();


        // минимальная цена ремонта
        public int MinPrice
        {
            get
            {
                // минимальная цена
                int min = _televisions[0].Price;

                // поиск минимального значения 
                _televisions.ForEach(item => min = item.Price < min ? item.Price : min);

                return min;
            }
        }

        // получение всех мастеров
        public List<string> Masters => _televisions.Select(item => item.Master).Distinct().ToList();

        // получение всех владельцев
        public List<string> Owners => _televisions.Select(item => item.Owner).Distinct().ToList();

        #endregion

        #region Констуркторы и индексатор

        // конструктор по умолчанию
        public RepairShopModel() : this(new List<TelevisionModel>()) { }

        // конструктор иницилизирующий
        public RepairShopModel(List<TelevisionModel> televisions)
        {
            // установка значений
            _televisions = televisions;

            // заполнение коллекции
            Initialization();
        }

        // индексатор
        public TelevisionModel this[int index]
        {
            get => _televisions[index];
            set => _televisions[index] = value;
        }

        #endregion 

        #region Методы

        // формирование данных коллекции
        public void Initialization(int n = 15)
        {
            // формирование данных
            _televisions = RepairShopModel.GenerateTelevision(n);
        }

        // формирование списка телевизоров данных коллекции
        static public List<TelevisionModel> GenerateTelevision(int n = 15)
        {
            List<TelevisionModel> televisions = new List<TelevisionModel>();

            // формирование данных
            for (int i = 0; i < n; i++)
                televisions.Add(FactoryMethod());

            return televisions;
        }

        // фабричный метод создания телевизора
        static public TelevisionModel FactoryMethod()
        {
            // производитель и тип телевизора, диагональ экрана
            (string model, int diagonal)[] modelsInfo = new[] {
                ("LG 55UN73006",        65),
                ("Samsung 55Q70T",      65),
                ("LG 55NANO866",        65),
                ("Samsung 55Q95T",      65),
                ("LG OLED55CX",         65),
                ("Sony 55XH9077",       65),
                ("LG 32LM570",          32),
                ("Xiaomi L32M5-5ARU",   32),
                ("MI TV 32 4A",         32),
                ("Octane Score ",       32),
            };

            // строка с описанием дефекта
            string[] defects = new[] {
                "Выход из строя модуля цветности",
                "Поломка блока питания",
                "Поломка электрического управления",
                "Неисправность селектора радиоканалов",
                "Поломка усилителя частот",
                "Поломка матрицы телевизора"
            };

            // фамилия и инициалами мастера
            string[] masters = new[]
            {
                "Князев И. А.",
                "Соколова В. К.",
                "Минин П. К.",
                "Михайлов Д. Я."
            };

            // фамилия и инициалы владельца
            string[] owners = new[]
            {
                "Румянцев Я. Д.",
                "Кошелева А. А.",
                "Королев Д. М.",
                "Антипов Р. В.",
                "Дорофеева А. И.",
                "Соколов П. А.",
                "Антипова С. Е.",
                "Устинова М. Е.",
                "Молчанов А. С.",
                "Тарасов М. М.",
                "Морозов С. Я.",
                "Седов Д. Т.",
                "Кулешова М. Н.",
                "Тимофеева Е. Р.",
                "Шубина В. А."
            };

            // генерация модели
            var model = modelsInfo[Utils.GetRand(0, modelsInfo.Length)];

            return new TelevisionModel
            {
                Model = model.model,
                Diagonal = model.diagonal,
                Defect = defects[Utils.GetRand(0, defects.Length)],
                Master = masters[Utils.GetRand(0, masters.Length)],
                Owner = owners[Utils.GetRand(0, owners.Length)],
                Price = Utils.GetRand(3000, 7001)
            };
        }

        // добавление телевизора
        public void Add(TelevisionModel television) => _televisions.Add(television);

        // вставка телевизора
        public void Insert(int index, TelevisionModel television) => _televisions.Insert(index, television);

        // удаление телевизора
        public void Remove(TelevisionModel television) => _televisions.Remove(television);

        // удление телевизора
        public void RemoveAt(int index) => _televisions.RemoveAt(index);

        // очистка коллекции
        public void Clear() => _televisions.Clear();

        // упорядочивание по компаратору
        public void OrderBy(Comparison<TelevisionModel> comparer) 
            => _televisions.Sort(comparer);

        // выборка по предикатору
        public List<TelevisionModel> SelectBy(Predicate<TelevisionModel> predicate) => 
            new List<TelevisionModel>(_televisions.FindAll(predicate));

        #endregion

    }
}
