using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

using static HomeWorkCSharp.Application.App.Utils;       // для использования утилит

namespace HomeWorkCSharp.Application
{
    public partial class App
    {
        #region Задание 1. Числа

        /*
         * Задача 1. Напишите консольное приложение для решения следующих задач. 
         * Создавайте в приложении бинарный файл.
         * •	В бинарном файле вещественных чисел найти первый локальный минимум
         *      (локальным минимумом называется элемент, который меньше своих
         *      соседей).
         * •	В бинарном файле вещественных чисел поменять местами минимальный 
         *      и максимальный элементы.
         * •	В бинарном файле целых чисел продублировать числа, принадлежащие
         *      диапазону значений 5–10.
         */

        // Задание 1. Числа
        public void Task1()
        {
            #region Меню

            // пункты меню 
            string[] points =
            {
                "1. Поиск первого локального минимума в бинарном файле вещественных чисел",
                "2. Обмен местами минимального и максимального элементов в бинарном файле вещественных чисел",
                "3. Дублирование целых чисел в бинарном файле, пренадлижащих диапазону значений 5-10",
            };

            // нажатая клавиша
            ConsoleKey num;

            // вывод меню
            while (true)
            {
                // отчистка консоли
                Console.Clear();

                // цвет 
                Console.ForegroundColor = ConsoleColor.Cyan;

                int x = 5, y = Console.CursorTop + 3;

                // заголовок
                Console.SetCursorPosition(x + 3, y); WriteColor($"{"    Задание 1. Числа"}", ConsoleColor.Blue);

                y += 2;

                // вывод пунктов меню
                Array.ForEach(points, item => WriteColorXY(item, x, y++));

                // вывод пункта выхода из приложения
                Console.SetCursorPosition(x, ++y); Console.WriteLine("0. Выход");

                y += 4;

                // ввод номера задания
                Console.SetCursorPosition(x, y); Console.Write("Введите номер задания: ");
                num = Console.ReadKey().Key;

                try
                {

                    // обработка ввода 
                    switch (num)
                    {
                        // выход
                        case ConsoleKey.NumPad0:
                            goto case ConsoleKey.D0;
                        case ConsoleKey.Escape:
                            goto case ConsoleKey.D0;
                        case ConsoleKey.D0:
                            // позициониаровние курсора 
                            Console.SetCursorPosition(2, y + 5);
                            return;

                        // 1. Поиск первого локального минимума в бинарном файле вещественных чисел
                        case ConsoleKey.NumPad1:
                            goto case ConsoleKey.D1;
                        case ConsoleKey.D1:
                            Console.Clear();
                            // запуск задания 
                            Point1();
                            break;

                        // 2. Обмен местами минимального и максимального элементов в бинарном файле вещественных чисел
                        case ConsoleKey.NumPad2:
                            goto case ConsoleKey.D2;
                        case ConsoleKey.D2:
                            Console.Clear();
                            // запуск задания 
                            Point2();
                            break;

                        // 3. Дублирование целых чисел в бинарном файле, пренадлижащих диапазону значений 5-10
                        case ConsoleKey.NumPad3:
                            goto case ConsoleKey.D3;
                        case ConsoleKey.D3:
                            Console.Clear();
                            // запуск задания 
                            Point3();
                            break;

                        // если номер задания невалиден
                        default:

                            // установка цвета
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.Black;

                            // позиционирование курсора
                            Console.SetCursorPosition(x, y); Console.WriteLine("         Номер задания невалиден!         ");

                            // выключение курсора
                            Console.CursorVisible = false;

                            // задержка времени
                            Thread.Sleep(1000);

                            // возвращение цвета
                            Console.ResetColor();

                            // включение курсора
                            Console.CursorVisible = true;

                            break;
                    } // switch
                } // try

                // стандартное исключение
                catch (Exception ex)
                {
                    Console.Clear();

                    // вывод сообщения об ошибке 
                    WriteColor(ex.Message, ConsoleColor.Red);
                    Console.WriteLine();
                    WriteColor(ex.StackTrace, ConsoleColor.Red);
                    Console.WriteLine();
                } // catch

                // обязательная часть
                finally
                {
                    // если пункт меню 0
                    if (num != ConsoleKey.D0 && num != ConsoleKey.NumPad0 && num != ConsoleKey.Escape)
                    {
                        // ввод клавиши для продолжения 
                        WriteColor("\n\n\tНажмите на [Enter] для продолжения...", ConsoleColor.Cyan);
                        Console.CursorVisible = false;
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
                        Console.CursorVisible = true;
                    }
                } // finally
            } // while

            #endregion

            #region 1. Поиск первого локального минимума в бинарном файле вещественных чисел

            // 1. Поиск первого локального минимума в бинарном файле вещественных чисел
            void Point1()
            {
                ShowNavBarMessage("1. Поиск первого локального минимума в бинарном файле вещественных чисел");

                // название файла и полный путь
                string pathFile = @"..\..\doubleNumbers.bin";

                // название файла
                string nameFile = new FileInfo(pathFile).Name;

                // заполнение файла
                FillDoubleFile(pathFile);

                // поиск локального минимума в файле
                (double value, int index) item = LocalMin(pathFile);

                // вывод файла
                ShowTable(pathFile, sizeof(double), ShowDoubleFile, val => val == item, nameFile);

                Console.WriteLine();

                // вывод значений
                ShowLocalMin(item);
            }

            // поиск локального минимума в файле
            (double value, int index) LocalMin(string fileName)
            {
                // размер записи в файле
                int length = sizeof(double);

                // размер файла 
                int n = (int)new FileInfo(fileName).Length / length;

                using (BinaryReader br = new BinaryReader(File.OpenRead(fileName)))
                {
                    // предыдущий элемент
                    double prev = br.ReadDouble();

                    // текущий элемент
                    double cur = br.ReadDouble();

                    // следующий элемент
                    double next = br.ReadDouble();

                    // поиск в файле локального минимума
                    for (int i = 2; i < n; i++)
                    {
                        // если найден локальный минимум
                        if (prev.CompareTo(cur) > 0 && cur.CompareTo(next) < 0)
                            return (cur, i - 1);

                        // перемещение значений
                        (prev, cur, next) = (cur, next, br.ReadDouble());
                    }
                }

                return (Double.NaN, -1);
            }

            // вывод локального минимума
            void ShowLocalMin((double value, int index)item)
            {
                //                  10                     30                                   33
                WriteColorXY("     ╔═════════════════════════╗\n", textColor: ConsoleColor.Magenta);
                WriteColorXY("     ║                         ║", textColor: ConsoleColor.Magenta);
                WriteColorXY("Локальный минимум", 10, textColor: ConsoleColor.DarkYellow);
                Console.WriteLine();

                WriteColorXY("     ╠════════════╦════════════╣\n", textColor: ConsoleColor.Magenta);
                WriteColorXY("     ║            ║            ║", textColor: ConsoleColor.Magenta);
                WriteColorXY("  Индекс  ", 7, textColor: ConsoleColor.DarkYellow);
                WriteColorXY(" Значение ", 20, textColor: ConsoleColor.DarkYellow);
                Console.WriteLine();

                WriteColorXY("     ╠════════════╬════════════╣\n", textColor: ConsoleColor.Magenta);
                WriteColorXY("     ║            ║            ║", textColor: ConsoleColor.Magenta);
                WriteColorXY($"{item.index,10}", 7, textColor: ConsoleColor.Green);
                WriteColorXY($"{item.value,10:n1}", 20, textColor: ConsoleColor.Green);
                Console.WriteLine();

                WriteColorXY("     ╚════════════╩════════════╝\n", textColor: ConsoleColor.Magenta);

            }

            #endregion

            #region 2. Обмен местами минимального и максимального элементов в бинарном файле вещественных чисел

            // 2. Обмен местами минимального и максимального элементов в бинарном файле вещественных чисел
            void Point2()
            {
                ShowNavBarMessage("2. Обмен местами минимального и максимального элементов в бинарном файле вещественных чисел");

                // название файла 
                string pathFile = @"..\..\doubleNumbers.bin";

                // название файла
                string nameFile = new FileInfo(pathFile).Name;

                // заполнение файла
                FillDoubleFile(pathFile);

                // поиск минимального элемента
                (double value, int index) min = MinElem(pathFile);

                // поиск максимального элемента
                (double value, int index) max = MaxElem(pathFile);

                // вывод файла
                ShowTable(pathFile, sizeof(double), ShowDoubleFile, item => item == min || item == max, nameFile);

                Console.WriteLine();

                // вывод минимального и максимального элементов
                ShowMinMaxElem(min, max);
            }

            // поиск минимального элемента
            (double value, int index) MinElem(string fileName)
            {
                // количество записей в файле
                int n = (int)new FileInfo(fileName).Length / sizeof(double);

                // чтение файла
                using (BinaryReader br = new BinaryReader(File.OpenRead(fileName), Encoding.UTF8))
                {
                    // минимальный элемент
                    (double value, int index) min = (br.ReadDouble(), 0);

                    // поиск минимального элемента
                    for (int i = 1; i < n; i++)
                    {
                        // значение из файла
                        double value = br.ReadDouble();

                        // если значение меньше текущего минимума
                        if (value < min.value)
                            min = (value, i);
                    }

                    return min;
                }
            }

            // поиск максимального элемента
            (double value, int index) MaxElem(string fileName)
            {
                // количество записей в файле
                int n = (int)new FileInfo(fileName).Length / sizeof(double);

                // чтение файла
                using (BinaryReader br = new BinaryReader(File.OpenRead(fileName), Encoding.UTF8))
                {
                    // максимальный элемент
                    (double value, int index) max = (br.ReadDouble(), 0);

                    // поиск максимального элемента
                    for (int i = 1; i < n; i++)
                    {
                        // значение из файла
                        double value = br.ReadDouble();

                        // если значение больше текущего максимума
                        if (value > max.value)
                            max = (value, i);
                    }

                    return max;
                }
            }

            // вывод минимального и максимального элементов
            void ShowMinMaxElem((double value, int index) min, (double value, int index) max)
            {
                WriteColorXY("     ╔═════════════════════════╦════════════╦════════════╗\n", textColor: ConsoleColor.Magenta);
                WriteColorXY("     ║                         ║            ║            ║", textColor: ConsoleColor.Magenta);
                WriteColorXY("Название", 14, textColor: ConsoleColor.DarkYellow);
                WriteColorXY("  Индекс  ", 33, textColor: ConsoleColor.DarkYellow);
                WriteColorXY(" Значение ", 46, textColor: ConsoleColor.DarkYellow);
                Console.WriteLine();

                WriteColorXY("     ╠═════════════════════════╬════════════╬════════════╣\n", textColor: ConsoleColor.Magenta);
                WriteColorXY("     ║                         ║            ║            ║", textColor: ConsoleColor.Magenta);
                WriteColorXY("Минимальный элемент", 10, textColor: ConsoleColor.Cyan);
                WriteColorXY($"{min.index,10}", 33, textColor: ConsoleColor.Green);
                WriteColorXY($"{min.value,10:n1}", 46, textColor: ConsoleColor.Green);
                Console.WriteLine();

                WriteColorXY("     ╠═════════════════════════╬════════════╬════════════╣\n", textColor: ConsoleColor.Magenta);
                WriteColorXY("     ║                         ║            ║            ║", textColor: ConsoleColor.Magenta);
                WriteColorXY("Максимальный элемент", 9, textColor: ConsoleColor.Cyan);
                WriteColorXY($"{max.index,10}", 33, textColor: ConsoleColor.Green);
                WriteColorXY($"{max.value,10:n1}", 46, textColor: ConsoleColor.Green);
                Console.WriteLine();

                WriteColorXY("     ╚═════════════════════════╩════════════╩════════════╝\n", textColor: ConsoleColor.Magenta);

            }

            #endregion

            #region 3. Дублирование целых чисел в бинарном файле, пренадлижащих диапазону значений 5-10

            // 3. Дублирование целых чисел в бинарном файле, пренадлижащих диапазону значений 5-10
            void Point3()
            {
                ShowNavBarMessage("3. Дублирование целых чисел в бинарном файле, пренадлижащих диапазону значений 5-10");

                // название файла 
                string pathFile = @"..\..\intNumbers.bin";

                // название файла
                string nameFile = new FileInfo(pathFile).Name;

                // заполнение файла
                FillIntFile(pathFile);

                // вывод файла
                ShowTable(pathFile, sizeof(int), ShowIntFile, item => item.item >= 5 && item.item <= 10, nameFile, "До дублирования");

                Console.WriteLine();

                // дублирование чисел пренадлижащих диапазону значений 5-10
                DuplicationNumbersRange(pathFile, 5, 10);

                // вывод файла
                ShowTable(pathFile, sizeof(int), ShowIntFile, item => item.item >= 5 && item.item <= 10, nameFile, "После дублирования");
            }

            // дублирование чисел пренадлижащих диапазону значений 5-10
            void DuplicationNumbersRange(string fileName, int min, int max)
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite))
                {
                    // поток для чтения
                    BinaryReader br = new BinaryReader(fs);

                    // поток для записи 
                    BinaryWriter bw = new BinaryWriter(fs);

                    // количество записей в файле 
                    int n = (int)new FileInfo(fileName).Length / sizeof(int);

                    // поиск дубликатов
                    for (int i = 0; i < n; i++)
                    {
                        // текущее значение 
                        int cur = br.ReadInt32();

                        // если значение входит в диапазон
                        if (cur >= min && cur <= max)
                        {
                            // сдвиг всех последующих записей на одну запись вправо
                            for (int j = n - 1; j >= i; j--)
                            {
                                // установка позиции в файле
                                fs.Seek(j * sizeof(int), SeekOrigin.Begin);

                                // дублирование текущей записи
                                bw.Write(br.ReadInt32());
                            }

                            // установка позиции в файле 
                            fs.Seek((i + 1) * sizeof(int), SeekOrigin.Begin);

                            // запись текущего элемента
                            bw.Write(cur);

                            // увеличение количество записей
                            n++;

                            // инкремент индекса
                            i++;
                        }
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Общие методы

        // заполнение файла случайными вещественными значениями
        private void FillDoubleFile(string nameFile, int min = 1, int max = 11, int count = 10)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create(nameFile), Encoding.UTF8))
            {
                for(int i = 0; i < count; i++)
                    bw.Write(GetDouble(min, max));
            }
        }

        // заполнение файла случайными целочисленными значениями
        private void FillIntFile(string nameFile, int min = 1, int max = 20, int count = 5)
        {
            using (BinaryWriter bw = new BinaryWriter(File.Create(nameFile), Encoding.UTF8))
            {
                for (int i = 0; i < count; i++)
                    bw.Write(rand.Next(min, max));
            }
        }

        // вывод массива
        public void ShowTable<T>(string nameFile, int sizeofElem, Action<string, Predicate<(T item, int i)>> showElements, string name = "Коллекция", string info = "Исходные данные")
        {
            // количество записей в файле
            int n = (int)new FileInfo(nameFile).Length / sizeofElem;

            // вывод шапки таблицы
            ShowHead(n, name, info);

            // вывод рамки таблицы 
            ShowElemFrame(n);

            // вывод элементов
            showElements(nameFile, item => false);
        }

        // вывод массива
        public void ShowTable<T>(string nameFile, int sizeofElem, Action<string, Predicate<(T item, int i)>> showElements, Predicate<(T item, int i)> predicate, string name = "Коллекция", string info = "Исходные данные")
        {
            // количество записей в файле
            int n = (int)new FileInfo(nameFile).Length / sizeofElem;

            // вывод шапки таблицы
            ShowHead(n, name, info);

            // вывод рамки таблицы 
            ShowElemFrame(n);

            // вывод элементов
            showElements(nameFile, predicate);
        }

        // вывод шапки таблицы 
        static public void ShowHead(int size, string name = "Коллекция", string info = "Исходные данные")
        {
            //                  10                     30                                   33
            WriteColorXY("     ╔════════════╦═════════════════════════════════╦═════════════════════════════════╗\n", textColor: ConsoleColor.Magenta);
            WriteColorXY("     ║            ║                                 ║                                 ║", textColor: ConsoleColor.Magenta);
            WriteColorXY("Размер: ", 7, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{size,2}", textColor: ConsoleColor.Green);
            WriteColorXY("Название: ", 20, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{name,-20}", textColor: ConsoleColor.Green);
            WriteColorXY("Инфо: ", 54, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{info,-25}", textColor: ConsoleColor.Green);
            Console.WriteLine();
            WriteColorXY("     ╚════════════╩═════════════════════════════════╩═════════════════════════════════╝\n", textColor: ConsoleColor.Magenta);
        }

        // вывод рамки для вывода значений элементов с индексированием 
        static private void ShowElemFrame(int countElem)
        {
            // разделительная линия между полями заголовка
            string line = new string('═', 80);

            // координаты для позиционирования курсора
            int x = 5;
            int y = Console.CursorTop;

            // если количество элементов равно нулю
            if (countElem == 0)
            {
                // вывод сообщения 
                WriteColorXY($"╔{line}╗", x, y++, ConsoleColor.Magenta);
                WriteColorXY($"║{' ',80}║", x, y++, ConsoleColor.Magenta);
                WriteColorXY($"║{' ',80}║", x, y++, ConsoleColor.Magenta);
                WriteColorXY($"║{' ',80}║", x, y, ConsoleColor.Magenta);
                WriteColorXY($"{"Нет данных"}", x + 36, y++, ConsoleColor.Red);
                WriteColorXY($"║{' ',80}║", x, y++, ConsoleColor.Magenta);
                WriteColorXY($"║{' ',80}║", x, y++, ConsoleColor.Magenta);
                WriteColorXY($"╚{line}╝", x, y++, ConsoleColor.Magenta);

                // позиционирование 
                PosXY(0, y + 1);

                return;
            }

            // исходная позиция по y
            int yTemp = y;

            // чать разделительной линии 
            string partLine = new string('═', 20);

            // вывод рамки

            // вывод линии разделителя 
            WriteColorXY($"╔{partLine,-20}╦═════╦═════╦═════╦═════╦═════╦═════╦═════╦═════╦═════╦═════╗", x, y++, ConsoleColor.Magenta);

            // позиционирование 
            PosXY(x, y);

            // вывод 
            WriteColorXY($"║ ", textColor: ConsoleColor.Magenta);
            WriteColorXY($"      Индекс      ", textColor: ConsoleColor.Cyan);
            WriteColorXY($" ║ ", textColor: ConsoleColor.Magenta);

            // вывод индексов
            WriteColorXY(" ║     ║     ║     ║     ║     ║     ║     ║     ║     ║     ║\n\n",
            x + 20, y, ConsoleColor.Magenta);

            // вывод линии разделителя 
            WriteColorXY($"╠{partLine,-20}╬═════╬═════╬═════╬═════╬═════╬═════╬═════╬═════╬═════╬═════╣", x, ++y, ConsoleColor.Magenta);

            WriteColorXY($"║ ", x, ++y, textColor: ConsoleColor.Magenta);
            WriteColorXY($"     Значение    ", textColor: ConsoleColor.Cyan);

            // вывод полей для вывода элементов 
            WriteColorXY(" ║     ║     ║     ║     ║     ║     ║     ║     ║     ║     ║\n",
            x + 20, y, ConsoleColor.Magenta);

            // вывод линии разделителя подвала
            WriteColorXY($"╚{partLine,-20}╩═════╩═════╩═════╩═════╩═════╩═════╩═════╩═════╩═════╩═════╝", x, textColor: ConsoleColor.Magenta);

            y++;

            // установка курсора для вывода значения первого элемента 
            PosXY(x + 23, yTemp + 1);
        }

        // вывод элементв 
        static private void ShowElem<T>(int num, T value, ConsoleColor colorIndex = ConsoleColor.DarkYellow, ConsoleColor colorValue = ConsoleColor.Green)
        {
            // координаты для позиционирования 
            int x = Console.CursorLeft;
            int y = Console.CursorTop;

            // вывод индекса
            WriteColorXY($"{num,3}", x, y, textColor: colorIndex);

            // вывод элемента 
            WriteColorXY($"{value,3:#.#}", x, y + 2, textColor: colorValue);

            // смещение позиции по x
            PosXY(x + 6, y);
        }

        // вывод файла элементов типа double
        public static Action<string, Predicate<(double item, int i)>> ShowDoubleFile = (nameFile, predicate)=>
        {
            using (BinaryReader br = new BinaryReader(File.OpenRead(nameFile), Encoding.UTF8))
            {
                // количество записей в файле 
                int n = (int)new FileInfo(nameFile).Length / sizeof(double);

                // вывод элементов массива
                for (int i = 0; i < n; i++)
                {
                    // чтение элемента
                    double item = br.ReadDouble();

                    // вывод элемента
                    ShowElem(i, item, colorValue: predicate((item, i)) ? ConsoleColor.Cyan : ConsoleColor.Blue);
                }

                // позиционирование курсора
                PosXY(0, Console.CursorTop + 4);
            }
        };

        // вывод файла элементов типа int
        public static Action<string, Predicate<(int item, int i)>> ShowIntFile = (nameFile, predicate) =>
        {
            using (BinaryReader br = new BinaryReader(File.OpenRead(nameFile), Encoding.UTF8))
            {
                // количество записей в файле 
                int n = (int)new FileInfo(nameFile).Length / sizeof(int);

                // вывод элементов массива
                for (int i = 0; i < n; i++)
                {
                    // чтение элемента
                    int item = br.ReadInt32();

                    // вывод элемента
                    ShowElem(i, item, colorValue: predicate((item, i)) ? ConsoleColor.Cyan : ConsoleColor.Blue);
                }

                // позиционирование курсора
                PosXY(0, Console.CursorTop + 4);
            }
        };

        #endregion
    }
}
