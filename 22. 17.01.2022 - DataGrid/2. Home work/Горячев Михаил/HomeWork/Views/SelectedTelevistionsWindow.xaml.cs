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
using HomeWork.Models.Task1;          // модели

namespace HomeWork.Views
{
    /// <summary>
    /// Interaction logic for SelectedTelevistionsWindow.xaml
    /// </summary>
    public partial class SelectedTelevistionsWindow : Window
    {
        // коллекция выбранных телевизоров
        public List<TelevisionModel> Televisions { get; set; }

        #region Конструкторы

        // конструктор по умолчанию
        public SelectedTelevistionsWindow()
        {
            InitializeComponent();
        }


        // конструктор инциализирующий
        public SelectedTelevistionsWindow(List<TelevisionModel> televisions, string nameSelection) : this()
        {
            // установка значений
            Televisions = televisions;
            LblHeader.Content = nameSelection;
        }

        #endregion

        #region Методы

        // загрузка окна 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // заполнение ListView
            FillListView();
        }


        // заполнение ListView
        public void FillListView()
        {
            LviTelevisions.ItemsSource = null;
            LviTelevisions.ItemsSource = Televisions;
        }        

        #endregion
    }
}
