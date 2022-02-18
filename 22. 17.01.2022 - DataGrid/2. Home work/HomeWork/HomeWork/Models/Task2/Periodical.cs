using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Поля класса Периодическое издание:
 *      - фамилию и инициалы подписчика
 *      - адрес подписчика (улицу, дом и квартиру)
 *      - название издания
 *      - тип издания
 *      - индекс издания
 *      - дата начала подписки
 *      - период подписки
 */

namespace HomeWork.Models.Task2
{
    // Класс Периодическое издание
    public class Periodical
    {
        // фамилию и инициалы подписчика
        private string _fullName;

        public string FullName
        {
            get => _fullName;
            set => _fullName = !string.IsNullOrWhiteSpace(value) ? value : throw new Exception("Periadical: поле FullName не может быть постым!");
        }


        // адрес подписчика(улицу, дом и квартиру)
        private Address _address;

        public Address Address
        {
            get => _address;
            set => _address = value;
        }


        // название издания
        private string _title;

        public string Title
        {
            get => _title;
            set => _title = value;
        }


        // тип издания
        private string _typeEdition;
            
        public string TypeEdition
        {
            get => _typeEdition;
            set => _typeEdition = value;
        }


        // индекс издания
        private string _index;

        public string Index
        {
            get => _index;
            set => _index = value;
        }


        // дата начала подписки
        private DateTime _dateSubscribe;

        public DateTime DateSubscribe
        {
            get => _dateSubscribe;
            set => _dateSubscribe = value;
        }


        // период подписки
        private int _duration;

        public int Duration
        {
            get => _duration;
            set => _duration = value;
        }
    }
}
