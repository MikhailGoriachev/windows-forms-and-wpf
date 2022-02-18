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
    /// Interaction logic for SelectWindow.xaml
    /// </summary>
    public partial class SelectWindow : Window
    {
        // выбранное значение 
        public string SelectionValue => CmbParam.SelectedItem?.ToString() ?? "";
        

        #region Конструкторы

        // конструктор по умолчанию
        public SelectWindow()
        {
            InitializeComponent();
        }


        // конструктор инцилизирующий
        public SelectWindow(string titleSelection, string nameParamSelection, List<string> values)
        {
            InitializeComponent();

            // установка значений
            Title = titleSelection;
            LblHeader.Content = titleSelection;
            LblParam.Content  = nameParamSelection;
            CmbParam.ItemsSource = values;
        }

        #endregion

        #region Методы

        // нажатие на клавишу "Выбрать"
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        #endregion

    }
}
