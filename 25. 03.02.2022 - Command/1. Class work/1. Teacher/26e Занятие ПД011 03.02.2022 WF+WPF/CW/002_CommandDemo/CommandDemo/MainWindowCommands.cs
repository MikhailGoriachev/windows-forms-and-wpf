using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDemo
{
    // Класс для создания команд - одной или нескольких
    public class MainWindowCommands
    {
        // В классе можно объявить несколько команд
        
        // свойство - команда Exit
        public static RoutedCommand Exit { get; set; }

        // свойство - команда Clear
        public static RoutedCommand Clear { get; set; }

        // свойство - команда Fill
        public static RoutedCommand Fill { get; set; }

        // свойство - команда OnePlusOne
        public static RoutedCommand OnePlusOne { get; set; }

        // статический конструктор - для привязки команд,
        // т.е. для назначения им исполнителей
        static MainWindowCommands() {
            // привязка команды Exit
            Exit = new RoutedCommand("Exit", typeof(MainWindow));

            // привязка команды Clear
            Clear = new RoutedCommand("Clear", typeof(MainWindow));

            // привязка команды Fill
            Fill = new RoutedCommand("Fill", typeof(MainWindow));

            // привязка команды OnePlusOne
            OnePlusOne = new RoutedCommand("OnePlusOne", typeof(MainWindow));
        } // MainWindowCommands
    } // class MainWindowCommands
}
