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

namespace WPF_ControlContent
{
    /// <summary>
    /// Логика взаимодействия для WinCheckBoxesRadioButtons.xaml
    /// </summary>
    public partial class WinCheckBoxesRadioButtons : Window
    {
        public WinCheckBoxesRadioButtons()
        {
            InitializeComponent();

            // Назначить ширину для панелей StackPanel, чтобы ширина не
            // менялась в динамике, при работе приложения 
            stackCheckBoxes.Width = stackRadiobuttons.Width = Width / 2;

            // Для того, чтобы приложение не падало при загрузке формы надо
            // назначать обрабочтик события Checked для радиокнопки программно,
            // при создании формы
            rbEng0.Checked += RadioButton_Checked;
            rbEng1.Checked += RadioButton_Checked;
            rbEng2.Checked += RadioButton_Checked;

            // Начальная установка текста - по выбранной по умолчанию
            // радиокнпоке (у нас в разметке выбрана кнопка rbEng0)
            tbEngines.Text = "Выбран двигатель: " + rbEng0.Content.ToString();

            /* 
             Пришлось назначать имена радиокнопкам, явно указывать радиокнопки
             в исходном тексте.
             Более правильно - просматривать все элементы контейнера и назначать
             обработчик события для радиокнопки, проверяя тип элемента в цикле
             */

            // Повторяем те же действия для всех других групп радиокнопок
            rbFuel0.Checked += RadioButton_Checked;
            rbFuel1.Checked += RadioButton_Checked;
            rbFuel2.Checked += RadioButton_Checked;
            tbFuels.Text = "Выбрано топливо: " + rbFuel0.Content.ToString();

            // назначение обработчика Checked для чек-боксов
            chBox1.Click += chBox_Click;
            chBox2.Click += chBox_Click;
            chBox3.Click += chBox_Click;

            // начальные состоянния чек-боксов
            tbBox1.Text = $"Состояние чекбокс1: {ConvertChBox(chBox1.IsChecked)}";
            tbBox2.Text = $"Состояние чекбокс2: {ConvertChBox(chBox2.IsChecked)}";
            tbBox3.Text = $"Состояние чекбокс3: {ConvertChBox(chBox3.IsChecked)}";

            ////////////////////////////////////////////////////////////////////////

            // Программное создание ToolTip для кнопки btnButton1
            // в этом toolTip будет заголовок и картинка
            ToolTip toolTip = new ToolTip();

            // собрать в панель элементы для ToolTip
            StackPanel stackToolTip = new StackPanel();
            stackToolTip.Children.Add(new TextBlock { Text = "Описание для кнопки", FontSize = 16 });
            stackToolTip.Children.Add(new Image { Source = new BitmapImage(new Uri("pack://application:,,,/Imgs/cat.jpg"))});

            // назначить эту панель ToolTip'у
            toolTip.Content = stackToolTip;
            toolTip.HorizontalContentAlignment = HorizontalAlignment.Left;
            toolTip.VerticalContentAlignment = VerticalAlignment.Stretch;
            toolTip.Width = 360;
            toolTip.Height = 240;

            // назначить ToolTip кнопке
            btnButon1.ToolTip = toolTip;
        }

        // обработчик радиокнопок - общий для всех групп
        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            RadioButton rb = (sender as RadioButton);
            if (rb.GroupName == "Engines")
                tbEngines.Text = "Выбран двигатель: " + rb.Content.ToString();
            else
                tbFuels.Text = "Выбрано топливо: " + rb.Content.ToString();
        } // RadioButton_Checked

        // общий для всех чек-боксов обработчик событий
        // Checked   - вызывается при установке чек-бокса
        // Unchecked - вызывается при сбросе чек-бокса
        // Click     - вызывается и при установки и при сбросе чек-бокса 
        private void chBox_Click(object sender, RoutedEventArgs e) {
            CheckBox cb = (sender as CheckBox);

            if (cb == chBox1)
                tbBox1.Text = $"Состояние чекбокс1: {ConvertChBox(chBox1.IsChecked)}";
            else if (cb == chBox2)
                tbBox2.Text = $"Состояние чекбокс2: {ConvertChBox(chBox2.IsChecked)}";
            else
                tbBox3.Text = $"Состояние чекбокс3: {ConvertChBox(chBox3.IsChecked)}";
        } // chBox_Click

        // перекодирует состояение чек-бокса в строковый формат: установлен, не установлен, неопределено
        private string ConvertChBox(bool? state) {
            string result;
            // приходится явно сравнивать с true, false т.к. state имеет тип bool?
            // т.е. три значения (true, false, null)
            if (state == true)
                result = "установлен";
            else if (state == false)
                result = "не устанвлен";
            else
                result = "не определено";
            return result;
        } // ConvertChBox

        // запуск Popup-окна при входе мыши на кнопку btnButton2
        private void btnButon2_MouseEnter(object sender, MouseEventArgs e) =>popup1.IsOpen = true;

        // Переход на окно с демонстрацией элемента Expander
        private void btnButon2_Click(object sender, RoutedEventArgs e) {
            ExpandersGBs win = new ExpandersGBs();
            win.ShowDialog();
        } // btnButon2_Click

        // обработчик клика по кнопке во всплывающем окне
        private void ButtonFromPopup_Click(object sender, RoutedEventArgs e) => 
            MessageBox.Show("Событие обработано", "К сведению", 
            MessageBoxButton.OK, MessageBoxImage.Information);
    } // class WinCheckBoxesRadioButtons
}
