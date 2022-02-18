using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardDialogs
{
    /*
     * Стандартные диалоги
     */
    public partial class MainForm : Form
    {
        // Конструктор формы
        public MainForm() {
            InitializeComponent();
        } // MainForm


        // завершение работы приложения
        private void Exit_Click(object sender, EventArgs e) => Application.Exit();


        // Обработка команды "Новый файл"
        private void New_Click(object sender, EventArgs e) {
            TxbText.Text = "";
            StlMain.Text = "";
        } // New_Click


        // вызов диалога открытия файла
        // Текст фильтра:
        // Текстовые файлы (*.txt)|*.txt|Файлы XML (*.xml)|*.xml|Файлы JSON(*.json)|*.json|Все файлы (*.*)|*.*
        private void Open_Click(object sender, EventArgs e) {
            if (OfdMain.ShowDialog() == DialogResult.OK) {
                TxbText.Text = File.ReadAllText(OfdMain.FileName);
                StlMain.Text = OfdMain.FileName;


                // снять выделение текста
                TxbText.SelectionStart = 0;
                TxbText.SelectionLength = 0;
            } // if
        } // Open_Click


        // вызов диалога сохранения файла
        private void Save_Click(object sender, EventArgs e) {
            SfdMain.Title = "Сохранение результатов";
            SfdMain.InitialDirectory = "/data";
            SfdMain.Filter = "Текстовые файлы (*.txt)|*.txt|Файлы XML (*.xml)|*.xml|Все файлы (*.*)|*.*d";
            SfdMain.FilterIndex = 1;

            if (SfdMain.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(SfdMain.FileName, TxbText.Text);
                StlMain.Text = SfdMain.FileName;


                // снять выделение текста
                TxbText.SelectionStart = 0;
                TxbText.SelectionLength = 0;
            } // if
        } // Save_Click


        // вызов диалога выбора шрифта
        private void Font_Click(object sender, EventArgs e) {
            FdlTextFont.ShowColor = true;
            if (FdlTextFont.ShowDialog() == DialogResult.OK) {
                TxbText.Font = FdlTextFont.Font;

                // снять выделение текста
                TxbText.SelectionStart = 0;
                TxbText.SelectionLength = 0;
            } // if
        } // Font_Click


        // вызов диалога выбора цветв фона текста
        private void Backcolor_Click(object sender, EventArgs e) {
            if (CdlBackColor.ShowDialog() == DialogResult.OK) {
                TxbText.BackColor = CdlBackColor.Color;
            } // if
        } // Backcolor_Click


        // Вызов диалога выбора цвета текста
        private void Color_Click(object sender, EventArgs e) {
            // MessageBox.Show("Реализовать в классе :)");
            if (CdlBackColor.ShowDialog() == DialogResult.OK) {
                TxbText.ForeColor = CdlBackColor.Color;
            } // if
        } // Color_Click
    } // class MainForm
}
