using System;
using System.Text;
using System.Windows.Forms;

namespace ListBox_ComboBox_Menu
{
    public partial class MainForm : Form
    {
        public MainForm () {
            InitializeComponent();
        }

        private void BtnAddToListBox_Click (object sender, EventArgs e) {
            // чтение из комбобокса  
            string fruit = CbxFruits.Text;

            // если ничего не выбрано - молча уходим
            if (string.IsNullOrWhiteSpace(fruit)) return;


            // добавление в листбокс
            LbxFruits.Items.Add(fruit);
        }

        // выбор элемента из комбобокса, добавление элемента в лист-бокс
        private void CbxSimple_SelectedIndexChanged (object sender, EventArgs e) {
            // защита от отсутствия выбора
            if (CbxSimple.SelectedIndex < 0)
                return;

            // прочитать выбранный элемент из комбобокса (простой стиль отображения)
            string item = (string)CbxSimple.Items[CbxSimple.SelectedIndex];

            // записать его в лист-бокс
            LbxFruits.Items.Add(item);
        } // CbxSimple_SelectedIndexChanged

        private void CbxDropdownList_SelectedIndexChanged (object sender, EventArgs e) {
            if (CbxDropdownList.SelectedIndex < 0)
                return;

            string item = (string) CbxDropdownList.Items[CbxDropdownList.SelectedIndex];

            CbxSimple.Items.Add(item);
            LbxFruits.Items.Add(item);
        } // CbxDropdownList_SelectedIndexChanged


        // Демонстрация множественного выбора из лист-бокса
        private void LbxFruits_SelectedIndexChanged (object sender, EventArgs e) {
            if (LbxFruits.SelectedIndices.Count == 0)
                return;
            
            // поместить все выбранные элементы в строку, отобразить строку
            // в MessageBox
            StringBuilder r = new StringBuilder();
            foreach (int index in LbxFruits.SelectedIndices) {
                r.Append($"Выбран элемент с индексом {index}\n");
            }
            MessageBox.Show(r.ToString(), "К сведению", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // LbxFruits_SelectedIndexChanged


        // удалить из ListBox выбранные элементы
        private void BtnDelete_Click (object sender, EventArgs e) {
            if (LbxFruits.SelectedIndices.Count == 0) {
                MessageBox.Show("Нет выбранных элементов, удаление не выполняем", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for(int i = LbxFruits.SelectedIndices.Count-1; i >= 0; --i)
                LbxFruits.Items.RemoveAt(LbxFruits.SelectedIndices[i]);

        } // BtnDelete_Click


        // очистка лист-бокса
        private void BtnClear_Click (object sender, EventArgs e) {
            DialogResult reply = MessageBox.Show("Вы уверены", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reply != DialogResult.Yes) return;

            LbxFruits.Items.Clear();
        }

        // выполнение пункта меню "Выход"
        private void MniExit_Click(object sender, EventArgs e) => Application.Exit();


        // Выполнение пункта меню "О программе"
        private void MniAbout_Click (object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        } // MniAbout_Click

        // Выполнение пункта меню "Коллекции объектов"
        private void MniCollections_Click (object sender, EventArgs e) {
            MessageBox.Show("Изучаем на следующем занятиии", "К сведению", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        } // MniCollections_Click
    } // class MainForm
}
