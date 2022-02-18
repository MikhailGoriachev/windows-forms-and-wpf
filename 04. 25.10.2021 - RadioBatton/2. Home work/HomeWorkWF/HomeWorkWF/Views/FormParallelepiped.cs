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
    public partial class FormParallelepiped : Form
    {
        // параллелепипед
        RectangularParallelepiped paral = new RectangularParallelepiped();

        public FormParallelepiped()
        {
            InitializeComponent();

            // установка по умолчанию значения материала
            RbtSteel.Checked = true;

            // установка начальных значений
            TxbInputSideA.Text = $"{10:n3}";
            TxbInputSideB.Text = $"{10:n3}";
            TxbInputSideC.Text = $"{10:n3}";
        }

        #region Вычисление

        // вычисление результата
        private void BtnResult_Click(object sender, EventArgs e)
        {
            // установка значений по умолчанию в результате
            SetDefaultResult();

            // если все данные корректны и валидны
            if (CheckSideA() && CheckSideB() && CheckSideC())
            {
                // считывание значения высоты
                paral.A = double.Parse(TxbInputSideA.Text);

                // установка значений
                paral.B = double.Parse(TxbInputSideB.Text);

                // считывание значения плотности
                paral.C = double.Parse(TxbInputSideC.Text);

                // вычисление и вывод результатов
                if (CbxArea.Checked) LblValueArea.Text = $"{paral.Area():n3}";

                // вычисление и вывод результатов
                if (CbxVolume.Checked) LblValueVolume.Text = $"{paral.Volume():n3}";

                // вычисление и вывод результатов
                if (CbxWeight.Checked) LblValueWeight.Text = $"{paral.Weight():n3}";
            }
        }

        #endregion

        #region Проверка полей на валидность

        // проверка стороны A на валидность
        private bool CheckSideA()
        {
            // считывание значения
            if (double.TryParse(TxbInputSideA.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrSideA.SetError(TxbInputSideA, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrSideA.SetError(TxbInputSideA, "");

                return true;
            }
            else { ErrSideA.SetError(TxbInputSideA, "Данные не являются числом"); return false; };
        }

        // проверка стороны B на валидность 
        private bool CheckSideB()
        {
            // считывание значения
            if (double.TryParse(TxbInputSideB.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrSideB.SetError(TxbInputSideB, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrSideB.SetError(TxbInputSideB, "");

                return true;
            }
            else { ErrSideB.SetError(TxbInputSideB, "Данные не являются числом"); return false; };
        }

        // проверка стороны C на валидность 
        private bool CheckSideC()
        {
            // считывание значения
            if (double.TryParse(TxbInputSideC.Text, out double value))
            {
                // если значение некорректно
                if (value <= 0)
                {
                    // вывод индикатора ошибки
                    ErrSideC.SetError(TxbInputSideC, "Значение должно быть больше 0!");

                    // выключение кнопки результата
                    BtnResult.Enabled = false;

                    return false;
                }

                // удаление индикатора ошибки
                ErrSideC.SetError(TxbInputSideC, "");

                return true;
            }
            else { ErrSideC.SetError(TxbInputSideC, "Данные не являются числом"); return false; };
        }

        #endregion

        #region Изменение полей для ввода

        // изменение вводимого значения высоты
        private void TxbInputHeight_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrSideC.SetError(TxbInputSideA, "");

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // изменение вводимого значения верхнего радиуса
        private void TxbInputSideA_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrSideA.SetError(TxbInputSideA, "");

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // изменение вводимого значения плотности
        private void TxbInputSideB_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrSideB.SetError(TxbInputSideB, "");

            // установка значения по умолчанию для результирующих полей 
            SetDefaultResult();
        }

        // изменение вводимого значения плотности
        private void TxbInputSideC_TextChanged(object sender, EventArgs e)
        {
            // снятие индикатора ошибки
            ErrSideC.SetError(TxbInputSideC, "");

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
            return ErrSideA.GetError(TxbInputSideA).Length == 0
                && ErrSideB.GetError(TxbInputSideB).Length == 0
                && ErrSideC.GetError(TxbInputSideC).Length == 0;
        }

        // проверка на валидность высоты
        private void TxbInputSideA_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckSideA() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // проверка на валидность верхнего радиуса
        private void TxbInputSideB_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckSideB() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // проверка на валидность плотности
        private void TxbInputSideC_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckSideC() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // проверка на валидность плотности
        private void TxbInputDensity_Validating(object sender, CancelEventArgs e)
        {
            // проверка поля на валидность и проверка на отсутсвие ошибок 
            if (CheckSideC() && CheckAllErr()) BtnResult.Enabled = true;
        }

        // закрытие формы
        private void BtnClose_Click(object sender, EventArgs e) => Close();

        // выбор материала "сталь (нержавеющая)"
        private void RbtSteel_CheckedChanged(object sender, EventArgs e)
        {
            // плотность стали (нержавеющей) кг/м3 Источник: http://betall.ru/info/plotnost-nerzhaveyki
            const double density = 7700d;

            // установка значения
            paral.Density = density;

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
            paral.Density = density;

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
            paral.Density = density;

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
            paral.Density = density;

            // вывод плотности
            LblValueDensity.Text = $"{density:n3}";

            // установка картирнки
            IbxMaterialView.ImageLocation = @"..\..\Images\Granit.jpg";
        }
    }
}
