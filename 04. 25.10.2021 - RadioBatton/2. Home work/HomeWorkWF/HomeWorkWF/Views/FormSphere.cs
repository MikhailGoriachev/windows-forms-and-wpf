using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWorkWF.Models;        // модели
using HomeWorkWF.Interface;     // интерфейсы

namespace HomeWorkWF
{
    public partial class FormSphere : Form
    {
        // сфера
        Sphere sphere = new Sphere();

        public FormSphere()
        {
            InitializeComponent();

            // установка по умолчанию значения материала
            RbtSteel.Checked = true;

            // установка начальных значений
            TxbInputRadius.Text = $"{10:n3}";
        }

        #region Вычисление

        // вычисление результата
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // установка значений по умолчанию в результате
            SetDefaultResult();

            // если все данные корректны и валидны
            if (CheckRadius())
            {
                // установка значений
                sphere.Radius = double.Parse(TxbInputRadius.Text);

                // вычисление и вывод результатов
                if (CbxArea.Checked) LblValueArea.Text = $"{sphere.Area():n3}";

                // вычисление и вывод результатов
                if (CbxVolume.Checked) LblValueVolume.Text = $"{sphere.Volume():n3}";

                // вычисление и вывод результатов
                if (CbxWeight.Checked) LblValueWeight.Text = $"{sphere.Weight():n3}";
            }
        }

        #endregion

        #region Проверка полей на валидность

        // установка значения верхнего радиуса с проверкой на валидность 
        private bool CheckRadius()
        {
            // считывание значения
            if (double.TryParse(TxbInputRadius.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrRadius.SetError(TxbInputRadius, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrRadius.SetError(TxbInputRadius, "");

                return true;
            }
            else { ErrRadius.SetError(TxbInputRadius, "Данные не являются числом"); return false; };
        }

        #endregion

        #region Изменение полей для ввода

        // изменение вводимого значения верхнего радиуса
        private void TxbInputRadius_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrRadius.SetError(TxbInputRadius, "");

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // установка значения по умолчанию для результирующих полей 
        void SetDefaultResult()
        {
            // установка значения результата
            LblValueArea.Text = "————";
            LblValueVolume.Text = "————";
            LblValueWeight.Text = "————";
        }

        #endregion

        // проверка всех объектов ErrorProvider
        private bool CheckAllErr() => ErrRadius.GetError(TxbInputRadius).Length == 0;

        // проверка на валидность верхнего радиуса
        private void TxbInputRadius_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckRadius() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // проверка на валидность плотности
        private void TxbInputDensity_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckAllErr()) BtnResult.Enabled = true;
        }

        // закрытие формы
        private void BtnClose_Click(object sender, EventArgs e) => Close();

        // выбор материала "сталь (нержавеющая)"
        private void RbtSteel_CheckedChanged(object sender, EventArgs e)
        {
            // плотность стали (нержавеющей) кг/м3 Источник: http://betall.ru/info/plotnost-nerzhaveyki
            const double density = 7700d;

            // установка значения
            sphere.Density = density;

            // вывод плотности
            LblValueDensity.Text = $"{density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = @"..\..\Images\Steel.jpg";
        }

        // выбор материала "медь"
        private void RbtCopper_CheckedChanged(object sender, EventArgs e)
        {
            // плотность меди (нержавеющей) кг/м3 Источник: http://thermalinfo.ru/svojstva-materialov/metally-i-splavy/svojstva-medi-plotnost-teploemkost-teploprovodnost
            const double density = 8933d;

            // установка значения
            sphere.Density = density;

            // вывод плотности
            LblValueDensity.Text = $"{density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = @"..\..\Images\Copper.jpg";
        }

        // выбор метериала "водяной лёд"
        private void RbtIce_CheckedChanged(object sender, EventArgs e)
        {
            // плотность водяного льда кг/м3 Источник: https://ru.wikipedia.org/wiki/%D0%9B%D1%91%D0%B4
            const double density = 916d;

            // установка значения
            sphere.Density = density;

            // вывод плотности
            LblValueDensity.Text = $"{density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = @"..\..\Images\Ice.jpg";
        }

        // выбор метериала "гранит"
        private void RbtGranite_CheckedChanged(object sender, EventArgs e)
        {
            // плотность водяного льда кг/м3 Источник: https://ru.wikipedia.org/wiki/%D0%93%D1%80%D0%B0%D0%BD%D0%B8%D1%82
            const double density = 2700d;

            // установка значения
            sphere.Density = density;

            // вывод плотности
            LblValueDensity.Text = $"{density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = @"..\..\Images\Granit.jpg";
        }
    }
}