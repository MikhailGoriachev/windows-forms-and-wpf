using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuToolbarTabControls.Models
{
    class Phone
    {
        // модель телефона
        private string _title;
        public string Title {
            get => _title;
            set => _title = value;
        } // Title

        // производитель телефона
        private string _company;
        public string Company {
            get => _company;
            set { _company = value; }
        } // Company

        // стоимость телефона
        private int _price;
        public int Price {
            get => _price;
            set { _price = value; }
        } // Price
    } // class Phone
}
