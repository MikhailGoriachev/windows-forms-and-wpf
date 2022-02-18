using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableFunctions
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        } // Form1

        // заполнение таблицы выполняем в обработчике события загрузки формы
        private void Form1_Load(object sender, EventArgs e) {
            // задать DataGridView
            // DgvPersons.RowCount = 25;

            for (int i = 0; i < DateTime.Now.Second + 10; i++) {
                // добавить строку
                DgvPersons.RowCount++;

                // заполнить строку данными
                // !! первый индекс - столбец, второй индекс - строка !!
                DgvPersons[0, i].Value = i + 1;    // тут происходит неявный вызов  ToString()
                DgvPersons[1, i].Value = $"Фамилия{i}";
                DgvPersons[2, i].Value = $"Имя{i+1}";
                DgvPersons[3, i].Value = $"Отчество{i+1}";
                DgvPersons[4, i].Value = 1990 + i;
            } // for i
        } // Form1_Load


        // Отобразить индекс выбранной строки
        private void CmiShowItem_Click(object sender, EventArgs e) {
            // ничего не выбрано - молча уходим
            if (DgvPersons.SelectedRows.Count == 0) return;

            // Отобразить индекс выбранной строки таблицы
            // DgvPersons.SelectedRows[0].Index - индекс выбранной строки
            MessageBox.Show($"В таблице выбрана строка с индексом {DgvPersons.SelectedRows[0].Index}\n",
                "К сведению", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // CmiShowItem_Click


        // Закрыть форму
        private void CmiClose_Click(object sender, EventArgs e) => Close();
    }
}
