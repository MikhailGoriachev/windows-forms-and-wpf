using System;

namespace ListViewStarter.Models
{
    /* 
     * Класс Conoid, представляющий усеченный конус (радиус верхнего
     * основания, радиус нижнего основания, высота и плотность – тип
     * полей double). 
     */
    public class Conoid: IVolumetricBody
    {
        // тип тела
        public BodyType Type => BodyType.Conoid;

        // Радиус верхнего основания
        private double _radiusTop;
        public double RadiusTop {
            get => _radiusTop; 
            set {
				if (value <= 0)
                    throw new ArgumentException("Conoid. Отрицательное или нулевое верхнее основание");
                _radiusTop = value;
			} // set
        } // RadiusTop

        // Радиус нижнего основания
        private double _radiusBottom;
        public double RadiusBottom {
            get => _radiusBottom;
            set {
				if (value <= 0)
					throw new ArgumentException("Conoid. Отрицательное или нулевое нижнее основание");
				_radiusBottom = value;
			} // set
        } // RadiusBottom

        // Высота
        private double _height;
        public double Height {
            get => _height;
            set {
				if (value <= 0)
					throw new ArgumentException("Conoid. Отрицательная или нулевая высота");
				_height = value;
			} // set
        } // Height

        // Плотность материала усеченного конуса
        private double _density;
        public double Density {
            get => _density;
            set {
                if (value <= 0)
                    throw new ArgumentException("Conoid. Отрицательная или нулевая плотность материала");
                _density = value;
            } // set
        } // Density

        // для вывода параметров (размеров) тела в ListView
        public string Params => $"Верхний радиус: {_radiusTop:f3} м; нижний радиус: {_radiusBottom:f3} м; высота: {_height:f3} м"; 

        // конструкторы объекта класса
        // по умолчанию - плотность стали
        public Conoid():this(1d, 2d, 1d, 7850.0) { } // Conoid

        public Conoid(double radiusTop, double radiusBottom, double height, double density) {
            RadiusTop = radiusTop;
            RadiusBottom = radiusBottom;
            Height = height;
            Density = density;
        } // Conoid

        // вычисляемые свойства для площади и объема усеченного конуса
        // площадь поверхности усеченного конуса
        // https://www-formula.ru/2011-09-21-04-35-14
        public double Area { get {
                double delta = _radiusBottom - _radiusTop; 
                double l = Math.Sqrt(_height*_height + delta*delta);
                double area = Math.PI * (l * _radiusTop + l * _radiusBottom +
                    _radiusBottom * _radiusBottom + _radiusTop * _radiusTop);
                return area;
            } 
        } // Area

        // объем усеченного конуса
        // https://www-formula.ru/2011-09-21-10-55-40
        public double Volume => Math.PI * _height * 
            (_radiusBottom*_radiusBottom + _radiusBottom*_radiusTop + 
             _radiusTop*_radiusTop) / 3d;

        // масса усеченного конуса
        public double Mass => Volume * _density;

        // строковое представление конуса (метод ToString(), выводить только
        // радиусы, высоту и плотность) 
        public override string ToString() => 
            $"радиус основания: {_radiusBottom:f3}; верхний радиус: {_radiusTop:f3}; " +
            $"высота: {_height:f3}; плотность: {_density:f3}";

    } // class Conoid
}
