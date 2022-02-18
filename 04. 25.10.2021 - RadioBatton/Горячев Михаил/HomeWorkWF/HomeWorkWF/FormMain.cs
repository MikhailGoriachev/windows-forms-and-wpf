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
     * Задача 1. Разработайте приложение Windows Forms для вычислений 
     * параметров объемных геометрических фигур по выбору пользователя. 
     * Каждый расчет выполняется на собственной форме, открываемой в 
     * модальном режиме. Выбор формы – при помощи кнопочного меню.
     * По команде О программе кнопочного меню в отдельной форме выводить
     * в Label сведения о приложении и разработчике (фамилия, имя, 
     * группа). При помощи таймера реализуйте закрытие формы «О 
     * программе» через 10 секунд после открытия.
     * В формах фигур разместить строки ввода для параметров фигур, 
     * чек-боксы для задания вычисляемых параметров фигуры, изображение 
     * фигуры (фото в Paintbox, фото Вы без проблем найдете в интернете), 
     * собственно вычисление выполнять при клике на кнопку "Вычислить". 
     * Необходимо контролировать правильность ввода параметров, использовать
     * ErrorProvider. Используйте модели для вычислений.
     * Что именно вычислять для каждой фигуры:
     * •	площадь поверхности 
     * •	объем
     * •	масса 
     * Типы фигур для расчетов:
     * •	усеченный конус
     * •	сфера
     * •	цилиндр
     * •	прямоугольный параллелепипед
*/

namespace HomeWorkWF
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // запуск формы "О программе"
        private void BtnMenuInfo_Click(object sender, EventArgs e)
        {
            // создание формы
            Form form = new FormInfo();

            // запуск формы в модальном режиме
            form.ShowDialog();
        }

        // выбор пункта "Усёченный конус"
        private void BtnMenuConoid_Click(object sender, EventArgs e)
        {
            // создание формы
            Form form = new FormConoid();

            // запуск формы в модальном режиме
            form.ShowDialog();
        }

        // выбор пункта "Цилиндр"
        private void BtnMenuCylinder_Click(object sender, EventArgs e)
        {
            // создание формы
            Form form = new FormCylinder();

            // запуск формы в модальном режиме
            form.ShowDialog();
        }

        // выход из приложения
        private void BtnExit_Click(object sender, EventArgs e) => Application.Exit();

        // выбор пункта "Цилиндр"
        private void BtnMenuSphere_Click(object sender, EventArgs e)
        {
            // создание формы
            Form form = new FormSphere();

            // запуск формы в модальном режиме
            form.ShowDialog();
        }

        // выбор пункта "Прямоугольный параллелепипед"
        private void BtnMenuRectParall_Click(object sender, EventArgs e)
        {
            // создание формы
            Form form = new FormParallelepiped();

            // запуск формы в модальном режиме
            form.ShowDialog();
        }
    }
}
