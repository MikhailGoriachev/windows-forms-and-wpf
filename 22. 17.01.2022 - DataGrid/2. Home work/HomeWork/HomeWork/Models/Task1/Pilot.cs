using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models.Task1
{
    // Класс Пилот самолёта
    class Pilot
    {
        // фамилия
        public string LastName { get; set; }

        // имя 
        public string FirstName { get; set; }

        // отчество 
        public string Patronymic { get; set; }

        // номер самолёта
        public string AircraftNumber { get; set; }

        // количество рейсов
        public int AmountFlights { get; set; }
    }
}
