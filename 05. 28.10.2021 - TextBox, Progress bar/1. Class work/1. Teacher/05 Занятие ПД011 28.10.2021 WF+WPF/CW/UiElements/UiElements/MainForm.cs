using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UiElements
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();

            // автозаполнение для TextBox ввода имени - пример программной настройки
            // свойств компонента
            AutoCompleteStringCollection source = new AutoCompleteStringCollection() {
                "Дмитрий", "Владимир", "Всеволод", "Владислав", "Андрей",
                "Артем", "Давид", "Даниил", "Юрий", "Сергей", "Семен",
                "Никита", "Павел", "Олег", "Олаф", "Орхонт"
            };
            TxbText1.AutoCompleteCustomSource = source;
            TxbText1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // установка шрифта на примере TextBox
            TxbMultiLine.Font = new Font(new FontFamily("Verdana"), 14);

            // Установка цвета на примере TextBox
            TxbMultiLine.ForeColor = Color.DarkBlue;
            TxbMultiLine.BackColor = Color.FromArgb(255, 190, 240, 180);
        } // MainForm


        // по окончании создания формы, но перед ее отображением, загрузить
        // этот файл исходного кода в элемент TextBox
        private void MainForm_Load(object sender, EventArgs e) {
            TxbSrcFile.Lines = File.ReadAllLines(@"..\..\MainForm.cs");
        } // MainForm_Load


        // обработчик изменения элемента NumericUpDown
        private void NudNumber_ValueChanged(object sender, EventArgs e) {
            TxbMultiLine.Text += $"{NudNumber.Value}\r\n";
        } // NudNumber_ValueChanged


        // обработчик события Scroll для регулятора TrackBar
        private void TrbNumber_Scroll(object sender, EventArgs e) {
            NudNumber.Value =  PrbNumber.Value = TrbNumber.Value;
        } // TrbNumber_Scroll


        // Обработчик клика Linklabel - переход на URL в интернете
        private void LnlItstep_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("http://itstep.org");
        } // LnlItstep_LinkClicked


        // Обработчик клика Linklabel - запуск приложения на компьютере
        // приложение должно быть указано в переменной среды PATH
        private void LnlCalc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("calc.exe");
        } // LnlCalc_LinkClicked


        // на LinlLabel может быть назначено и совершенно обычное действие
        private void LnlBackColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            BackColor = BackColor == Color.Azure?DefaultBackColor:Color.Azure;
        } // LnlBackColor_LinkClicked


        /*     пример вывода символов псевдографики в TextBox, требуется установить моноширинный шрифт
         *     при работе приложения этот файл загружается в TextBox, можно наглядно посмотреть на
         *     то, как простыми и даже примитивными средствами можно выводить данные в табличном формате
         *    ┌─────┬────────┬──────────────┬────────────────────────────┬─────────────┬────────────────────────┐
         *    │  N  │ Номер  │ Номер        │ Пункт                      │  Желаемая   │ Фамилия И.О.           │
         *    │ п/п │ заявки │        рейса │       назначения           │ дата вылета │              пассажира │
         *    ├─────┼────────┼──────────────┼────────────────────────────┼─────────────┼────────────────────────┤
         *    │     │        │              │                            │             │                        │
         *    └─────┴────────┴──────────────┴────────────────────────────┴─────────────┴────────────────────────┘
         * */
    }
}
