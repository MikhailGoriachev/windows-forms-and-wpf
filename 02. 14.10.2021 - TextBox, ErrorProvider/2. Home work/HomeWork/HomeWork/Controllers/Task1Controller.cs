using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;
using HomeWork.Models.Task1;  // модели

using static HomeWork.Application.App.Utils;    // подключение утилит

namespace HomeWork.Controllers
{
    // Класс Обработка по заданию
    internal class Task1Controller
    {
        #region Свойства 

        // коллекция пользователей 
        public Departament UsersDepart { get; set; }

        #endregion

        #region Конструкторы 

        // конструктор по умолчанию
        public Task1Controller() : this(new Departament()) { }

        // конструктор инициализирующий
        public Task1Controller(Departament depart)
        {
            // установка значений
            UsersDepart = depart;

            Initialization();
        }

        #endregion

        #region Методы

        #region Формирование данных

        // формирование данных
        public void Initialization(int size = 20)
        {
            // отчистка коллекции
            UsersDepart.Users.Clear();

            // заполнение коллекции
            for (int i = 0; i < size; i++)
                UsersDepart.Users.Add(FactoryMethodUser());
        }

        // фабричный метод создания пользователя 
        public User FactoryMethodUser()
        {
            // имена
            string[] names = new[]
            {
                "Трофим",
                "Геннадий",
                "Степан",
                "Павел",
                "Шамиль",
                "Назар",
                "Антон",
                "Валентин",
                "Никита",
                "Тимофей",
            };

            // фамилии
            string[] surnames = new[]
            {
                "Повалий",
                "Шумейко",
                "Иващенко",
                "Тарасюк",
                "Крюков",
                "Захарченко",
                "Вишняков",
                "Кудрявцев",
                "Забужко",
                "Соловьёв",
            };

            // создание пользователя
            return new User
            {
                Name = names[rand.Next(0, names.Length)],
                Surname = surnames[rand.Next(0, surnames.Length)],
                Date = new DateTime(rand.Next(1940, 1970),
                                    rand.Next(1, 13),
                                    rand.Next(1, 29))
            };
        }

        #endregion

        #region Добавление трёх пользователей в коллекцию

        // добавление трёх пользователей в коллекцию (с зажиганием событий)
        public void AddThreeUsers()
        {
            // подписка обработчика на событие 
            UsersDepart.Users.CollectionChanged += UsersEventHandler;

            // вывод всех пользователей
            ShowTable(info: $"Добавление элементов 0 / 3");

            // пауза в одну секунду
            Thread.Sleep(1500);

            // добавление трёх пользователей с интервалом в секунду
            for (int i = 0; i < 3; i++)
            {
                // создание пользователя
                User user = FactoryMethodUser();

                // установка месяца и дня рождения, чтоб знак был "Рыба"
                user.Date = new DateTime(rand.Next(1960, 2010), 3, rand.Next(1, 21));

                // добавление пользователя
                UsersDepart.Users.Add(user);

                // установка курсора в начало экрана
                PosXY(0, 2);

                // вывод всех пользователей
                ShowTable(info: $"Добавление элементов {i + 1} / 3");

                // пауза в одну секунду
                Thread.Sleep(1500);
            }

            // отписка обработчика от события
            UsersDepart.Users.CollectionChanged -= UsersEventHandler;
        }

        #endregion

        #region Удаление всех пользователей возраст, которых больше 60

        // Удаление всех пользователей возраст, которых больше 60
        public void RemoveUserAgeOverSixty(string navBar)
        {
            // подписка обработчика на событие 
            UsersDepart.Users.CollectionChanged += UsersEventHandler;

            // текущая дата 
            DateTime cur = DateTime.Now;

            // вывод всех пользователей
            ShowTable(info: $"Удаление пользователей");

            // пауза в одну секунду
            Thread.Sleep(1500);

            // удаление всех пользователей возраст, которых больше 60
            for (int i = 0; i < UsersDepart.Lenght; i++)
            {
                // если возраст пользователя больше 60
                if (UsersDepart[i].Date.AddYears(60) < DateTime.Now)
                {
                    // очистка консоли
                    Console.Clear();

                    ShowNavBarMessage(navBar);

                    // удаление элемента
                    UsersDepart.Users.RemoveAt(i);

                    // позиционирование курсора
                    PosXY(0, 2);

                    // вывод всех пользователей
                    ShowTable(info: $"Удаление пользователей");

                    // пауза в одну секунду
                    Thread.Sleep(1000);

                    i--;
                }
            }

            // отписка обработчика от события
            UsersDepart.Users.CollectionChanged -= UsersEventHandler;
        }

        #endregion

        #region Замена всех записей знака Овен этими же записями, но с добавлением строки "-бе-бе" к фамилии

        // замена всех записей знака Овен этими же записями, но с добавлением строки "-бе-бе" к фамилии
        public void ReplaceUserSign(string navBar)
        {
            // подписка обработчика на событие 
            UsersDepart.Users.CollectionChanged += UsersEventHandler;

            // пользователи
            var users = UsersDepart.Users;

            // вывод всех пользователей
            ShowTable(info: $"Замена пользователей");

            // пауза
            Thread.Sleep(1500);

            // удаление всех пользователей знак, которых Овен
            for (int i = 0; i < users.Count; i++)
            {
                // если возраст пользователя больше 60
                if (users[i].Sign == "Овен")
                {
                    // очистка консоли
                    Console.Clear();

                    ShowNavBarMessage(navBar);

                    // добавление строки к фамилии и замена
                    users[i] = new User { Date = users[i].Date, Surname = users[i].Surname + "-бе-бе", Name = users[i].Name };

                    // позиционирование курсора
                    PosXY(0, 2);

                    // вывод всех пользователей
                    ShowTable(info: $"Замена пользователей");

                    // пауза в одну секунду
                    Thread.Sleep(500);
                }
            }

            // отписка обработчика от события
            UsersDepart.Users.CollectionChanged -= UsersEventHandler;
        }

        #endregion

        #region Обработчик событий (Create, Delete, Replace)

        // событие при добавлении пользователя в коллекцию
        private void UsersEventHandler(Object sender, NotifyCollectionChangedEventArgs a)
        {
            switch (a.Action)
            {
                // добавление элемента
                case NotifyCollectionChangedAction.Add:
                    ShowHandler("Добавленный элемент", a.NewItems[0] as User);
                    break;

                // удаление элемента
                case NotifyCollectionChangedAction.Remove:
                    ShowHandler("Удалённый элемент", a.OldItems[0] as User);
                    break;

                // замена элемента
                case NotifyCollectionChangedAction.Replace:
                    ShowHandler("Новый элемент", a.NewItems[0] as User);
                    ShowHandler("Старый элемент", a.OldItems[0] as User, 27);
                    break;
            }
        }

        // вывод обработчика
        private void ShowHandler(string name, User user, int startY = 2)
        {
            WriteColorXY("╔══════════════════════╗\n", 94, startY, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"{name, -20}", 96, textColor: ConsoleColor.Cyan);
            Console.WriteLine();

            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"        ID          ", 96, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();
            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"{user.ID,10}", 96, textColor: ConsoleColor.Green);
            Console.WriteLine();

            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"      Фамилия        ", 96, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();
            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"{user.Surname,-20}", 96, textColor: ConsoleColor.Cyan);
            Console.WriteLine();

            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"        Имя          ", 96, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();
            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"{user.Name,-20}", 96, textColor: ConsoleColor.Cyan);
            Console.WriteLine();

            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"    Знак Зодиака     ", 96, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();
            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"{user.Sign,-20}", 96, textColor: ConsoleColor.Green);
            Console.WriteLine();

            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"    Дата рождения    ", 96, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();
            WriteColorXY("╠══════════════════════╣\n", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY("║                      ║", 94, textColor: ConsoleColor.Magenta);
            WriteColorXY($"{user.Date,10:d}", 101, textColor: ConsoleColor.Green);
            Console.WriteLine();

            WriteColorXY("╚══════════════════════╝\n", 94, textColor: ConsoleColor.Magenta);
        }

        #endregion

        #region Сортировка по дате рождения

        // сортировка по дате рождения
        public User[] SortByDate() => UsersDepart.SortByDate();

        #endregion

        #region Сортировка по знаку Зодиака

        // сортировка по знаку Зодиака
        public User[] SortBySign() => UsersDepart.SortBySign();

        #endregion

        #region Сортирока по фамилии

        // сортировка по фамилии
        public User[] SortBySurname() => UsersDepart.SortBySurname();

        #endregion

        #region Сортировка по имени

        // сортировка по имени
        public User[] SortByName() => UsersDepart.SortByName();

        #endregion

        #region Вывод таблицы

        // вывод таблицы
        public void ShowTable(string name = "Пользователи", string info = "Исходные данные") =>
            UsersDepart.ShowTable(name, info);

        // вывод таблицы
        public static void ShowTable(IEnumerable<User> users, string name = "Пользователи", string info = "Исходные данные") 
        {
            // вывод шапки таблицы
            Departament.ShowHead(users.Count(), name, info);

            // вывод элементов 
            Departament.ShowElements(users);

            // вывод подвала таблицы
            Departament.ShowLine();
        }

        #endregion

        #endregion
    }
}
