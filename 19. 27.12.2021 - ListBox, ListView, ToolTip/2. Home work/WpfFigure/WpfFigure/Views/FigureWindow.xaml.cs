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
using System.Windows.Shapes;
using WpfFigure.Models;             // модели
using WpfFigure.Interfaces;         // интерфейсы
using WpfFigure.Utilities;          // утилиты

namespace WpfFigure.Views
{
    /// <summary>
    /// Interaction logic for FigureView.xaml
    /// </summary>
    public partial class FigureWindow : Window
    {
        // фигура для обработки
        private IFigure _figure;

        // перечисление состояний запуска окна
        public enum FigureWindowState
        {
            // усеченный конус
            ConoidWindowState,

            // сфера
            SphereWindowState,

            // цилиндр
            CylinderWindowState,

            // прямоугольный параллелепипед
            ParallelepipedWindowState
        }

        // состояние запуска окна
        private FigureWindowState _stateWindow;

        #region Конструктор по умолчанию

        // конструктор по умолчанию
        public FigureWindow() : this(FigureWindowState.ConoidWindowState) { }


        // конструктор инициализирующий
        public FigureWindow(FigureWindowState stateWindow)
        {
            InitializeComponent();

            // установка значений
            _stateWindow = stateWindow;

            // инициализация окна
            InitWindow();

            // установка значения материала по умолчанию
            RbtSteel.IsChecked = true;
        }

        #endregion

        #region Методы

        // загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // подготовка окна к запуску
            InitWindow();

            // установка фокуса на первое поле ввода
            TbxFirst.Focus();

        } // Window_Loaded


        // проверка текста в текст-боксах
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // если один из объектов еще не инициализирован
            if (TbxFirst == null || TbxSecond == null || TbxThird == null || BtnResult == null)
                return;

            // включить/включить кнопку, если данные некорректны
            BtnResult.IsEnabled = double.TryParse(TbxFirst.Text, out double n)
                && double.TryParse(TbxSecond.Text, out n)
                && double.TryParse(TbxThird.Text, out n);

            // устнановка значения по умолчанию для полей вывода результата
            SetDefultResult();

        } // TextBox_TextChanged


        // обработка нажатия клавиш при вводе в текст-боксы
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = !(e.Key >= Key.D0 && e.Key <= Key.D9 ||
                         e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 ||
                         e.Key == Key.Tab ||
                         e.Key == Key.OemMinus ||
                         e.Key == Key.Subtract ||
                         e.Key == Key.OemComma);
        } // TbxHeight_KeyDown


        // вычисление 
        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            // установка значений для модели и получение результата
            SetValuesFigure();

            // получение результата и вывод результата
            TbxArea.Text   = CkbArea.IsChecked   == true ? $"{_figure.Area():n5}"   : TbxArea.Text;
            TbxMass.Text   = CkbMass.IsChecked   == true ? $"{_figure.Weight():n5}" : TbxMass.Text;
            TbxVolume.Text = CkbVolume.IsChecked == true ? $"{_figure.Volume():n5}" : TbxVolume.Text;

        } // BtnResult_Click


        // закрытие окна
        private void Exit_Click(object sender, RoutedEventArgs e) => Close();


        // изменение состояния чек-бокса
        private void CheckBox_Click(object sender, RoutedEventArgs e) => SetDefultResult();


        // устнановка значения по умолчанию для полей вывода результата
        public void SetDefultResult() =>
            TbxArea.Text = TbxVolume.Text = TbxMass.Text = "────────────";


        // выбор материала с помощью радиокнопок
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (_figure == null)
                return;

            SetDefultResult();

            // файл изображения / плотность материала
            (string file, double density) value = Utils.GetMaterial(((RadioButton)e.OriginalSource).Content?.ToString() ?? "");

            // установка изображения материала
            ImgMaterial.Source = Utils.GetUri(value.file);

            // вывод плотности
            TbxDensity.Text = $"{value.density:n5}";
        }

        #region Общие методы

        // установка значения полей окна для ввода по данным фигуры
        public void InitWindow()
        {
            switch (_stateWindow)
            {
                // усеченный конус
                case FigureWindowState.ConoidWindowState:

                    // создание фигуры
                    Conoid conoid = Utils.GetConoid();

                    // установка фигуры
                    _figure = conoid;

                    // установка названия окна
                    Title = "Усечённый конус";

                    // заполнение полей окна
                    TbxFirst.Text   = $"{conoid.Height:n5}";
                    TbxSecond.Text  = $"{conoid.Radius.top:n5}";
                    TbxThird.Text   = $"{conoid.Radius.down:n5}";

                    // установка наименований полей
                    LblFirst.Content    = "Высота";
                    LblSecond.Content   = "Верний радиус"; 
                    LblThird.Content   = "Нижний радиус";

                    // установка изображения фигуры
                    ImgFigure.Source = Utils.GetUri("conoid.png");

                    break;
                // сфера
                case FigureWindowState.SphereWindowState:

                    // создание фигуры
                    Sphere sphere = Utils.GetSphere();

                    // установка фигуры
                    _figure = sphere;

                    // установка названия окна
                    Title = "Сфера";

                    // заполнение полей окна
                    TbxFirst.Text = $"{sphere.Radius:n5}";

                    // установка наименований полей
                    LblFirst.Content = "Радиус";

                    // скрытие полей
                    LblSecond.Visibility = TbxSecond.Visibility = 
                        LblThird.Visibility = TbxThird.Visibility = Visibility.Hidden;

                    // установка изображения фигуры
                    ImgFigure.Source = Utils.GetUri("sphere.png");

                    break;
                // цилиндр
                case FigureWindowState.CylinderWindowState:

                    // создание фигуры
                    Cylinder cylinder = Utils.GetCylinder();

                    // установка фигуры
                    _figure = cylinder;

                    // установка названия окна
                    Title = "Цилиндр";

                    // заполнение полей окна
                    TbxFirst.Text  = $"{cylinder.Height:n5}";
                    TbxSecond.Text = $"{cylinder.Radius:n5}";

                    // установка наименований полей
                    LblFirst.Content  = "Высота";
                    LblSecond.Content = "Радиус";

                    // скрытие полей
                    LblThird.Visibility = TbxThird.Visibility = Visibility.Hidden;

                    // установка изображения фигуры
                    ImgFigure.Source = Utils.GetUri("cylinder.png");

                    break;
                // прямоугольный параллелепипед
                case FigureWindowState.ParallelepipedWindowState:

                    // создание фигуры
                    RectangularParallelepiped parallelepiped = Utils.GetParallelepiped();

                    // установка фигуры
                    _figure = parallelepiped;

                    // установка названия окна
                    Title = "Прямоугольный параллелепипед";

                    // заполнение полей окна
                    TbxFirst.Text  = $"{parallelepiped.A:n5}";
                    TbxSecond.Text = $"{parallelepiped.B:n5}";
                    TbxThird.Text  = $"{parallelepiped.C:n5}";

                    // установка наименований полей
                    LblFirst.Content  = "Сторона A";
                    LblSecond.Content = "Сторона B";
                    LblSecond.Content = "Сторона C";

                    // установка изображения фигуры
                    ImgFigure.Source = Utils.GetUri("parallelepiped.png");

                    break;
                default:
                    break;
            }
        }


        // опеределение состояния окна по типу фигуры
        public void SetStateWindow()
        {
            // тип фигуры
            Type type = _figure.GetType();

            // усеченный конус
            if (type == typeof(Conoid))
                _stateWindow = FigureWindowState.ConoidWindowState;
            // сфера
            else if (type == typeof(Sphere))
                _stateWindow = FigureWindowState.SphereWindowState;
            // цилиндр
            else if (type == typeof(Cylinder))
                _stateWindow = FigureWindowState.CylinderWindowState;
            // прямоугольный параллелепипед
            else if (type == typeof(RectangularParallelepiped))
                _stateWindow = FigureWindowState.ParallelepipedWindowState;
        }


        // установка значений полей в модель
        public void SetValuesFigure()
        {
            try
            {

                switch (_stateWindow)
                {
                    // усеченный конус
                    case FigureWindowState.ConoidWindowState:

                        // приведение типа фигуры
                        Conoid conoid = (Conoid)_figure;

                        // установка значений
                        conoid.Height  = double.Parse(TbxFirst.Text);
                        conoid.Radius  = (double.Parse(TbxSecond.Text), double.Parse(TbxThird.Text));
                        conoid.Density = double.Parse(TbxDensity.Text);

                        break;
                    // сфера
                    case FigureWindowState.SphereWindowState:

                        // приведение типа фигуры
                        Sphere sphere = (Sphere)_figure;

                        // установка значений
                        sphere.Radius  = double.Parse(TbxFirst.Text);
                        sphere.Density = double.Parse(TbxDensity.Text);

                        break;
                    // цилиндр
                    case FigureWindowState.CylinderWindowState:

                        // приведение типа фигуры
                        Cylinder cylinder = (Cylinder)_figure;

                        // установка значений
                        cylinder.Height  = double.Parse(TbxFirst.Text);
                        cylinder.Radius  = double.Parse(TbxSecond.Text);
                        cylinder.Density = double.Parse(TbxDensity.Text);

                        break;
                    // прямоугольный параллелепипед
                    case FigureWindowState.ParallelepipedWindowState:

                        // приведение типа фигуры
                        RectangularParallelepiped parallelepiped = (RectangularParallelepiped)_figure;

                        // установка значений
                        parallelepiped.A       = double.Parse(TbxFirst.Text);
                        parallelepiped.B       = double.Parse(TbxSecond.Text);
                        parallelepiped.C       = double.Parse(TbxThird.Text);
                        parallelepiped.Density = double.Parse(TbxDensity.Text);

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

        #endregion
    }
}
