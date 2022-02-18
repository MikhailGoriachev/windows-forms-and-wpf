using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;           // подключение коллекций

using static Home_Work_Collection.Application.App.Utils;       // для использования утилит

namespace Home_Work_Collection.Application
{
    public partial class App
    {
        #region Задание 1. Коллекции

        /*
         * Задача 1. Разработайте, пожалуйста, консольное приложение C# для решения 
         * следующих задач, с использованием типизированных коллекций, закрытых типом int. 
         * •	Dynamic10. Дан непустой стек. Создать два новых стека, переместив в первый 
         *      из них все элементы исходного стека с четными значениями, а во второй — с 
         *      нечетными (элементы в новых стеках будут располагаться в порядке, обратном 
         *      исходному; один из этих стеков может оказаться пустым). 
         * •	Dynamic24. Даны две непустые очереди, очереди содержат одинаковое количество 
         *      элементов. Объединить очереди в одну, в которой элементы исходных очередей 
         *      чередуются (начиная с первого элемента первой очереди)
         * •	Dynamic37. Дан непустой список. Продублировать в списке все элементы с 
         *      нечетными номерами (новые элементы добавлять перед существующими элементами 
         *      с такими же значениями)
         */

        // Задание 1. Коллекции
        public void Task1()
        {
            #region Меню

            // номер задания 
            int numberTask = 0;

            // вывод меню
            while (true)
            {
                // отчистка консоли
                Console.Clear();

                // цвет 
                Console.ForegroundColor = ConsoleColor.Cyan;

                int x = 5, y = Console.CursorTop + 3;

                // заголовок
                Console.SetCursorPosition(x + 3, y); WriteColor($"{"    Задание 1. Коллекции"}", ConsoleColor.Blue);

                y += 2;

                // пукты меню
                Console.SetCursorPosition(x, y++); Console.WriteLine("1. Стек");
                Console.SetCursorPosition(x, y++); Console.WriteLine("2. Очередь");
                Console.SetCursorPosition(x, y++); Console.WriteLine("3. Список");
                Console.SetCursorPosition(x, ++y); Console.WriteLine("0. Выход");

                y += 4;

                // ввод номера задания
                Console.SetCursorPosition(x, y); Console.Write("Введите номер задания: ");
                if (!int.TryParse(Console.ReadLine(), out numberTask))
                    continue;

                try
                {

                    // обработка ввода 
                    switch (numberTask)
                    {
                        // выход
                        case (int)Cmd.pointExit:
                            // позициониаровние курсора 
                            Console.SetCursorPosition(2, y + 5);
                            return;

                        // 1. Стек
                        case (int)Cmd.pointOne:
                            Console.Clear();
                            // запуск задания 
                            Point1();
                            break;

                        // 2. Очередь
                        case (int)Cmd.pointTwo:
                            Console.Clear();
                            // запуск задания 
                            Point2();
                            break;

                        // 3. Список
                        case (int)Cmd.pointThree:
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
                    if (numberTask != 0)
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

            #region 1. Стек

            // 1. Стек
            void Point1()
            {
                ShowNavBarMessage("1. Стек");

                // исходный стек
                Stack<int> source = new Stack<int>();

                // заполенение исходного стека
                FillStack(source);

                // вывод исходного стека после заполнения
                ShowTable(source, ShowElementsEvenOddValue, "Исходный стек");

                // обработка по заданию 
                HandingStack(source, out Stack<int> even, out Stack<int> odd);

                WriteColorXY("\n     ────────────────────────────────  После обработки  ───────────────────────────────\n\n", textColor: ConsoleColor.Yellow);

                // вывод исходного стека после обработки
                ShowTable(source, ShowElementsEvenOddValue, "Исходный стек");

                // вывод стека с чётными элементами 
                ShowTable(even, ShowElementsEvenOddValue, "Стек 1", "Четные элементы");

                // вывод стека с нечётными элементами 
                ShowTable(odd, ShowElementsEvenOddValue, "Стек 2", "Нечётные элементы");
            }

            // заполнение стека 
            void FillStack(Stack<int> stack, int size = 10)
            {
                for (int i = 0; i < size; i++)
                    stack.Push(rand.Next(-10, 11));
            }

            // обработка стека по заданию
            // разделение стека на стек с чётными и стек с нечётными элементами
            void HandingStack(Stack<int> stack, out Stack<int> even, out Stack<int> odd)
            {
                // стек с чётными элементами
                even = new Stack<int>();

                // стек с нечётными элементами
                odd = new Stack<int>();

                // разделение стека на чётный и нечётный
                while (stack.Count > 0)
                    if ((stack.Peek() & 1) == 1) odd.Push(stack.Pop()); 
                    else even.Push(stack.Pop());
            }

            #endregion

            #region 2. Очередь

            // 2. Очередь
            void Point2()
            {
                ShowNavBarMessage("2. Очередь");

                // первая очередь
                Queue<int> queue1 = new Queue<int>();

                // вторая очередь
                Queue<int> queue2 = new Queue<int>();

                // заполнение очередей 
                FillQueue(queue1);
                FillQueue(queue2);

                // вывод первой и второй очереди
                ShowTable(queue1, ShowElementsBlue, "Очередь 1");
                ShowTable(queue2, ShowElementsRed, "Очередь 2");

                // объединение очереди с чередованием элементов
                UnionQueue(queue1, queue2, out Queue<int> result);

                WriteColorXY("\n     ────────────────────────────────  После обработки  ───────────────────────────────\n\n", textColor: ConsoleColor.Yellow);

                // вывод первой и второй очереди
                ShowTable(queue1, ShowElementsBlue, "Очередь 1");
                ShowTable(queue2, ShowElementsRed, "Очередь 2");

                // вывод результирующей очереди
                ShowTable(result, ShowElementsEvenOddNumber, "Результирущая очередь");
            }

            // заполнение очереди
            void FillQueue(Queue<int> queue, int size = 5)
            {
                for (int i = 0; i < size; i++)
                    queue.Enqueue(rand.Next(-10, 11));
            }
            
            // обработка очереди по задании
            void UnionQueue(Queue<int> queue1, Queue<int> queue2, out Queue<int> result)
            {
                // результирующая очередь
                result = new Queue<int>();

                // объединение двух очередей в одну с чередованием элементов
                for (int i = queue1.Count * 2; i > 0; i--)
                    result.Enqueue((i & 1) == 1 ? queue2.Dequeue() : queue1.Dequeue());
            }

            #endregion

            #region 3. Список

            // 3. Список
            void Point3()
            {
                ShowNavBarMessage("3. Список");

                // исходный список
                List<int> list = new List<int>();

                // заполнение списка 
                FillList(list);

                // вывод после заполнения
                ShowTable(list, ShowElementsEvenOddNumber, "Список", "После заполнения");

                // дублирование элементов с нечётными номера
                DublicationOddNumElem(list);

                // вывод после дублирования элементов с нечётными порядковыми номерами
                ShowTable(list, ShowElements, "Список", "После дублирования");
            }

            // заполнение списка
            void FillList(List<int> list, int size = 5)
            {
                for (int i = 0; i < size; i++)
                    list.Add(rand.Next(-3, 3));                
            }

            // дублирование элементов с нечётными номера
            void DublicationOddNumElem(List<int> list)
            {
                for (int i = 0, count = list.Count, k = 0; i < count; i++, k++)
                    if ((i & 1) == 0) list.Insert(list.IndexOf(list[k]), list[k++]);
            }

            #endregion
        }

        #endregion

        #region Общие методы

        // вывод массива
        public void ShowTable<T>(IEnumerable<T> array, Action<IEnumerable<T>> showElements, string name = "Коллекция", string info = "Исходные данные")
        {
            // вывод шапки таблицы
            ShowHead(array.Count(), name, info);

            // вывод рамки таблицы 
            ShowElemFrame(array.Count());

            // вывод элементов
            showElements(array);
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

        // вывод элементов
        static public Action<IEnumerable<int>> ShowElements = (IEnumerable<int> array) =>
        {
            // индекс элемента
            int i = 0;

            // если нет элементов 
            if (array.Count() == 0) return;

            // вывод элементов массива
            foreach (var item in array) ShowElem(i++, item);

            // позиционирование курсора
            PosXY(0, Console.CursorTop + 4);
        };

        // вывод элементов с подсветкой чётных и нечётных по значению элементов
        static public Action<IEnumerable<int>> ShowElementsEvenOddValue = (IEnumerable<int> array) =>
        {
            // индекс элемента
            int i = 0;

            // если нет элементов 
            if (array.Count() == 0) return;

            // вывод элементов массива
            foreach (var item in array) ShowElem(i++, item, colorValue: (item & 1) == 1 ? ConsoleColor.Blue : ConsoleColor.Red);

            // позиционирование курсора
            PosXY(0, Console.CursorTop + 4);
        };

        // вывод элементов с подсветкой чётных и нечётных по номеру элементов
        static public Action<IEnumerable<int>> ShowElementsEvenOddNumber = (IEnumerable<int> array) =>
        {
            // индекс элемента
            int i = 0;

            // если нет элементов 
            if (array.Count() == 0) return;

            // вывод элементов массива
            foreach (var item in array) ShowElem(i++, item, colorValue: (i & 1) == 1 ? ConsoleColor.Blue : ConsoleColor.Red);

            // позиционирование курсора
            PosXY(0, Console.CursorTop + 4);
        };

        // вывод элементов с подсветкой чётных и нечётных по значению элементов
        static public Action<IEnumerable<int>> ShowElementsRed = (IEnumerable<int> array) =>
        {
            // индекс элемента
            int i = 0;

            // если нет элементов 
            if (array.Count() == 0) return;

            // вывод элементов массива
            foreach (var item in array) ShowElem(i++, item, colorValue: ConsoleColor.Red);

            // позиционирование курсора
            PosXY(0, Console.CursorTop + 4);
        };

        // вывод элементов с подсветкой чётных и нечётных по значению элементов
        static public Action<IEnumerable<int>> ShowElementsBlue = (IEnumerable<int> array) =>
        {
            // индекс элемента
            int i = 0;

            // если нет элементов 
            if (array.Count() == 0) return;

            // вывод элементов массива
            foreach (var item in array) ShowElem(i++, item, colorValue: ConsoleColor.Blue);

            // позиционирование курсора
            PosXY(0, Console.CursorTop + 4);
        };

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
            WriteColorXY($"{value,3}", x, y + 2, textColor: colorValue);

            // смещение позиции по x
            PosXY(x + 6, y);
        }

        #endregion

    }
}
