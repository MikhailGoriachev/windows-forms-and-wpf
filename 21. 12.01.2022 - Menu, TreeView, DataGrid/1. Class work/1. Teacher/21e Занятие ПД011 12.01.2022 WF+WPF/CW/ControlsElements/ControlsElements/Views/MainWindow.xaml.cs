using System.Windows;
using System.Windows.Controls;
using ControlsElements.Models;

namespace ControlsElements.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();

            // Убираем сообщения, размещенные для удобства просмотра при разработке
            TbSbMain.Text = TbSbAlter.Text = TbSbTablets.Text = "";
        } // MainWindow
        

        #region TreeView

        // Обработчик события "Открыть узел"
        private void DoExpanded(object sender, RoutedEventArgs e) {
            TreeViewItem tvItem = sender as TreeViewItem;
            TbSbMain.Text = $"Развернут узел {tvItem?.Header}";
            
            // останавливаем распространнение события
            e.Handled = true;
        } // DoExpanded


        // Обработчик события "Выбрать элемент"
        private void DoSelected(object sender, RoutedEventArgs e) {
            TreeViewItem tvItem = sender as TreeViewItem;
            TbSbAlter.Text = $"Выбран узел {tvItem?.Header}";

            // останавливаем распространнение события
            e.Handled = true;
        } // DoSelected      

        #endregion


        #region DataGreed
        // Обработчик выбора в DataGrid
        private void DgMain_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            Tablet tablet = DgMain.SelectedItem as Tablet;
            TbSbTablets.Text = $"{tablet}";

            // останавливаем распространнение события
            e.Handled = true;
        } // DgMain_SelectionChanged
        #endregion

    } // class MainWindow
}
