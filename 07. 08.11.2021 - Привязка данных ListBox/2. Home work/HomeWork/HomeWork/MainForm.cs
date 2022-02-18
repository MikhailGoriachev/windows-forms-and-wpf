using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Controllers;     // контроллеры
using HomeWork.Models;          // моделей
using HomeWork.Views;           // формы

namespace HomeWork
{
    public partial class MainForm : Form
    {
        // контроллер 
        private Controller _controller;

        // электроприборы
        private List<ElectricalAppliance> _appliances;

        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();

            // создание списка элемектроприборов
            _appliances = new List<ElectricalAppliance>();

            // инициализация контроллера 
            _controller = new Controller(_appliances);

            // установка связи
            AppliancesBind();

            // установка значений по умолчанию
            CbxState.SelectedIndex = 1;
            TxbName.Text = "Чайник";
            NudPower.Value = 1600;
            NudPrice.Value = 2300;
        }

        // установка связи
        private void AppliancesBind()
        {
            LbxAppliances.DataSource = null;
            LbxAppliances.DataSource = _appliances;
            LbxAppliances.DisplayMember = "ShowElem";
            LbxAppliances.ValueMember = "id";
        }

        // информация о проаграмме
        private void InfoProgram_Command(object sender, EventArgs e) => new FormInfo().ShowDialog();

        // выход из программы
        private void Exit_Command(object sender, EventArgs e) => Application.Exit();

        // включение выбранного прибора
        private void PowerOnSelect_Command(object sender, EventArgs e)
        {
            // если элемент не выбран
            if (LbxAppliances.SelectedIndex == -1)
                return;

            // включение выбранного прибора
            _appliances[LbxAppliances.SelectedIndex].TurnPower(true);

            // установка связи
            AppliancesBind();
        }

        // выключение выбранного прибора
        private void PowerOffSelect_Command(object sender, EventArgs e)
        {
            // если элемент не выбран
            if (LbxAppliances.SelectedIndex == -1)
                return;

            // выключение выбранного прибора
            _appliances[LbxAppliances.SelectedIndex].TurnPower(false);

            // установка связи
            AppliancesBind();
        }

        // включение всех приборов
        private void PowerOnAll_Command(object sender, EventArgs e)
        {
            _appliances.ForEach((item) => item.TurnPower(true));

            // установка связи
            AppliancesBind();
        }

        // выключение всех приборов
        private void PowerOffAll_Command(object sender, EventArgs e)
        {
            _appliances.ForEach((item) => item.TurnPower(false));

            // установка связи
            AppliancesBind();
        }

        // формирование новой коллекции
        private void InitializationCollection_Command(object sender, EventArgs e)
        {
            // очистка коллекции
            _appliances.Clear();

            // формирование коллекции
            _controller.Initialization();

            // установка связи
            AppliancesBind();
        }

        // добавить элементы в текущую коллекцию
        private void AddRange_Command(object sender, EventArgs e)
        {
            // формирование коллекции
            _controller.Initialization();

            // установка связи
            AppliancesBind();
        }
        
        // перемешивание приборов
        private void Shuffle_Command(object sender, EventArgs e)
        {
            // перемешивание коллекции
            _controller.Shuffle();

            // установка связи
            AppliancesBind();
        }

        // удаление всех приборов
        private void RemoveAll_Command(object sender, EventArgs e)
        {
            // удаление 
            _appliances.Clear();

            // установка связи
            AppliancesBind();
        }

        // сортировка по названию
        private void SortByName_Command(object sender, EventArgs e)
        {
            // сортировка
            _controller.OrderByName();

            // установка связи
            AppliancesBind();
        }

        // сортировка по мощности
        private void SortByCapacity_Command(object sender, EventArgs e)
        {
            // сортировка
            _controller.OrderByPower();

            // установка связи
            AppliancesBind();
        }

        // удалить выбранный прибор
        private void RemoveSelect_Command(object sender, EventArgs e)
        {
            // если элемент не выбран
            if (LbxAppliances.SelectedIndex == -1)
                return;

            // удаление выбранного прибора
            _appliances.RemoveAt(LbxAppliances.SelectedIndex);

            // установка связи
            AppliancesBind();
        }

        // добавление в коллекцию
        private void AddAppliance_Command(object sender, EventArgs e)
        {
            // заполнение полей
            var appl =  new ElectricalAppliance
            {
                Name = TxbName.Text,
                Power = (int)NudPower.Value,
                Price = (int)NudPrice.Value,
            };

            // установка состояния
            appl.TurnPower(CbxState.SelectedIndex == 0);

            // добавление в коллекцию
            _appliances.Add(appl);

            // установка связи
            AppliancesBind();
        }

        // ввод названия
        private void TxbName_Validating(object sender, CancelEventArgs e)
        {
            BtnAdd.Enabled = !String.IsNullOrWhiteSpace(TxbName.Text);
        }
    }
}
