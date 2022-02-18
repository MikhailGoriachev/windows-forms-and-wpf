using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlListView
{
    public partial class MainForm : Form
    {
        // счетчик вкладок 
        private int _counter;

        public MainForm() {
            InitializeComponent();
            _counter = 0;
        }

        private void TabPageAdd_Command(object sender, EventArgs e) {
            TbcMain.TabPages.Add($"Вкладка {++_counter}");
        }

        // на первую вкладку
        private void FirstTab_Command(object sender, EventArgs e) {
            TbcMain.SelectedTab = TbcMain.TabPages[0];
        }

        // на последнюю вкладку
        private void LastTab_Comamnd(object sender, EventArgs e) {
            TbcMain.SelectedTab = TbcMain.TabPages[TbcMain.TabPages.Count-1];
        }


        // свернуть в трей
        private void ToTray_Command(object sender, EventArgs e) {
            this.Hide();
            NtiMain.Visible = true;
        }


        // восстановить из трея
        private void FromTray_Command(object sender, EventArgs e) {
            this.Show();
            WindowState = FormWindowState.Normal;
            NtiMain.Visible = false;
        }

        private void Exit_Command(object sender, EventArgs e) => Application.Exit();


        // выбрать режимы отображения ListView
        private void LargeIcon_Command(object sender, EventArgs e) {
            LsvDemo1.View = View.LargeIcon;
            LsvDemo2.View = View.LargeIcon;
        }

        private void SmaillIcon_Command(object sender, EventArgs e) {
            LsvDemo1.View = View.SmallIcon;
            LsvDemo2.View = View.SmallIcon;
        }

        private void List_Command(object sender, EventArgs e) {
            LsvDemo1.View = View.List;
            LsvDemo2.View = View.List;
        }

        private void Tile_Command(object sender, EventArgs e) {
            LsvDemo1.View = View.Tile;
            LsvDemo2.View = View.Tile;
        }


        private void Detail_Command(object sender, EventArgs e) {
            LsvDemo1.View = View.Details;
            LsvDemo2.View = View.Details;
        }


        // Обработка выбора в ListView1
        private void LsvDemo1_SelectedIndexChanged(object sender, EventArgs e) {
            if (LsvDemo1.SelectedIndices.Count == 0) return;
            LblSelected1.Text = LsvDemo1.Items[LsvDemo1.SelectedIndices[0]].Text;
        }

        // Обработка выбора в ListView2
        private void LsvDemo2_SelectedIndexChanged(object sender, EventArgs e) {
            if (LsvDemo2.SelectedIndices.Count == 0) return;
            LblSelected2.Text = LsvDemo2.Items[LsvDemo2.SelectedIndices[0]].Text;
        }

        // удаление выбранной вкладки
        private void RemoveTab_Command(object sender, EventArgs e) {
            
            // не удаляем 1ю и 2ю вкладки
            if (TbcMain.SelectedIndex > 1)
                TbcMain.TabPages.RemoveAt(TbcMain.SelectedIndex);
        }
    } // class MainForm
}
