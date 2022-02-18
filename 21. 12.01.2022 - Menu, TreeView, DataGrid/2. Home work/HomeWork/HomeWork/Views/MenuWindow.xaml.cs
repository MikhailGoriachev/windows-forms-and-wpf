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

namespace HomeWork.Views
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }


        // запуск окна "Списки пилотов и стюардесс"
        private void Lists_Click(object sender, RoutedEventArgs e) => new DataGridsWindow().ShowDialog();


        // запуск окна "Ремонт телевизоров"
        private void ListRepairShop_Click(object sender, RoutedEventArgs e) => new DataGridRepairShopWindow().ShowDialog();


        // запуск окна "Информация о программе"
        private void ProgramInfo_Click(object sender, RoutedEventArgs e) => new ProgramInfoWindow().ShowDialog();


        // завершение работы приложения
        private void Exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();


    }
}
