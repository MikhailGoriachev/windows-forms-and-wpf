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

namespace CommandDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // используется при выполнении команд
        private int _counter = 0;

        public MainWindow() {
            InitializeComponent();
        } // MainWindow

        // выполнение команды, назначенной на кнопку BtnCommand
        private void CommandBinding_Executer(object sender, ExecutedRoutedEventArgs e) {
            TxbInfo.Text += $"{++_counter}. Пример выполнения команды\n";
        } // CommandBinding_Executer

        // Выполнение стандартной команды Help - можно просто воспользоваться
        // существующей командой, не выполнять что-нибудь свое - но это неправильно
        private void WindowBinding_Executer(object sender, ExecutedRoutedEventArgs e) {
            TxbRoute.Text += $"Маршрутизация:\nИсточник: {sender}\nЦель команды: {e.Source}\n\n";
        } // WindowBinding_Executer

        // Выполнение команды "Выход"
        private void Exit_Executer(object sender, ExecutedRoutedEventArgs e) =>
            Application.Current.Shutdown();

        // обработчик события
        // очистка элементов отображения в интерфейсе 
        private void ClearItems(object sender, RoutedEventArgs e) =>
            TxbInfo.Text = TxbRoute.Text = EdText.Text = "";

        // обработчик команды
        // очистка элементов отображения в интерфейсе
        private void Clear_Executed(object sender, ExecutedRoutedEventArgs e) =>
            TxbRoute.Text = TxbInfo.Text = EdText.Text = "";

        // обработчик команды
        // заполенение текст-бокса текстом
        private void Fill_Executer(object sender, ExecutedRoutedEventArgs e) {
            EdText.Text += "Gwynne says that BFR is still on track for human trips to Mars in 2024. " +
                          "Source Raising funds slowly and as-needed. This will continue. Very picky " +
                          "about who invests in SpaceX. They MUST share their long term vision.\r\n";
        } // Fill_Executer

        // обработчик команды OnePlusOne
        private void OnePlusOne_Executer(object sender, ExecutedRoutedEventArgs e) =>
            TxbRoute.Text += $"{DateTime.Now:T}: Это будет два! 2 то есть. Иногда...\r\n";

        private void Test(object sender, RoutedEventArgs e) =>
            MessageBox.Show($"{DateTime.Now:T}: Это тест, и клик и команда",
                "К сведению", MessageBoxButton.OK, MessageBoxImage.Information);
    } // class MainWindow
}
