using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;              // для работы с потоками данных
using HomeWork.Utilities;     // утилиты
using HomeWork.Models;        // модели
using HomeWork.Interface;     // интерфейсы

namespace HomeWork.Views
{
    public partial class FormConoid : Form
    {
        // конус
        private Conoid conoid = new Conoid();

        public FormConoid()
        {
            InitializeComponent();

            // установка по умолчанию значения материала
            CbxMaterial.SelectedIndex = 0;

            // установка начальных значений
            NudHeight.Value = (decimal)Utils.GetRand(1d, 5d);
            NudTopRadius.Value = (decimal)Utils.GetRand(1d, 3d);
            NudDownRadius.Value = (decimal)Utils.GetRand(4d, 6d);

            // запись ссылки на соответствующий label результата в тег
            CbxArea.Tag = LblValueArea;
            CbxVolume.Tag = LblValueVolume;
            CbxWeight.Tag = LblValueWeight;
        }

        #region Установка значений

        // установка значения по умолчанию для результирующих полей 
        void SetDefaultResult()
        {
            // установка значения результата
            LblValueArea.Text = "————";
            LblValueVolume.Text = "————";
            LblValueWeight.Text = "————";
        }

        // изменение значения поля ввода
        private void NudHeight_ValueChanged(object sender, EventArgs e)
        {
            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // изменение значения поля ввода
        private void NudTopRadius_ValueChanged(object sender, EventArgs e)
        {
            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();

            // установка минимального значения для нижнего радиуса
            NudDownRadius.Minimum = ((NumericUpDown)sender).Value + (decimal)1e-10;
        }

        // изменение значения поля ввода
        private void NudDownRadius_ValueChanged(object sender, EventArgs e)
        {
            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();

            // установка минимального значения для нижнего радиуса
            NudTopRadius.Maximum = ((NumericUpDown)sender).Value - (decimal)1e-10;
        }

        // нажатие на цифры при вводе данных
        private void NudValue_KeyDown(object sender, KeyEventArgs e)
        {
            // нажатая клавиша
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                // установка значения по умолчанию для результирующих полей 
                SetDefaultResult();
        }

        // выбор материала 
        private void RbtMaterials_CheckedChanged(object sender, EventArgs e)
        {
            // плотность и путь к файлу картинки
            (double density, string imageFile) figure = (ValueTuple<double, string>)(sender as RadioButton)?.Tag;

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();

            // установка значения
            conoid.Density = figure.density;

            // вывод плотности
            LblValueDensity.Text = $"{conoid.Density:n3}";

            // установка картирнки
            IbxMaterialView.Image = Image.FromFile(figure.imageFile);
        }

        // изменение параментров вычисления
        private void CbxParams_CheckStateChanged(object sender, EventArgs e)
        {
            // приведение к CheckBox
            CheckBox cbx = (CheckBox)sender;

            // если checkBox включен
            if (cbx.Checked)
                SetDefaultResult();
            else
                // установка значения по умолчанию для результирующих полей 
                ((Label)cbx.Tag).Text = "————";
        }

        // выбор материала 
        private void CbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // unboxing 
            ComboBox cbx = (ComboBox)sender;

            // плотность и путь к файлу картинки
            (double density, string imageFile) figure = (0d, "");

            switch (cbx.SelectedIndex)
            {
                // Сталь(нержавеющая)
                case 0:
                    figure = (density: 7700d, imageFile: @"..\..\Images\Steel.jpg");
                    break;

                // Медь
                case 1:
                    figure = (density: 8933d, imageFile: @"..\..\Images\Copper.jpg");
                    break;

                // Водяной лед
                case 2:
                    figure = (density: 916d, imageFile: @"..\..\Images\Ice.jpg");
                    break;

                // Гранит
                case 3:
                    figure = (density: 2700d, imageFile: @"..\..\Images\Granit.jpg");
                    break;

                default:
                    break;
            }

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();

            // установка значения
            conoid.Density = figure.density;

            // вывод плотности
            LblValueDensity.Text = $"{conoid.Density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = figure.imageFile;
        }

        #endregion

        #region Вычисление

        // вычисление результата
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // установка значений по умолчанию в результате
            SetDefaultResult();

            // установка введенных значений
            conoid.Height = (double)NudHeight.Value;
            conoid.Radius = ((double)NudHeight.Value, (double)NudHeight.Value);

            // вычисление и вывод результатов
            if (CbxArea.Checked) LblValueArea.Text = $"{conoid.Area():n3}";

            // вычисление и вывод результатов
            if (CbxVolume.Checked) LblValueVolume.Text = $"{conoid.Volume():n3}";

            // вычисление и вывод результатов
            if (CbxWeight.Checked) LblValueWeight.Text = $"{conoid.Weight():n3}";

            // строка для записи в файл результата
            StringBuilder sb = new StringBuilder();

            // вычисление и вывод результатов
            sb.Append($"S: {(CbxArea.Checked ? (LblValueArea.Text = $"{conoid.Area():n3}") : "─────"),-7:n3}");

            // вычисление и вывод результатов
            sb.Append($" V: {(CbxVolume.Checked ? (LblValueVolume.Text = $"{conoid.Volume():n3}") : "─────"),-7:n3}");

            // вычисление и вывод результатов
            sb.Append($" m: {(CbxWeight.Checked ? (LblValueWeight.Text = $"{conoid.Weight():n3}") : "─────"),-7:n3}");

            // запись данных в файл
            WriteToFile(DateTime.Now, sb.ToString());
        }

        // запись данных в файл
        void WriteToFile(DateTime time, string result)
        {
            // запись в файл
            File.WriteAllText(MainForm.saveFileName,
                $"{time:G};  {$"{"Усеченный конус",-15}: {$"H({conoid.Height:n3}), R1({conoid.Radius.top:n3}), R2({conoid.Radius.down:n3}), ρ({conoid.Density:n3})",-52} {(string)CbxMaterial.SelectedItem};",-85}  {result}\r\n"
                + File.ReadAllText(MainForm.saveFileName, Encoding.UTF8));
        }
        #endregion


        // закрытие формы
        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}
