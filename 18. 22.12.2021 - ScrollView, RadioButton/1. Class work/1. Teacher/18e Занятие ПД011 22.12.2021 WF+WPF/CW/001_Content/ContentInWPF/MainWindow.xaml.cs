using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContentInWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Test - не наследуется от UIElement. Используется метод ToString
            // Content - свойство, принимающее колллекцию объектов для отображения
            Button1.Content = new Test();

            // TextBox - производный от UIElement.
            // отрисовка добавленного элемента - его методом OnRender() 
            TextBox textBox = new TextBox {
                Width = 100
            };
            Button2.Content = textBox;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Клик по кнопке", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    class Test
    {
        public override string ToString() => "Hello world";
        
    }
}
