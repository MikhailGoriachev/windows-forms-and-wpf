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
    // Класс Поезд
    [DataContract]
    public class TrainModel
    {
        // номер поезда
        [DataMember]
        private string _number;

        public string Number
        {
            get => _number; 
            set => _number = value; 
        }


        // пункт отправления 
        [DataMember]
        private string _departure;

        public string Departure
        {
            get => _departure;
            set => _departure = !string.IsNullOrWhiteSpace(value) ? value
                : throw new Exception("TrainMode: поле Departure не может быть пустым!");
        }


        // пункт назначения 
        [DataMember]
        private string _destination;

        public string Destination
        {
            get => _destination;
            set => _destination = !string.IsNullOrWhiteSpace(value) ? value
                : throw new Exception("TrainMode: поле Destination не может быть пустым!");
        }


        // коллекция вагонов
        [DataMember]
        private List<Wagon> _wagons;

        public List<Wagon> Wagons
        {
            get => _wagons; 
            set => _wagons = value; 
        }


        // максимальное количество вагонов
        private const int _maxCountWagons = 20;

        public int MaxCountWagons => _maxCountWagons;


        #region Свойства

        // количество вагонов
        public int CountWagons => _wagons.Count;


        // количество вагонов по типам
        public (int Amount, int Sleeper, int Corridor, int Reserved) CountWagonsTypes
        {
            get
            {
                // количество вагонов
                (int Amount, int Sleeper, int Corridor, int Reserved) count = (0, 0, 0, 0);

                // подсчёт вагонов по типам
                _wagons.ForEach(item => {
                    switch (item.WagonType)
                    {
                        // СВ		    – 2 места, 9 купе
                        case Wagon.TypeWagon.Sleeper:
                            count.Sleeper++;
                            break;

                        // Купейный	    – 4 места, 9 купе
                        case Wagon.TypeWagon.Corridor:
                            count.Corridor++;
                            break;

                        // Плацкартный 	– 6 мест,  9 купе
                        case Wagon.TypeWagon.Reserved:
                            count.Reserved++;
                            break;
                    }
                });

                // запись общего количества вагонов
                count.Amount = count.Sleeper + count.Corridor + count.Reserved;

                return count;
            }
        }


        // количество купе
        public int CountCoupe
        {
            get {
                int count = 0;
                _wagons.ForEach(item => count += item.CountCoupe);
                return count;
            }
        }


        // количество купе по типам
        public (int Amount, int Sleeper, int Corridor, int Reserved) CountCoupeTypes
        {
            get {
                // количество купе
                (int Amount, int Sleeper, int Corridor, int Reserved) count = (0, 0, 0, 0);

                // подсчёт купе по типам
                _wagons.ForEach(item => {
                    switch (item.WagonType)
                    {
                        // СВ		    – 2 места, 9 купе
                        case Wagon.TypeWagon.Sleeper:
                            count.Sleeper += item.CountCoupe;
                            break;

                        // Купейный	    – 4 места, 9 купе
                        case Wagon.TypeWagon.Corridor:
                            count.Corridor += item.CountCoupe;
                            break;

                        // Плацкартный 	– 6 мест,  9 купе
                        case Wagon.TypeWagon.Reserved:
                            count.Reserved += item.CountCoupe;
                            break;
                    }

                    // запись общего количества купе
                    count.Amount = count.Sleeper + count.Corridor + count.Reserved;
                });

                return count;
            }
        }


        // количество мест (общее, свободно, занято)
        public (int amount, int busy, int free) CountSeats
        {
            get
            {
                // количество мест
                (int amount, int busy, int free) count = (0, 0, 0);

                // подсчёт количества мест
                _wagons.ForEach(item => {
                    var i = item.CountSeats;
                    count = (count.amount + i.amount, count.busy + i.busy, count.free + i.free);
                });

                return count;
            }
        }


        // количество мест СВ
        public (int amount, int busy, int free) CountSeatsSleeper
        {
            get
            {
                // количество мест
                (int amount, int busy, int free) count = (0, 0, 0);

                // подсчёт количества мест
                _wagons.ForEach(item => {
                    if (item.WagonType == Wagon.TypeWagon.Sleeper)
                    {
                        var i = item.CountSeats;
                        count = (count.amount + i.amount, count.busy + i.busy, count.free + i.free);
                    }
                });

                return count;
            }
        }


        // количество мест купейный
        public (int amount, int busy, int free) CountSeatsCorridor
        {
            get
            {
                // количество мест
                (int amount, int busy, int free) count = (0, 0, 0);

                // подсчёт количества мест
                _wagons.ForEach(item => {
                    if (item.WagonType == Wagon.TypeWagon.Corridor)
                    {
                        var i = item.CountSeats;
                        count = (count.amount + i.amount, count.busy + i.busy, count.free + i.free);
                    }
                });

                return count;
            }
        }


        // количество мест плацкарт
        public (int amount, int busy, int free) CountSeatsReserved
        {
            get
            {
                // количество мест
                (int amount, int busy, int free) count = (0, 0, 0);

                // подсчёт количества мест
                _wagons.ForEach(item => {
                    if (item.WagonType == Wagon.TypeWagon.Reserved)
                    {
                        var i = item.CountSeats;
                        count = (count.amount + i.amount, count.busy + i.busy, count.free + i.free);
                    }
                });

                return count;
            }
        }


        #endregion

        #region Конструкторы

        // конструктор по умолчанию
        public TrainModel() : this(Utils.GenerateNumberTrain(), new List<Wagon>()) { }


        // конструктор инициализирующий
        public TrainModel(string number, List<Wagon> wagons)
        {
            // установка значений
            _number = number;
            _wagons = wagons;
        }

        #endregion

        #region Методы

        // добавление вагона 
        public void AddWagon(Wagon wagon)
        {
            // если количество вагонов максимальное 
            if (_wagons.Count >= _maxCountWagons)
                MessageBox.Show("TrainModel: Достигнуто максимальное количество вагонов!", "Ошибка добавления!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // добавление вагона в коллецию
            _wagons.Add(wagon);

            // обновление номеров вагонов
            UpdateNumberWagons();
        }


        // добавление вагона 
        public void AddWagon(Wagon.TypeWagon typeWagon) =>  AddWagon(new Wagon(typeWagon));


        // удаление вагона 
        public void Remove(Wagon wagon) => RemoveAt(_wagons.IndexOf(wagon));


        // удаление вагона 
        public void RemoveAt(int index)
        {
            // удаление вагона из коллеции
            _wagons.RemoveAt(index);

            // обновление номеров вагонов
            UpdateNumberWagons();
        }


        // удаление всех вагонов
        public void Clear() => _wagons.Clear();


        // обмена вагонов местами
        public void SwapWagons(Wagon wagon1, Wagon wagon2) => SwapWagons(_wagons.IndexOf(wagon1), _wagons.IndexOf(wagon2));
        

        // обмена вагонов местами
        public void SwapWagons(int index1, int index2)
        {
            (_wagons[index1], _wagons[index2]) = (_wagons[index2], _wagons[index1]);

            // обновление номеров вагонов
            UpdateNumberWagons();
        }


        // обноваление номеров вагонов
        public void UpdateNumberWagons()
        {
            for (int i = _wagons.Count - 1, k = 1; i >= 0; i--, k++)
                _wagons[i].Number = k;
        }


        // создание TreeNode
        public TreeNode GetTreeNode()
        {
            var node = new TreeNode($"Поезд № {_number} {_departure} - {_destination}", 0, 0);

            // добавление элементов 
            _wagons.ForEach(item => node.Nodes.Add(item.GetTreeNode()));

            // установка ссылка на запись
            node.Tag = this;

            return node;
        }

        #endregion

    }
}
