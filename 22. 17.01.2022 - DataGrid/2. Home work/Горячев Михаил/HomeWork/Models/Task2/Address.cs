using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Поля класса Адрес:
 *      - название улицы
 *      - номер дома
 *      - номер квартиры (если квартира отсутсвует значение: -1)
*/
namespace HomeWork.Models.Task2
{
    // Класс Адрес (дома/квартиры)
    public class Address
    {
        // название улицы
        private string _street;

        public string Street
        {
            get => _street;
            set => _street = value;
        }


        // номер дома
        private string _home;

        public string Home
        {
            get => _home;
            set => _home = value;
        }


        // номер квартиры (если квартира отсутсвует значение: -1)
        private int _apartment;

        public int Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }
    }
}
