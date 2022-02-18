using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkWF
{
    /*
     * Задача 2. Разработайте приложение Windows Forms, состоящее из одной формы,
     * используйте TextBox, Button, ErrorProvider, Label, GroupBox.
     * 
     * Приложение должно организовать ввод данных и обработку по командным кнопкам
     * Button (т.е. в событии Click кнопок, пока без модели) следующих задач.
     * 
     * If15. Даны три переменные вещественного типа. Найти сумму двух наибольших 
     *      из них (т.е. для чисел 1, 2, 3 сумма будет равна 5).
     *      
     * If17. Даны три переменные вещественного типа: A, B, C. Если их значения 
     *      упорядочены по возрастанию или убыванию, то удвоить их; в противном 
     *      случае заменить значение каждой переменной на противоположное. Вывести 
     *      новые значения переменных A, B, C.
     *      
     * Предусмотрите кнопку завершения работы приложения.
    */

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // закрытие формы
        private void BtnExit_Click(object sender, EventArgs e) => Close();

        // задание 1 If15
        private void BtnTaskIf15_Click(object sender, EventArgs e)
        {
            /*
             * If15. Даны три переменные вещественного типа. Найти сумму двух наибольших 
             *      из них (т.е. для чисел 1, 2, 3 сумма будет равна 5).
             */

            // вывод условий задания
            LblTaskInfo.Text = "If15. Даны три переменные вещественного типа. Найти сумму двух наибольших из них (т.е. для чисел 1, 2, 3 сумма будет равна 5).";

            // значения
            double[] abc = new double[3];

            // считывание значения A
            bool isParse = double.TryParse(TxbFirstNumber.Text, out abc[0]);
            ErpNumberA.SetError(TxbFirstNumber, isParse ? "" : "Данные невалидны!");

            // считывание значения B
            isParse = double.TryParse(TxbSecondNumber.Text, out abc[1]);
            ErpNumberB.SetError(TxbSecondNumber, isParse ? "" : "Данные невалидны!");

            // считывание значения C
            isParse = double.TryParse(TxbThirdNumber.Text, out abc[2]);
            ErpNumberC.SetError(TxbThirdNumber, isParse ? "" : "Данные невалидны!");

            // сортировка по значению
            Array.Sort(abc, (item1, item2) => item2.CompareTo(item1));

            // вывод результата
            LblResult.Text = $"Сложение чисел {abc[0]} и {abc[1]}:\nСумма: {abc[0] + abc[1]}";
        }

        // задание 1 If17
        private void BtnTaskIf17_Click(object sender, EventArgs e)
        {
            /*
             * If17. Даны три переменные вещественного типа: A, B, C. Если их значения 
             *      упорядочены по возрастанию или убыванию, то удвоить их; в противном 
             *      случае заменить значение каждой переменной на противоположное. Вывести 
             *      новые значения переменных A, B, C.
             */

            // вывод условий задания
            LblTaskInfo.Text = "If17. Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию или убыванию, то удвоить их; в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных A, B, C.";

            // значения
            double[] abc = new double[3];

            // считывание значения A
            bool isParse = double.TryParse(TxbFirstNumber.Text, out abc[0]);
            ErpNumberA.SetError(TxbFirstNumber, isParse ? "" : "Данные невалидны!");

            // считывание значения B
            isParse = double.TryParse(TxbSecondNumber.Text, out abc[1]);
            ErpNumberB.SetError(TxbSecondNumber, isParse ? "" : "Данные невалидны!");

            // считывание значения C
            isParse = double.TryParse(TxbThirdNumber.Text, out abc[2]);
            ErpNumberC.SetError(TxbThirdNumber, isParse ? "" : "Данные невалидны!");

            // делегат для обработки значений
            Func<double, double> action;

            // если значения упорядочены по возрастанию или по убыванию
            if (abc[0] > abc[1] && abc[1] > abc[2] || abc[0] < abc[1] && abc[1] < abc[2])
                action = item => item * 2d;
            else action = item => -item;

            // обработка значений
            for (int i = 0; i < abc.Length; i++) abc[i] = action(abc[i]);

            // вывод результата
            LblResult.Text = $"Обработка чисел {abc[0]}, {abc[1]} и {abc[2]}:\nЧисло A: {abc[0]}\nЧисло B: {abc[1]}\nЧисло C: {abc[2]}";
        }

        // изменение значения при ввода числа A
        private void TxbFirstNumber_TextChanged(object sender, EventArgs e) => ErpNumberA.SetError(TxbFirstNumber, "");

        // изменение значения при ввода числа B
        private void TxbSecondNumber_TextChanged(object sender, EventArgs e) => ErpNumberB.SetError(TxbSecondNumber, "");

        // изменение значения при ввода числа C
        private void TxbThirdNumber_TextChanged(object sender, EventArgs e) => ErpNumberC.SetError(TxbThirdNumber, "");
    }
}
