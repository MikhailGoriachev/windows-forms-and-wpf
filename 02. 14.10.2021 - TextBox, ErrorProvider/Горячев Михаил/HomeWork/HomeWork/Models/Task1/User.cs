using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static HomeWork.Application.App.Utils;    // подключение утилит

namespace HomeWork.Models.Task1
{
    // Класс Пользователь
    internal class User
    {
        // значение для создания ID
        private static int nextID;

        // идентификатор 
        private int _id;

        // фамилия
        private string _surname;

        // имя
        private string _name;

        // знак Зодиака
        private string _sign;

        // дата рождения
        private DateTime _date;

        #region Свойства

        // доступ к полю _id
        public int ID { get => _id; }

        // доступ к полю _surname
        public string Surname { get => _surname; set => _surname = !String.IsNullOrWhiteSpace(value) ? value : 
                throw new Exception("User: поле Фамилия нельзя оставлять пустым!"); }

        // доступ к полю _name
        public string Name { get => _name; set => _name = !String.IsNullOrWhiteSpace(value) ? value :
                throw new Exception("User: поле Имя нельзя оставлять пустым!"); }

        // доступ к полю _sign
        public string Sign { get => _sign; private set => _sign = value; }

        // доступ к полю _date
        public DateTime Date
        {
            get => _date;
            set
            {
                // старая дата 
                DateTime old = _date;

                _date = value.Year >= 1900 ? value :
                    throw new Exception("User: Год рождение должен быть >= 1900!");

                // если новая дата отличается от старой
                if (old != value)
                    // установка знака
                    SetSign();
            }
        }

        #endregion

        #region Конструкторы 

        // статический конструктор 
        static User() => nextID = 1;

        // конструктор по умолчанию 
        public User() => _id = nextID++;

        #endregion

        #region Методы 

        // установка знака Зодиака
        private void SetSign()
        {
            // год рождения
            int curYear = _date.Year;

            // массив со знаками
            (DateTime min, DateTime max, string sign)[] signs = 
            {
                (new DateTime(curYear, 3,  21), new DateTime(curYear, 4,  20), "Овен"),
                (new DateTime(curYear, 4,  21), new DateTime(curYear, 5,  21), "Телец"),
                (new DateTime(curYear, 5,  22), new DateTime(curYear, 6,  21), "Близнецы"),
                (new DateTime(curYear, 6,  22), new DateTime(curYear, 7,  22), "Рак"),
                (new DateTime(curYear, 7,  23), new DateTime(curYear, 8,  21), "Лев"),
                (new DateTime(curYear, 8,  22), new DateTime(curYear, 9,  23), "Дева"),
                (new DateTime(curYear, 9,  24), new DateTime(curYear, 10, 23), "Весы"),
                (new DateTime(curYear, 10, 24), new DateTime(curYear, 11, 23), "Скорпион"),
                (new DateTime(curYear, 11, 24), new DateTime(curYear, 12, 22), "Стрелец"),
                (new DateTime(curYear, 12, 23), new DateTime(curYear + 1, 1,  20), "Козерог"),
                (new DateTime(curYear - 1, 12, 23), new DateTime(curYear, 1,  20), "Козерог"),
                (new DateTime(curYear, 1,  21), new DateTime(curYear, 2,  19), "Водолей"),
                (new DateTime(curYear, 2,  20), new DateTime(curYear, 3,  20), "Рыбы")
            };

            // установка знака соответствующего дате
            _sign = Array.Find(signs, item => _date >= item.min && _date <= item.max).sign;
        }

        // вывод элемента в таблицу
        public void ShowElem(int num, bool activeColor = false)
        {
            WriteColorXY("     ║    ║       ║                 ║                 ║                 ║                 ║", textColor: ConsoleColor.Magenta);
            WriteColorXY($"{num, 2}", 7, textColor: ConsoleColor.DarkGray);
            WriteColorXY($"{ID, 5}", 12, textColor: ConsoleColor.Cyan);
            WriteColorXY($"{_surname, -15}", 20, textColor: ConsoleColor.Green);
            WriteColorXY($"{_name}", 38, textColor: ConsoleColor.Green);
            WriteColorXY($"{_sign}", 56, textColor: ConsoleColor.Cyan);
            WriteColorXY($"  {_date, 10:d}", 74, textColor: ConsoleColor.Cyan);
            Console.WriteLine();

        }

        #endregion
    }
}
