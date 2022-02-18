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
    // Класс Вагон
    [DataContract]
    public class Wagon
    {
        // количество купе 
        const int _countCoupe = 9;

        // перечисление типов вагона
        public enum TypeWagon
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
        private TypeWagon _wagonType;

        public TypeWagon WagonType
        {
            get => _wagonType; 
            set => _wagonType = value; 
        }



        // название типа вагона
        [DataMember]
        private string _titleType;

        public string TytleType
        {
            get => _titleType; 
            set => _titleType = value; 
        }


        // номер вагона 
        [DataMember]
        private int _number;

        public int Number
        {
            get => _number; 
            set => _number = value; 
        }


        // коллекция купе
        [DataMember]
        private Coupe[] _coupeCollection;

        public Coupe[] CoupeCollection
        {
            get => _coupeCollection; 
            set => _coupeCollection = value; 
        }


        #region Свойства

        // количество купе
        public int CountCoupe => _countCoupe;


        // получение коллекции мест вагона
        public List<Seat> Seats
        {
            get
            {
                // список мест вагона
                List<Seat> seats = new List<Seat>();

                // заполнение списка мест
                Array.ForEach(_coupeCollection, item => seats.AddRange(item.Seats));

                return seats;
            }
        }

        // количество мест
        public (int amount, int busy, int free) CountSeats
        {
            get
            {
                // количество мест
                (int amount, int busy, int free) count = (0, 0, 0);

                // подсчёт количества мест
                Array.ForEach(_coupeCollection, item => {
                    var i = item.CountSeats;  
                    count = (count.amount + i.amount, count.busy + i.busy, count.free + i.free); 
                });

                return count;
            }
        }

        #endregion


        #region Конструкторы 

        // конструктор по умолчанию 
        public Wagon() : this(TypeWagon.Corridor) { }


        // конструктор инициализирующий
        public Wagon(TypeWagon typeWagon) 
        {
            // установка значений
            _wagonType = typeWagon;

            switch (typeWagon)
            {
                // СВ		    – 2 места, 9 купе
                case TypeWagon.Sleeper:
                    _titleType = "Спальный вагон";
                    CreateCoupe(Coupe.TypeCoupe.Sleeper);       // генерация купе
                    break;

                // Купейный	    – 4 места, 9 купе
                case TypeWagon.Corridor:
                    _titleType = "Купейный вагон";
                    CreateCoupe(Coupe.TypeCoupe.Corridor);      // генерация купе
                    break;

                // Плацкартный 	– 6 мест,  9 купе
                case TypeWagon.Reserved:
                    _titleType = "Плацкартный вагон";
                    CreateCoupe(Coupe.TypeCoupe.Reserved);      // генерация купе
                    break;
            }
        }

        #endregion


        #region Методы

        // создание купе
        private void CreateCoupe(Coupe.TypeCoupe typeCoupe)
        {
            // выделение памяти
            _coupeCollection = new Coupe[_countCoupe];

            // заполнение массива купе
            for (int i = 0; i < _countCoupe; i++)
                _coupeCollection[i] = new Coupe(typeCoupe, i + 1);
        }


        // создание TreeNode
        public TreeNode GetTreeNode()
        {
            var node = new TreeNode($"Вагон № { _number } - { _titleType }", 1, 1);

            // добавление элементов 
            Array.ForEach(_coupeCollection, item => node.Nodes.Add(item.GetTreeNode()));

            // установка ссылка на запись
            node.Tag = this;

            return node;
        }

        #endregion

    }
}

