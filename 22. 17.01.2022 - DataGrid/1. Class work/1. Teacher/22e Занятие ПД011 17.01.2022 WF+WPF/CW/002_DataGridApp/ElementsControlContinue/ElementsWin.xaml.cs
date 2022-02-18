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

namespace ElementsControlContinue
{
    /// <summary>
    /// Логика взаимодействия для ElementsWin.xaml
    /// </summary>
    public partial class ElementsWin : Window
    {
        public ElementsWin()
        {
            InitializeComponent();
        }

        // Связь прогесс-бара и слайдера
        private void slFirst_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            pbFirst.Value = slFirst.Value;          // перемещение выделенной части прогресс-бара
            slFirst.SelectionEnd = slFirst.Value;   // перемещение затенения по слайдеру
        } // slFirst_ValueChanged

        // Обработчик выбора даты пользователем 
        private void dpFirst_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            tbDatePicker.Text =
                $"Дата из элемента DatePicker: {dpFirst.SelectedDate.Value.Date.ToShortDateString()}";
        } // dpFirst_SelectedDateChanged


        // Получить дату из элемента Calendar и отобразить в элементе TextBlock
        private void btnGetDate_Click(object sender, RoutedEventArgs e)
        {
            tbCalendar.Text =
                $"Дата из элемента Calendar: {clnFirst.SelectedDate.Value.Date.ToShortDateString()}";
        } // btnGetDate_Click
    } // class ElementsWin
}
