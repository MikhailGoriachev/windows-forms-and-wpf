using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Models;          // модели
using HomeWork.Controllers;     // контроллеры

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
            // выборка по владельцу
            OwnerMode,
            // выборка по диагонали
            DiagonalMode
        }

        // констроллер ремонтной мастерской
        private RepairShopController _controller;

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
        public SelectionByForm(RepairShopController controller, States state) : this()
        {
            // установка значений
            _controller = controller;
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
                    CbxParameter.Items.AddRange(_controller.Repair.Masters);
                    CbxParameter.SelectedIndex = 1;
                    break;
                // выборка по владельцу
                case States.OwnerMode:
                    TxbSelectionBy.Text = "Владельцу";
                    LblParameter.Text = "Владелец";
                    CbxParameter.Items.AddRange(_controller.Repair.Owners);
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
                    _televisions = _controller.SelectByMinPrice();
                    break;
                // выборка по мастеру
                case States.MasterMode:
                    _televisions = _controller.SelectByMaster((string)CbxParameter.SelectedItem);
                    break;
                // выборка по владельцу
                case States.OwnerMode:
                    _televisions = _controller.SelectByOwner((string)CbxParameter.SelectedItem);
                    break;
                // выборка по диагонали
                case States.DiagonalMode:
                    _televisions = _controller.SelectByDiagonal(double.Parse((string)CbxParameter.SelectedItem));
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