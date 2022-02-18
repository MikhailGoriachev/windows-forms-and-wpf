using System;
using System.Threading;
using System.Windows.Forms;

namespace TableFunctions.Models
{
    public partial class MainForm : Form
    {
        // форма для вывода при старте приложения, форма "О программе"
        private SplashForm _splashForm = new SplashForm();

        public MainForm() {
            InitializeComponent();

            AddOwnedForm(_splashForm);
            _splashForm.Show();

            // Для отображения содержимого окна-заставки
            Application.DoEvents();
        } // MainForm


        // Заполнить таблицу при загрузке формы
        private void MainForm_Load(object sender, EventArgs e) {
            int n = 100;          // количество точек, выводимых в таблицу
            int timeLoad = 2_0; // время для загрузки формы (с прогресс-баром, 2000)
             
            double step = 2*Math.PI / (n - 1);   // шаг вывода точек таблицы
            double x, sx, cx, tg, ctg;           // переменные для расчета таблицы

            // программное создание столбца, доступ для настройки параметров
            // первый параметр - имя столбца
            // второй параметр - заголовок столбца
            // Есть перегруженный вариант - создание из другого столбца
            // dgvTable.Columns.Add("None", "Примечание");   // создание
            // dgvTable.Columns["None"].FillWeight = 30;     // доступ через индексатор к свойствам

            dgvTable.RowCount = n;          // создать таблицу с заданным количеством строк
            
            int timePause = timeLoad / n;   // время паузы для восприятия прогресс-бара 
            int stepProgressBar = _splashForm.prbSplash.Maximum / n;  // !! Возможна погрешность !! 

            x = -Math.PI;
            for (int i = 0; i < n; i++) {

                // Проверка видимости экрана-заставки и завершение приложения,
                // если окно скрыто. Скрывается окно только по команде пользователя
                // на досрочное завершение приложения
                Application.DoEvents();
                if (!_splashForm.Visible) {
                    Close();    // закрывает окно, но не завершает выполнение кода
                    return;     // выход из метода
                } // if
                 
                // Расчет очередной строки таблицы
                sx = Math.Sin(Math.PI + x);
                cx = Math.Cos(Math.PI + x);
                tg = Math.Tan(Math.PI + x);

                // Особый случай - обработка деления на ноль 
                ctg = Math.Abs(x - Math.PI) < 0.0000001?double.PositiveInfinity:(cx / sx);

                // Заполнение очередной строки таблицы DataGridView
                // ‼ В индексаторе таблицы на первом месте - индекс столбца
                // ‼ на втором месте - индекс строки
                dgvTable[0, i].Value = $"{x,   8:f5}";
                dgvTable[1, i].Value = $"{sx,  12:f8}";
                dgvTable[2, i].Value = $"{cx,  12:f8}";
                dgvTable[3, i].Value = $"{tg,  12:f8}";
                dgvTable[4, i].Value = $"{ctg, 12:f8}";

                // Изменить показания ProgressBar, пауза для восприятия этих изменений
                _splashForm.prbSplash.Value += stepProgressBar;  
                Thread.Sleep(timePause);

                x += step;     // К следующей строке таблицы, к следующей точке расчета 
            } // for i

            // Только для того, чтобы увидеть форму-заставку делаем принудительную 
            // паузу в загрузке
            // TODO: выяснить почему прогресс-бар заполнен не до конца
            _splashForm.prbSplash.Value = _splashForm.prbSplash.Maximum;
            Thread.Sleep(700);

            // Убираем заставку до появления главной формы
            _splashForm.Hide();

            // Настройка окна-заставки в режим информационного окна "О программе..."
            _splashForm.UseWaitCursor = false;             // убрать курсор занятости
            _splashForm.Controls["btnOk"].Visible = true;  // кнопку Ок отобразить
            _splashForm.Opacity = 100d;                    // делаем окно непрозрачным
            _splashForm.prbSplash.Visible = false;         // прячем прогресс-бар 
        } // MainForm_Load


        // Выход из приложения - команда меню
        private void ExitCommand(object sender, EventArgs e) => 
            Application.Exit();


        // Отображение экрана-заставки как информационного окна "О программе..."
        // команда меню
        private void AboutCommand(object sender, EventArgs e) =>
            _splashForm.ShowDialog();

        // Открыть форму с примером таблицы, заполненной сгенерированными данными
        private void MniSimpleTable_Click(object sender, EventArgs e) {
            Form1 form1 = new Form1();

            form1.Show();
        } // MniSimpleTable_Click


        // Открыть форму с примером таблицы, заполненной коллекцией объектов, без
        // использования привязки DataSource
        private void MniCollectionTable_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();

            form2.Show();
        } // MniSimpleTable_Click


        // Открыть форму с демонстрацией привязки данных
        private void DataSource_Command(object sender, EventArgs e) {
            Form3 form3 = new Form3();

            form3.Show();
        }
    } // class MainForm
}
