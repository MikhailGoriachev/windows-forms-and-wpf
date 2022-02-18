using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appliances.Controllers;     // контроллеры
using Appliances.Models;          // модели
using Appliances.Utilities;       // утилиты

namespace Appliances.Views
{
    public partial class ApplianceForm : Form
    {
        // прибор
        public ElectricalAppliance Appliance { get; private set; }

        // создание формы в режиме создания
        public ApplianceForm()
        {
            InitializeComponent();

            // создание прибора 
            Appliance = HomeAppliancesController.FactoryMethod(Utils.GetRand(0, 4));

            // вывод данных 
            CbxState.SelectedIndex = Appliance.StateActive ? 0 : 1;
            NudPower.Value = Appliance.Power;
            NudPrice.Value = Appliance.Price;
            TbxTitle.Text = Appliance.Name;
            TbxRoom.Text = Appliance.Room;

            // выключние ненужных полей
            TbxCurrentPower.Visible = TbxCurrentPrice.Visible = TbxCurrentState.Visible
                = TbxCurrentTitle.Visible = LblCurrentPower.Visible = LblCurrentPrice.Visible
                = LblCurrentState.Visible = LblCurrentTitle.Visible = false;

            // установка значений на кнопки
            BtnOk.Text = "Добавить";

            // изменение заголовка
            this.Text = "Добавить прибор";

            // уменьшение формы
            this.Height = 320;
        }

        // создание формы в режиме редактирования
        public ApplianceForm(ElectricalAppliance appliance)
        {
            InitializeComponent();

            // установка прибора 
            Appliance = appliance;

            // вывод данных 
            TbxCurrentState.Text = appliance.StateActive ? "Включен" : "Выключен";
            TbxCurrentPower.Text = appliance.Power.ToString();
            TbxCurrentPrice.Text = appliance.Price.ToString();
            TbxCurrentTitle.Text = appliance.Name;
            CbxState.SelectedIndex = Appliance.StateActive ? 0 : 1;
            NudPower.Value = Appliance.Power;
            NudPrice.Value = Appliance.Price;
            TbxTitle.Text = Appliance.Name;
            TbxRoom.Text  = Appliance.Room;
        }

        // выбор кнопки "Сохранить"
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Appliance.Name = TbxTitle.Text;
            Appliance.Power = (int)NudPower.Value;
            Appliance.Price = (int)NudPrice.Value;
            Appliance.TurnPower(CbxState.SelectedItem == "Включен");
            Appliance.Room = TbxRoom.Text;
        }

        // изменение текста в текстбоксах
        private void TextBoxChange_Command(object sender, EventArgs e)
        {
            BtnOk.Enabled = !String.IsNullOrWhiteSpace(TbxTitle.Text) && !String.IsNullOrWhiteSpace(TbxRoom.Text);
        }
    }
}
