using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _6DataGridRowDeteils
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // разместим коллекцию в коде
        // private ObservableCollection<Customer> _customers;
        public MainWindow()
        {
            InitializeComponent();

            // _customers = new Customer().CustomersList;
            // DgCustomers.ItemsSource = _customers;

            // добавление в коллекцию 
            // _customers.Add(new Customer {FirstName = "Василий", LastName = "Петров"});
        }
    }
}
