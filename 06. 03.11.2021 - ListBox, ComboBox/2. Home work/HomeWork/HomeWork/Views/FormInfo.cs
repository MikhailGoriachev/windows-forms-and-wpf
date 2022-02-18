﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork.Views
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        // установка таймера на 10 секунд для закрытия формы после загрузки
        private void FormInfo_Load(object sender, EventArgs e)
        {
            // загрузка текста о программе из файла
            TbxInfoProgram.Text = Properties.Resources.InfoProgram;

            // включение таймера
            TmrLoadFormInfo.Enabled = true;
        }

        // закрытие формы по истечению 10 секунд
        private void TmrLoadFormInfo_Tick(object sender, EventArgs e) => Close();

        // закрытие формы
        private void BtnExit_Click(object sender, EventArgs e) { TmrLoadFormInfo.Enabled = false; Close(); }
    }
}