using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;     // сериализация
using Train.Utilities;                  // утилиты

namespace Train.Models
{
    // Класс Купе
    [DataContract]
    public class Coupe
    {
        // перечисление типов купе
        public enum TypeCoupe
        {
            // СВ		    – 2 места, 9 купе
            Sleeper,
            // Купейный	    – 4 места, 9 купе
            Corridor,
            // Плацкартный 	– 6 мест,  9 купе
            Reserved,
        }

        // тип купе
        [DataMember]
        private string _title;
        
        public string Title
        {
            get => _title; 
            private set => _title = value; 
        }


        // номер купе
        [DataMember]
        private int _number;

        public int Number
        {
            get => _number; 
            private set => _number = value; 
        }


        // количество мест
        [DataMember]
        private int _amountAllSeats;

        public int AmountAllSeats
        {
            get => _amountAllSeats; 
            private set => _amountAllSeats = value; 
        }


        // места
        [DataMember]
        private Seat[] _seats;

        public Seat[] Seats
        {
            get => _seats; 
            private set => _seats = value;
        }


        #region Свойства

        // количество мест (общее количество / занято / свободно)
        public (int amount, int busy, int free) CountSeats
        {
            get
            {
                // количество мест
                (int amount, int busy, int free) count = (0, 0, 0);

                // подсчёт количества мест
                Array.ForEach(_seats, item => { count.amount++; if (item.State) count.busy++; else count.free++; });

                return count;
            }
        }

        #endregion


        #region Конструкторы

        // конструктор по умолчанию 
        public Coupe() : this(TypeCoupe.Corridor, 1) {}

        // конструктор инициализирующий
        public Coupe(TypeCoupe typeCoupe, int number)
        {
            // установка значений
            _number = number;

            switch (typeCoupe)
            {
                // СВ		    – 2 места, 9 купе
                case TypeCoupe.Sleeper:
                    _title = "Спальное купе";
                    _amountAllSeats = 2;
                    break;

                // Купейный	    – 4 места, 9 купе
                case TypeCoupe.Corridor:
                    _title = "Купейное купе";
                    _amountAllSeats = 4;
                    break;

                // Плацкартный 	– 6 мест,  9 купе
                case TypeCoupe.Reserved:
                    _title = "Плацкартное купе";
                    _amountAllSeats = 6;
                    break;
            }

            // выделение места для массива мест
            _seats = new Seat[_amountAllSeats];

            // заполнение 
            for (int i = 0, k = ((_number - 1) * _amountAllSeats) + 1; i < _amountAllSeats; i++, k++)
                _seats[i] = new Seat(k, Utils.GetRand(0, 2) == 0); 
        }

        #endregion


        #region Методы

        // создание TreeNode
        public TreeNode GetTreeNode()
        {
            var node = new TreeNode($"Купе № { _number } - { _title }", 2, 2);

            // добавление элементов 
            Array.ForEach(_seats, item => node.Nodes.Add(item.GetTreeNode()));

            // установка ссылка на запись
            node.Tag = this;

            return node;
        }
        #endregion

    }
}
