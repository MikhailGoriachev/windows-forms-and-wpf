using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    // обработка по заданию:
    // сложение,
    // вычитание,
    // умножение,
    // деление,
    // вычисление синуса,
    // вычисление квадратного корня,
    // вычисление степени
    internal class Controller
    {
        #region Методы 

        // сложение двух чисел
        public double Sum(double a, double b) => a + b;

        // вычитание 
        public double Substract(double a, double b) => a - b;

        // умножение 
        public double Mult(double a, double b) => a * b;

        // деление 
        public double Division(double a, double b) => a / b;

        // вычисление синуса
        public double Sin(double a) => Math.Sin(a);

        // вычисление квадратного корня
        public double Square(double a) => Math.Sqrt(a);

        // вычисление степени
        public double Degree(double a, int degree) => Math.Pow(a, degree);

        #endregion
    }
}
