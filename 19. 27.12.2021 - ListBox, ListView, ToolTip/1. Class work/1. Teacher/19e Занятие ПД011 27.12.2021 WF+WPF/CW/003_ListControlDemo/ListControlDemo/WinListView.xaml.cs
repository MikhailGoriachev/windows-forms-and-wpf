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

namespace ListControlDemo
{
    /// <summary>
    /// Логика взаимодействия для WinListView.xaml
    /// </summary>
    public partial class WinListView : Window
    {
        public WinListView()
        {
            InitializeComponent();

            // добавление приведет к выборосу исключения
            // LvPhones.Items.Add(new Phone { Company="BQ", Title="BQ 2300", Price=1990});
        }
    } // class WinListView
}
