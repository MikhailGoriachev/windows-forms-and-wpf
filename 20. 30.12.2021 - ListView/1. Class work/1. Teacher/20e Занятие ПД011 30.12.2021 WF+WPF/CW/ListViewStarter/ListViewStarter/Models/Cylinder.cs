using System;

namespace ListViewStarter.Models
{
    /* 
     * Класс Cylinder, представляющий цилиндр (радиус основания, высота
     * и плотность – тип полей double). 
     */
    public class Cylinder : IVolumetricBody
    {
        // тип тела
        public BodyType Type => BodyType.Cylinder;

        // Радиус основания
        private double _radius;
        public double Radius {
            get => _radius;
            set {
                if (value <= 0)
                    throw new ArgumentException("Cylinder. Отрицательнsq или нулевой радиус основания");
                _radius = value;
            } // set
        } // Radius


        // Высота
        private double _height;
        public double Height {
            get => _height;
            set {
                if (value <= 0)
                    throw new ArgumentException("Cylinder. Отрицательная или нулевая высота");
                _height = value;
            } // set
        } // Height

        // Плотность материала цилиндра
        private double _density;
        public double Density {
            get => _density;
            set {
                if (value <= 0)
                    throw new ArgumentException("Cylinder. Отрицательная или нулевая плотность материала");
                _density = value;
            } // set
        } // Density

        // для вывода параметров (размеров) тела в ListView
        public string Params => $"Радиус: {_radius:f3} м; высота: {_height:f3} м";

        // конструкторы объекта класса
        // по умолчанию - плотность стали
        public Cylinder() : this(1d, 1d, 7850.0) { } // Cylinder

        public Cylinder(double radius, double height, double density) {
            Radius = radius;
            Height = height;
            Density = density;
        } // Cylinder

        // вычисляемые свойства для площади и объема цилиндра
        // площадь поверхности цилиндра
        // https://www-formula.ru/2011-09-21-04-33-30
        public double Area => 2d * Math.PI * _radius * (_height + _radius);

        // объем цилиндра
        // https://www-formula.ru/2011-09-21-10-54-43
        public double Volume => Math.PI * _radius * _radius * _height;

        // масса цилиндра
        public double Mass => Volume * _density;

        // строковое представление цилиндра (метод ToString(), выводить только
        // радиус, высоту и плотность) 
        public override string ToString() =>
            $"радиус основания: {_radius:f3}; " +
            $"высота: {_height:f3}; " +
            $"плотность: {_density:f3}";
    } // class Cylinder
}
