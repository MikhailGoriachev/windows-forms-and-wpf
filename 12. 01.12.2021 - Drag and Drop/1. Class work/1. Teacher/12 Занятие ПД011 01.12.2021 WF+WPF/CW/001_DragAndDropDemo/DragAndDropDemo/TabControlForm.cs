using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropDemo
{
    public partial class TabControlForm : Form
    {
        public TabControlForm() {
            InitializeComponent();
        }

        private void TbcDemo_DragEnter(object sender, DragEventArgs e) =>
            e.Effect = DragDropEffects.Copy;

        // при начале перетаскивания
        private void Label1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) return;

            // Начало буксировки - по нажатии ЛКМ на строке ввода текста
            LblSource.DoDragDrop(LblSource.Text, DragDropEffects.Copy);
        }

        // при попадании перетаскиваемого объекта на метку-приемник
        private void LblRedirect_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
            lblRedirect.BackColor = Color.BlueViolet;
        } // LblRedirect_DragEnter


        // прием данных приводит к переходу на другую вкладку и прием данных
        // элеметом этой вкладки
        private void LblRedirect_DragDrop(object sender, DragEventArgs e) {
            tbcDemo.SelectTab(1);
            lblDestination.Text = e.Data.GetData(DataFormats.StringFormat).ToString();

            lblRedirect.BackColor = Color.PaleTurquoise;
        } // LblRedirect_DragDrop


        // очистка метки
        private void BtnClrLabel_Click(object sender, EventArgs e) => lblDestination.Text = "";
        
    } // class TabControlForm
}
