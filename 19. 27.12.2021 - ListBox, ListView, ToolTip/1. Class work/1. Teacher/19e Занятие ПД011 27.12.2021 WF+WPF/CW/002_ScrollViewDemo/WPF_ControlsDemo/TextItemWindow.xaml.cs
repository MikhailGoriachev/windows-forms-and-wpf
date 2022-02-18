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

namespace WPF_ControlsDemo
{
    /// <summary>
    /// Логика взаимодействия для TextItemWindow.xaml
    /// </summary>
    public partial class TextItemWindow : Window
    {
        public TextItemWindow() {
            InitializeComponent();
        }

        // Обработка щелчка правой кнопки мышки по TextBlock - выделение первых
        // 50 символов текста в TextBox, передача фокуса ввода в этот TextBox
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.RightButton != MouseButtonState.Pressed)
                return;

            TxtBox.SelectionBrush = Brushes.DarkGreen;  // цвет выделения текста
            TxtBox.SelectionStart = 0;                 // начало области выделения 
            TxtBox.SelectionLength = 50;               // длина области выделения
            TxtBox.Focus();                            // передать фокус ввода
            
            // прервать путь распространения события
            e.Handled = true;    
        } // TextBlock_MouseDown
    }
}
