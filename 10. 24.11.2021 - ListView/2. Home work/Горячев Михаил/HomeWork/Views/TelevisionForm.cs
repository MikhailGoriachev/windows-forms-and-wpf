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
    // форма создания/редактирования телевизора
    public partial class TelevisionForm : Form
    {
        // телевизор 
        public Television television;

        // конструктор для запуска формы в режиме создания
        public TelevisionForm()
        {
            InitializeComponent();

            // иницилизация полей
            television = RepairShop.FactoryMethod();

            // заполнение полей
            CbxMaster.SelectedIndex = CbxMaster.Items.IndexOf(television.Master);
            CbxDiagonal.SelectedIndex = CbxDiagonal.Items.IndexOf(television.Diagonal.ToString());
            CbxDefect.SelectedIndex = CbxDefect.Items.IndexOf(television.Defect);
            TxbModel.Text = television.Model;
            TxbOwner.Text = television.Owner;
            NudPrice.Value = (decimal)television.Price;
        }

        // констурктор для запуска формы в режиме редактирования
        public TelevisionForm(Television televisionSelect)
        {
            InitializeComponent();

            television = televisionSelect;

            // установка значений
            BtnCreate.Text = "Сохранить";
            this.Text = "Редактирование записи";

            // заполнение полей
            CbxMaster.SelectedIndex = CbxMaster.Items.IndexOf(television.Master);
            CbxDiagonal.SelectedIndex = CbxDiagonal.Items.IndexOf(television.Diagonal.ToString());
            CbxDefect.SelectedIndex = CbxDefect.Items.IndexOf(television.Defect);
            TxbModel.Text = television.Model;
            TxbOwner.Text = television.Owner;
            NudPrice.Value = (decimal)television.Price;
        }

        // проверка на корректность ввода в полях
        private void CheckFields_Command(object sender, EventArgs e) =>
            BtnCreate.Enabled = !(String.IsNullOrWhiteSpace(TxbModel.Text) ||
                                  String.IsNullOrWhiteSpace(TxbOwner.Text));

        // обработка введённых данных
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            // установка значений
            television.Master = (string)CbxMaster.SelectedItem;
            television.Diagonal = int.Parse((string)CbxDiagonal.SelectedItem);
            television.Defect = (string)CbxDefect.SelectedItem;            
            television.Model = TxbModel.Text;
            television.Owner = TxbOwner.Text;
            television.Price = (int)NudPrice.Value;
        }

        // фильтрация клавиш при вводе цены
        private void NudPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.OemMinus || e.KeyData == Keys.Subtract)
                SendKeys.Flush();
        }
    }
}
