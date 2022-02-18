using System.Windows;
using System.Collections;
using System.Data;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Input;

namespace DataGridAndTable
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // в таблицу загружаем данные, сгенерированные методом:
            Grid1.ItemsSource = CreateTable().DefaultView;
        }

        // создание таблицы в коде
        DataTable CreateTable()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID"), 
                new DataColumn("FirstName"), 
                new DataColumn("LastName")
            });

            table.LoadDataRow(new object[] { "1", "Jhon", "Doe" }, true);
            table.LoadDataRow(new object[] { "2", "Kate", "Khone" }, true);
            table.LoadDataRow(new object[] { "3", "Tom", "Ronald" }, true);
            
            return table;
        }

        private void grid1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView selectedRow = Grid1.SelectedItem as DataRowView;

            if (selectedRow == null) {
                return;
            }

            string result = string.Empty;
            for (int i = 0; i < 3; ++i) {
                result += selectedRow.Row[i] + " ";
            }
            
            TblInfo.Text =  $"Выбранные данные: \"{result}\"";

        }
    }
}
