using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextInputOutptut
{
    public partial class MainForm : Form
    {
        // конструктор по умолчанию, сгенерированный средой
        public MainForm() {
            InitializeComponent();

            // пример настройки элементов интерфейса в коде
            // (естественно, константные литеральные значения правильнее
            // задавать в палитре свойств)
            TbxFirstNumber.Text = "0";
            TbxFirstNumber.TextAlign = HorizontalAlignment.Right;

            TbxSecndNumber.Text = "0";
            TbxSecndNumber.TextAlign = HorizontalAlignment.Right;
            
            TbxThirdNumber.Text = "0";
            TbxThirdNumber.TextAlign = HorizontalAlignment.Right;
        } // MainForm

        // выход из приложения
        private void BtnQuit_Click(object sender, EventArgs e) => Close();


        // решение задачи поиска минимального числа из трех,
        // пока без модели, но только в этом примере
        private void BtnMinimum_Click(object sender, EventArgs e) {
            int min;
            
             // проверка корректности ввода данных - число A 
             bool result = int.TryParse(TbxFirstNumber.Text, out int a);
             if (!result) {
                 // данные не корректны - активировать ErrorProvider 
                 // на элементе, в котором возникла ошибка
                 ErpNumberA.SetError(TbxFirstNumber, "Недопустимый формат");
             } else {
                 // данные корректны - деактивировать ErrorProvider
                 // на этом элементе ввода
                 ErpNumberA.SetError(TbxFirstNumber, "");
             } // if

             // аналогичный ввод и проверка для числа B
             result = int.TryParse(TbxSecndNumber.Text, out int b);
             ErpNumberB.SetError(TbxSecndNumber, !result ? "Недопустимый формат" : "");

             // аналогичный ввод и проверка для числа C
             result = int.TryParse(TbxThirdNumber.Text, out int c);
             ErpNumberC.SetError(TbxThirdNumber, !result ? "Недопустимый формат" : "");

             // обработка по заданию - ищем минимальное значение
             // для трех чисел A, B, C
             if (a < b && a < c)
                 min = a;
             else if (b < c)
                 min = b;
             else
                 min = c;

             // вывод результата
             LblResult.Text = $"Из трех чисел {a}, {b}, {c}\nминимальное {min}";
        } // BtnMinimum_Click


        // при начале ввода данных в поле ввода числа A убираем 
        // признак ошибки для ErrorProvider
        private void TbxFirstNumber_TextChanged(object sender, EventArgs e) =>
            ErpNumberA.SetError(TbxFirstNumber, "");
        

        // при начале ввода данных в поле ввода числа B убираем 
        // признак ошибки для ErrorProvider
        private void TbxSecndNumber_TextChanged(object sender, EventArgs e) =>
            ErpNumberB.SetError(TbxSecndNumber, "");

        // при начале ввода данных в поле ввода числа С убираем 
        // признак ошибки для ErrorProvider
        private void TbxThirdNumber_TextChanged(object sender, EventArgs e) =>
            ErpNumberC.SetError(TbxThirdNumber, "");


        // решение задачи поиска максимального числа из трех,тоже пока без модели,
        // но только в этом примере
        private void BtnMaximum_Click(object sender, EventArgs e) {
            int max;
            
             // проверка корректности ввода данных - число A 
             bool result = int.TryParse(TbxFirstNumber.Text, out int a);
             if (!result) {
                 // данные не корректны - активировать ErrorProvider 
                 // на элементе, в котором возникла ошибка
                 ErpNumberA.SetError(TbxFirstNumber, "Недопустимый формат");
             } else {
                 // данные корректны - деактивировать ErrorProvider
                 // на этом элементе ввода
                 ErpNumberA.SetError(TbxFirstNumber, "");
             } // if

             // аналогичный ввод и проверка для числа B
             result = int.TryParse(TbxSecndNumber.Text, out int b);
             ErpNumberB.SetError(TbxSecndNumber, !result ? "Недопустимый формат" : "");

             // аналогичный ввод и проверка для числа C
             result = int.TryParse(TbxThirdNumber.Text, out int c);
             ErpNumberC.SetError(TbxThirdNumber, !result ? "Недопустимый формат" : "");

             // обработка по заданию - ищем максимальное значение
             // для трех чисел A, B, C
             if (a > b && a > c)
                 max = a;
             else if (b > c)
                 max = b;
             else
                 max = c;

             // вывод результата
             LblResult.Text = $"Из трех чисел {a}, {b}, {c}\nмаксимальное {max}";
        } // BtnMaximum_Click
    } // class MainForm
}
