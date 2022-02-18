using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Controllers;     // обработка по заданию
using HomeWork.Utilities;       // утилиты
using System.IO;                // для работы с потоками данных
using HomeWork.Views;           // формы

/*
 * Задача 1. Разработайте приложение Windows Forms c «меню» на базе LinkLabel. 
 * В главной форме разместите кнопки, элементы NumericUpDown для ввода операндов
 * и выполнения операций: сложение, вычитание, умножение, деление, вычисление 
 * синуса, вычисление квадратного корня, вычисление степени.
 * Должны быть радиокнопки задания угла для вычисления синуса в градусах или 
 * радианах.
 * На форме должен быть TextBox для вывода текущей операции, операндов и ее 
 * результата, TextBox для вывода истории операций (операнды, операция и 
 * результат).
 * Операция выполняется по клику на кнопку.  
 * Момент выполнения операции (дата и время с точность до секунды), операнд 
 * или операнды, результат записывайте в текстовый файл – журнал операций в папке
 * исполняемого файла приложения.
 * По команде О программе «меню» в отдельной форме выводить в Label сведения о
 * приложении и разработчике (фамилия, имя, группа). При помощи таймера реализуйте
 * закрытие формы «О программе» через 10 секунд после открытия.
 * По команде Выход «меню» завершается работа приложения
 * По команде Журнал «меню» открывается в модальном режиме форма с многострочным
 * полем TextBox только для чтения. В событии Load читать файл журнала, выводить
 * его записи в табличном виде в TextBox. В форме предусмотрите кнопки для очистки 
 * файла журнала, закрытия формы  
 */ 

namespace HomeWork
{
    // главная форма
    public partial class MainForm : Form
    {
        // перечисление состояний
        public enum States
        {
            // 1. Сложение,
            Sum,
            // 2. Вычитание,
            Substract,
            // 3. Умножение,
            Multi,
            // 4. Деление,
            Division,
            // 5. Вычисление синуса,
            Sin,
            // 6. Вычисление квадратного корня,
            Sqrt,
            // 7. Вычисление степени
            Degree
        }

        // обработка по заданию
        private Controller controller = new Controller();

        // состояние (паттерн Состояние)
        // обработка по заданию:
        // 1. Сложение,
        // 2. Вычитание,
        // 3. Умножение,
        // 4. Деление,
        // 5. Вычисление синуса,
        // 6. Вычисление квадратного корня,
        // 7. Вычисление степени
        public States State { get; set; }

        // название файла для сохранения результата
        public string NameFile { get; set; } = "log.txt";

        #region Конструкторы 

        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Методы

        // выход из приложения
        private void LilExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => Application.Exit();

        #region Установка состояния элементов по умолчанию

        // установка значения LblType
        void SetDefaultLblType() => LblType.Text = "Выберите тип вычисления";

        // установка значения LblViewType
        void SetDefaultLblViewType() => LblViewType.Text = "Вид вычисления";

        // установка значения TbxResult
        void SetDefaultTbxResult() => TbxResult.Text = "\r\nРезультат";

        // установка значения LblResultDateTime
        void SetDefaultLblResultDateTime() => LblResultDateTime.Text = "Дата и время";

        // установка значения NudInputA
        void SetDefaultNudInputA() => NudInputA.Value = 1;

        // установка значения NudInputB
        void SetDefaultNudInputB() => NudInputB.Value = 1;

        // установка значения по умолчанию выбора типа единиц измерения
        void SetDefaultSelectType()
        {
            RbnDegree.Checked = RbnRadians.Checked = false;
            RbnDegree.Enabled = RbnRadians.Enabled = false;
        }

        #endregion

        #region Установка типа вычисления

        // сложение 
        private void LilSum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Сложение";

            // установка вида выражения
            LblViewType.Text = "a + b";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "Число B";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 3;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 1_000_000_000;
            NudInputB.Minimum = -1_000_000_000;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = (decimal)Utils.GetRand(10d, 20d);

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = true;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = false;
            RbnRadians.Enabled = false;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = false;
            RbnRadians.Checked = false;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Sum((double)NudInputA.Value, (double)NudInputB.Value);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Sum;

            // выделение фона пункта
            ElementHighlightType();
        }

        // вычитание 
        private void LilSubstract_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Вычитание";

            // установка вида выражения
            LblViewType.Text = "a - b";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "Число B";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 3;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 1_000_000_000;
            NudInputB.Minimum = -1_000_000_000;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = (decimal)Utils.GetRand(10d, 20d);

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = true;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = false;
            RbnRadians.Enabled = false;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = false;
            RbnRadians.Checked = false;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Substract((double)NudInputA.Value, (double)NudInputB.Value);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Substract;

            // выделение фона пункта
            ElementHighlightType();
        }

        // умножение
        private void LilMulti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Умножение";

            // установка вида выражения
            LblViewType.Text = "a * b";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "Число B";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 3;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 1_000_000_000;
            NudInputB.Minimum = -1_000_000_000;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = (decimal)Utils.GetRand(10d, 20d);

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = true;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = false;
            RbnRadians.Enabled = false;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = false;
            RbnRadians.Checked = false;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Mult((double)NudInputA.Value, (double)NudInputB.Value);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Multi;

            // выделение фона пункта
            ElementHighlightType();
        }

        // деление 
        private void LilDivision_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Деление";

            // установка вида выражения
            LblViewType.Text = "a / b";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "Число B";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 3;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 1_000_000_000;
            NudInputB.Minimum = -1_000_000_000;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = (decimal)Utils.GetRand(10d, 20d);

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = true;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = false;
            RbnRadians.Enabled = false;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = false;
            RbnRadians.Checked = false;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Division((double)NudInputA.Value, (double)NudInputB.Value);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Division;

            // выделение фона пункта
            ElementHighlightType();
        }

        // вычисление степени
        private void LilDigree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Вычисление степени";

            // установка вида выражения
            LblViewType.Text = "a^n";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "Степень n";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 0;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 100;
            NudInputB.Minimum = -100;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = 3;

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = true;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = false;
            RbnRadians.Enabled = false;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = false;
            RbnRadians.Checked = false;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Degree((double)NudInputA.Value, (int)NudInputB.Value);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Degree;

            // выделение фона пункта
            ElementHighlightType();
        }

        // вычисление синуса
        private void LilSinus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Вычисление синуса";

            // установка вида выражения
            LblViewType.Text = "sinA";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "───────";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 0;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 0;
            NudInputB.Minimum = 0;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = 0;

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = false;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = true;
            RbnRadians.Enabled = true;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = true;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Sin(RbnRadians.Checked ? (double)NudInputA.Value : (double)NudInputA.Value * Math.PI / 180);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Sin;

            // выделение фона пункта
            ElementHighlightType();
        }

        // вычисление квадратного корня
        private void LilSquareRoot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // активация кнопки "Вычислить резултат"
            BtnResult.Enabled = true;

            // установка названия типа 
            LblType.Text = "Вычисление квадратного корня";

            // установка вида выражения
            LblViewType.Text = "sqrt(a)";

            // установка результата
            SetDefaultLblResultDateTime();
            SetDefaultTbxResult();

            // установка названия полей
            LblInputA.Text = "Число A";
            LblInputB.Text = "───────";

            // установка дробной части
            NudInputA.DecimalPlaces = 3;
            NudInputB.DecimalPlaces = 0;

            // установка диапазона для ввода
            NudInputA.Maximum = 1_000_000_000;
            NudInputA.Minimum = -1_000_000_000;
            NudInputB.Maximum = 0;
            NudInputB.Minimum = 0;

            // установка значений по умолчанию для ввода
            NudInputA.Value = (decimal)Utils.GetRand(10d, 20d);
            NudInputB.Value = 0;

            // активация полей для ввода 
            NudInputA.Enabled = true;
            NudInputB.Enabled = false;

            // активация RadioButton для выбора единицы измерения
            RbnDegree.Enabled = false;
            RbnRadians.Enabled = false;

            // установка значения по умолчанию (градусы)
            RbnDegree.Checked = false;
            RbnRadians.Checked = false;

            // установка курсора на поле ввода первого числа
            NudInputA.Focus();

            // запись в тег результирующей кнопки ссылки на метод обработки
            Func<double> lambda = () => controller.Square((double)NudInputA.Value);
            BtnResult.Tag = lambda;

            // установка состояния
            State = States.Sqrt;

            // выделение фона пункта
            ElementHighlightType();
        }

        // получение строкового представления результата
        private string GetResultString(double result)
        {
            switch (State)
            {
                // 1. Сложение,
                case States.Sum:
                    return $"{NudInputA.Value:n3} + {NudInputB.Value:n3} = {result:n3}";
                // 2. Вычитание,
                case States.Substract:
                    return $"{NudInputA.Value:n3} - {NudInputB.Value:n3} = {result:n3}";
                // 3. Умножение,
                case States.Multi:
                    return $"{NudInputA.Value:n3} * {NudInputB.Value:n3} = {result:n3}";
                // 4. Деление,
                case States.Division:
                    return $"{NudInputA.Value:n3} / {NudInputB.Value:n3} = {result:n3}";
                // 5. Вычисление синуса,
                case States.Sin:
                    return $"sin{NudInputA.Value:n3} = {result:n3}";
                // 6. Вычисление квадратного корня,
                case States.Sqrt:
                    return $"sqrt({NudInputA.Value:n3}) = {result:n3}";
                // 7. Вычисление степени
                case States.Degree:
                    return $"{NudInputA.Value:n3}^{NudInputB.Value:n0} = {result:n3}";

                default:
                    return "────────";
            }
        }

        #endregion

        #region Вычисление результата

        // получение результата
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // результат
            double valueResult = (BtnResult.Tag as Func<double>).Invoke();

            // строковое представление резултата
            (string value, DateTime date) result = (GetResultString(valueResult), DateTime.Now);

            // вывод результата
            TbxResult.Text = $"\r\n{result.value}";
            LblResultDateTime.Text = $"{result.date:G}";

            // вывод операции в историю операций
            TbxHistory.Text += $"{result.value,-50}{ result.date:G}\r\n";

            // запись в файл выражения, времени и даты резултата
            WriteLogFile(valueResult, result.date);
        }

        #endregion

        #region Общие методы

        // выделение фона LinkedLable выбора типа вычисления (по состояние State)
        private void ElementHighlightType()
        {
            // установка стандартного фона всех пунктов
            LilDigree.BackColor = 
                LilDivision.BackColor = 
                LilMulti.BackColor = 
                LilSinus.BackColor = 
                LilSquareRoot.BackColor = 
                LilSum.BackColor = 
                LilSubstract.BackColor = Color.Gray;

            // выделение пункта по состоянию
            switch (State)
            {
                // 1. Сложение,
                case States.Sum:
                    LilSum.BackColor = Color.DarkGray;
                    break;
                // 2. Вычитание,
                case States.Substract:
                    LilSubstract.BackColor = Color.DarkGray;
                    break;
                // 3. Умножение,
                case States.Multi:
                    LilMulti.BackColor = Color.DarkGray;
                    break;
                // 4. Деление,
                case States.Division:
                    LilDivision.BackColor = Color.DarkGray;
                    break;
                // 5. Вычисление синуса,
                case States.Sin:
                    LilSinus.BackColor = Color.DarkGray;
                    break;
                // 6. Вычисление квадратного корня,
                case States.Sqrt:
                    LilSquareRoot.BackColor = Color.DarkGray;
                    break;
                // 7. Вычисление степени
                case States.Degree:
                    LilDigree.BackColor = Color.DarkGray;
                    break;
            }

        }

        // измененеие значения полей ввода чисел A и B
        private void NudInput_ValueChanged(object sender, EventArgs e)
        {
            // установка значений по умолчанию в полях вывода результата
            SetDefaultTbxResult();
            SetDefaultLblResultDateTime();

        }

        // изменение единицы измерения
        private void RbnDegree_CheckedChanged(object sender, EventArgs e)
        {
            // установка значений по умолчанию в полях вывода результата
            SetDefaultTbxResult();
            SetDefaultLblResultDateTime();
        }

        // запись операции в файл
        private void WriteLogFile(double result, DateTime date) => 
            // добавление записи в файл
            File.AppendAllText(NameFile, GetInfoResult(result, date));

        // получение строки с описанием действия (операнды, операция, результат, время и дата)
        private string GetInfoResult(double result, DateTime date)
        {
            // выделение пункта по состоянию
            switch (State)
            {
                // 1. Сложение,
                case States.Sum:
                    return $"Тип: Сложение;                          Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                // 2. Вычитание,
                case States.Substract:
                    return $"Тип: Вычитание;                         Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                // 3. Умножение,
                case States.Multi:
                    return $"Тип: Умножение;                         Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                // 4. Деление,
                case States.Division:
                    return $"Тип: Деление;                           Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                // 5. Вычисление синуса,
                case States.Sin:
                    return $"Тип: Вычисление синуса;                 Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                // 6. Вычисление квадратного корня,
                case States.Sqrt:
                    return $"Тип: Вычисление квадратного корня;      Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                // 7. Вычисление степени
                case States.Degree:
                    return $"Тип: Вычисление степени;                Оперция: {GetResultString(result) + ";",-35} Дата и время: {date:G}\r\n";
                default:
                    return "";
            }
        }

        #endregion

        #endregion

        // открытие формы "Журнал" в модальном режиме
        private void LilLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => new LogForm().ShowDialog();

        // открытие формы "О программе" в модальном режиме
        private void LilInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => new InfoForm().ShowDialog();
    }
}