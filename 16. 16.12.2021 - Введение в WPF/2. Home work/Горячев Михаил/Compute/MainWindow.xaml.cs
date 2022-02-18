using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Compute.Models;           // модели
using Compute.Utilities;        // утилиты

/*
 * Задача 2. В решение задачи 1 добавьте приложение WPF, разработанное по следующему заданию.
 * В контейнере компоновки Grid создайте 5 строк для размещения элементов TextBlock, TextBox, Button.
 * В верхних трех строках – TextBlock (текст метки), TextBox (поле ввода). Размещение в строке – 
 * при помощи атрибута Margin. Так мы поступим только в этом задании.
 * В четвертой строке – TextBlock для вывода результатов.
 * В пятой строке – кнопки для запуска обработок: вычисление среднего арифметического, среднего 
 * геометрического трех чисел, вычисление корня квадратного уравнения с коэффициентами из TextBox. 
*/

namespace Compute
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // модель для математический вычислений
        MathComput comput = new MathComput();

        // конструтор по умолчанию
        public MainWindow()
        {
            InitializeComponent();
        }


        // загрузка формы
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // заполнение TextBox значениями
            TbxInputA.Text = $"{Utils.GetRand(-10d, 15d):n5}";
            TbxInputB.Text = $"{Utils.GetRand(1d, 15d):n5}";
            TbxInputC.Text = $"{Utils.GetRand(1d, 15d):n5}";

            // установка фокуса 
            TbxInputA.Focus();
        }


        // подавление любых цифр знаков кроме цифр и разделителя целой части числа при вводе в TextBox
        private void KetDownTextBox_Command(object sender, KeyEventArgs e)
        {
            // получение TextBox
            TextBox box = (TextBox)sender;

            // есть ли знак '-' в строке
            bool minus = box.Text.IndexOf('-') == 0;

            // есть ли разделитель ',' в строке
            bool sep = box.Text.IndexOf(',') == 0;

            // если это цифра
            if (e.Key >= Key.D0 && e.Key <= Key.D9 
                || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9
                || !minus && e.Key == Key.OemMinus 
                || !minus && e.Key == Key.Subtract
                || !sep   && e.Key == Key.OemComma
                || e.Key == Key.Tab)
                return;
            else
                e.Handled = true;
        }


        // кнопка для вычисления среднего арифметического
        private void BtnAvg_Click(object sender, RoutedEventArgs e)
        {
            // получение результата
            double result = comput.Avg(double.Parse(TbxInputA.Text), double.Parse(TbxInputB.Text), double.Parse(TbxInputC.Text));

            // вывод результата
            TblResult.Text = $"Среднее арифметическое = {result:n5}";
        }


        // кнопка для вычисления среднего геометрического трех чисел
        private void BtnMean_Click(object sender, RoutedEventArgs e)
        {
            // получение результата
            double result = comput.Mean(double.Parse(TbxInputA.Text), double.Parse(TbxInputB.Text), double.Parse(TbxInputC.Text));

            // вывод результата
            TblResult.Text = $"Среднее геометрическое = {(result == double.NaN ? "среди трех чисел есть отрицательное число" : $"{result:n5}")}";
        }


        // кнопка для вычисления вычисление корня квадратного уравнения с коэффициентами
        private void BtnEquation_Click(object sender, RoutedEventArgs e)
        {
            // получение результата
            (double? x1, double? x2) result = comput.Equation(double.Parse(TbxInputA.Text), double.Parse(TbxInputB.Text), double.Parse(TbxInputC.Text));

            if (result.x1.Equals(double.NaN) && result.x2.Equals(double.NaN))
                TblResult.Text = "Уравнение не является квадратным, так как A == 0";
            else if (result.x1 == null && result.x2 == null)
                TblResult.Text = $"Действительных корней уравнения не существует";
            else 
                TblResult.Text = $"Корни квадратного уравнения\nx1 = {result.x1:n5}\n{(result.x2 != null ? $"x2 = {result.x2:n5}" : "")}";
        }

        // проверка всех TextBox для ввода чисел на содержание
        private void TbxInputTextChanged_Command(object sender, TextChangedEventArgs e)
        {
            BtnAvg.IsEnabled = BtnEquation.IsEnabled = BtnMean.IsEnabled
                = (double.TryParse(TbxInputA.Text, out double n) 
                    && double.TryParse(TbxInputB.Text, out n) 
                    && double.TryParse(TbxInputC.Text, out n));
        }

    }
}
