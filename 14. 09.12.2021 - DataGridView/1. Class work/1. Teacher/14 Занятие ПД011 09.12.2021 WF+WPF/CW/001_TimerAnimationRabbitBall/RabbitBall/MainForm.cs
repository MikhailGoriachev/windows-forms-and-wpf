using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitBall
{
    public partial class MainForm : Form
    {
        private string _path = "../../Images/a";

        private int _index;

        public MainForm() {
            InitializeComponent();
            _index = 0;
			Animation_Tick(this, EventArgs.Empty);

            LblInfo.Text = $"Период анимации {TrbInterval.Value}";
        } // MainForm

        // обработчик тика таймера - вывод очередной картинки
        private void Animation_Tick(object sender, EventArgs e) {
            ++_index;
            if (_index > 7) _index = 1;

            // !!! это путь к добавлению картинок в ImageList
            pbxMain.Image = new Bitmap(_path + _index + ".png");
        } // Animation_Tick


        // кнопка старта таймера
        private void Button1_Click(object sender, EventArgs e) {
            tmrAnimation.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        } // Button1_Click

        // кнопка стопа таймера
        private void Button2_Click(object sender, EventArgs e) {
            tmrAnimation.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = false;
        } // Button2_Click


        // обработка перемещения трэкбара
        private void TrbInterval_Scroll(object sender, EventArgs e) {
            tmrAnimation.Interval = TrbInterval.Value;
            LblInfo.Text = $"Период анимации {TrbInterval.Value}";
        } // TrbInterval_Scroll
    }
}
