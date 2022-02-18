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

namespace WPF_ControlsDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        // Заверешние работы приложения
        private void btnExit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        } // btnExit_Click


        // Прокрутка списка радиокнопок на один элемент вверх
        // можно прокручивать: 
        // влево  LineLeft()
        // вправо LineRight()
        // вверх  LineUp()
        // вниз   LineDown()
        private void btnUp_Click(object sender, RoutedEventArgs e) =>
            scroll.LineUp();

        // Прокрутка списка радиокнопок на один элемент вниз
        // можно прокручивать: 
        // влево  LineLeft()
        // вправо LineRight()
        // вверх  LineUp()
        // вниз   LineDown()
        private void btnDown_Click(object sender, RoutedEventArgs e) =>
            scroll.LineDown();


        // Переход в окно для текстовых элементво управления
        private void Button_Click(object sender, RoutedEventArgs e) {
            TextItemWindow win = new TextItemWindow();
            win.ShowDialog();
        } // Button_Click
    } // class MainWindow
}
