using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConeDemo
{
    public partial class MainForm : Form
    {
        // Данные для обработки - объект класса конус
        private Cone _cone;

        // Конструктор формы
        public MainForm() {
            InitializeComponent();
            _cone = new Cone();
        } // MainForm

        public MainForm(Cone cone) {
            InitializeComponent();
            _cone = cone;

            // пересылка данных в элементы интерфейса
            txbRadius.Text = $"{cone.Radius:N3}";
            txbHeight.Text = $"{cone.Height:N3}";
            txbDensity.Text = $"{cone.Density:N3}";
        } // MainForm


        // Выход - обработка кнопки btnExit
        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        } // btnExit_Click


        // Расчет параметров конуса по значениям формы
        private void btnCalculate_Click(object sender, EventArgs e) {
            try {
                double massa;   // масса конуса
                double volume;  // объем конус

                // Получить исходные данные для расчета
                _cone.Radius = double.Parse(txbRadius.Text);
                _cone.Height = double.Parse(txbHeight.Text);
                _cone.Density = double.Parse(txbDensity.Text);

                // скорректировать введенные значения
                txbRadius.Text = $"{_cone.Radius:n3}";
                txbHeight.Text = $"{_cone.Height:n3}";
                txbDensity.Text = $"{_cone.Density:n3}";

                // Расчитать требуемые параметры и вывести на форму
                // Проверяем чекбоксы и вычисляем параметры конуса в соответствии с заданием
                // расчет объема
                if (chbVolume.Checked) {
                    volume = _cone.CalcVolume();
                    lblVolume.ForeColor = Color.ForestGreen;
                    lblVolume.Text = $"Объем конуса: {volume:n3}";
                } else {
                    lblVolume.ForeColor = Color.IndianRed;
                    lblVolume.Text = "Объем конуса: расчет не требуется";
                } // if

                
                // расчет для массы
                if (chbMassa.Checked) {
                    massa = _cone.CalcMassa();
                    lblMassa.ForeColor = Color.ForestGreen;
                    lblMassa.Text = $"Масса конуса: {massa:n3}";
                } else {
                    lblMassa.ForeColor = Color.IndianRed;
                    lblMassa.Text = "Масса конуса: расчет не требуется";
                } // if
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } // try-catch
        } // btnCalculate_Click
    } // class MainForm
}
