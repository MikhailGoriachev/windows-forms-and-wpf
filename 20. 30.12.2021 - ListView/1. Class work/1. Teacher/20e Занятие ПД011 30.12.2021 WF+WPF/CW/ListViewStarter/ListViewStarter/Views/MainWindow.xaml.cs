using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ListViewStarter.Models;

namespace ListViewStarter.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        } // MainWindow


        // Завершить работу приложения
        private void Exit_Click(object sender, RoutedEventArgs e) {
            Close();
        } // Exit_Click


        #region Изменение цвета надписи на кнопке при перемещении курсора мыши на кнопку
        private void Button_MouseEnter(object sender, MouseEventArgs e){
            Button btn = e.OriginalSource as Button;
            btn.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        } // Button_MouseEnter

        private void Button_MouseLeave(object sender, MouseEventArgs e) {
            Button btn = e.OriginalSource as Button;
            btn.Foreground = new SolidColorBrush(Colors.White);
        } // Button_MouseLeave
        #endregion


        // Открыть окно со сведениями о приложении и разработчике
        private void About_Click(object sender, RoutedEventArgs e) {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        } // About_Click


        // Обработчик выбора в ComboBox - открытие окна для вычисления параметров 
        // выбранного типа объемного тела
        private void BodyType_Selected(object sender, RoutedEventArgs e) {
            ComboBox comboBox = e.OriginalSource as ComboBox;
            BodyWindow bodyWindow;   // ссылка на окно вычисления параметров

            switch (comboBox.Items[comboBox.SelectedIndex]) {
                // по умолчанию создаем окно для работы с усеченным конусом
                default:
                    bodyWindow = new BodyWindow();
                    break;
                case "Цилиндр":
                    bodyWindow = new BodyWindow(new Cylinder());
                    break;
                case "Сфера":
                    bodyWindow = new BodyWindow(new Sphere());
                    break;
                case "Прямоугольный параллелепипед":
                    bodyWindow = new BodyWindow(new Parallelepiped());
                    break;
            } // switch

            // отобразить окно
            bodyWindow.ShowDialog();
        } // BodyType_Selected


        // Обработка клика по кнопке "Список фигур"
        private void BodyList_Click(object sender, RoutedEventArgs e) {
            BodyListWindow bodyListWindow = new BodyListWindow();
            bodyListWindow.ShowDialog();
        } // BodyList_Click
    } // class MainWindow
}
