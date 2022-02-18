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
        }

        #region Вычисление

        // вычисление результата
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // установка значений по умолчанию в результате
            SetDefaultResult();

            // если все данные корректны и валидны
            if (CheckRadius() && CheckDensity())
            {
                // установка значений
                sphere.Radius = double.Parse(TxbInputRadius.Text);

                // считывание значения плотности
                sphere.Density = double.Parse(TxbInputDensity.Text);

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

        // установка значения плотности с проверкой на валидность 
        private bool CheckDensity()
        {
            // считывание значения
            if (double.TryParse(TxbInputDensity.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrDensity.SetError(TxbInputDensity, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrDensity.SetError(TxbInputDensity, "");

                return true;
            }
            else { ErrDensity.SetError(TxbInputDensity, "Данные не являются числом"); return false; };
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

        // изменение вводимого значения плотности
        private void TxbInputDensity_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrDensity.SetError(TxbInputDensity, "");

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
        private bool CheckAllErr()
        {
            return ErrDensity.GetError(TxbInputDensity).Length == 0
                && ErrRadius.GetError(TxbInputRadius).Length == 0;
        }

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
            if (CheckDensity() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // закрытие формы
        private void BtnClose_Click(object sender, EventArgs e) => Close();
    }
}