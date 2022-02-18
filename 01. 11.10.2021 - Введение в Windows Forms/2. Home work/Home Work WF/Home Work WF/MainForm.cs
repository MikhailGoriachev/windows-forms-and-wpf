using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Задача 2. Разработайте приложение Windows Forms, разместите на форме элементы 
 * Label, Button, Timer для выполнения обработок:
 * •	По кнопке «Рисунок» выводите в Label с моноширинным шрифтом ASCII-art, 
 *      приведенный в файле ascii.txt. Рисунок стирается при помощи таймера через 
 *      5 секунд
 * •	По кнопке «Приветствие» выводите сообщение «Привет, Windows Forms», 
 *      сообщение стирается при помощи таймера через 5 секунд
 * •	По кнопке «Выход» работа приложения завершается
 */

namespace Home_Work_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // нажатие на кнопку BtnDrawing
        private void BtnDrawing_Click(object sender, EventArgs e)
        {
            // ASCII - рисунок
            string drawing =
                   @"                   ,%%%," + "\n" +
                   @"                 ,%%%` %==--" + "\n" +
                   @"                ,%%`( '|" + "\n" +
                   @"               ,%%@ /\_/" + "\n" +
                   @"     ,%.-""""""-- %%% ""@@__" + "\n" +
                   @"    %%/             |__`\" + "\n" +
                   @"   .%'\     |   \   /  //" + "\n" +
                   @"   ,%' >   .'----\ |  [/" + "\n" +
                   @"      < <<`       ||" + "\n" +
                   @"       `\\\       ||" + "\n" +
                   @"         )\\      )\" + "\n" +
                   @" ^^^^^^^^""""""^^^^^^""""^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";

            // изменение цвета объекта LblDrawing
            LblDrawing.BackColor = Color.Silver;

            // вывод текста
            LblDrawing.Text = drawing;

            // запуск таймера
            TmrDrawing.Enabled = true;
        }

        // окончание работы таймера TmrDrawing
        private void TmrDrawing_Tick(object sender, EventArgs e)
        {
            // отчистка рисунка
            LblDrawing.Text = "";

            // изменение цвета объекта LblDrawing
            LblDrawing.BackColor = Color.Gray;
        }

        // нажатие на кнопку BtnQuit
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            // выход из приложения
            Application.Exit();
        }

        // нажатие на кнопку BtnGreetings
        private void BtnGreetings_Click(object sender, EventArgs e)
        {
            // изменение цвета объекта LblGreeting
            LblGreetings.BackColor = Color.Silver;

            // вывод приветствия
            LblGreetings.Text = "Привет, Windows Forms!";

            // запуск таймера
            TmrGreetings.Enabled = true;
        }

        // окончание работы таймера TmrGreetings
        private void TmrGreetings_Tick(object sender, EventArgs e)
        {
            // удаление приветствия
            LblGreetings.Text = "";

            // изменение цвета объекта LblGreeting
            LblGreetings.BackColor = Color.Gray;
        }
    }
}
