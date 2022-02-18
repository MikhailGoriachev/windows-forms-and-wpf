using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DragAndDropDemo
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();

            // Назначение обработчика события Click для кнопки "Выход" - только вызов
            // метода Exit() для завершения приложения
            BtnExit.Click += (sender, e) => Application.Exit();

            // Настроить разрешение перетаскивания на кнопку по стартовому состоянию чек-бокса
            BtnExit.AllowDrop = ChbEnable.Checked;
        } // MainForm


        // Начало перетаскивания - нажатие левой кнопки мышки
        private void txtSource_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) return;

            // Начало буксировки - по нажатии ЛКМ на строке ввода текста
            // txtData.DoDragDrop(txtData.Text, DragDropEffects.Move);
            TxtData.DoDragDrop(TxtData.Text, DragDropEffects.Copy);
        } // txtSource_MouseDown


        // Обработчик завершения перетаскивания - сброс перетаскиваемых данных
        private void lblData_DragDrop(object sender, DragEventArgs e) {
            if (e.Effect == DragDropEffects.Move)
                TxtData.Text = "";
            LblData.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
        } // lblData_DragDrop


        // Подтверждение эффекта перетаскивания при входе в элемент управления -
        // адресат перетаскивания: если содержатся ожидаемые данные, задаем 
        // команду на их копирование иначе - ничего не предпринимать, 
        // т.е. отменить перетаскивание 
        // (общий обработчик для метки, строки ввода и кнопки)
        private void elements_DragEnter(object sender, DragEventArgs e) {
            e.Effect = e.Data.GetDataPresent(DataFormats.StringFormat) // строковые данные 
                || e.Data.GetDataPresent(DataFormats.FileDrop)?  // файл данных - имя файла
                // DragDropEffects.All:    // разрешены все операции
                // DragDropEffects.Move:   // разрешена только операция Move
                DragDropEffects.Copy :     // разрешена только операция Copy
                DragDropEffects.None;
        } // elements_DragEnter

        // ------------------------ развитие перетаскивания --------------------------------

        // Приемником перетаскивания сделаем строку ввода
        private void TxtData_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
                // Прием текста
                TxtData.Text = e.Data.GetData(DataFormats.StringFormat).ToString();
            else {
                // Прием файла, data[] - массив имен файлов
                // Недостаток - можно перетаскивать любые файлы...
                // string[] fileNames = e.Data.GetData(DataFormats.FileDrop) as string[];
                // Альтернатива оператору as -- это кошмарное приведение типа для 
                // доступа к элементу массива
                // string fileName = ((string[])(e.Data.GetData(DataFormats.FileDrop)))[0];
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in fileNames) {
                    TxtData.Text += "\r\n------------------------------------------------\r\n";
                    TxtData.Text += $"Файл: {file}\r\n";
                    TxtData.Text += "------------------------------------------------\r\n";
                    TxtData.Text += File.ReadAllText(file, Encoding.UTF8);
                    TxtData.Text += "\r\n------------------------------------------------\r\n";
                } // foreach
            } // if
        } // TxtData_DragDrop


        // Приемником перетаскивания делаем кнопку
        // кнопка принимает первые два слова из копируемого текста)
        private void BtnExit_DragDrop(object sender, DragEventArgs e) {
            string str = e.Data.GetData(DataFormats.StringFormat).ToString();

            // принимаем только первые два слова из перетаскиваемого текста
            string[] buf = str.Split(" .,!?:;\r\n\t<>()=0123456789\"".ToCharArray(), 
                StringSplitOptions.RemoveEmptyEntries);

            if (buf.Length >= 2)
                BtnExit.Text = buf[0] + ' ' + buf[1];
            else {
                BtnExit.Text = "Маловато будет";
            }
        } // BtnExit_DragDrop


        // Разрешение или запрет кнопке принимать перетаскиваемые данные
        // Если перетаскивание на кнопку запрещено, то восстановить надпись на кнопке
        private void chbEnable_CheckStateChanged(object sender, EventArgs e) {
            BtnExit.AllowDrop = ChbEnable.Checked;
            if (!BtnExit.AllowDrop) BtnExit.Text = "Выход";
        } // chbEnable_CheckStateChanged

        // выход из приложения
        private void Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void MniTabPages_Click(object sender, EventArgs e) {
            TabControlForm tabControlForm = new TabControlForm();
            tabControlForm.ShowDialog();
        } // MniTabPages_Click
    } // class MainForm
}
