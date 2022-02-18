using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ListViewStarter.Views
{
    /// <summary>
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow() {
            InitializeComponent();
        } // AboutWindow


        #region Изменение цвета надписи на кнопке при перемещении курсора мыши на кнопку
        private void Button_MouseEnter(object sender, MouseEventArgs e) {
            Button btn = sender as Button;
            btn.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        } // Button_MouseEnter

        private void Button_MouseLeave(object sender, MouseEventArgs e) {
            Button btn = sender as Button;
            btn.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        } // Button_MouseLeave
        #endregion
    } // class AboutWindow
}
