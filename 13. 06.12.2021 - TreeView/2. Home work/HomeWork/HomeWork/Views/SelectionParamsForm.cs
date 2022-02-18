using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliances.Views
{
    // Форма выбора параметра для выборки
    public partial class SelectionParamsForm : Form
    {

        // выбранный параметр
        public string Parameter { get; private set; }

        private SelectionParamsForm()
        {
            InitializeComponent();
        }

        // создание формы для выбора параметров выборки
        public SelectionParamsForm(string title, string titleParam, string[] items)
        {
            InitializeComponent();

            // заполнение комбо-бокса
            CbxSelectionParams.Items.AddRange(items);

            // установка заголовка окна
            this.Text = title;

            // установка названия параметра
            LblParams.Text = titleParam;

            // если коллекция параметров пуста
            if (CbxSelectionParams.Items.Count == 0)
                BtnOk.Enabled = false;
            else 
                // выбор по умолчанию 
                CbxSelectionParams.SelectedIndex = 0;
        }

        // нажатие на кнопку "Выбрать"
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Parameter = CbxSelectionParams.SelectedItem.ToString();
        }

    }
}
