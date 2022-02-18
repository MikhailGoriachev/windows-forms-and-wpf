using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_CustomCommand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // назначить на кнопку созданную нами команду, передавать команде
            // методы для проверки возможности выполнения команды и полезную работу команды 
            Button1.Command = new CustomCommand(CommandExecute, CanCommandExecute);
        }

        private void CommandExecute(object parameter)
        {
            MessageBox.Show("Привет "  + Convert.ToString(parameter));
        }

        private bool CanCommandExecute(object parameter) => TxbExample.Text != string.Empty;
        
    }
}
