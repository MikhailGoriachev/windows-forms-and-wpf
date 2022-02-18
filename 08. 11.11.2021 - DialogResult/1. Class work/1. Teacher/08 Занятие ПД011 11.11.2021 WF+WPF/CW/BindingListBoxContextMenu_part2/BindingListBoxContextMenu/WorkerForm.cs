using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingListBoxContextMenu.Models;

namespace BindingListBoxContextMenu
{
    public partial class WorkerForm : Form
    {
        private Worker _worker;
            
        public Worker Worker {
            get => _worker;
            set {
                _worker = value;

                // к сведению
                TxbInfo.Text = $"{_worker}";

                // запись в элементы управления
                LblId.Text = $"ИД: {_worker.Id}";
                TxbFullName.Text = _worker.FullName;
                NudAge.Value = (decimal) _worker.Age;

                // вывести должность, если не совпадает с имеющимися вариантами - заменить
                // первой из доступного списка должностей
                CbxPosition.Text = CbxPosition.Items.IndexOf(_worker.Position) >= 0
                    ? _worker.Position
                    : CbxPosition.Items[0].ToString();

            } // Worker
        }

        // конструктор для формы в режиме добавления нового работника
        public WorkerForm()
        {
            InitializeComponent();

            // !! особые действия при создании объекта !! 
            _worker = new Worker() {Id = DateTime.Now.Second + 1000 };
        }

        // конструктор для формы в режиме редкатирования данных работника
        public WorkerForm(string formTitle, string btnTitle) {
            InitializeComponent();

            _worker = new Worker();

            // Заголовок формы
            Text = formTitle;
            BtnAdd.Text = btnTitle;
        } // WorkerForm

        // Обработчик кнопки "Добавить"/"Сохранить" - собрать данные из элементов
        // интерфейса
        private void BtnAdd_Click(object sender, EventArgs e) {
            /*
            _worker = new Worker {
                Age = DateTime.Now.Second + 19,
                FullName = "Романофф Н.П.",
                Position = "ассистент",
                Id = DateTime.Now.Second + 1000
            };
            */

            _worker.Age = (int) NudAge.Value;
            _worker.FullName = TxbFullName.Text;
            _worker.Position = CbxPosition.Text;
        } // BtnAdd_Click

        // проверка текст-бокса ввода имени
        private void TxbFullName_Validated(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(TxbFullName.Text))
                TxbFullName.ForeColor = Color.Red;
            else
                TxbFullName.ForeColor = Color.Black;
        }
    } // class WorkerForm
}
