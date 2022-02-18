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

namespace HomeWork.Views.Task2
{
    /// <summary>
    /// Interaction logic for SelectSelection.xaml
    /// </summary>
    public partial class SelectSelection : Window
    {
        // выбранное значение
        public string Parameter => (string)CmbParam.SelectedItem;

        #region Конструкторы

        // конструктор по умолчанию
        public SelectSelection()
        {
            InitializeComponent();
        }


        // конструктор иницаилизирующий
        public SelectSelection(List<string> valuesCmbs, string labelParam, string title) : this()
        {
            // установка значений в ComboBox
            valuesCmbs.ForEach(v => CmbParam.Items.Add(v));

            // установка текста
            LblTitle.Content = title;
            LblParam.Content = labelParam;

            // если количество элементов для заполнения равен нулю
            BtnOk.IsEnabled = valuesCmbs.Count == 0 ? false : true;
        }

        #endregion

        #region Методы

        // кнопка "Выбрать"
        private void BtnOk_Click(object sender, RoutedEventArgs e) { DialogResult = true; Close(); }

        #endregion



    }
}
