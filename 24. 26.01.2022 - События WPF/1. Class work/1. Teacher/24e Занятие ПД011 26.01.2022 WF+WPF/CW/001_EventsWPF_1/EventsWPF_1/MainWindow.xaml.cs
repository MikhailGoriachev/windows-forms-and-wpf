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

namespace EventsWPF_1
{
    /*
     
    Для элементов управления в WPF определено большое количество событий, которые 
    условно можно разделить на несколько групп:
       
    События клавиатуры
    События мыши
    События стилуса
    События сенсорного экрана/мультитач
    События жизненного цикла

    Маршрутизация событий
    Модель событий WPF отличается от событий WinForms не только декларативным подключением. 
    События, возникнув на одном элементе, могут обрабатываться на другом. События могут 
    подниматься и опускаться по дереву элементов.
       
    Так, маршрутизируемые события делятся на три вида:
       
    Прямые (direct events) - они возникают и отрабытывают на одном элементе и никуда дальше 
    не передаются. Действуют как обычные события.
       
    Поднимающиеся (bubbling events) - возникают на одном элементе, а потом передаются 
    дальше к родителю - элементу-контейнеру и далее, пока не достигнет наивысшего родителя 
    в дереве элементов.
       
    Опускающиеся, туннельные (tunneling events) - начинает отрабатывать в корневом элементе 
    окна приложения и идет далее по вложенным элементам, пока не достигнет элемента, 
    вызвавшего это событие.
    
    Все маршрутизируемые события используют класс RoutedEventArgs (или его наследников), 
    который представляет доступ к следующим свойствам:
    Source:         элемент логического дерева, являющийся источником события.
    OriginalSource: элемент визуального дерева, являющийся источником события. Обычно 
                    то же самое, что и Source 
    RoutedEvent:    представляет имя события 
    Handled:        если это свойство установлено в True, событие не будет подниматься 
                    и опускаться, а ограничится непосредственным источником.
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // программное добавление обработчика событий кнопки
            BtnFirst.Click += btnFirst_ClickSW;

            // программное назначение обработчика прикрепленных событий
            // в д.с. события от радиокнопок прикрепляются к родительскому
            // элементу - StackPanel
            // stpVariants.AddHandler(RadioButton.CheckedEvent, new RoutedEventHandler(RadioButton_Checked)); 
        } // MainWindow

        // обработчик события кнопки, назначенный программно
        private void btnFirst_ClickSW(object sender, RoutedEventArgs e) {
            TbxInfo1.Text = "Из обработчка, назначенного программно";
        } // btnFirst_ClickSW

        // обработчик события той же кнопки, назначенный декларативно (в разметке)
        private void btnFirst_Click(object sender, RoutedEventArgs e) {
            TbxInfo2.Text = "Из обработчка, назначенного декларативно";
        } // btnFirst_Click

        // поднимающееся/всплывающее событие, назначено на правую кнопку мышки
        private void Control_MouseDown(object sender, MouseButtonEventArgs e) {
            TbxInfo3.Text += $"sender: {sender}\nsource: {e.Source}\n\n";

            // прервать путь события на кнопке
            // if (sender is Button) e.Handled = true;
        } // Control_MouseDown


        // Сервисный обработчик, когда курсор покидает текст-блок tbxInfo3, то
        // текст-блок очищается
        private void tbxInfo3_MouseLeave(object sender, MouseEventArgs e) {
            TbxInfo3.Text = "";
            e.Handled = true;
        } // tbxInfo3_MouseLeave


        // Обработчик прикрепляемого события, т.е. события от элемента, но обработанного
        // в родительском контейнере
        // Один обработчик для всех радиокнопок
        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            RadioButton rb = e.Source as RadioButton;
            TxbInfo4.Text = $"Выбрана радиокнопка \"{rb.Content}\"";
        } // RadioButton_Checked

        // прямой обработчик события на StackPanel
        private void SP_MousDown(object sender, MouseButtonEventArgs e) {
            TbxInfo3.Text += $"sender: {sender}\nsource: {e.Source}";
            e.Handled = true;
        } // SP_MousDown
    } // class MainWindow
}
