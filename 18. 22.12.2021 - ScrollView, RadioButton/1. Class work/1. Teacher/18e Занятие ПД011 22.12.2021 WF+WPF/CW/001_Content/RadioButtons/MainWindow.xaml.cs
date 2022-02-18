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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioButtons
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();

            // некоторые настройки окна при старте приложения
            ResizeMode = ResizeMode.NoResize;                           // запрет изменения размера окна
            WindowStartupLocation = WindowStartupLocation.CenterScreen; // окно позиционируем по центру экрана
        } // MainWindow

        // опросить состояние радиокнопок окна
        private void Pending_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(
                $"Состояние радиокнопок:\n" +
                $"-----------------------------------\n" +
                $"RadioButton1: {Rb1.IsChecked}\n" +
                $"RadioButton2: {Rb2.IsChecked}\n" +
                $"RadioButton3: {Rb3.IsChecked}\n" +
                $"RadioButton4: {Rb4.IsChecked}\n" +
                $"RadioButton5: {Rb5.IsChecked}\n" +
                $"-----------------------------------\n", "Информация", MessageBoxButton.OK,
                MessageBoxImage.Information);
        } // Pending_Click

        // Обработчик установки радиокнопки Rb1: светло-зеленый фон окна
        private void Rb1_Checked(object sender, RoutedEventArgs e) =>
            Background = new SolidColorBrush(Colors.LightSeaGreen);

        // Обработчик установки радиокнопки Rb2: исходный фон окна
        private void Rb2_Checked(object sender, RoutedEventArgs e) =>
            Background = new SolidColorBrush(Colors.AliceBlue);


        // Обработичк клика по радиокнопке Rb3: загрузка Cat1.jpg в Image
        private void Rb3_Checked(object sender, RoutedEventArgs e) =>
            ImgCat.Source = BuildImageSource("Cat1.jpg");

        // Обработичк клика по радиокнопке Rb4: загрузка Cat2.jpg в Image
        private void Rb4_Checked(object sender, RoutedEventArgs e) =>
            ImgCat.Source = BuildImageSource("Cat2.jpg");

        // Обработичк клика по радиокнопке Rb5: загрузка Cat3.jpg в Image
        private void Rb5_Checked(object sender, RoutedEventArgs e) => 
            ImgCat.Source = BuildImageSource("Cat3.jpg");


        // формирование Uri из имени файла, файлы изображений в папке проекта
        // Images, действие при построении для каждого файла изображения - Resource
        // формат Uri для имени файла в ресурсах проекта
        // pack://application:,,,/Папка/файл.ext, так, для нашего проекта это будет
        // pack://application:,,,/Images/Cat0.jpg
        private ImageSource BuildImageSource(string fileName) {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri($"pack://application:,,,/Images/{fileName}");
            image.EndInit();

            return image;
        } // BuildImageSource
    }
}
