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

namespace DynamicContent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void chkLongText_Checked(object sender, RoutedEventArgs e)
        {
            cmdPrev.Content = " <- Перейти к предыдущему окну - Window ";
            cmdNext.Content = " Перейти к следующему окну - Window -> ";
        }

        private void chkLongText_Unchecked(object sender, RoutedEventArgs e)
        {
            cmdPrev.Content = "Назад";
            cmdNext.Content = "Вперед";
        }

        // Рекомендуемый способ завершение WPF-приложений
        private void cmdClose_Click(object sender, RoutedEventArgs e) =>
            Application.Current.Shutdown();
    }
}
