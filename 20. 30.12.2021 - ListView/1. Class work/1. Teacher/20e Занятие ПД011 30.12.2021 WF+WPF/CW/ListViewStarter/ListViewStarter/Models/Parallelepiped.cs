using System;

namespace ListViewStarter.Models
{
    /* 
     * Класс Parallelepiped, представляющий прямоугольный параллелепипед
     * (стороны оснований, плотность – тип полей double). 
     */
    public class Parallelepiped : IVolumetricBody
    {
        // тип тела
        public BodyType Type => BodyType.Parallelepiped;

        // Длина основания A прямоугольного параллелепипеда
        private double _a;
        public double A {
            get => _a;
            set {
                if (value <= 0)
                    throw new ArgumentException("Parallelepiped. Отрицательнsq или нулевая длина основания A");
                _a = value;
            } // set
        } // A

        // Длина основания B прямоугольного параллелепипеда
        private double _b;
        public double B {
            get => _b;
            set {
                if (value <= 0)
                    throw new ArgumentException("Parallelepiped. Отрицательнsq или нулевая длина основания B");
                _b = value;
            } // set
        } // B

        // Длина основания C прямоугольного параллелепипеда
        private double _c;
        public double C {
            get => _c;
            set {
                if (value <= 0)
                    throw new ArgumentException("Parallelepiped. Отрицательнsq или нулевая длина основания C");
                _c = value;
            } // set
        } // C

        // Плотность материала прямоугольного параллелепипеда
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
        public string Params => $"Сторона A: {_a:f3} м; сторона В: {_b:f3} м; сторона С: {_c:f3} м";

        // конструкторы объекта класса
        // по умолчанию - плотность стали
        public Parallelepiped() : this(1d, 1d, 1d, 7850.0) { } // Parallelepiped

        public Parallelepiped(double a, double b, double c, double density) {
            A = a;
            B = b;
            C = c;
            Density = density;
        } // Parallelepiped

        // вычисляемые свойства для площади и объема прямоугольного параллелепипеда
        // площадь поверхности прямоугольного параллелепипеда
        // https://www-formula.ru/2011-09-21-04-29-58
        public double Area => 2d * (_a * _b + _a * _c + _b * _c);

        // объем прямоугольного параллелепипеда
        // https://www-formula.ru/2011-09-21-10-52-19
        public double Volume => _a * _b * _c;

        // масса прямоугольного параллелепипеда
        public double Mass => Volume * _density;

        // строковое представление прямоугольного параллелепипеда (метод ToString(),
        // выводить только стороны основания и плотность) 
        public override string ToString() =>
            $"сторона основания a: {_a:f3}; " +
            $"сторона основания b: {_b:f3}; " +
            $"сторона основания c: {_c:f3}; " +
            $"плотность: {_density:f3}";
    } // class Parallelepiped
}
