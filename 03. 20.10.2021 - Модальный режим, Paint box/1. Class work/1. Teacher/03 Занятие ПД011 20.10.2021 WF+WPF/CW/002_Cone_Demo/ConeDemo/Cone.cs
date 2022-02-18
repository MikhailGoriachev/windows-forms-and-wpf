using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConeDemo
{
    // Класс, используем для работы по заданию
    public class Cone {
        private double _radius;
        public double Radius {
            get => _radius;
            set => _radius = value <= 0d?1d:value;
        }

        private double _height;
        public double Height {
            get => _height;
            set => _height = value <= 0d ? 1d : value;
        }

        private double _density;
        public double Density {
            get => _density;
            set => _density = value <= 0d ? 1d : value;
        }

        public Cone() : this(1d, 1d, 1d) { }
        public Cone(double r, double h, double d) {
            Radius = r;
            Height = h;
            Density = d;
        } // Cone

        // Методы для работы по заданию
        // Вычисление объема конуса
        public double CalcVolume() =>
            Math.PI * Radius * Radius * Height / 3d;

        // Вычисление массы конуса
        public double CalcMassa() =>
            CalcVolume() * Density;
    } // class Cone
}
