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
using HomeWork.Utilities;       // утилиты

namespace HomeWork.Views
{
    // Форма редактирования данных о мастерской
    public partial class RepairShopForm : Form
    {
        // мастерская
        private RepairShop _repair;

        // доступ к полю _repair
        public RepairShop Repair => _repair;

        // файл для сохранения
        private string _saveFile;

        // доступ к полю _saveFile
        public string SaveFile
        {
            get => _saveFile; 
            set => _saveFile = value; 
        }

        // состояние формы
        private States _state;

        // состояния запуска формы
        public enum States
        {
            // запуск формы в режиме создания мастерской
            EditMode,

            // запуск формы в режиме редактирования мастерской
            CreateMode
        }

        // конструктор по умолчанию (запуск формы в режиме создания)
        public RepairShopForm()
        {
            InitializeComponent();

            // данные для мастерской
            var repairShopInfo = Utils.repiarShopInfo[Utils.GetRand(0, Utils.repiarShopInfo.Length)];

            // установка значений
            _repair = new RepairShop { Name = repairShopInfo.Name, Address = repairShopInfo.Address };
            _state = States.CreateMode;
            _saveFile = SfdSaveFile.FileName;
            TxbFilePath.Text = _saveFile;

            // уменьшение размера окна по высоте
            this.Size = new Size(this.Width, this.Height - (TxbCurrentAddress.Location.Y + TxbCurrentAddress.Height));
            TxbCurrentAddress.Visible = TxbCurrentName.Visible = false;
            LblCurrentAddress.Visible = LblCurrentName.Visible = false;
            TxbName.Text = _repair.Name;
            TxbAddress.Text = _repair.Address;
        }

        // конструктор инициализирующий (запуск формы в режиме редактирования)
        public RepairShopForm(RepairShop repairShop, string saveFile)
        {
            InitializeComponent();

            // установка значений
            _repair = repairShop;
            _state = States.EditMode;
            _saveFile = saveFile;
            TxbFilePath.Text = _saveFile;
            SfdSaveFile.FileName = _saveFile;
        }

        // загрузка формы
        private void RepairShopForm_Load(object sender, EventArgs e)
        {
            // данные для мастерской
            var repairShopInfo = Utils.repiarShopInfo[Utils.GetRand(0, Utils.repiarShopInfo.Length)];

            // заполнение полей
            TxbCurrentName.Text = _repair.Name;
            TxbCurrentAddress.Text = _repair.Address;
            TxbName.Text = repairShopInfo.Name;
            TxbAddress.Text = repairShopInfo.Address;

            switch (_state)
            {
                // запуск формы в режиме создания мастерской     
                case States.CreateMode:
                    this.Text = "Создание мастерской";
                    BtnEdit.Text = "Создать";
                    break;

                // запуск формы в режиме редактирования мастерской
                case States.EditMode:
                    this.Text = "Редактирование мастерской";
                    BtnEdit.Text = "Сохранить";
                    break;
            };
        }

        // проверка на корректность ввода в полях
        private void CheckFields_Command(object sender, EventArgs e) =>
            BtnEdit.Enabled = !(String.IsNullOrWhiteSpace(TxbName.Text) ||
                                String.IsNullOrWhiteSpace(TxbAddress.Text) ||
                                String.IsNullOrWhiteSpace(TxbFilePath.Text));

        // применение изменений
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            _repair.Name = TxbName.Text;
            _repair.Address = TxbAddress.Text;
        }

        // выбор файла для сохранения
        private void SelectFile_Command(object sender, EventArgs e)
        {
            // запуск формы выбора файла для сохранения
            if (SfdSaveFile.ShowDialog() != DialogResult.OK)
                return;

            // установка файла
            _saveFile = SfdSaveFile.FileName;

            // вывод имени файла и пути
            TxbFilePath.Text = _saveFile;
        }
    }
}
