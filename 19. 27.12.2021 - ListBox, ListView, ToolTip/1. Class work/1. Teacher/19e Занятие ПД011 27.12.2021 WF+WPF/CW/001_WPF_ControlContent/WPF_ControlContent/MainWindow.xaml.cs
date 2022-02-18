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

namespace WPF_ControlContent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button _btnInner;  // для реализации вложенной кнопки

        public MainWindow() {
            InitializeComponent();
        } // MainWindow


        // По щелчку задать новый контент для кнопки - приемника, btnRec 
        private void btnDo_Click(object sender, RoutedEventArgs e) {
            BtnRec.Content = $"Новое значение: {100d*(new Random()).NextDouble():f3}";
        } // btnDo_Click


        // Программное создание/удаление вложенной кнопки
        private void btnChangeContent_Click(object sender, RoutedEventArgs e) {
            // Если вложенной кнопки нет - создать вложенную кнопку
            if (_btnInner == null) {
                _btnInner = new Button();
                // Обработчик клика кнопки - удлалить кнопку и запрет ее создания
                // при обработке клика, но т.к. события в WPF маршрутизируемые
                // то будет вызван обработчик контейнера, хранящего вложенную кнопку
                // Что бы этого избежать, прервем маршрут обработчика - установив
                // свойство Handled параметров события в true
                _btnInner.Click += (s, r) => {
                    // задать контент внешней кнопки
                    BtnChangeContent.Content = "Создать вложенную кнопку";

                    // удалить вложенную кнопку
                    _btnInner = null;

                    // прервать путь прохождения события - т.к. вся логика
                    // обработки выполнена вложенной кнопкой
                    r.Handled = true;  
                };
            } // if

            // Если кнопка создана - заменить контент кнопки btnChangeContet
            // вложенной кнопкой
            if (_btnInner != null) { 
                _btnInner.Content = "Удалить вложенную кнопку";
                _btnInner.Height = 30;
                BtnChangeContent.Content = _btnInner;
            } // if

        } // btnChangeContent_Click

        // Выход из приложения
        private void btnExit_Click(object sender, RoutedEventArgs e) =>
            Application.Current.Shutdown();


        // программное создание контейнера с элементами интерфейса и размещение его
        // в кнопке:
        // 1. Создать контейнер
        // 2. Заполнить контейнер
        // 3. Назначить контейнер в качестве элемента контента интерфейса (т.е. 
        //    присвоить созданный контейнер свойству Content кнопки)
        private void btnChangeContainer_Click(object sender, RoutedEventArgs e) {
            // создание контейнера
            StackPanel stack = new StackPanel();   

            // заполнение контейнера
            stack.Children.Add(new TextBlock { Text = "Автоуправление двигателем" });

            stack.Children.Add(new Button {
                Content = "Без корректировок", Background = Brushes.CornflowerBlue,
                Margin = new Thickness(10), Height = 30,
            });

            stack.Children.Add(new Button {
                Content = "С корректировками", Background = Brushes.LemonChiffon,
                Margin = new Thickness(10), Height = 30
            });

            // назначить новый контейнер для контента кнопки
            BtnContainer.Content = stack;
        } // btnChangeContainer_Click

        private void btnNextWindow_Click(object sender, RoutedEventArgs e) {
            WinCheckBoxesRadioButtons win = new WinCheckBoxesRadioButtons();
            win.ShowDialog();
        } // btnNextWindow_Click 
    } // class MainWindow
}
