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
using System.Windows.Shapes;

using HomeWork.Utilities;           // утилиты
using HomeWork.Models.Task2;        // модели

namespace HomeWork.Views.Task2
{
    /// <summary>
    /// Interaction logic for PeriodicalWindow.xaml
    /// </summary>
    public partial class PeriodicalWindow : Window
    {
        // обрабатываемый сотрудник
        private PeriodicalModel _periocical;

        public PeriodicalModel Periodical => _periocical;


        #region Конструкторы 


        // конструктор по умолчанию (Запуск формы в режиме создания)
        public PeriodicalWindow()
        {
            InitializeComponent();

            // получение подписки из ресурсов
            _periocical = Resources["PeriodicalRes"] as PeriodicalModel;

            // новый объект
            PeriodicalModel periodical = PeriodicalModel.GetPeriodical();

            // установка новых данных
            _periocical.FullName        = periodical.FullName;
            _periocical.Title           = periodical.Title;
            _periocical.Index           = periodical.Index;
            _periocical.Duration        = periodical.Duration;
            _periocical.DateSubscribe   = periodical.DateSubscribe;
            _periocical.Street          = periodical.Street;
            _periocical.Home            = periodical.Home;
            _periocical.Apartment       = periodical.Apartment;

            // установка значения в combo-box 
            CmbDuration.SelectedItem = _periocical.Duration;
        }


        // конструктор окна для запуска в режиме редактирования
        public PeriodicalWindow(PeriodicalModel periodical)
        {
            InitializeComponent();

            // получение подписки из ресурсов
            _periocical = Resources["PeriodicalRes"] as PeriodicalModel;

            // установка данных
            _periocical.FullName        = periodical.FullName;
            _periocical.Title           = periodical.Title;
            _periocical.Index           = periodical.Index;
            _periocical.Duration        = periodical.Duration;
            _periocical.DateSubscribe   = periodical.DateSubscribe;
            _periocical.Street          = periodical.Street;
            _periocical.Home            = periodical.Home;
            _periocical.Apartment       = periodical.Apartment;
            _periocical.TypeEdition     = periodical.TypeEdition;

            // установка значения в combo-box 
            CmbDuration.SelectedValue = _periocical.Duration;

            // установка заголовка
            LblHeader.Content = Title = "Редактирование подписки на периодическое издание";

            // установка надписи на кнопке
            BtnOk.Content = "Сохранить";
        }

        #endregion


        #region Методы

        // загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // подписка на события

            TbxFullName.TextChanged     += TextBox_TextChanged;
            TbxPatronymic.TextChanged   += TextBox_TextChanged;
            TbxStreet.TextChanged       += TextBox_TextChanged;
            TbxHome.TextChanged         += TextBox_TextChanged;
            TbxApartment.TextChanged    += TextBox_TextChanged;
            TbxType.TextChanged         += TextBox_TextChanged;
            TbxIndex.TextChanged        += TextBox_TextChanged;
        }


        // добавление/сохранение сотрудника
        private void BtnOk_Click(object sender, RoutedEventArgs e) => DialogResult = true;


        // обработка измений текста в полях ввода
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) =>
            BtnOk.IsEnabled = !string.IsNullOrWhiteSpace(TbxFullName.Text)
                           && !string.IsNullOrWhiteSpace(TbxPatronymic.Text)
                           && !string.IsNullOrWhiteSpace(TbxType.Text)
                           && !string.IsNullOrWhiteSpace(TbxStreet.Text)
                           && !string.IsNullOrWhiteSpace(TbxHome.Text)
                           && !string.IsNullOrWhiteSpace(TbxType.Text)
                           && !string.IsNullOrWhiteSpace(TbxIndex.Text)
                           && int.TryParse(TbxApartment.Text, out int i);


        // обработка ввода численных данных
        private void TbxApartment_PreviewTextInput(object sender, TextCompositionEventArgs e) =>
            e.Handled = !int.TryParse(e.Text, out int temp);


        // обработка нажатия клавиши
        private void TbxApartment_PreviewKeyDown(object sender, KeyEventArgs e) =>
            e.Handled = !(e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9 || e.Key == Key.Back);

        #endregion

    }
}
