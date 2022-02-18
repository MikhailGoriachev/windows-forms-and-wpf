using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute.Models
{
    // Класс Математические вычисления
    public class MathComput
    {
        // вычисление среднего арифметического
        public double Avg(double a, double b, double c) => (a + b + c) / 3d;


        // вычисление среднего геометрического трех чисел
        public double Mean(double a, double b, double c) => Math.Pow(a * b * c, 1.0 / 3);


        // вычисление корня квадратного уравнения с коэффициентами
        public (double? x1, double? x2) Equation(double a, double b, double c)
        {
            // если число A равно нулю
            if (a == 0)
                return (double.NaN, double.NaN);

            // дискриминант
            double D = b * b - 4 * a * c; 


            if (D > 0) // Условие при дискриминанте больше нуля
                return (((-b) - Math.Sqrt(D)) / (2 * a), ((-b) + Math.Sqrt(D)) / (2 * a));

            else if (D == 0) // Условие для дискриминанта равного нулю
                return (-(b / (2 * a)), null);

            else // Условие при дискриминанте меньше нуля
                return (null, null);
        }
    }
}
