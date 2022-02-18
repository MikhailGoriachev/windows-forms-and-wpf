﻿using Home_Work_Collection.Application;    // подключение главного класса приложения 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // установка заголовка окна 
            Console.Title = "Домашнее задание на 13.10.2021";

            // объект App
            App app = new App();

            // запуск меню приложения 
            app.Task1();

            // возвращение исходного цвета 
            Console.ResetColor();
        }
    }
}
