using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTreeView
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();

            // назначение обработчика события клика по элементу дерева
            // TrvMain.Click += (s, args) => { MessageBox.Show($"Имя узла \"{TrvMain.SelectedNode.Text}\"", "Узел"); };
        } // MainForm

        // выход из приложения
        private void MniExit_Click(object sender, EventArgs e) => Application.Exit();


        // Добавление элемента к текущему узлу
        private void MniAddNode_Click(object sender, EventArgs e) {
            TreeNode node = TrvMain.SelectedNode;

            string newText = "Это еще один узел";
            node.Nodes.Add(newText);
            node.Expand();  // Развернуть узел

            // добавить в ListView имя добавленного узла
            LsvLog.Items.Add(new ListViewItem(newText));
        } // MniAddNode_Click


        // Удаление текущего узла дерева
        private void MniRemoveNode_Click(object sender, EventArgs e) {
            TreeNode node = TrvMain.SelectedNode;

            node?.Remove();
        } // MniRemoveNode_Click


        // раскрыть все узлы дерева
        private void MniExpandAll_Click(object sender, EventArgs e) =>
            TrvMain.ExpandAll();

        // свернуть все узлы дерева
        private void MniCollapseAll_Click(object sender, EventArgs e) =>
            TrvMain.CollapseAll();

        private void MniExit_MouseHover(object sender, EventArgs e) {
            mniExit.BackColor = Color.Blue;
            mniExit.ForeColor = Color.White;
        } // MniExit_MouseHover

        private void TrvMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) =>
            LsvLog.Items.Add($"NodeMouseDoubleClick: Вы кликнули по узлу \"{e.Node.Text}\"");

        private void TrvMain_Click(object sender, EventArgs e) {
            // если у элемента дерева нет следующего узла, ничего не делаем
            if (TrvMain.SelectedNode?.NextNode == null) return;

            // вывод в ListView описания события
            LsvLog.Items.Add($"Click: выбран \"{TrvMain.SelectedNode.Text}\", " +
                                $"след. \"{TrvMain.SelectedNode.NextNode.Text}\"");
        } // TrvMain_Click

        private void TrvMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            LsvLog.Items.Add($"NodeMouseClick: Вы кликнули по узлу \"{e.Node.Text}\": {e.Node.Index}");
        }

        private void trvMain_MouseClick(object sender, MouseEventArgs e) {
            LsvLog.Items.Add($"MouseClick: текущий узел \"{TrvMain.HitTest(e.Location).Node.Text}\"");
        }

        private void trvMain_MouseDoubleClick(object sender, MouseEventArgs e) {
            LsvLog.Items.Add($"MouseDoubleClick: текущий узел \"{TrvMain.HitTest(e.Location).Node.Text}\"");
        }

        // Сформировать узлы дерева
        private void TsbGenerate_Click(object sender, EventArgs e) {
            // чистим все узлы времени проектирования
            TrvMain.Nodes.Clear();

            // генерация узлов в коде
            /*
            TrvMain.Nodes.Add("Корневой элемент 1");
            TrvMain.Nodes[0].Nodes.Add("Первый элемент");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Подэлемент 1.0");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Подэлемент 1.1");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Подэлемент 1.2");

            TrvMain.Nodes[0].Nodes.Add("Второй элемент");
            TrvMain.Nodes[0].Nodes[1].Nodes.Add("Подэлемент 2.0");
            TrvMain.Nodes[0].Nodes[1].Nodes.Add("Подэлемент 2.1");
            TrvMain.Nodes[0].Nodes[1].Nodes.Add("Подэлемент 2.2");
            
            TrvMain.Nodes[0].Nodes.Add("Третий элемент");
            TrvMain.Nodes[0].Nodes[2].Nodes.Add("Подэлемент 3.0");
            TrvMain.Nodes[0].Nodes[2].Nodes.Add("Подэлемент 3.1");
            TrvMain.Nodes[0].Nodes[2].Nodes.Add("Подэлемент 3.2");
             
            TrvMain.Nodes.Add("Корневой элемент 2");
            TrvMain.Nodes[1].Nodes.Add("Первый элемент");
            TrvMain.Nodes[1].Nodes[0].Nodes.Add("Подэлемент 1.0");
            TrvMain.Nodes[1].Nodes[0].Nodes.Add("Подэлемент 1.1");
            TrvMain.Nodes[1].Nodes[0].Nodes.Add("Подэлемент 1.2");
            */

            // пример формирования узлов для квартиры 
            TrvMain.Nodes.Add("Квартира No 50");
            
            TrvMain.Nodes[0].Nodes.Add("Кухня");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Холодильник");
            TrvMain.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("белый");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Светильник");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Микроволновка");
            TrvMain.Nodes[0].Nodes[0].Nodes.Add("Вытяжка");

            TrvMain.Nodes[0].Nodes.Add("Гостиная");
            TrvMain.Nodes[0].Nodes[1].Nodes.Add("Телевизор");

            TrvMain.Nodes[0].Nodes.Add("Спальня");
            TrvMain.Nodes[0].Nodes[2].Nodes.Add("Светильник");

            // развернуть сформированные узлы дерева 
            TrvMain.ExpandAll();
        } // TsbGenerate_Click


        // http://qaru.site/questions/655482/saving-content-of-a-treeview-to-a-file-and-load-it-later
        // очень грубый пример сохранения/сериализации TreeView в файле:
        // пришлось использовать Cast<> это один из расширяющих
        // методов, но без него код катастрофически усложняется 
        private void Save_Command(object sender, EventArgs e) {
            using (Stream file = File.Open("tree.bin", FileMode.Create)) {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, TrvMain.Nodes.Cast<TreeNode>().ToList());
            } // using
        } // Save_Command


        // загрузить дерево из файла, код взят тут
        // http://qaru.site/questions/655482/saving-content-of-a-treeview-to-a-file-and-load-it-later
        // ToArray() это тоже расширяющий метод, но без его использования
        // код также сильно разрастается
        private void Load_Command(object sender, EventArgs e) {
            string fileName = "tree.bin";
            if (!File.Exists(fileName)) return;

            // чистим узлы текущего дерева, затем загружаем
            TrvMain.Nodes.Clear();

            // код взят тут
            // http://qaru.site/questions/655482/saving-content-of-a-treeview-to-a-file-and-load-it-later
            using (Stream file = File.Open(fileName, FileMode.Open)) {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                TrvMain.Nodes.AddRange(nodeList);
            } // using
        } // Load_Command


        // Открыть дополнительную форму
        private void OpenForm1_Command(object sender, EventArgs e) {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        } // OpenForm1_Command


        // Команда на начало редактирования узла дерева (метки узла)
        // Свойство LabelEdit также надо установить в true 
        // https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.forms.treeview.labeledit?view=netframework-4.8
        private void NodeEdit_Command(object sender, EventArgs e) {
            TreeNode node = TrvMain.SelectedNode;

            // если уже редактируем - уходим
            if (node.IsEditing) return;

            // начать редактирование
            node.BeginEdit();
        } // NodeEdit_Command


        // Обработка завершения редактирования узла дерева (меток в дереве) 
        // https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.forms.treeview.labeledit?view=netframework-4.8
        private void TrvMain_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
            // сохранить введенный текст
            e.Node.EndEdit(false);

            // какая-то обработка, с полученными из узла данными
            // в даннном случае, просто копируем в строку состояния
            // полученный из узла введенный текст
            TslNodeText.Text = e.Label;   // e.Label это новый текст
            e.Node.Text = e.Label;        // e.Node.Text - это старый текст в редактируемом узле
        } // trvOrder_AfterLabelEdit
    } // class MainForm
}
