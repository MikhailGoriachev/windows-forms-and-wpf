using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsControlContinue
{
    public class DataBus
    {
        // Фамилия и инициалы водителя
        private string _surname;
        public string Surname {
            get => _surname;
            set => _surname = value;
        } // Surname


        // Гос.номер автобуса
        private string _numbers;
        public string Numbers {
            get => _numbers;
            set => _numbers = value;
        } // Numbers


        // Марка производителя
        private string _manufacturer;
        public string Manufacturer {
            get => _manufacturer;
            set => _manufacturer = value;
        } // Manufacturer


        // Год выпуска автобуса
        private int _yearOfIssue;
        public int YearOfIssue {
            get => _yearOfIssue;
            set => _yearOfIssue = value;
        } // YearOfIssue


        // Пробег автобуса
        private double _mileage;
        public double Mileage {
            get => _mileage;
            set => _mileage = value;
        } // Mileage

    } // class DataBus
} // namespace Car_company
