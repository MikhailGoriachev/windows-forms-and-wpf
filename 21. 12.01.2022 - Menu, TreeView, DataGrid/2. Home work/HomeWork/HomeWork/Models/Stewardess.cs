using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    // Класс Стюардесса
    class Stewardess
    {
        // фамилия
        public string LastName { get; set; }

        // имя 
        public string FirstName { get; set; }

        // отчество 
        public string Patronymic { get; set; }

        // цвет формы
        public string ColorUniform{ get; set; }
        
        // количество рейсов
        public int AmountFlights { get; set; }

        // количество обслуженных клиентов
        public int AmountClients { get; set; }
    }
}
