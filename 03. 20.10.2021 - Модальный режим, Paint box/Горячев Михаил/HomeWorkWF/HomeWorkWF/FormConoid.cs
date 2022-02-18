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
    public partial class FormConoid : Form
    {
        // конус
        Conoid conoid = new Conoid();

        public FormConoid()
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
            if (CheckHeight() && CheckRadiusTop() && CheckRadiusDown() && CheckDensity())
            {
                // считывание значения высоты
                conoid.Height = double.Parse(TxbInputHeight.Text);

                // считывание значения плотности
                conoid.Density = double.Parse(TxbInputDensity.Text);

                // считывание значения верхнего и нижнего радиуса
                double top = double.Parse(TxbInputRadiusTop.Text);
                double down = double.Parse(TxbInputRadiusDown.Text);

                // если значение верхнего радиуса больше значения нижнего радиуса
                if (top > down)
                {
                    // вывод ошибки
                    ErrRadiusTop.SetError(TxbInputRadiusTop, "Значение должно быть меньше нижнего радиуса!");
                    ErrRadiusDown.SetError(TxbInputRadiusDown, "Значение должно быть больше верхнего радиуса!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return;
                }

                // установка значений
                conoid.Radius = (top, down);

                // вычисление и вывод результатов
                if (CbxArea.Checked) LblValueArea.Text = $"{conoid.Area():n3}";

                // вычисление и вывод результатов
                if (CbxVolume.Checked) LblValueVolume.Text = $"{conoid.Volume():n3}";

                // вычисление и вывод результатов
                if (CbxWeight.Checked) LblValueWeight.Text = $"{conoid.Weight():n3}";
            }
        }

        #endregion

        #region Проверка полей на валидность

        // считывание и установка значения высоты с проверкой на валидность
        private bool CheckHeight()
        {
            // считывание значения
            if (double.TryParse(TxbInputHeight.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrHeight.SetError(TxbInputHeight, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrHeight.SetError(TxbInputHeight, "");

                return true;
            }
            else { ErrHeight.SetError(TxbInputHeight, "Данные не являются числом"); return false; };
        }

        // установка значения верхнего радиуса с проверкой на валидность 
        private bool CheckRadiusTop()
        {
            // считывание значения
            if (double.TryParse(TxbInputRadiusTop.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrRadiusTop.SetError(TxbInputRadiusTop, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrRadiusTop.SetError(TxbInputRadiusTop, "");

                return true;
            }
            else { ErrRadiusTop.SetError(TxbInputRadiusTop, "Данные не являются числом"); return false; };
        }

        // установка значения нижнего радиуса с проверкой на валидность 
        private bool CheckRadiusDown()
        {
            // считывание значения
            if (double.TryParse(TxbInputRadiusDown.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrRadiusDown.SetError(TxbInputRadiusDown, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrRadiusDown.SetError(TxbInputRadiusDown, "");

                return true;
            }
            else { ErrRadiusDown.SetError(TxbInputRadiusDown, "Данные не являются числом"); return false; };
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

        // изменение вводимого значения высоты
        private void TxbInputHeight_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrHeight.SetError(TxbInputHeight, "");

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // изменение вводимого значения верхнего радиуса
        private void TxbInputRadiusTop_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrRadiusTop.SetError(TxbInputRadiusTop, "");

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // изменение вводимого значения нижнего радиуса
        private void TxbInputRadiusDown_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrRadiusDown.SetError(TxbInputRadiusDown, "");

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
                && ErrHeight.GetError(TxbInputHeight).Length == 0
                && ErrRadiusDown.GetError(TxbInputRadiusDown).Length == 0
                && ErrRadiusTop.GetError(TxbInputRadiusTop).Length == 0;
        }

        // проверка на валидность высоты
        private void TxbInputHeight_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckHeight() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // проверка на валидность верхнего радиуса
        private void TxbInputRadiusTop_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckRadiusTop() && CheckRadiusDown() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // проверка на валидность нижнего радиуса
        private void TxbInputRadiusDown_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckRadiusTop() && CheckRadiusDown() && CheckAllErr()) BtnResult.Enabled = true;
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
