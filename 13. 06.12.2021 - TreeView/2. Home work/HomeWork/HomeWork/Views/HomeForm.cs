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
    public partial class HomeForm : Form
    {
        // дом
        public HomeAppliances Home { get; private set; }

        // запуск формы в режиме создания
        public HomeForm()
        {
            InitializeComponent();

            // создание и заполнение дома коллекцией приборов
            Home = new HomeAppliances { Address = Utils.Addresses[Utils.GetRand(0, Utils.Addresses.Length)],
                                        Title = Utils.TitlesHome[Utils.GetRand(0, Utils.TitlesHome.Length)],
                                        Appliances = HomeAppliancesController.GenerateAppliancesCollection() };

            // вывод данных 
            TbxTitle.Text   = Home.Title;
            TbxAddress.Text = Home.Address;
            
            // выключение отображение элементов для редактирования
            LblCurrentAddress.Visible = TbxCurrentAddress.Visible =
                LblCurrentTitle.Visible = TbxCurrentTitle.Visible = false;

            // уменьшение размера формы 
            this.Height = 310;

            // изменение заголовка формы
            this.Text = "Создание дома";

            // изменение текста кнопки "Изменить"
            BtnOk.Text = "Создать";
        }

        // запуск формы в режиме редактирования
        public HomeForm(HomeAppliances homeAppliances)
        {
            InitializeComponent();

            // установка ссылки на дом
            Home = homeAppliances;

            // вывод данных 
            TbxCurrentTitle.Text    = Home.Title;
            TbxCurrentAddress.Text  = Home.Address;
            TbxTitle.Text   = Utils.TitlesHome[Utils.GetRand(0, Utils.TitlesHome.Length)];
            TbxAddress.Text = Utils.Addresses[Utils.GetRand(0, Utils.Addresses.Length)];

            // изменение надписи на кнопки сохранения результата "Добавить"
            BtnOk.Text = "Сохранить";
        }

        // сохранение результата - нажатие на кнопку "Добавить"/"Сохранить"
        private void BtnOk_Click(object sender, EventArgs e)
        {
            // установка адреса в объект дома
            Home.Address = TbxAddress.Text;
            Home.Title   = TbxTitle.Text;
        }

        // валидация строки ввода адреса
        private void TextBoxChange_Command(object sender, EventArgs e)
        {
            BtnOk.Enabled = !(String.IsNullOrWhiteSpace(TbxAddress.Text) || String.IsNullOrWhiteSpace(TbxTitle.Text));
        }
    }
}
