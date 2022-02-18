using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using MenuToolbarTabControls.Models;

namespace MenuToolbarTabControls.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public MainWindow() {
            InitializeComponent();

            // для корректной работы обработчик события Checked должен назначаться 
            // после создания всех элементов в конструкторе класса окна
            foreach (var item in SpRadiobuttons.Children) {
                RadioButton rb = item as RadioButton;
                // пропускаем элементы, не являющиеся радиокнопками
                // (для перестраховки)
                if (rb == null) continue;

                // для радиокнопок назначим обработчик события Checked
                rb.Checked += RBs_Checked;

                // Если радиокнопка отмечена - вызываем обработчик для отображения
                // соответствующего текста в текстблоке tbRbChoose 
                if (rb.IsChecked == true) RBs_Checked(rb, null);
            } // foreach
       } // MainWindow


        // Обработчик выбора в списке планшетов - выбранный планшет отобразим
        // в элементе TextBlock ниже списка
        private void lbTablets_Selected(object sender, SelectionChangedEventArgs e) {
            Tablet t = (Tablet)(e.OriginalSource as ListBox).SelectedItem;
            TbChoose.Text = t.Title;
        } // lbTablets_Selected

        // Добавление вкладки - обработчик команды кнопки, делается только 
        // один раз т.к. кнопка запрещается после создания вкладки
        private void btnAddTab_Click(object sender, RoutedEventArgs e) {
            CreateTab();  // создать вкладку

            // запрет выполнения команды от кнопки
            (sender as Button).IsEnabled = false;
        } // btnAddTab_Click


        // Добавление вкладки - обработчик команды меню, делается только 
        // один раз т.к. команда меню запрещается после создания вкладки
        private void AddTab_Menu(object sender, RoutedEventArgs e) {
            CreateTab();  // создать вкладку

            // запрет выполнения команды от меню
            (sender as MenuItem).IsEnabled = false;
        } // AddTab_Menu


        // Выполнение команды меню - создание вкладки. Выполнение команды
        // возможно только один раз т.к. команда меню запрещается после 
        // создания вкладки
        private void AddTab_ContextMenuClick(object sender, RoutedEventArgs e) {
            CreateTab();  // создать вкладку

            // запрет выполнения команды от кнопки
            (sender as MenuItem).IsEnabled = false;
        } // AddTab_ContextMenuClick

        // Создание вкладки - отдельный метод, т.к. он будет вызываться 
        // и из меню и по кнопке
        private void CreateTab() {
            // формируем содержимое вкладки
            ListBox notebooks = new ListBox();

            notebooks.Items.Add("Macbook Pro");
            notebooks.Items.Add("HP Probook 450 G0");
            notebooks.Items.Add("HP Pavilion 15gr");
            notebooks.Items.Add("ASUS K56e");
            notebooks.Items.Add("Dell Latitude 1350");
            notebooks.Items.Add("Acer TravelMate TM-1556");

            // добавить вкладку в TabControl TbcGoods
            TabItem tabItem = new TabItem {
                Header = new TextBlock { Text = "Ноутбуки" }, // заголовок вкладки
                Content = notebooks                         // контент вкладки
            };

            // обработчик выбора элемента в ListBox
            notebooks.SelectionChanged += (sender, e) => 
                MessageBox.Show($"Выбор ноутбука выполнен: {e.AddedItems[0]}");
            
            // собственно добавление новой вкладки
            TbcGoods.Items.Add(tabItem);
        } // CreateTab


        // Завершение приложения - команда меню
        private void Exit_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        } // Exit_Click


        // Обработчик события Click для всех радиокнопок один
        // надпись радиокнопки копируем в текстовый блок tbRbChoose
        // (находится под груп-боксом  с радиокнопками)     
        private void RBs_Checked(object sender, RoutedEventArgs e) {
            RadioButton rb = sender as RadioButton;
            TbRbChoose.Text = rb.Content.ToString();
        } // rb_Click


        // Удаление вкладки из коллекции вкладок:
        // Удаляем только вкладки, созданные в программе т.е. вкладки
        // с индексами больше 1 
        private void RemoveTab_Menu(object sender, RoutedEventArgs e) {
            // Если вкладок 2 или меньше - нечего удалять, выходим из обработчика 
            if (TbcGoods.Items.Count <= 2) return;

            // удаление вкладки по номеру ее позиции в коллекции,
            // т.е. по индексу
            TbcGoods.Items.RemoveAt(TbcGoods.Items.Count - 1);
        } // RemoveTab_Menu

        // Обработчик пункта меню New
        private void New_Menu(object sender, RoutedEventArgs e) {
            TbStatusBar.Text = @"Выполнена команда меню ""Новый""";
        } // New_Menu


        // Обработчик пункта меню "Открыть"
        private void Open_Menu(object sender, RoutedEventArgs e) {
            TbStatusBar.Text = @"Выполнена команда меню ""Открыть""";
        } // Open_Menu

        // Обработчик пункта меню и кнопки на панели инструментов "Сохранить как текст"
        private void SaveAsText_Menu(object sender, RoutedEventArgs e) {
            TbStatusBar.Text = @"Выполнена команда меню""Сохранить как текст""";
            
            TxbStatus.Background = new SolidColorBrush(Colors.Aquamarine);
            TxbStatus.Text = "Данные сохранены";
        } // SaveAsText_Menu

        private void Find_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Поиск выполнен");
        }

        private void Test_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("Проверка выполнен");
        }
    }
}
