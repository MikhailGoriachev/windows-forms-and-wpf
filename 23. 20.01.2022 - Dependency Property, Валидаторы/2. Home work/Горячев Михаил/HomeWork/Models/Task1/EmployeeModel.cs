using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using HomeWork.Utilities;       // утилиты

/* Поля класса Сотрудник
 *      - фамилия
 *      - имя
 *      - отчество
 *      - возраст
 *      - оклад
 *      - город проживания
 */

namespace HomeWork.Models.Task1
{
    // Класс Сотрудник
    public class EmployeeModel : DependencyObject
    {
        // минимальное значение возраста
        public static int MinAge => 0;

        // максимальное значение возраста
        public static int MaxAge => 190;


        // минимальное значение оклада
        public static int MinSalary => 0;

        // максимальное значение оклада
        public static int MaxSalary => 1_000_000;


        // фамилия
        public string Surname
        {
            get => (string)GetValue(SurnameProperty);
            set => SetValue(SurnameProperty, value);
        }

        public static readonly DependencyProperty SurnameProperty;


        // имя
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }

        public static readonly DependencyProperty NameProperty;


        // отчество
        public string Patronymic
        {
            get => (string)GetValue(PatronymicProperty);
            set => SetValue(PatronymicProperty, value);
        }

        public static readonly DependencyProperty PatronymicProperty;


        // возраст
        public int Age
        {
            get => (int)GetValue(AgeProperty);
            set => SetValue(AgeProperty, value);
        }

        public static readonly DependencyProperty AgeProperty;


        // оклад
        public int Salary
        {
            get => (int)GetValue(SalaryProperty);
            set => SetValue(SalaryProperty, value);
        }

        public static readonly DependencyProperty SalaryProperty;


        // город проживания
        public string City
        {
            get => (string)GetValue(CityProperty);
            set => SetValue(CityProperty, value);
        }

        public static readonly DependencyProperty CityProperty;


        #region Конструкторы

        // статический конструктор
        static EmployeeModel()
        {
            // установка значений
            SurnameProperty     = DependencyProperty.Register("Surname",    typeof(string), typeof(EmployeeModel));
            NameProperty        = DependencyProperty.Register("Name",       typeof(string), typeof(EmployeeModel));
            PatronymicProperty  = DependencyProperty.Register("Patronymic", typeof(string), typeof(EmployeeModel));
            AgeProperty         = DependencyProperty.Register("Age",        typeof(int),    typeof(EmployeeModel), new PropertyMetadata { CoerceValueCallback = CorrectAge });
            SalaryProperty      = DependencyProperty.Register("Salary",     typeof(int),    typeof(EmployeeModel), new PropertyMetadata { CoerceValueCallback = CorrectSalary });
            CityProperty        = DependencyProperty.Register("City",       typeof(string), typeof(EmployeeModel));
        }


        #endregion
         
        #region Валидаторы

        // корректирующий валидатор поля Age
        private static object CorrectAge(DependencyObject d, object baseValue)
        {
            // новое значение
            int value = (int)baseValue;

            return value < MinAge ? MinAge : value > MaxAge ? MaxAge : value;
        }

        // корректирующий валидатор поля Salary
        private static object CorrectSalary(DependencyObject d, object baseValue)
        {
            // новое значение
            int value = (int)baseValue;

            return value < MinSalary ? MinSalary : value > MaxSalary ? MaxSalary : value;
        }

        #endregion

        #region Методы


        // фабричный метод
        public static EmployeeModel GetEmployee()
        {
            // ФИО персоны
            var person = Utils.GetPerson();

            return new EmployeeModel
            {
                Surname    = person.surname,
                Name       = person.name,
                Patronymic = person.patronymic,
                Age        = Utils.GetRand(15, 60),
                Salary     = Utils.GetRand(15, 40) * 1000,
                City       = Utils.GetCity()
            };
        }


        // клонирование объекта (паттерн клон)
        public EmployeeModel Clone() => new EmployeeModel
        {
            Surname = Surname,
            Name = Name,
            Patronymic = Patronymic,
            Age = Age,
            Salary = Salary,
            City = City
        };

        #endregion
    }
}
