using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;        // сериализация в формате JSON
using System.Runtime.Serialization;             // сериализация в формате JSON

using static HomeWorkCSharp.Application.App.Utils;      // утилиты

namespace HomeWorkCSharp.Models
{
    // предикатор для сериализации в формате JSON
    [DataContract]

    // класс Заявка на авиабилет
    public class RequestOnTicket
    {        
        [DataMember]
        // следующий номер заявки
        private static int _next;

        [DataMember]
        // номер заявки 
        private int _numberRequest;

        [DataMember]
        // пункт назначения
        private string _pointDest;

        [DataMember]
        // номер рейса 
        private string _numberFlight;

        [DataMember]
        // фамилия и инициалы покупатели
        private string _name;

        [DataMember]
        // желаемая дата вылета
        private DateTime _date;

        #region Свойства 

        // доступ к полю _numberRequest
        public int NumberRequest { get => _numberRequest;  set => _numberRequest = value; }

        // доступ к полю _pointDest
        public string PointDest { get => _pointDest;
            set => _pointDest = !String.IsNullOrWhiteSpace(value) ? value :
                throw new Exception($"RequestOnTicket: поле PointDest не может быть пустым!"); 
        }

        // доступ к полю _numberFlight
        public string NumberFlight
        {
            get => _numberFlight;
            set => _numberFlight = !String.IsNullOrWhiteSpace(value) ? value :
                throw new Exception($"RequestOnTicket: поле NumberFlight не может быть пустым!");
        }

        // доступ к полю _name
        public string Name
        {
            get => _name;
            set => _name = !String.IsNullOrWhiteSpace(value) ? value :
                throw new Exception($"RequestOnTicket: поле Name не может быть пустым!");
        }

        // доступ к полю _date
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        #endregion

        #region Конструкторы 

        // конструктор по умолчанию
        public RequestOnTicket()
        {
            // установка значений
            _numberRequest = _next++;
        }

        // конструктор статический
        static RequestOnTicket()
        {
            // установка зачений 
            _next = 1_000_000;
        }

        #endregion

        #region Методы

        // вывод элемента в таблицу
        public void ShowElem(int num)
        {
            WriteColorXY("     ║    ║            ║                      ║            ║                      ║            ║", textColor: ConsoleColor.Magenta);
            WriteColorXY($"{num, 2}", 7, textColor: ConsoleColor.DarkGray);
            WriteColorXY($"{_numberRequest, 10}", 12, textColor: ConsoleColor.Cyan);
            WriteColorXY($"{_pointDest, -20}", 25, textColor: ConsoleColor.Green);
            WriteColorXY($"{_numberFlight, -10}", 48, textColor: ConsoleColor.Cyan);
            WriteColorXY($"{_name, -20}", 61, textColor: ConsoleColor.Green);
            WriteColorXY($"{_date:d}", 84, textColor: ConsoleColor.Cyan);
            Console.WriteLine();
        }

        #endregion
    }
}
