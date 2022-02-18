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
using System.IO;

namespace EventsWPF_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // заполнить текст-блок данными из текстового файла
            TxbSource.Text = File.ReadAllText(@"..\..\MainWindow.xaml", Encoding.UTF8);
            //  txbSource.Text = File.ReadAllText(@"..\..\MainWindow.html", Encoding.UTF8);
        } // MainWindow

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e) {
            Point p = e.GetPosition(this);
            TxbInfo.Text += $"Событие нажатие кнопки мыши - X: {p.X}  Y: {p.Y} {e.ChangedButton}\n";
            Title = $"События мыши и перетаскивание. Мышь в X: {p.X}; Y: {p.Y} {e.ChangedButton} {e.ButtonState}";
        } // Grid_MouseDown

        // всплывающее событие, перемещение на любых элементах маршрутизируется, всплывает
        // в этот обработчик, назначенный окну, верхнему элементу логического/визуального
        // дерева элементов
        private void Window_MouseMove(object sender, MouseEventArgs e)  {
            Point p = e.GetPosition(this);
            Title = $"События мыши и перетаскивание. Мышь в X: {p.X}; Y: {p.Y}";
        } // Window_MouseMove


        // начало перетаскивания
        private void txbSource_MouseDown(object sender, MouseButtonEventArgs e) {

            // если нажата не левая кнопка мышки - выход, нет перетаскивания
            if (e.LeftButton != MouseButtonState.Pressed) {
                e.Handled = true; 
                return;
            } // if

            DragDrop.DoDragDrop(TxbSource, TxbSource.Text, DragDropEffects.Copy);
        } // txbSource_MouseDown

        // завершение перетаскивания на текст-боксе, строке ввода
        private void edText_Drop(object sender, DragEventArgs e)  {
            EdText.Text = (string)e.Data.GetData(DataFormats.UnicodeText);
        } // edText_Drop


        // завершение перетаскивания на текст-блоке, блок отобржения текста
        private void txbDest_Drop(object sender, DragEventArgs e) {
            if (e.Data.GetFormats().Contains(DataFormats.FileDrop)) {
                var fileNames = (string[]) e.Data.GetData(DataFormats.FileDrop);
                if (fileNames != null) TxbDest.Text = File.ReadAllText(fileNames[0]);
            } else    
                TxbDest.Text = (string)e.Data.GetData(DataFormats.UnicodeText);
        } // txbDest_Drop

        // завершение перетаскивания на кнопке, не требуется приведение типа
        // т.к. Content для кнопки  объект
        private void btnDest_Drop(object sender, DragEventArgs e) {
            BtnDest.Content = e.Data.GetData(DataFormats.UnicodeText);
            // BtnDest.Content = e.Data.GetData(DataFormats.Html);
        }

        // событие получения фокуса
        private void edFocus_GotFocus(object sender, RoutedEventArgs e) {
            EdFocus.Background = Brushes.Chartreuse;
        }

        // событие утери фокуса
        private void edFocus_LostFocus(object sender, RoutedEventArgs e) {
            EdFocus.Background = Brushes.NavajoWhite;
        }

        // получение фокуса от клавиатуры
        private void edFocus_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) {
            EdFocus.Background = Brushes.LightBlue;
        }


        // программная передача фокуса
        private void btnDest_Click(object sender, RoutedEventArgs e) {
            EdFocus.Focus();
        }
    } // class MainWindow
}
