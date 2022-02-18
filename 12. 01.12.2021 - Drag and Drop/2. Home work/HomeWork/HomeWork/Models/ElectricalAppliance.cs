using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;         // JSON сериализация

namespace HomeWork.Models
{
    // Класс Электроприбор
    [DataContract]
    public class ElectricalAppliance
    {
        [DataMember]
        // название
        private string _name;

        [DataMember]
        // мощность
        private int _power;

        [DataMember]
        // цена 
        private int _price;

        [DataMember]
        // состояние питания
        private bool _active;

        [DataMember]
        // дата и время последнего изменения состояния
        private DateTime _dateTimeStateChange = DateTime.Now;

        #region Свойства

        // доступ к полю _name
        public string Name { get => _name; set => _name = !String.IsNullOrWhiteSpace(value) ?
                value : throw new Exception("ElectricalAppliance: Поле name не может оставаться пустым!"); }

        // доступ к полю _power
        public int Power
        {
            get => _power; 
            set => _power = value >= 0 ?
                value : throw new Exception($"ElectricalAppliance: Мощность не может быть отрицательной! Значение: {value,5}");
        }

        // доступ к полю _price
        public int Price { get => _price; set => _price = value >= 0 ?
               value : throw new Exception($"ElectricalAppliance: Цена не может быть отрицательной! Значение: {value,5}"); }

        // статус питания
        public bool StateActive 
        { 
            get => _active;
            private set => _active = value;
        }

        // статус питания
        public DateTime DateTimeStateChange => _dateTimeStateChange;

        #endregion

        #region Методы 

        // включение / выключение питания 
        public void TurnPower(bool value)
        {
            // если состояние НЕ отличается от текущего 
            if (value == _active) 
                return;
            
            // установка состояния
            _active = value;

            // установка даты и времени изменения
            _dateTimeStateChange = DateTime.Now;
        }

        #endregion 
    }
}
