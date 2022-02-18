using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.Serialization;     // сериализация

using HomeWork.Utilities;               // утилиты

/*
 * Поля класса Периодическое издание:
 *      - фамилию и инициалы подписчика
 *      - адрес подписчика (улицу, дом и квартиру)
 *      - название издания
 *      - тип издания
 *      - индекс издания
 *      - дата начала подписки
 *      - период подписки
 *      - улица
 *      - дом
 *      - квартира
 */

namespace HomeWork.Models.Task2
{
    // Класс Периодическое издание
    [DataContract]
    public class PeriodicalModel : DependencyObject
    {
        // максимальное значение количества месяцев длительности подписки
        public static int MaxDuration => 12;

        // максимальное значение номера квартиры
        public static int MaxApartment => 10_000;


        // фамилию и инициалы подписчика
        [DataMember]
        public string FullName
        {
            get => (string)GetValue(FullNameProperty);
            set => SetValue(FullNameProperty, value);
        }

        public static readonly DependencyProperty FullNameProperty;


        // название издания
        [DataMember]
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly DependencyProperty TitleProperty;


        // тип издания
        [DataMember]
        public string TypeEdition
        {
            get => (string)GetValue(TypeEditionProperty);
            set => SetValue(TypeEditionProperty, value);
        }

        public static readonly DependencyProperty TypeEditionProperty;


        // индекс издания
        [DataMember]
        public string Index
        {
            get => (string)GetValue(IndexProperty);
            set => SetValue(IndexProperty, value);
        }

        public static readonly DependencyProperty IndexProperty;


        // дата начала подписки
        [DataMember]
        public DateTime DateSubscribe
        {
            get => (DateTime)GetValue(DateSubscribeProperty);
            set => SetValue(DateSubscribeProperty, value);
        }

        public static readonly DependencyProperty DateSubscribeProperty;


        // период подписки (месяц)
        [DataMember]
        public int Duration
        {
            get => (int)GetValue(DurationProperty);
            set => SetValue(DurationProperty, value);
        }

        public static readonly DependencyProperty DurationProperty;


        // название улицы
        [DataMember]
        public string Street
        {
            get => (string)GetValue(StreetProperty);
            set => SetValue(StreetProperty, value);
        }

        public static readonly DependencyProperty StreetProperty;


        // номер дома
        [DataMember]
        public string Home
        {
            get => (string)GetValue(HomeProperty);
            set => SetValue(HomeProperty, value);
        }

        public static readonly DependencyProperty HomeProperty;


        // номер квартиры (если квартира отсутсвует значение: 0)
        [DataMember]
        public int Apartment
        {
            get => (int)GetValue(ApartmentProperty);
            set => SetValue(ApartmentProperty, value);
        }

        public static readonly DependencyProperty ApartmentProperty;


        // получение адреса в виде Улица Дом/Квартира
        public string Address => $"{Street} {Home} / {Apartment}";

        // получение даты подписки в виде строки в формате даты
        public string DateSubscribeFormat => $"{DateSubscribe:d}";


        #region Конструкторы


        // конструктор статический
        static PeriodicalModel()
        {
            // установка значений
            FullNameProperty        = DependencyProperty.Register("FullName",       typeof(string),     typeof(PeriodicalModel));
            TitleProperty           = DependencyProperty.Register("Title",          typeof(string),     typeof(PeriodicalModel));
            TypeEditionProperty     = DependencyProperty.Register("TypeEdition",    typeof(string),     typeof(PeriodicalModel));
            IndexProperty           = DependencyProperty.Register("Index",          typeof(string),     typeof(PeriodicalModel));
            DateSubscribeProperty   = DependencyProperty.Register("DateSubscribe",  typeof(DateTime),   typeof(PeriodicalModel));
            DurationProperty        = DependencyProperty.Register("Duration",       typeof(int),        typeof(PeriodicalModel), new PropertyMetadata { CoerceValueCallback = CorrectDuration });
            StreetProperty          = DependencyProperty.Register("Street",         typeof(string),     typeof(PeriodicalModel));
            HomeProperty            = DependencyProperty.Register("Home",           typeof(string),     typeof(PeriodicalModel));
            ApartmentProperty       = DependencyProperty.Register("Apartment",      typeof(int),        typeof(PeriodicalModel), new PropertyMetadata { CoerceValueCallback = CorrectApartment });
        }

        #endregion

        #region Валидаторы

        // валидатор поля Duration
        private static object CorrectDuration(DependencyObject d, object BaseValue)
        {
            // новое значение
            int value = (int)BaseValue;

            return value < 0 ? 0 : value > MaxDuration ? MaxDuration : value;
        }


        // валидатор поля Apartment
        private static object CorrectApartment(DependencyObject d, object BaseValue)
        {
            // новое значение
            int value = (int)BaseValue;

            return value < 0 ? 0 : value > MaxApartment ? MaxApartment : value;
        }

        #endregion

        #region Методы

        // фабричный метод 
        public static PeriodicalModel GetPeriodical()
        {
            // издание
            var edition = Utils.GetEdition();

            // персона
            var person = Utils.GetPerson();

            return new PeriodicalModel { FullName   = $"{person.surname} {person.name[0]}. {person.patronymic[0]}.",
                                    Title           = edition.title,
                                    TypeEdition     = edition.type,
                                    Index           = edition.index,
                                    DateSubscribe   = Utils.GetDate(),
                                    Duration        = Utils.GetDuration(),
                                    Street          = Utils.GetStreets(),
                                    Home            = Utils.GetRand(1, 255).ToString(),
                                    Apartment       = Utils.GetRand(1, 200)
            };
        }


        // клонирование объекта (паттерн клон)
        public PeriodicalModel Clone() => new PeriodicalModel
        {
            FullName        = FullName,
            Title           = Title,
            Index           = Index,
            Duration        = Duration,
            DateSubscribe   = DateSubscribe,
            Street          = Street,
            Home            = Home,
            Apartment       = Apartment,
            TypeEdition     = TypeEdition
        };

        #endregion
    }
}
