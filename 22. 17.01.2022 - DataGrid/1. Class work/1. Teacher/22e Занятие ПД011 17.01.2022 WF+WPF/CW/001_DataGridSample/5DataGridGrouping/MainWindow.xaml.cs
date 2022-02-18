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
using System.ComponentModel;

namespace _5DataGridGrouping
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Customer customer = new Customer();

            // ListCollectionView - позволяет группировать коллекцию по свойству
            // в данном случае по свойству Status 
            ListCollectionView view = new ListCollectionView(customer.CustomersList);
            view.GroupDescriptions.Add(new PropertyGroupDescription("Status"));

            // источник данных - сгруппированная колекция
            grid1.ItemsSource = view;
        }
    }
}
