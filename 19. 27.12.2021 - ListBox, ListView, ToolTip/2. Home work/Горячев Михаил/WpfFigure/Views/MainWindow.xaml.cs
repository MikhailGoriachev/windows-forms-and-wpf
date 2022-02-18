using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/* 
 *    Задача 1. Разработайте приложение Windows Presentation Foundation для 
 *    вычислений параметров объемных тел по выбору пользователя. Все расчеты 
 *    выполняются в одном окне, открываемом в модальном режиме (все окна 
 *    приложения открываются модально). 
 *    
 *    Выбор типа тела и открытие окна расчетов
 *    – при помощи комбобокса главного окна (список вариантов комбобокса заполняйте
 *    в разметке). В кнопочном меню главного окна должны быть кнопки «Список фигур»,
 *    «О программе», «Выход».
 *    
 *    По кнопке «Список фигур» в отдельном окне выводить ListView, заполненный данными
 *    объемных тел (только текстовые данные, без указания материала, но с выводом 
 *    площади и объема) – по два экземпляра каждого типа тела. Заполнение ListView – 
 *    из ресурса ListView. 
 *    
 *    По кнопке «Выход» завершайте работу приложения.
 *    
 *    По кнопке «О программе» кнопочного меню в отдельном окне выводить в TextBlock 
 *    сведения о приложении и разработчике (фамилия, имя, группа). Используйте 
 *    форматирование текста.
 *    
 *    В окне вычисления параметров тел разместить строки ввода для параметров тел, 
 *    чек-боксы для задания вычисляемых параметров тела, элемент для изображения тела,
 *    элемент для изображения материала тела. Изображения выводить в Image, Вы без 
 *    проблем найдете изображения в интернете. При создании окна изменяйте названия 
 *    вводимых параметров, делайте невидимыми элементы ввода, не требующиеся для данного
 *    типа тела.
 *    
 *    Собственно вычисления выполнять при клике на кнопку «Вычислить». Необходимо 
 *    контролировать правильность ввода параметров. Используйте модели для вычислений.
 *    
 *    Что именно вычислять для каждой фигуры:
 *    •	площадь поверхности 
 *    •	объем
 *    •	масса 
 *    
 *    Типы фигур для расчетов:
 *    •	усеченный конус
 *    •	сфера
 *    •	цилиндр
 *    •	прямоугольный параллелепипед
 *    
 *    Виды материалов, из которых создаются фигуры (расширения номенклатуры материалов 
 *    не предвидится 😊):
 *    •	сталь (нержавеющая)
 *    •	медь
 *    •	водяной лед
 *    •	гранит
 *    
 *    Материал выбирайте при помощи набора радиокнопок, в Tooltip радиокнопки поместите 
 *    название материала, его плотность, изображение материала. В обработчике события 
 *    Checked обновляйте изображение материала в элементе интерфейса Image окна.
*/

namespace WpfFigure.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        // выход из приложения
        private void Exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();


        // запуск формы списка фигур
        private void ListFigure_Click(object sender, RoutedEventArgs e) => new ListFiguresWindow().ShowDialog();


        // запуск формы с информацией о программе
        private void ProgramInfo_Click(object sender, RoutedEventArgs e) => new ProgramInfoWindow().ShowDialog();


        // выбор фигуры
        private void CmbFigure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CmbFigure.SelectedValue)
            {
                // усеченный конус
                case "Усечённый конус":
                    new FigureWindow(FigureWindow.FigureWindowState.ConoidWindowState).ShowDialog();
                    break;
                // сфера
                case "Сфера": 
                    new FigureWindow(FigureWindow.FigureWindowState.SphereWindowState).ShowDialog();
                    break;
                // цилиндр
                case "Цилиндр":
                    new FigureWindow(FigureWindow.FigureWindowState.CylinderWindowState).ShowDialog();
                    break;
                // прямоугольный параллелепипед
                case "Прямоугольный параллелепипед":
                    new FigureWindow(FigureWindow.FigureWindowState.ParallelepipedWindowState).ShowDialog();
                    break;
                default:
                    break;
            }
        }

    }
}
