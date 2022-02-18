using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TabControlListView.Models;

namespace TabControlListView
{
    public partial class MainForm : Form
    {
        // счетчик вкладок 
        private int _counter;

        // коллекция объектов для вывода в ListView в табличном режиме (Details)
        private List<Person> _persons;

        public MainForm() {
            InitializeComponent();
            _counter = 0;

            // генерация коллекции
            _persons = new List<Person>();
            for (int i = 0; i < 10; i++) {
                _persons.Add(Person.Generate());
            } // for i
        } // MainForm


        // запись коллекции объектов в ListView для табличного отображения
        private void WriteToListView() {

            LsvPersons.Items.Clear();

            foreach (var person in _persons) {
                // получить элемент для заполнения строки ListView, указать в нем данные 0го столбца 
                ListViewItem listViewItem = new ListViewItem($"{person.Id}", 0);

                // добавить остальные столбцы
                listViewItem.SubItems.Add(person.FullName);
                listViewItem.SubItems.Add($"{person.Age}");
                listViewItem.SubItems.Add($"{person.Salary:f2}");

                // добавить строку в ListView
                LsvPersons.Items.Add(listViewItem);
            } // foreach person
        } // WriteToListView
          

        // запись коллекции объектов в ListView для табличного отображения с картинкой
        private void WriteToImgListView() {

            LsvImgPersons.Items.Clear();

            foreach (var person in _persons) {
                // получить элемент для заполнения строки ListView, указать в нем данные 0го столбца 
                ListViewItem listViewItem = new ListViewItem("", person.ImageId);

                // добавить остальные столбцы
                listViewItem.SubItems.Add($"{person.Id}");
                listViewItem.SubItems.Add(person.FullName);
                listViewItem.SubItems.Add($"{person.Age}");
                listViewItem.SubItems.Add($"{person.Salary:f2}");

                // добавить строку в ListView
                LsvImgPersons.Items.Add(listViewItem);
            } // foreach person
        } // WriteToImgListView


        // после готовности всех элементов, после работы конструктора
        // заполнить ListView данными коллекции
        private void MainForm_Load(object sender, EventArgs e) {
            WriteToListView();
            WriteToImgListView();
        } // MainForm_Load


        // Обработчик выбора в ListView
        private void LsvPersons_SelectedIndexChanged(object sender, EventArgs e) {
            // если нет выбранных элементов - молча уходим
            if (LsvPersons.SelectedIndices.Count == 0) return;

            // получить индекас выбранного элемента в ListView
            int index = LsvPersons.SelectedIndices[0];

            LblListInfo1.Text = $"{_persons[index]}";
        } // LsvPersons_SelectedIndexChanged


        // удаление записи из коллекции по клавише Delete
        private void LsvPersons_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Delete) return;

            // если нет выбранных элементов - молча уходим
            if (LsvPersons.SelectedIndices.Count == 0) return;

            // получить индекас выбранного элемента в ListView
            int index = LsvPersons.SelectedIndices[0];

            // удаление записей и из коллекции и из ListView
            _persons.RemoveAt(index);
            LsvPersons.Items.RemoveAt(index);

            // так тоже можно обновить связь c ListView
            // WriteToListView();
        } // LsvPersons_KeyDown


        // по клавише Enter заменим картинку в строке ListView
        // моделируем редактирование элемента коллекции
        private void LsvImgPersons_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode != Keys.Return) return;

            // если нет выбранных элементов - молча уходим
            if (LsvImgPersons.SelectedIndices.Count == 0) return;

            int index = LsvImgPersons.SelectedIndices[0];
            var person = _persons[index];

            ListViewItem listViewItem = new ListViewItem("", DateTime.Now.Second % 15);

            listViewItem.SubItems.Add($"{person.Id}");
            listViewItem.SubItems.Add(person.FullName);
            listViewItem.SubItems.Add($"{person.Age}");
            listViewItem.SubItems.Add($"{person.Salary:f2}");

            LsvImgPersons.Items[index] = listViewItem;
        } // LsvImgPersons_KeyDown

        // ------------------------------------------------------------------------------------

        // добавление вкладки 
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
        } // ToTray_Command


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
