using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    // Класс Электроприбор
    internal class ElectricalAppliance
    {
        // следующий id (нужен при создании объекта для уникальности id)
        private static int _nextId;

        // идентификатор 
        public int id { get; }

        // название
        private string _name;

        // мощность
        private int _power;

        // цена 
        private int _price;

        // состояние питания
        private bool _active;

        #region События

        // событие изменения мощности на нечётное значение 
        public event EventHandler PowerChange;

        // событие изменения состояния питания
        public event EventHandler StateChangee;

        #endregion

        #region Свойства

        // доступ к полю _name
        public string Name { get => _name; set => _name = !String.IsNullOrWhiteSpace(value) ?
                value : throw new Exception("ElectricalAppliance: Поле name не может оставаться пустым!"); }

        // доступ к полю _power
        public int Power
        {
            get => _power; set
            {
                // старое значение мощности 
                int old = _power;

                // присваивание значения
                _power = value >= 0 ?
                       value : throw new Exception($"ElectricalAppliance: Мощность не может быть отрицательной! Значение: {value,5}");

                // если новое значение нечётное
                if (_power != old && (_power & 1) == 1)
                    PowerChange?.Invoke(this, EventArgs.Empty);
            }
        }

        // доступ к полю _price
        public int Price { get => _price; set => _price = value >= 0 ?
               value : throw new Exception($"ElectricalAppliance: Цена не может быть отрицательной! Значение: {value,5}"); }

        // статус питания
        public bool StateActive { get => _active;
            private set {

                // текущее состояние 
                bool old = _active;

                // установка значения
                _active = value;

                // если состояние изменилось
                if (old != value)
                    StateChangee?.Invoke(this, EventArgs.Empty);
            }
        }

        #endregion

        #region Конструкторы 

        // конструктор по умолчанию
        public ElectricalAppliance() => id = _nextId++;

        // конструктор статический
        static ElectricalAppliance() => _nextId = 1;

        #endregion

        #region Методы 

        // включение / выключение питания 
        public void TurnPower(bool value) => StateActive = value;

        // вывод элемента в таблицу
        public string ShowElem =>
            $"│ {id,2} │ {_name,-30} │ {_power,20} │ {_price,10} │ {(StateActive ? "Включено" : "Выключено"),-10}│";

        #endregion 
    }
}
