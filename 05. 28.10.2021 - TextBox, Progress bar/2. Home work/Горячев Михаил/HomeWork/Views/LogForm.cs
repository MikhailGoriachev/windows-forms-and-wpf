using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                // для работы с потоками данных

namespace HomeWork.Views
{
    // Форма Вывод журнала
    public partial class LogForm : Form
    {
        // название файла для сохранения результата
        public string NameFile { get; set; } = "log.txt";

        public LogForm()
        {
            InitializeComponent();

            // создание файла если его не существует
            using (File.OpenWrite(NameFile));
        }

        // открытие файла сохранения
        private void LilInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start(NameFile);

        // очистка журнала
        private void BtnClearFile_Click(object sender, EventArgs e) 
        {
            // очистка файла
            using (File.Create(NameFile));

            // вывод содержимого файла журнала в TbxLog
            TbxLog.Text = File.ReadAllText(NameFile);
        }

        // загрузка формы
        private void LogForm_Load(object sender, EventArgs e) =>
            // вывод содержимого файла журнала в TbxLog
            TbxLog.Text = File.ReadAllText(NameFile);
    }
}
