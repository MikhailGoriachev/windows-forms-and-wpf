using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Models;      // модели

namespace HomeWork.Views
{
    // Форма вывода выборки
    public partial class SelectionByForm : Form
    {
        // состояния
        public enum States
        {
            // выборка с минимальной стоимостью
            MinPriceMode,
            // выборка по мастеру
            MasterMode,
            // выборка по диагонали
            DiagonalMode
        }

        // мастерская
        private RepairShop _repairShop;

        // коллекция выбранных данных
        private List<Television> _televisions;

        // текущее состояние 
        private States _state;

        // конструктор по умолчанию
        private SelectionByForm()
        {
            InitializeComponent();
        }

        // конструктор инициализирующий
        public SelectionByForm(RepairShop repairShop, States state) : this()
        {
            // установка значений
            _repairShop = repairShop;
            _state = state;

            // установка режима 
            SetMode();
        }

        // установка режима
        private void SetMode()
        {
            switch (_state)
            {
                // выборка с минимальной стоимостью
                case States.MinPriceMode:
                    TxbSelectionBy.Text = "Минимальной стоимости";
                    CbxParameter.Visible = false;
                    LblParameter.Visible = false;
                    break;
                // выборка по мастеру
                case States.MasterMode:
                    TxbSelectionBy.Text = "Мастеру";
                    LblParameter.Text = "Мастер";
                    CbxParameter.Items.AddRange(new[] { "Князев И. А.", "Соколова В. К.", "Минин П. К.", "Михайлов Д. Я" });
                    CbxParameter.SelectedIndex = 1;
                    break;
                // выборка по диагонали
                case States.DiagonalMode:
                    TxbSelectionBy.Text = "Диагонали";
                    LblParameter.Text = "Диагональ";
                    CbxParameter.Items.AddRange(new[] { "22", "26", "32", "37", "40", "42", "46", "50", "60", "65" });
                    CbxParameter.SelectedIndex = 2;
                    break;
            }

            // выборка
            Selection_Command();
        }

        // выборка 
        private void Selection_Command()
        {
            switch (_state)
            {
                // выборка с минимальной стоимостью
                case States.MinPriceMode:
                    _televisions = _repairShop.SelectByMinPrice();
                    break;
                // выборка по мастеру
                case States.MasterMode:
                    _televisions = _repairShop.SelectByMaster((string)CbxParameter.SelectedItem);
                    break;
                // выборка по диагонали
                case States.DiagonalMode:
                    _televisions = _repairShop.SelectByDiagonal(double.Parse((string)CbxParameter.SelectedItem));
                    break;
            }

            // установка связи
            UpdateCommunication();

            // вывод в статус количества отобранных элементов
            SlbInfoCountElement.Text = $"Количество выбранных элементов: {_televisions.Count()}";
        }

        // установка связи
        private void UpdateCommunication()
        {
            LbxTelevisions.DataSource = null;
            LbxTelevisions.DataSource = _televisions;
            LbxTelevisions.DisplayMember = "ShowElem";
        }

        // выбор параметра
        private void CbxParameter_SelectedIndexChanged(object sender, EventArgs e) =>
            Selection_Command();
    }
}