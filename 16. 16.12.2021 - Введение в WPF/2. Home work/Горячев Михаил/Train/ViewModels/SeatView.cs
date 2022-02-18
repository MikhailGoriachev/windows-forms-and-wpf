using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Train.Models;     // модели

namespace Train.ViewModels
{
    // модель для вывода мест вагона
    internal class SeatView
    {   
        // номер места 
        public int NumberSeat { get; set; }

        // номер купе
        public string InfoCoupe { get; set; }

        // номер вагона 
        public string InfoWagon { get; set; }

        // состояние (продано/свободно)
        public string State { get; set; }

        #region Конструкторы

        // конструктор 
        public SeatView() : this(new Seat(), new Coupe(), new Wagon()) { }


        // конструктор инициализирующий
        public SeatView(Seat seat, Coupe coupe, Wagon wagon)
        {
            // установка значений
            NumberSeat  = seat.Number;
            State       = seat.State ? "Продано" : "Свободно";
            InfoCoupe   = $"№ {coupe.Number} {coupe.Title}";
            InfoWagon   = $"№ {wagon.Number} {wagon.TytleType}";            
        }

        #endregion
    }
}
