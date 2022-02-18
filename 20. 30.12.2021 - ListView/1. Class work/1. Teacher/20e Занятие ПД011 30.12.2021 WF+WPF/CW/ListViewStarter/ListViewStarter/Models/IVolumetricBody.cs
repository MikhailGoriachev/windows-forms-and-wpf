using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewStarter.Models
{
    // для обеспечения полиморфной работы с разными типами тел
    public interface IVolumetricBody
    {
        double Area   { get; }  // вычисление площади поверхности
        double Volume { get; }  // вычисление объема
        double Mass   { get; }  // вычисление массы

        double Density { get; set; } // плотность материала тела
        BodyType Type { get; }       // тип тела

        // строковое представление параметров фигур
        string Params { get; }
    } // interface IVolumetricBody
}
