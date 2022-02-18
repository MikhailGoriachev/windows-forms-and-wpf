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
using DependencyPropertyDemo.Models;
using DependencyPropertyDemo.Views;

namespace DependencyPropertyDemo
{
    /// <summary>
    /// Присоединенные свойства, свойства зависимостей
    /// </summary>
    public partial class MainWindow : Window
    {
        private Fox _fox;

        public MainWindow() {
            InitializeComponent();
            _fox = new Fox {Title = "Памела", Age = 12, Weight = 19.2};

            BtnJumpLeft.IsEnabled = false;

            // определение доступности "прыгающей" кнопки 
            BtnDemo.IsEnabled = BtnJumpRigth.IsEnabled && BtnJumpLeft.IsEnabled;

            // Программное создание объекта класса Button 
            // Button grid = new Button();
            // grid.Content = "Кнопка";
            // BtnDemo = grid;
        } // MainWindow

        // Демонстрация программной работы с присоединенными свойствами
        private void BtnJumpRight_Click(object sender, RoutedEventArgs e) {

            // чтение присоединенного свойства
            //        Класс.GetИмяСвойства(ЦелевойОбъект)
            int col = Grid.GetColumn(BtnDemo);
            BtnJumpLeft.IsEnabled = true;

            col++;
            if (col == 2) {
                BtnJumpRigth.IsEnabled = false;
            } // if

            // запись присоединенного свойства
            //        Класс.SetИмяСвойства(ЦелевойОбъект, значение)
            Grid.SetColumn(BtnDemo, col);

            // опеределение доступности "прыгающей" кнопки 
            BtnDemo.IsEnabled = BtnJumpRigth.IsEnabled && BtnJumpLeft.IsEnabled;
        } // BtnJump_Click

        private void BtnJumpLeft_Click(object sender, RoutedEventArgs e) {
            int col = Grid.GetColumn(BtnDemo);
            BtnJumpRigth.IsEnabled = true;

            col--;
            if (col == 0) {
                BtnJumpLeft.IsEnabled = false;
            } // if

            Grid.SetColumn(BtnDemo, col);

            // опеределение доступности "прыгающей" кнопки 
            BtnDemo.IsEnabled = BtnJumpRigth.IsEnabled && BtnJumpLeft.IsEnabled;
        } // BtnJumpLeft_Click


        // открыть окно для демонстрации свойств зависимости
        private void BtnDemo_Click(object sender, RoutedEventArgs e) {
            // пример использования конструкторов окна
            // FoxWindow win = new FoxWindow();
            FoxWindow win = new FoxWindow(_fox);
            if (win.ShowDialog() == true) {
                _fox = win.Fox;
                TxbFox.Text = $"{_fox}";
            } // if
        } // btnDemo_Click
    } // class MainWindow
}
