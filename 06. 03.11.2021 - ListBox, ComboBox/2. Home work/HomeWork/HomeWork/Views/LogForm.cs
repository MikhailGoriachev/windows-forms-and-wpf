using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;        // для работы с потоками данных

namespace HomeWork.Views
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        // загрузка формы
        private void LogForm_Load(object sender, EventArgs e) => LoadLog();

        // считывание файла журнала
        private void LoadLog()
        {
            // создание или открытие файла для сохранения истории операций
            using (File.OpenWrite(MainForm.saveFileName)) { }

            // чтение файла и вывод в журнал
            TbxHistory.Text = File.ReadAllText(MainForm.saveFileName, Encoding.UTF8);
        }

        // очистка журнала
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // очистка журнала
            File.WriteAllText(MainForm.saveFileName, "");

            // считывание файла журнала
            LoadLog();
        }

        // открытие файла журнала
        private void BtnLoadFile_Click(object sender, EventArgs e) => System.Diagnostics.Process.Start(MainForm.saveFileName);
    }
}
