﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Utilities
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
                num = rand.Next((int)min, (int)max) + rand.NextDouble();
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

        // массив цветов
        public static string[] Colors = { "Серый", "Белый", "Коричневый", "Черный", "Зеленый", "Красный", "Желтый" };

        // массив кличек животных
        public static string[] NamesAnimal = 
            { "Харрис", "Ирк", "Монт", "Юкки", "Атанг", "Тимус", "Фурор", "Антер", "Румбик", "Кебби" };

        // массив фамилий и инициалов
        public static string[] NamesPersons = {   
                "Устинова М. Г.",       "Верещагина А. Т.",
                "Щербакова А. А.",      "Гуляева А. М.",
                "Котов Е. А.",          "Юдин А. Я.",
                "Карташова В. Ф.",      "Сычева А. К.",
                "Колесникова М. Н.",    "Колесникова М. Н.",
                "Степанова М. М.",      "Русанова А. Л.",
                "Колесников Л. Д.",     "Егоров И. В.",
                "Елисеева К. В.",       "Кузнецова М. Л.",
                "Захарова В. А.",       "Бородин А. А.",
                "Бородина А. К.",       "Захарова М. Е." 
        };
    }
}