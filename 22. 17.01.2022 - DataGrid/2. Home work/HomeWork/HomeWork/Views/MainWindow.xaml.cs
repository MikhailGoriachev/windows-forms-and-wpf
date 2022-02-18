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
using HomeWork.Models.Task1;        // модели

namespace HomeWork.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // конструктор по умолчанию
        public MainWindow()
        {
            InitializeComponent();
        }


        // загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // заполнение ListView с стюардессами
            DgdStewardess.ItemsSource = new[] {
                new Stewardess { LastName = "Зимина",       FirstName = "Рада",         Patronymic = "Юхимовна",        ColorUniform = "Синий",     AmountClients = 13, AmountFlights = 9},
                new Stewardess { LastName = "Иванив",       FirstName = "Янина",        Patronymic = "Платоновна",      ColorUniform = "Чёрный",    AmountClients = 18, AmountFlights = 8},
                new Stewardess { LastName = "Игнатьева",    FirstName = "Юнона",        Patronymic = "Валериевна",      ColorUniform = "Синий",     AmountClients = 17, AmountFlights = 8},
                new Stewardess { LastName = "Субботина",    FirstName = "Федосья",      Patronymic = "Викторовна",      ColorUniform = "Чёрный",    AmountClients = 32, AmountFlights = 8},
                new Stewardess { LastName = "Крылова",      FirstName = "Евгения",      Patronymic = "Валериевна",      ColorUniform = "Синий",     AmountClients = 24, AmountFlights = 9},
                new Stewardess { LastName = "Петровска",    FirstName = "Анна",         Patronymic = "Ивановна",        ColorUniform = "Чёрный",    AmountClients = 22, AmountFlights = 6},
                new Stewardess { LastName = "Иванова",      FirstName = "Оксана",       Patronymic = "Петровна",        ColorUniform = "Чёрный",    AmountClients = 29, AmountFlights = 6},
                new Stewardess { LastName = "Волкова",      FirstName = "Капитолина",   Patronymic = "Станиславовна",   ColorUniform = "Белый",     AmountClients = 15, AmountFlights = 6},
                new Stewardess { LastName = "Филатова",     FirstName = "Харитина",     Patronymic = "Богдановна",      ColorUniform = "Белый",     AmountClients = 25, AmountFlights = 9},
                new Stewardess { LastName = "Кузьмина",     FirstName = "Розалина",     Patronymic = "Борисовна",       ColorUniform = "Синий",     AmountClients = 23, AmountFlights = 4},
                new Stewardess { LastName = "Ковалёва",     FirstName = "Олеся",        Patronymic = "Дмитриевна",      ColorUniform = "Синий",     AmountClients = 22, AmountFlights = 9},
                new Stewardess { LastName = "Костина",      FirstName = "Шушана",       Patronymic = "Виталиевна",      ColorUniform = "Белый",     AmountClients = 21, AmountFlights = 4}
            };

        }


        #region Меню


        // запуск окна "Ремонтная мастерская"
        private void RepairShop_Click(object sender, RoutedEventArgs e) => new DataGridRepairShopWindow().ShowDialog();


        // запуск окна "О программе"
        private void ProgramInfo_Click(object sender, RoutedEventArgs e) => new ProgramInfoWindow().ShowDialog();


        // завершнение работы приложения
        private void Exit_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();



        #endregion
    }
}
