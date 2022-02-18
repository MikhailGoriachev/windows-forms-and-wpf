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
    // Форма редактирования данных о мастерской
    public partial class RepairShopForm : Form
    {
        // мастерская
        RepairShop repair;

        // конструктор по умолчанию
        private RepairShopForm()
        {
            InitializeComponent();
        }

        // конструктор инициализирующий
        public RepairShopForm(RepairShop repairShop) : this()
        {
            // установка значений
            repair = repairShop;
        }

        // загрузка формы
        private void RepairShopForm_Load(object sender, EventArgs e)
        {
            // заполнение полей
            TxbCurrentName.Text = repair.Name;
            TxbCurrentAddress.Text = repair.Address;
        }

        // проверка на корректность ввода в полях
        private void CheckFields_Command(object sender, EventArgs e) =>
            BtnEdit.Enabled = !(String.IsNullOrWhiteSpace(TxbName.Text) ||
                                String.IsNullOrWhiteSpace(TxbAddress.Text));

        // применение изменений
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            repair.Name = TxbName.Text;
            repair.Address = TxbAddress.Text;
        }
    }
}
