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
    public partial class FormCylinder : Form
    {
        // цилиндр
        private Cylinder cylinder = new Cylinder();

        public FormCylinder()
        {
            InitializeComponent();

            // установка по умолчанию значения материала
            CbxMaterial.SelectedIndex = 0;

            // установка начальных значений
            NudHeight.Value = (decimal)Utils.GetRand(1d, 5d);
            NudRadius.Value = (decimal)Utils.GetRand(1d, 5d);

            // запись ссылки на соответствующий label результата в тег
            CbxArea.Tag = LblValueArea;
            CbxVolume.Tag = LblValueVolume;
            CbxWeight.Tag = LblValueWeight;
        }

        #region Изменение полей для ввода

        // установка значения по умолчанию для результирующих полей 
        void SetDefaultResult()
        {
            // установка значения результата
            LblValueArea.Text = "————";
            LblValueVolume.Text = "————";
            LblValueWeight.Text = "————";
        }

        // выбор материала 
        private void RbtMaterials_CheckedChanged(object sender, EventArgs e)
        {
            // плотность и путь к файлу картинки
            (double density, string imageFile) figure = (ValueTuple<double, string>)(sender as RadioButton)?.Tag;

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();

            // установка значения
            cylinder.Density = figure.density;

            // вывод плотности
            LblValueDensity.Text = $"{cylinder.Density:n3}";

            // установка картирнки
            IbxMaterialView.Image = Image.FromFile(figure.imageFile);
        }

        // нажатие на цифры при вводе данных
        private void NudValue_KeyDown(object sender, KeyEventArgs e)
        {
            // нажатая клавиша
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                // установка значения по умолчанию для результирующих полей 
                SetDefaultResult();
        }

        // изменение значения поля ввода
        private void NudValue_ValueChanged(object sender, EventArgs e)
        {
            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
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

        #endregion

        #region Вычисление

        // вычисление результата
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // установка значений по умолчанию в результате
            SetDefaultResult();

            // установка введенных значений
            cylinder.Height = (double)NudHeight.Value;
            cylinder.Radius = (double)NudRadius.Value;

            // вычисление и вывод результатов
            if (CbxArea.Checked) LblValueArea.Text = $"{cylinder.Area():n3}";

            // вычисление и вывод результатов
            if (CbxVolume.Checked) LblValueVolume.Text = $"{cylinder.Volume():n3}";

            // вычисление и вывод результатов
            if (CbxWeight.Checked) LblValueWeight.Text = $"{cylinder.Weight():n3}";

            // строка для записи в файл результата
            StringBuilder sb = new StringBuilder();

            // вычисление и вывод результатов
            sb.Append($"S: {(CbxArea.Checked ? (LblValueArea.Text = $"{cylinder.Area():n3}") : "─────"),-7:n3}");

            // вычисление и вывод результатов
            sb.Append($" V: {(CbxVolume.Checked ? (LblValueVolume.Text = $"{cylinder.Volume():n3}") : "─────"),-7:n3}");

            // вычисление и вывод результатов
            sb.Append($" m: {(CbxWeight.Checked ? (LblValueWeight.Text = $"{cylinder.Weight():n3}") : "─────"),-7:n3}");

            // запись данных в файл
            WriteToFile(DateTime.Now, sb.ToString());
        }

        // запись данных в файл
        void WriteToFile(DateTime time, string result) =>
            // запись в файл
            File.WriteAllText(MainForm.saveFileName,
                $"{time:G};  {$"{"Цилиндр",-15}: {$"H({cylinder.Height:n3}), R({cylinder.Radius:n3}), ρ({cylinder.Density:n3}),",-52} {(string)CbxMaterial.SelectedItem};",-85}  {result}\r\n"
                + File.ReadAllText(MainForm.saveFileName, Encoding.UTF8));

        #endregion

        // закрытие формы
        private void BtnClose_Click(object sender, EventArgs e) => Close();

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
            cylinder.Density = figure.density;

            // вывод плотности
            LblValueDensity.Text = $"{cylinder.Density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = figure.imageFile;
        }
    }
}
