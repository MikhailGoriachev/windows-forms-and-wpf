using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFigure.Interfaces
{
    // Интерфейс Поведение фигуры
    public interface IFigure
    {
        // площадь поверхности 
        double Area();

        // объем
        double Volume();

        // масса
        double Weight();
    }
}
