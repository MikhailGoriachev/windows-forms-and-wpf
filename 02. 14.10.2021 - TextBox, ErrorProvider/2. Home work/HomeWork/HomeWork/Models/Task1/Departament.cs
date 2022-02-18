using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HomeWork.Application.App.Utils;    // подключение утилит

namespace HomeWork.Models.Task1
{
    // Класс Список пользователей
    internal class Departament : IEnumerable
    {
        #region Свойства

        // коллекция пользователей +
        public ObservableCollection<User> Users { get; set; }

        // размер коллекции
        public int Lenght { get => Users.Count; }

        #endregion

        #region Конструкторы и индексатор

        // конструктор по умолчанию
        public Departament()
        {
            // установка значений
            Users = new ObservableCollection<User>();
        }

        // индексатор
        public User this[int index]
        {
            get
            {
                // если индекс выходит за пределы массива
                if (index < 0 || index >= Users.Count)
                    throw new IndexOutOfRangeException($"Departament: Индекс {index} выходит за пределы массива!");

                return Users[index];
            }

            set
            {
                // если индекс выходит за пределы массива
                if (index < 0 || index >= Users.Count)
                    throw new IndexOutOfRangeException($"Departament: Индекс {index} выходит за пределы массива!");

                Users[index] = value;
            }
        }

        #endregion

        #region Методы

        // реализация неименованного итератора
        public IEnumerator GetEnumerator() => Users.GetEnumerator();

        // именованный итератор по заданной фамилии
        public IEnumerable<User> SurnameIter(string surname)
        {
            // итерация по коллекции
            for (int i = 0; i < Users.Count; i++)
                // если фамилия соответствует заданной
                if (Users[i].Surname == surname)
                    yield return Users[i];

            // остановка итератора
            yield break;
        }

        // именованный итератор по знаку Зодиака
        public IEnumerable<User> SignIter(string sign)
        {
            // итерация по коллекции
            for (int i = 0; i < Users.Count; i++)
                // если знак соответсвует заданному
                if (Users[i].Sign == sign)
                    yield return Users[i];

            // остановка итератора
            yield break;
        }

        // именованный итератор по месяцу
        public IEnumerable<User> MonthIter(int month)
        {
            // итерация по коллекции
            for (int i = 0; i < Users.Count; i++)
                // если месяц соответсвует заданному
                if (Users[i].Date.Month == month)
                    yield return Users[i];

            // остановка итератора
            yield break;
        }

        // сортировка по дате рождения
        public User[] SortByDate()
        {
            // массив пользователей
            User[] array = Users.ToArray(); 

            // сортировка массива 
            Array.Sort(array, (item1, item2) => item1.Date.CompareTo(item2.Date)); 

            return array;
        }

        // сортировка по знаку Зодиака
        public User[] SortBySign()
        {
            // массив пользователей
            User[] array = Users.ToArray();

            // сортировка массива 
            Array.Sort(array, (item1, item2) => item1.Sign.CompareTo(item2.Sign));

            return array;
        }

        // сортровка по фамилии
        public User[] SortBySurname()
        {
            // массив пользователей
            User[] array = Users.ToArray();

            // сортировка массива 
            Array.Sort(array, (item1, item2) => item1.Surname.CompareTo(item2.Surname));

            return array;
        }

        // сортировка по имени
        public User[] SortByName()
        {
            // массив пользователей
            User[] array = Users.ToArray();

            // сортировка массива 
            Array.Sort(array, (item1, item2) => item1.Name.CompareTo(item2.Name));

            return array;
        }

        // вывод таблицы 
        public void ShowTable(string name = "Пользователи", string info = "Исходные данные")
        {
            // вывод шапки таблицы
            ShowHead(Users.Count, name, info);

            // вывод элементов 
            ShowElements(Users);

            // вывод подвала таблицы
            ShowLine();
        }

        // вывод шапки таблицы 
        public static void ShowHead(int size, string name = "Пользователи", string info = "Исходные данные")
        {
            //                       10                     30                               36                    
            WriteColorXY("     ╔════════════╦════════════════════════════════╦══════════════════════════════════════╗\n", textColor: ConsoleColor.Magenta);
            WriteColorXY("     ║            ║                                ║                                      ║", textColor: ConsoleColor.Magenta);
            WriteColorXY($"Размер: ", 7, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{size, 2}", textColor: ConsoleColor.Green);
            WriteColorXY($"Название: ", 20, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{name, -20}", textColor: ConsoleColor.Green);
            WriteColorXY($"Инфо: ", 53, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{info,-30}", textColor: ConsoleColor.Green);
            Console.WriteLine();

            //                   2      5           15                15                15                15     
            WriteColorXY("     ╠════╦═══════╬═════════════════╦══════════════╩══╦═════════════════╦═════════════════╣\n", textColor: ConsoleColor.Magenta);
            WriteColorXY("     ║    ║       ║                 ║                 ║                 ║                 ║", textColor: ConsoleColor.Magenta);
            WriteColorXY($"N ", 7, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($" ID  ", 12, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"    Фамилия    ", 20, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"      Имя      ", 38, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($" Знак Зодиака  ", 56, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($" Дата рождения ", 74, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();
            WriteColorXY("     ╠════╬═══════╬═════════════════╬═════════════════╬═════════════════╬═════════════════╣\n", textColor: ConsoleColor.Magenta);

        }

        // вывод элементов в таблицу
        public static void ShowElements(IEnumerable<User> users)
        {
            // номер элемента
            int n = 1;

            // вывод элементов
            foreach (var item in users) item.ShowElem(n++);
        }

        // вывод подавала таблицы
        public static void ShowLine() => 
            WriteColorXY("     ╚════╩═══════╩═════════════════╩═════════════════╩═════════════════╩═════════════════╝\n", textColor: ConsoleColor.Magenta);

        #endregion
    }
}