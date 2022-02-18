using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;  // для паузы, Thread.Sleep()
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanoiTower
{
    public partial class MainForm : Form
    {
        private int _count;     // счетчик ходов
        private int _minMoves;  // минимальное количество ходов

        public MainForm() {
            InitializeComponent();

            // Разрешение перетаскивания для компонентов GroupBox
            groupBox1.AllowDrop = groupBox2.AllowDrop = groupBox3.AllowDrop = true;
        } // Form1

        // Подготовка начального положения
        private void MainForm_Load(object sender, EventArgs e) {
            // Для формирования цвета
            Random rand = new Random();

            // количество элементов
            int n = (int)numericUpDown1.Value;

            // цикл создания элементов
            for (int i = 0; i < n; i++) {
                Label lb = new Label();
                lb.BorderStyle = BorderStyle.FixedSingle;  // рамка
                lb.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                // Размер и позиция очередного блока
                lb.Size = new Size((groupBox1.Width - 10)*(n - i)/n, (groupBox1.Height - 15)/n);
                lb.Location = new Point((groupBox1.Width - lb.Width)/2, groupBox1.Height - 2 - (i + 1)*lb.Height);

                // Назначить обработчик события 
                lb.MouseDown += label_MouseDown;

                // Назначение родителя (владельца) элемента
                groupBox1.Controls.Add(lb); 
            } // for i

            // Определение и отображение счетчика ходов и минимального количества ходов
            _count = 0;                            // обнуляем счетичк ходов
            _minMoves = (int)Math.Pow(2, n) - 1;   // расчет минимально необходимого количества ходов
            ShowMovesCounter();                    // показать количество ходов

            // прячем метку с сообщением о решении задачи
            label2.Visible = false;
        } // MainForm_Load


        // Перерисовка башни в начальном состоянии при изменении количества 
        // блоков - переход в исходное состояние
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            // очистка башен - удаляем элменты из всех башен
            label_Dispose(groupBox1);
            label_Dispose(groupBox2);
            label_Dispose(groupBox3);

            // вызов обработчика события MainForm_Load() для рисования башни с новым
            // количеством блоков
            MainForm_Load(this, EventArgs.Empty);  
        } // numericUpDown1_ValueChanged


        // Удаление Label из GroupBox - удаление блоков башни
        // Dispose() - удаление объекта, освобождение ресурсов объекта
        private void label_Dispose(GroupBox gb) {
            for (int i = gb.Controls.Count - 1; i >= 0; i--) gb.Controls[i].Dispose();
        } // label_Dispose


        // Обработка нажатия кнопки мыши для каждого блока башни
        private void label_MouseDown(object sender, MouseEventArgs e) {
            // не начинать перетаскивание в режиме показа решения
            if (!button1.Enabled) return;

            // По нажатию ЛКМ задать тип операции перетаскивания - перемещение объекта
            if (e.Button == MouseButtons.Left)
                DoDragDrop(sender, DragDropEffects.Move);
        } // label_MouseDown

        // Подтверждение операции перетаскивания при входе на очередной элемент
        private void groupBox1_DragEnter(object sender, DragEventArgs e) {
            // перетаскивание не разрешаем по окончании решения задачи
            // состояние "задача решена" определяем по видимости метки label2
            if (label2.Visible) {                  // метка видна == решение заверщено
                e.Effect = DragDropEffects.None;   // в этом случае не перемещать
                return;
            } // if

            // Перетескивание разрешаем для верхнего блока
            // Верхний блок всегда последний блок в коллекции Controls
            // перетаскивание также запрещаем если делается попытка положить
            // больший блок на меньший блок

            // ширина верхнего блока, инициируем самым большим целым
            // для срабатывания на пустой башне - тогда любая ширина
            // гарантированно меньше 
            int widthTopBlock = int.MaxValue;

            GroupBox gb = sender as GroupBox;
            if (gb.Controls.Count > 0)
                widthTopBlock = gb.Controls[gb.Controls.Count - 1].Width;

            Label lb = e.Data.GetData(typeof(Label)) as Label;
            if (lb != lb.Parent.Controls[lb.Parent.Controls.Count - 1] || 
                lb.Width > widthTopBlock)
                // Отмена операции перемещения для не верхенго блока башни 
                e.Effect = DragDropEffects.None;
            else
                // Подтверждение операции перемещения для верхнего блока башни
                e.Effect = DragDropEffects.Move;
        } // groupBox1_DragEnter


        // Обработчик завершения перетаскивания для блока башни 
        private void groupBox1_DragDrop(object sender, DragEventArgs e) {
            Label lb = e.Data.GetData(typeof(Label)) as Label; // перетаскиваемый элемент
            GroupBox gb = sender as GroupBox;                  // принимающий элемент

            // Если перетаскивание завершилось в исходной башне действия не нужны
            if (gb == lb.Parent) return;

            // Смена родителя метки, позиционирование метки в башне
            label_Move(lb, gb);
        } // groupBox1_DragDrop


        // Смена владельца блока, определение его позиции в очередной башне
        private void label_Move(Label lb, GroupBox gb) {
            // Смена владельца
            lb.Parent = gb;

            // Обеспечиваем размещение блока всегда сверху всех блоков башни
            lb.Top = gb.Height - 2 - gb.Controls.Count * lb.Height;

            // увеличение счетчика ходов и его отображение
            _count++;
            ShowMovesCounter();

            // отображения сообщения об окончании решения задачи
            // делаем видимым если количество элементов в третьей башне
            // равно количеству собираемых элементов
            label2.Visible = groupBox3.Controls.Count == numericUpDown1.Value; 
        } // label_Move


        // Отображение количества ходов, все настройки отображения будут размещены
        // в этом месте
        private void ShowMovesCounter() {
            label1.Text = $"Количество ходов: {_count} (минимально: {_minMoves})";
        } // ShowMovesCounter

        // Показать решение задачи по оптимальному алгоритму (есть известное
        // рекурсивное решение данной задачи)
        private void button2_Click(object sender, EventArgs e) {
            // запретить работу кнопки сброса и блока задания элементов
            // для предотваращения ошибки времени исполнения
            numericUpDown1.Enabled = button1.Enabled = false;

            // Показа решения выполняем только из начального состояния
            // (т.к. нигде не сохраняем никаких игровых состояний)
            if (groupBox1.Controls.Count != numericUpDown1.Value) {// не начальное состояние
                numericUpDown1_ValueChanged(null, null);           // сбросить в начальное состояние 
                Application.DoEvents();
                Thread.Sleep(800);
            } // if
             
            // начать рекурсивный вызов
            Step((int)numericUpDown1.Value, groupBox1, groupBox3, groupBox2);
            numericUpDown1.Enabled = button1.Enabled = true;
        } // button2_Click

        // рекурсивный метод для решения задачи
        // n - количество собираемых блоков
        // src - исходная башня
        // dst - результирующая башня, в ней собираем блоки
        // tmp - вспомогательная башня, помогает сборке
        private void Step(int n, GroupBox src, GroupBox dst, GroupBox tmp) {
            if (n == 0) return; // выход из рекурсии - если в исходной башне нет блоков

            // первая часть рекурсивного хода - собрать башню из n-1 элементов
            // в поле tmp, используя башню dst как вспомогательную
            Step(n - 1, src, tmp, dst);

            // еще один, аварийный, выход из рекурсии - если кнопка button1
            // стала доступной
            if (button1.Enabled) return;

            // Визуализация хода
            label_Move(src.Controls[src.Controls.Count-1] as Label, dst);
            Application.DoEvents();  // обеспечим прорисовку, обработав события из очереди событий
            Thread.Sleep(1500 / ((int)numericUpDown1.Value));  // пауза для восприятия

            // вторая часть рекурсивного хода - собрать башню из n-1 элемента в dst из tmp,
            // используя src как вспомогательную башню 
            Step(n - 1, tmp, dst, src);
        } // Step

        // Обработка закрытия формы - защита от ошибки доступа к уже удаленным 
        // элементам
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            // для прерывания рекурсии в режиме показа решения
            // рекурсия прервется, не будет попытки использовать уже удаленные
            // при зарытии формы элементы управления
            button1.Enabled = true;
        } // MainForm_FormClosed
    } // class MainForm
}
