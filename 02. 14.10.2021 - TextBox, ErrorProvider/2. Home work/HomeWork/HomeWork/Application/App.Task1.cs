using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HomeWork.Controllers;     // обработка по заданию
using HomeWork.Models.Task1;          // модели

using static HomeWork.Application.App.Utils;       // для использования утилит

namespace HomeWork.Application
{
    public partial class App
    {
        #region Задание 1. Пользователи

        /*
         * Задача 1. Описать класс с именем User, содержащую следующие поля:
         * •	числовой идентификатор - int;
         * •	фамилия, имя - string;
         * •	знак Зодиака - string;
         * •	дата рождения - DateTime
         * Создать класс Department со списком пользователей – коллекцией типа 
         * ObservableCollection<User>. Проинициировать ее не менее чем 20 
         * записями о пользователях, использовать все знаки Зодиака, заполнение 
         * коллекции также выполняйте из пункта меню.
         * Реализовать CRUD-операции, (операции Read и Update – реализовать 
         * индексатором), обрабатывать события добавления, удаления и замещения 
         * (replace) данных в коллекции. 
         * Обрабатывать события при выполнении следующих запросов, включенных 
         * в меню приложения:
         * •	добавление трех пользователей со знаком Рыбы (create)
         * •	удаление всех пользователей старше 60 лет (delete)
         * •	заменить все записи знака Овен этими же записями, но с добавлением 
         *      строки "-бе-бе" к фамилии (update - replace)
         * Таже в пунктах меню задать выполнение следующих действий:
         * •	при помощи именованного итератора вывести в список и консоль записи 
         *      с заданной фамилией
         * •	при помощи именованного итератора вывести в список и консоль записи 
         *      с заданным знаком Зодиака
         * •	при помощи именованного итератора вывести в список и консоль записи 
         *      с заданным месяцем рождения
         * •	сортировка по дате рождения
         * •	сортировка по названиям знаков Зодиака
         * •	сортировка по фамилии, имени
         */

        // Задание 1. Пользователи
        public void Task1()
        {
            // обработка по заданию
            Task1Controller controller = new Task1Controller();

            #region Меню

            // пункты меню 
            string[] points =
            {
                "1. Формирование данных",
                "2. Вывод пользователей",
                "3. Добавление трех пользователей со знаком Рыбы",
                "4. Удаление всех пользователей старше 60 лет",
                "5. Заменить все записи знака Овен этими же записями, но с добавлением строки \"-бе-бе\" к фамилии",
                "6. Вывести в список и консоль записи с заданной фамилией",
                "7. Вывести в список и консоль записи с заданным знаком Зодиака",
                "8. Вывести в список и консоль записи с заданным месяцем",
                "9. Сортировка по дате рождения",
                "Q. Сортировка по названиям знаков Зодиака",
                "W. Сортировка по фамилии, имени"
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
                Console.SetCursorPosition(x + 3, y); WriteColor($"{"    Задание 1. Пользователи"}", ConsoleColor.Blue);

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

                        // 1. Формирование данных
                        case ConsoleKey.NumPad1:
                            goto case ConsoleKey.D1;
                        case ConsoleKey.D1:
                            Console.Clear();
                            // запуск задания 
                            Point1();
                            break;

                        // 2. Вывод пользователей
                        case ConsoleKey.NumPad2:
                            goto case ConsoleKey.D2;
                        case ConsoleKey.D2:
                            Console.Clear();
                            // запуск задания 
                            Point2();
                            break;

                        // 3. Добавление трех пользователей со знаком Рыбы
                        case ConsoleKey.NumPad3:
                            goto case ConsoleKey.D3;
                        case ConsoleKey.D3:
                            Console.Clear();
                            // запуск задания 
                            Point3();
                            break;

                        // 4. Удаление всех пользователей старше 60 лет
                        case ConsoleKey.NumPad4:
                            goto case ConsoleKey.D4;
                        case ConsoleKey.D4:
                            Console.Clear();
                            // запуск задания 
                            Point4();
                            break;

                        // 5. Заменить все записи знака Овен этими же записями, но с добавлением строки \"-бе-бе\" к фамилии
                        case ConsoleKey.NumPad5:
                            goto case ConsoleKey.D5;
                        case ConsoleKey.D5:
                            Console.Clear();
                            // запуск задания 
                            Point5();
                            break;

                        // 6 Пункт меню
                        case ConsoleKey.NumPad6:
                            goto case ConsoleKey.D6;
                        case ConsoleKey.D6:
                            Console.Clear();
                            // запуск задания 
                            Point6();
                            break;

                        // 7. Вывести в список и консоль записи с заданным знаком Зодиака
                        case ConsoleKey.NumPad7:
                            goto case ConsoleKey.D7;
                        case ConsoleKey.D7:
                            Console.Clear();
                            // запуск задания 
                            Point7();
                            break;

                        // 8. Вывести в список и консоль записи с заданным месяцем
                        case ConsoleKey.NumPad8:
                            goto case ConsoleKey.D8;
                        case ConsoleKey.D8:
                            Console.Clear();
                            // запуск задания 
                            Point8();
                            break;

                        // 9. Сортировка по дате рождения
                        case ConsoleKey.NumPad9:
                            goto case ConsoleKey.D9;
                        case ConsoleKey.D9:
                            Console.Clear();
                            // запуск задания 
                            Point9();
                            break;

                        // 10. Сортировка по названиям знаков Зодиака
                        case ConsoleKey.Q:
                            Console.Clear();
                            // запуск задания 
                            Point10();
                            break;

                        // 11. Сортировка по фамилии, имени
                        case ConsoleKey.W:
                            Console.Clear();
                            // запуск задания 
                            Point11();
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

            #region 1. Формирование данных

            // 1. Формирование данных
            void Point1()
            {
                ShowNavBarMessage("1. Формирование данных"); 

                // формирование данных
                controller.Initialization();

                // вывод пользователей
                controller.ShowTable(info: "После заполнения");
            }

            #endregion

            #region 2. Вывод пользователей

            // 2. Вывод пользователей
            void Point2()
            {
                ShowNavBarMessage("2. Вывод пользователей");

                // вывод пользователей
                controller.ShowTable();
            }

            #endregion

            #region 3. Добавление трех пользователей со знаком Рыбы

            // 3. Добавление трех пользователей со знаком Рыбы
            void Point3()
            {
                ShowNavBarMessage("3. Добавление трех пользователей со знаком Рыбы");

                // демонстрация добавления
                controller.AddThreeUsers();

                PosXY(0, 35);
            }

            #endregion

            #region 4. Удаление всех пользователей старше 60 лет

            // 4. Удаление всех пользователей старше 60 лет
            void Point4()
            {
                string navBar = "4. Удаление всех пользователей старше 60 лет";

                ShowNavBarMessage(navBar);

                // демонстрация удаления пользователей
                controller.RemoveUserAgeOverSixty(navBar);
            }

            #endregion

            #region 5. Заменить все записи знака Овен этими же записями, но с добавлением строки \"-бе-бе\" к фамилии

            // 5. Заменить все записи знака Овен этими же записями, но с добавлением строки \"-бе-бе\" к фамилии
            void Point5()
            {
                string navBar = "5. Заменить все записи знака Овен этими же записями, но с добавлением строки \"-бе-бе\" к фамилии";

                ShowNavBarMessage(navBar);

                // демонстрация замены пользователей
                controller.ReplaceUserSign(navBar);

                PosXY(0, 35);
            }

            #endregion

            #region 6. Вывести в список и консоль записи с заданной фамилией

            // 6. Вывести в список и консоль записи с заданной фамилией
            void Point6()
            {
                ShowNavBarMessage("6. Вывести в список и консоль записи с заданной фамилией");

                // случайная фамилия 
                string surname = controller.UsersDepart[rand.Next(0, controller.UsersDepart.Lenght)].Surname;

                // список с отобранными пользователями
                List<User> list = new List<User>();

                // порядковый номер элемента 
                int n = 1;

                // список ползователей
                var departament = controller.UsersDepart;

                // вывод шапки таблицы
                Departament.ShowHead(-1, "Вывод foreach", $"Заданная фамилия {surname}");

                // вывод всех пользователей с заданной фамилией
                foreach (var item in departament.SurnameIter(surname))
                {
                    // вывод элемента 
                    item.ShowElem(n++);

                    // добавление элемента в список
                    list.Add(item);
                }

                // вывод подвала таблицы
                Departament.ShowLine();

                Console.WriteLine();

                // вывод списка с отобранными пользователями
                Departament.ShowHead(list.Count, "Вывод списка", $"Заданная фамилия {surname}");
                Departament.ShowElements(list);
                Departament.ShowLine();
            }

            #endregion

            #region 7. Вывести в список и консоль записи с заданным знаком Зодиака

            // 7. Вывести в список и консоль записи с заданным знаком Зодиака
            void Point7()
            {
                ShowNavBarMessage("7. Вывести в список и консоль записи с заданным знаком Зодиака");

                // случайный знак Зодиака
                string sign = controller.UsersDepart[rand.Next(0, controller.UsersDepart.Lenght)].Sign;

                // список с отобранными пользователями
                List<User> list = new List<User>();

                // порядковый номер элемента 
                int n = 1;

                // список ползователей
                var departament = controller.UsersDepart;

                // вывод шапки таблицы
                Departament.ShowHead(-1, "Вывод foreach", $"Заданный знак {sign}");

                // вывод всех пользователей с заданным знаком
                foreach (var item in departament.SignIter(sign))
                {
                    // вывод элемента 
                    item.ShowElem(n++);

                    // добавление элемента в список
                    list.Add(item);
                }

                // вывод подвала таблицы
                Departament.ShowLine();

                Console.WriteLine();

                // вывод списка с отобранными пользователями
                Departament.ShowHead(list.Count, "Вывод списка", $"Заданный знак {sign}");
                Departament.ShowElements(list);
                Departament.ShowLine();
            }

            #endregion

            #region 8. Вывести в список и консоль записи с заданным месяцем

            // 8. Вывести в список и консоль записи с заданным месяцем
            void Point8()
            {
                ShowNavBarMessage("8. Вывести в список и консоль записи с заданным месяцем");

                // случайный номер месяца
                int month = controller.UsersDepart[rand.Next(0, controller.UsersDepart.Lenght)].Date.Month;

                // список с отобранными пользователями
                List<User> list = new List<User>();

                // порядковый номер элемента 
                int n = 1;

                // список ползователей
                var departament = controller.UsersDepart;

                // вывод шапки таблицы
                Departament.ShowHead(-1, "Вывод foreach", $"Заданный номер месяца {month}");

                // вывод всех пользователей с заданным номером месяца
                foreach (var item in departament.MonthIter(month))
                {
                    // вывод элемента 
                    item.ShowElem(n++);

                    // добавление элемента в список
                    list.Add(item);
                }

                // вывод подвала таблицы
                Departament.ShowLine();

                Console.WriteLine();

                // вывод списка с отобранными пользователями
                Departament.ShowHead(list.Count, "Вывод списка", $"Заданный номер месяца {month}");
                Departament.ShowElements(list);
                Departament.ShowLine();
            }

            #endregion

            #region 9. Сортировка по дате рождения

            // 9. Сортировка по дате рождения
            void Point9()
            {
                ShowNavBarMessage("9. Сортировка по дате рождения");

                // вывод после сортировки
                Task1Controller.ShowTable(controller.SortByDate(), info: "Сортировка по дате рождения");
            }

            #endregion

            #region 10. Сортировка по названиям знаков Зодиака

            // 10. Сортировка по названиям знаков Зодиака
            void Point10()
            {
                ShowNavBarMessage("10. Сортировка по названиям знаков Зодиака");

                // вывод после сортировки
                Task1Controller.ShowTable(controller.SortBySign(), info: "Сортировка по знаку Зодиака");
            }

            #endregion

            #region 11. Сортировка по фамилии, имени

            // 11. Сортировка по фамилии, имени
            void Point11()
            {
                ShowNavBarMessage("11. Сортировка по фамилии, имени");

                // сортировка по фамилии
                Task1Controller.ShowTable(controller.SortBySurname(), info: "Сортировка по фамилии");
                                
                // сортировка по имени
                Task1Controller.ShowTable(controller.SortByName(), info: "Сортировка по имени");
            }

            #endregion

        }

        #endregion
    }
}
