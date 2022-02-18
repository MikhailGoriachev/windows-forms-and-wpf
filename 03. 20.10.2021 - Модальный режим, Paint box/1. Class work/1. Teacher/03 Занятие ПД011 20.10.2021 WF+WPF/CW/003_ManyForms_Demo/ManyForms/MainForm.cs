using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyForms
{
    public partial class MainForm : Form
    {
        // формы приложения
        private FirstForm _first;
        private SecndForm _secnd;
        private ThirdForm _third;
        private FormFour _fourth;
        private FormFifth _fifth;

        public MainForm()
        {
            InitializeComponent();

            

            lblInfo.Text = "";
        } // MainForm


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // btnExit_Click

        private void btnFirstForm_Click(object sender, EventArgs e)
        {
            _first = new FirstForm();

            // Передать данные в форму при помощи сеттеров
            _first.SetMode(false);
            _first.SetText("Текст для отображения в форме FirstForm");

            // Отобразить форму в модальном режиме
            DialogResult dr = _first.ShowDialog();
            if (dr == DialogResult.OK)
                BackColor = Color.Green;
            else
                BackColor = Color.CadetBlue;

            // Использование геттеров для доступа к данным на форме
            // Получить данные из формы при помощи геттеров
            lblInfo.Text = _first.GetText() + " " + _first.GetMode();

            _first.Show();
        } // btnFirstForm_Click

        private void btnSecndForm_Click(object sender, EventArgs e)
        {
            _secnd = new SecndForm();

            _secnd.ShowDialog();  // модальное отображение формы
            // secnd.Show();           // не модальное отображение формы
        } // btnSecndForm_Click


        private void btnThirdForm_Click(object sender, EventArgs e)
        {
            _third = new ThirdForm(this, Text);
            // third.ShowDialog();
            _third.Show();
        } // btnThirdForm_Click

        public void SetLabel(string text) {
            lblInfo.Text = text;
        }

        private void btnFourhForm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) {
                _fourth = new FormFour();
                _fourth.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _fifth = new FormFifth();
            _fifth.ShowDialog();
        }
    }
}
