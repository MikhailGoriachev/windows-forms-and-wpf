﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train.Utilities
{
    // Класс Утилиты
    internal class Utils
    {
        // объект для генерации случайных значений
        public static Random rand = new Random();

        // генерация вещественного числа (min, max]
        public static double GetRand(double min, double max)
        {
            // если диапазон не корректен
            if (min.CompareTo(max) > 0 || max.CompareTo(min) < 0)
                throw new Exception("Utils.GetRand(double min, double max): минимум не может быть больше максимума");

            // число
            double num;

            // генерация числа
            do
            {
                num = rand.Next((int)min, (int)max - 1) + rand.NextDouble();
            } while (num.CompareTo(min) < 0 || num.CompareTo(max) > 0);

            return num;
        }

        // генерация целого числа (min, max]
        public static int GetRand(int min, int max)
        {
            // если диапазон не корректен
            if (min.CompareTo(max) > 0 || max.CompareTo(min) < 0)
                throw new Exception("Utils.GetRand(int min, int max): минимум не может быть больше максимума");

            return rand.Next(min, max);
        }

        // массив адресов
        public static string[] Addresses = new[]{ "Улица Кольцова, 15", "Улица Авдеева, 12", 
            "Бульвар Шевченко, 67", "Проспект Ленинский, 4а", "Проспект Мира, 13" };

        // массив комнат
        public static string[] Rooms = new[] { "Кухня", "Зал", "Спальня" };

        // массив названий квартир
        public static string[] TitlesHome = new[] { "Зелёный дом", "Дом Ивановых", "Дом Романовых", "Дом Фёдоровых" };

        // генерация номера поезда
        public static string GenerateNumberTrain() => $"{GetRand(301, 451)}";
    }
}