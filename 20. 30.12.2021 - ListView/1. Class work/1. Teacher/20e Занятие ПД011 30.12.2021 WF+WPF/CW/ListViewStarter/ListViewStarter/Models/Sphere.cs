using System;

namespace ListViewStarter.Models
{
    /* 
     * Класс Sphere, представляющий сферу (радиус и плотность – тип
     * полей double). 
     */
    public class Sphere : IVolumetricBody
    {
        // тип тела
        public BodyType Type => BodyType.Sphere;

        // Радиус
        private double _radius;
        public double Radius {
            get => _radius;
            set {
                if (value <= 0)
                    throw new ArgumentException("Sphere. Отрицательный или нулевой радиус");
                _radius = value;
            } // set
        } // Radius

        // Плотность материала сферы
        private double _density;
        public double Density {
            get => _density;
            set {
                if (value <= 0)
                    throw new ArgumentException("Sphere. Отрицательная или нулевая плотность материала");
                _density = value;
            } // set
        } // Density

        // для вывода параметров (размеров) тела в ListView
        public string Params => $"Радиус: {_radius:f3} м";

        // конструкторы объекта класса
        // по умолчанию - плотность стали
        public Sphere() : this(1d, 7850.0) { } // Sphere

        public Sphere(double radius, double density) {
            Radius = radius;
            Density = density;
        } // Sphere

        // вычисляемые свойства для площади и объема сферы
        // площадь поверхности сферы
        // https://www-formula.ru/2011-09-21-04-30-33
        public double Area => 4d * Math.PI * _radius * _radius; // Area

        // объем шара
        // https://www-formula.ru/2011-09-21-10-52-47
        public double Volume => 4d * Math.PI * _radius * _radius * _radius / 3d;

        // масса сферы
        public double Mass => Volume * _density;

        // строковое представление сферы (метод ToString(), выводить только
        // радиус и плотность) 
        public override string ToString() =>
            $"радиус: {_radius:f3}; " +
            $"плотность: {_density:f3}";
    } // Sphere
}
