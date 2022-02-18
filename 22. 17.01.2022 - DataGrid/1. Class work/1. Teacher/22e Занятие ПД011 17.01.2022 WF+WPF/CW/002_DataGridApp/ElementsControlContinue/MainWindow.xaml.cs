using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml.Serialization;

// для стандартных диалогов, можно использовать после установки NuGet
// System.Windows.Interactivity.WPF
using Microsoft.Win32;      

namespace ElementsControlContinue
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // XML сериализатор
        private XmlSerializer _formatter;
        // Имя файла
        private const string FileName = @"...\...\buses.dat";

        // коллекция данных для обработки - список автобусов
        private List<DataBus> _buses;


        public MainWindow() {
            InitializeComponent();
            _buses = new List<DataBus>();

            // чтение данных из XML-файла
            // _formatter = new XmlSerializer(typeof(List<DataBus>));
            // _buses = LoadData();
            Debug.WriteLine($"MainWindow: загружено элементов {_buses.Count} ");

            // привязка таблицы к списку автобусов
            // dataGridMain.ItemsSource = _buses;

            Debug.WriteLine($"MainWindow: {StatusBar.Background}");

        } // MainWindow


        // Выход из приложения
        private void Exit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        } // Exit_Click


        // Окно "О программе"
        private void aboutWinShow_Click(object sender, RoutedEventArgs e) {
            AboutWindow win = new AboutWindow();
            win.ShowDialog();
        } // aboutWinShow_Click


        // загрузка данных из XML-файла
        // если файл данных найден, то возвращаем список, иначе - возвращаем null
        private List<DataBus> LoadData() {
            List<DataBus> temp = null;

            if (File.Exists(FileName)) {
                using (StreamReader sr = new StreamReader(FileName, Encoding.UTF8)) {
                    temp = (List<DataBus>)_formatter.Deserialize(sr);
                } // using
            } // if

            return temp;
        } // LoadData


        // сохранить коллекцию автобусов в XML-файле после закрытия окна
        private void Window_Closed(object sender, EventArgs e) {
            
            using (StreamWriter sw = new StreamWriter(FileName, false, Encoding.UTF8)) {
                _formatter.Serialize(sw, _buses);
            } // using
        } // Window_Closed


        // Удаление автобуса - назначим этот обработчик и позициям главного и
        // контекстного меню, и кнопке панели инструментов  
        private void Remove_Click(object sender, RoutedEventArgs e) {
            
            // Если нет выбранного элемента - молча уходим
            if (dataGridMain.SelectedItem == null) return;

            // Получить выбранный в таблице аавтобус, удалить первое
            // вхождение этого автобуса из списка и, следовательно, из таблмцы
            DataBus bus = (DataBus)dataGridMain.SelectedItem;
            _buses.Remove(bus);

            // перезапуск привязки таблицы к коллекции данных
            dataGridMain.ItemsSource = null;
            dataGridMain.ItemsSource = _buses;
        } // Remove_Click


        // Вывод еще одного окна с демонстрацией элементов управления
        private void Elements_Click(object sender, RoutedEventArgs e) {
            ElementsWin win = new ElementsWin();
            win.ShowDialog(); 
        } // Elements_Click

        // Открытие файла
        private void Open_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                Multiselect      = false,
                Title            = "Файл данных для загрузки",
                Filter           = "Файлы XML (*.xml)|*.xml|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FilterIndex      = 0,
                InitialDirectory = @"c:\"
            };

            StatusBar.Text = (ofd.ShowDialog() == true)
                ? ofd.FileName         // файл выбран
                : "Файл не выбран";    // файл не выбран
        } // Open_Click
    } // class MainWindow : Window
}
