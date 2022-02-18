using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                     // элементы Windows Forms
using System.IO;                                // потоки данных
using System.Runtime.Serialization;             // json сериализация
using System.Runtime.Serialization.Json;        // json сериализация
using Animals.Models;       // модели
using Animals.Utilities;    // утилиты

/*
         * выборку коллекции животных с максимальным весом
         * выборку коллекции животных, фамилия владельцев которых содержит заданную подстроку (подстроку вводить в этой же вкладке)
         * отсортированную по возрасту копию коллекции животных
         * отсортированную по виду копии коллекции животных
         * отсортированную по фамилиям владельцев копию коллекции животных
         * сохранению в коллекцию в файле типа JSON, в папке App_Data у исполняемого файла
         * загрузка коллекции из файла JSON
*/

namespace Animals.Controllers
{
    // Класс Контроллер коллекции зверей
    internal class AnimalsController
    {
        // навзание файла для сохранения
        private string _saveFile;

        #region Свойства

        // зоопарк
        public ZooModel Zoo { get; set; }

        // коллекция зверей
        public List<Animal> AnimalsZoo { get => Zoo.AnimalsZoo; set => Zoo.AnimalsZoo = value; }

        // доступ к полю _saveFile
        public string SaveFile
        {
            get => _saveFile;
            set => _saveFile = value;
        } // SaveFile

        // размер коллекции зверей
        public int Count => AnimalsZoo.Count;

        // максимальный вес 
        public double MaxWight {
            get
            {
                // максимальный вес 
                double max = 0d;

                // поиск минимального веса 
                AnimalsZoo.ForEach(item => max = item.Weight.CompareTo(max) > 0 ? item.Weight : max);

                return max;
            }
        }

        // получение коллекции фамилий владельцев
        public string[] SurnamesOwners
        {
            get
            {
                // коллекция
                var set = new SortedSet<string>();

                // поулчение всех фамилий
                AnimalsZoo.ForEach(item => set.Add(item.Owner.Substring(0, item.Owner.Length - 6)));

                // массив для фамилий
                string[] arr = new string[set.Count];

                // копирование в массив
                set.CopyTo(arr);

                return arr;
            }
        }

        #endregion

        #region Конструкторы 

        // конструктор по умолчанию
        public AnimalsController() :
            this(".\\App_Data\\animals.json", new ZooModel { Title = "Зоопарк \"Бинго\""}) { }

        // констркутор инициализирующий
        public AnimalsController(string fileName, ZooModel zoo)
        {
            // установка значений
            _saveFile = fileName;
            Zoo = zoo;

            // проверка/создание файла
            if (!CheckFileSave())
                // инициализация коллекции животными
                Initialization();

            // загрузка из файла
            Deserialization();

        } // HomeAppliancesController

        #endregion

        #region Методы

        #region Инициализация

        // коды животных
        public enum AnimalCode
        {
            // птица
            Bird,
            // бык
            Bull,
            // кошка
            Cat,
            // корова 
            Cow,
            // собака
            Dog,
            // утка 
            Duck,
            // слон 
            Elephant,
            // рыба 
            Fish,
            // лошадь 
            Horse,
            // божья коровка 
            Ladybug,
            // леопард 
            Leopard,
            // лев 
            Lion,
            // лобстер 
            Lobster,
            // заяц 
            Rabbit,
            // улитка 
            Snail,
            // черепаха 
            Turtle,
        } // ApplianceCode


        // инициализация
        public void Initialization(int n = 20) { AnimalsZoo = GenerateAnimals(n); Serialization(); }


        // получение коллекции созданных Appliances
        public static List<Animal> GenerateAnimals(int n = 20)
        {
            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < n; i++)
                animals.Add(FactoryMethod((AnimalCode)Utils.GetRand(0, 16)));

            return animals;
        } // GenerateAnimals


        // фабричный метод элекстроприборов
        static public Animal FactoryMethod(AnimalCode code)
        {
            switch (code)
            {
                // птица
                case AnimalCode.Bird:
                    return new Animal
                    {
                        IdImage = 0,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(1, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Птица",
                        Weight = Utils.GetRand(0.5, 3d),
                        Сolor = Utils.Colors[Utils.GetRand(0, Utils.Colors.Length)],
                    };

                // бык
                case AnimalCode.Bull:
                    return new Animal {
                        IdImage = 1,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Бык",
                        Weight = Utils.GetRand(400d, 750d),
                        Сolor = Utils.Colors[Utils.GetRand(0, Utils.Colors.Length)],
                    };

                // кошка
                case AnimalCode.Cat:
                    return new Animal {
                        IdImage = 2,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Кошка",
                        Weight = Utils.GetRand(3.6, 4.5),
                        Сolor = Utils.Colors[Utils.GetRand(0, Utils.Colors.Length)],
                    };

                // корова 
                case AnimalCode.Cow:
                    return new Animal {
                        IdImage = 3,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Корова",
                        Weight = Utils.GetRand(400d, 750d),
                        Сolor = Utils.Colors[Utils.GetRand(1, 3)],
                    };

                // собака
                case AnimalCode.Dog:
                    return new Animal {
                        IdImage = 4,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Собака",
                        Weight = Utils.GetRand(12d, 15d),
                        Сolor = Utils.Colors[Utils.GetRand(0, 3)],
                    };

                // утка 
                case AnimalCode.Duck:
                    return new Animal {
                        IdImage = 5,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 10),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Утка",
                        Weight = Utils.GetRand(0.5, 1d),
                        Сolor = Utils.Colors[Utils.GetRand(1, 4)],
                    };

                // слон 
                case AnimalCode.Elephant:
                    return new Animal {
                        IdImage = 6,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(20, 50),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Слон",
                        Weight = Utils.GetRand(3_000d, 6_000d),
                        Сolor = Utils.Colors[0],
                    };

                // рыба 
                case AnimalCode.Fish:
                    return new Animal {
                        IdImage = 7,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 10),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Рыба",
                        Weight = Utils.GetRand(0.5, 15d),
                        Сolor = Utils.Colors[Utils.GetRand(1, Utils.Colors.Length)],
                    };

                // лошадь 
                case AnimalCode.Horse:
                    return new Animal {
                        IdImage = 8,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(15, 30),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Лошадь",
                        Weight = Utils.GetRand(300d, 450d),
                        Сolor = Utils.Colors[Utils.GetRand(1, 3)],
                    };

                // божья коровка 
                case AnimalCode.Ladybug:
                    return new Animal {
                        IdImage = 9,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(1, 3),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Божья коровка",
                        Weight = Utils.GetRand(3e-5, 5e-5),
                        Сolor = Utils.Colors[Utils.GetRand(4, 6)],
                    };

                // леопард 
                case AnimalCode.Leopard:
                    return new Animal {
                        IdImage = 10,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(7, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Леопард",
                        Weight = Utils.GetRand(20d, 31d),
                        Сolor = Utils.Colors[6],
                    };

                // лев 
                case AnimalCode.Lion:
                    return new Animal {
                        IdImage = 11,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(7, 15),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Лев",
                        Weight = Utils.GetRand(130d, 190d),
                        Сolor = Utils.Colors[6],
                    };

                // лобстер 
                case AnimalCode.Lobster:
                    return new Animal {
                        IdImage = 12,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(15, 54),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Лобстер",
                        Weight = Utils.GetRand(0.3, 0.8),
                        Сolor = Utils.Colors[5],
                    };

                // заяц 
                case AnimalCode.Rabbit:
                    return new Animal {
                        IdImage = 13,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(1, 6),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Заяц",
                        Weight = Utils.GetRand(1.6, 7d),
                        Сolor = Utils.Colors[Utils.GetRand(0, 2)],
                    };

                // улитка 
                case AnimalCode.Snail:
                    return new Animal {
                        IdImage = 14,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(5, 12),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Улитка",
                        Weight = Utils.GetRand(25d, 30d),
                        Сolor = Utils.Colors[Utils.GetRand(0, 2)],
                    };

                // черепаха 
                case AnimalCode.Turtle:
                    return new Animal {
                        IdImage = 15,
                        Name = Utils.NamesAnimal[Utils.GetRand(0, Utils.NamesAnimal.Length)],
                        Age = Utils.GetRand(15, 30),
                        Owner = Utils.NamesPersons[Utils.GetRand(0, Utils.NamesPersons.Length)],
                        Specials = "Черепаха",
                        Weight = Utils.GetRand(0.7, 40d),
                        Сolor = Utils.Colors[Utils.GetRand(0, 2)],
                    };

                default:
                    goto case AnimalCode.Bird;
            } // switch
        } // FactoryMethod

        #endregion

        // проверка на наличие в папке исполняемого файла папки App_Data и файла 
        // appliances.json с данными о квартире.Если папки и/или файл нет, то
        // создать папку, заполнить начальными данными объект, описывающий
        // электрооборудование квартиры, сериализовать данные в формате JSON
        // Возвращает true, если файл существует, иначе false, если он был создан
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


        // добавление элемента в коллекцию
        public void Add(Animal animal) { AnimalsZoo.Insert(0, animal); Serialization(); }


        // добавление коллекции в коллекцию
        public void AddRange() { AnimalsZoo.AddRange(GenerateAnimals(20)); Serialization(); }


        // удаление элемента из коллекции по индексу
        public void RemoveAt(int index) { AnimalsZoo.RemoveAt(index); Serialization(); }


        // удаление элемента из коллекции по ссылке
        public void Remove(Animal animal) { AnimalsZoo.Remove(animal); Serialization(); }


        // удалание всех животных
        public void Clear() { AnimalsZoo.Clear(); Serialization(); }


        // сохранение данных в файл – сериализация в формате JSON
        public void Serialization() {

            // форматтер 
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ZooModel));

            using (FileStream fs = new FileStream(_saveFile, FileMode.Create, FileAccess.Write))
                serializer.WriteObject(fs, Zoo);
        } // Serialization


        // загрузка данных из файла, десериализация в формате JSON
        public bool Deserialization() {

            // форматтер 
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ZooModel));

            try
            {
                // десериализация
                using (FileStream fs = new FileStream(_saveFile, FileMode.Open, FileAccess.Read))
                    Zoo = (ZooModel)serializer.ReadObject(fs);
            }
            catch { return false; }

            return true;
        } // Deserialization


        // упорядочивание по умопаратору
        public List<Animal> OrderByComparison(Comparison<Animal> comparison)
        {
            // копия коллекции
            var list = new List<Animal>(AnimalsZoo);

            // сортировка
            list.Sort(comparison);

            return list;
        } // OrderByComparison


        // упорядочивание копии коллекции животных по возрасту       
        public List<Animal> OrderByAge() => OrderByComparison((item1, item2) => item2.Age.CompareTo(item1.Age));


        // упорядочивание копии коллекции животных по виду       
        public List<Animal> OrderBySpecials() => OrderByComparison((item1, item2) => item1.Specials.CompareTo(item2.Specials));


        // упорядочивание копии коллекции животных по фамилиям       
        public List<Animal> OrderByOwner() => OrderByComparison((item1, item2) => item1.Owner.CompareTo(item2.Owner));


        // выборка записей коллекции с максимальным весом
        public List<Animal> SelectionWhereWeight()
        {
            // получение максимального веса
            double max = MaxWight;

            return AnimalsZoo.FindAll(item => item.Weight.Equals(max));
        }


        // выборка записей коллекции, фамилия владельцев которых содержит заданную подстроку (подстроку вводить в этой же вкладке)
        public List<Animal> SelectionWhereOwner(string token)
        {
            // перевод токена в нижний регистр
            token = token.ToLower();

            return AnimalsZoo.FindAll(item =>
            {
                // если размер строки меньше 5 символов
                if (item.Owner.Length < 5)
                    return false;

                // получение фамилии без инициалов
                string surname = item.Owner.Substring(0, item.Owner.Length - 6);

                // поиск записей содержащую токен
                return surname.ToLower().Contains(token);
            });
        }


        // вывод элементов в ListView
        public void ShowListView(ListView listView) => ShowListView(listView, AnimalsZoo);

        // вывод элементов в ListView
        public void ShowListView(ListView listView, List<Animal> animals)
        {
            // очистка ListView
            listView.Items.Clear(); 

            // вывод элементов
            animals.ForEach(item => item.ShowListView(listView));
        }


        // вывод элементов в DataGridView
        public void ShowDataGridView(DataGridView view) => ShowDataGridView(view, AnimalsZoo);


        // вывод элементов в DataGridView
        public void ShowDataGridView(DataGridView view, List<Animal> animals)
        {
            // очистка DataGridView
            view.Rows.Clear();

            // установка количества строк
            view.RowCount = animals.Count;

            // заполнение DataGridView
            for (int i = 0; i < animals.Count; i++) 
            {
                view[0, i].Value = animals[i].Specials;
                view[1, i].Value = animals[i].Name;
                view[2, i].Value = $"{animals[i].Weight:n5}";
                view[3, i].Value = animals[i].Age;
                view[4, i].Value = animals[i].Сolor;
                view[5, i].Value = animals[i].Owner;
            }

            // снятие активности с элемента элементов
            foreach (DataGridViewRow item in view.SelectedRows)
            {
                item.Selected = false;
            }
        }


        // изменение элемента в отображении DataGridView
        public void ShowDataGridViewChangeElem(DataGridView view, List<Animal> animals, int index)
        {
            // прибор 
            Animal animal = animals[index];

            // обновление данных элемента в отображении
            view[0, index].Value = animal.Specials;         // вид
            view[1, index].Value = animal.Name;             // кличка
            view[2, index].Value = animal.Weight;           // вес
            view[3, index].Value = animal.Age;              // возраст
            view[4, index].Value = animal.Сolor;            // цвет
            view[5, index].Value = animal.Owner;            // владелец
        }


        // загрузка из файла 
        public bool LoadToFile(string fileName, DataGridView view)
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

            // обновление информации в ListView
            if (flag) 
                ShowDataGridView(view);

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


        // вывод в TreeView
        public void ShowTreeView(TreeView treeView)
        {
            // очистка
            treeView.Nodes.Clear();

            // заполнение 
            treeView.Nodes.Add(Zoo.GetTreeNode());

            // развернуть
            treeView.Nodes[0].Expand();
        }


        #endregion

    }
}
