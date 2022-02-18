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

namespace EventsWPF_2
{
    /// <summary>
    /// События клавиатуры 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        } // MainWindow

        // событие нажатия клавиши (всплывающее) для текстового ввода - TextBox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TxbKeyInfo1.Text += $"{e.Key} ";

            // вывод модификатора нажатой клавиши при помощи KeyboardDevice
            switch (e.KeyboardDevice.Modifiers) {
                case ModifierKeys.Alt:
                    TxbKeyInfo1.Text += " {Alt} ";
                    break;
                case ModifierKeys.Control:
                    TxbKeyInfo1.Text += " {Ctrl} ";
                    break;
                case ModifierKeys.Shift:
                    TxbKeyInfo1.Text += " {Shift} ";
                    break;
                case ModifierKeys.Windows:
                    TxbKeyInfo1.Text += " {Win} ";
                    break;
            } // switch

            TxbKeyInfo2.Text += $"|{e.SystemKey}| ";
        } // TextBox_KeyDown


        // обработка туннелированного события клавиатуры - получение текста
        private void TextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            TxbKeyInfo3.Text += e.Text;
        } // TextBox_TextInput

        // ------------------------------------- начало -------------------------------

        // Для валидации ввода нам надо использовать обработчики для двух событий - PreviewKeyDown и
        // PreviewTextInput. Дело в том, что нажатия не всех клавиш PreviewTextInput обрабатывает.
        // Например, нажатие на клавишу пробела не обрабтывается. Поэтому также применяется обработка
        // и PreviewKeyDown.

        // блок текстовой валидации, пропускает только правильные телефонные номера
        // т.е. допустимые символы - цифры, минус
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            // пробуем преобразовать текст в число
            // не удачно - прерываем маршрут события
            // if (!int.TryParse(e.Text, out int temp) && e.Text != "-") e.Handled = true;
            e.Handled = !int.TryParse(e.Text, out int temp) && e.Text != "-";
        } // TextBox_PreviewTextInput

        // дополнительная проверка - на пробел. Если нажатая клавиша - пробел, тоже
        // прерываем путь события
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e) {
            e.Handled = e.Key == Key.Space;
        } // TextBox_PreviewKeyDown
        // ------------------------------------- конец  -------------------------------
    }
}
