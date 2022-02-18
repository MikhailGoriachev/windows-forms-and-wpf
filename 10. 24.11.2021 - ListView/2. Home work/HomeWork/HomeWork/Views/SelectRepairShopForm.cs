using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Controllers;     // контроллер

namespace HomeWork.Views
{
    // Форма Выбор мастерской
    public partial class SelectRepairShopForm : Form
    {
        // контроллер мастерской
        private RepairShopController _controller;

        // конструктор по умолчанию
        public SelectRepairShopForm(RepairShopController controller)
        {
            InitializeComponent();

            // инициализация контроллера 
            _controller = controller;
        }

        #region Свойства

        // доступ к полю _controller
        public RepairShopController Controller => _controller;

        #endregion

        #region Методы

        // создание мастерской
        private void CreateRepair_Command(object sender, EventArgs e)
        {
            // форма для создания данных о мастерсой
            var repairForm = new RepairShopForm();

            // форма для создания данных о мастерсой
            if (repairForm.ShowDialog() != DialogResult.OK)
                return;

            // установка ссылки на новую мастерскую
            _controller.Repair = repairForm.Repair;

            // установка файла для сохранения
            _controller.SaveFile = repairForm.SaveFile;

            // сохранение в файл
            _controller.Save();

            // закрытие формы
            Close();
        }

        // загрузка мастерской
        private void LoadRepair_Command(object sender, EventArgs e)
        {
            // получение результата формы
            if (OfdLoad.ShowDialog() != DialogResult.OK) return;

            // выбор файла для сохранения
            _controller.SaveFile = OfdLoad.FileName;

            // десериализация из файла
            _controller.Load();

            // закрытие формы
            Close();
        }

        #endregion
    }
}
