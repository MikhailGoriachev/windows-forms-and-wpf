using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

using static HomeWorkCSharp.Application.App.Utils;      // утилиты

namespace HomeWorkCSharp.Models
{
    // класс Список заявок на авиабилеты
    public class RequestTicketList : IEnumerable
    {
        #region Свойства

        // список заявок
        public List<RequestOnTicket> Requests { get; set; }

        // размер списка заявок
        public int Length { get => Requests.Count; }

        // название файла для сохранения в формате JSON
        public string NameSaveFile { get; set; }

        #endregion

        #region Конструкторы, индексатор

        // конструктор по умолчанию
        public RequestTicketList() : this(new List<RequestOnTicket>(), @"..\..\tickets.json") { }

        // конструктор инициализирующий
        public RequestTicketList(List<RequestOnTicket> requests, string nameSaveFile)
        {
            // установка значений
            Requests = requests;
            NameSaveFile = nameSaveFile;
        }

        // индексатор
        public RequestOnTicket this[int index]
        {
            get => isIndex(index) ? Requests[index] : 
                throw new IndexOutOfRangeException($"RequestTicketList: Выход за " +
                    $"пределы коллекции! Значение индекса: {index}");

            set => Requests[index] = isIndex(index) ? value :
                throw new IndexOutOfRangeException($"RequestTicketList: Выход за " +
                    $"пределы коллекции! Значение индекса: {index}");
        }

        // проверка индекса на корректность
        private bool isIndex(int index) => index >= 0 && index < Requests.Count();

        #endregion

        #region Методы

        // JSON сериализация списка
        public void JsonSerializationList()
        {
            // сохранение всех элементов в файл
            using (FileStream fs = new FileStream(NameSaveFile, FileMode.Create, FileAccess.Write))
            {
                // форматтер 
                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<RequestOnTicket>));

                // сериализация коллекции
                formatter.WriteObject(fs, Requests);                             
            }
        }

        // JSON десериализация списка
        public void JsonDeserializationList()
        {
            // загрузка всех элементов из файла в список
            using (FileStream fs = new FileStream(NameSaveFile, FileMode.OpenOrCreate, FileAccess.Read))
            {
                // очистка списка 
                Requests.Clear();

                // форматтер 
                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<RequestOnTicket>));

                // десериализация коллекции
                Requests = formatter.ReadObject(fs) as List<RequestOnTicket>;
            }
        }

        // именованный итератор по заявкам с заданным номером рейса и датой вылета
        public IEnumerable<RequestOnTicket> IterByNumFlightAndDate(string numberFlight, DateTime date)
        {
            for (int i = 0; i < Requests.Count(); i++)
                if (Requests[i].NumberFlight == numberFlight && Requests[i].Date == date)
                    yield return Requests[i];
        }

        // добавление заявки в список и файл
        public void AddRequest(RequestOnTicket request)
        {
            // добавление заявки в список
            Requests.Add(request);

            // сериализация модифицированной коллекции
            JsonSerializationList();
        }

        // удаление заявки по номеру заявки из списка и сохранение списка в файл
        public void RemoveRequest(int numberRequest)
        {
            // добавление заявки в список
            Requests.Remove(Requests.Find(item => item.NumberRequest == numberRequest));

            // сериализация модифицированной коллекции
            JsonSerializationList();
        }

        // очистка списка и файла
        public void Clear()
        {
            // отчистка файла
            Requests.Clear();

            // сериализация модифицированной коллекции
            JsonSerializationList();
        }

        // упорядочивание по номеру рейса 
        public void OrderByNumberFlight()
        {
            // упорядочивание по номеру рейса
            Requests.Sort((item1, item2) => item1.NumberFlight.CompareTo(item2.NumberFlight));

            // сериализация модифицированной коллекции
            JsonSerializationList();
        }

        // упорядочивание по желаемой дате рейса 
        public void OrderByDate()
        {
            // упорядочивание по желаемой дате рейса
            Requests.Sort((item1, item2) => item1.Date.CompareTo(item2.Date));

            // сериализация модифицированной коллекции
            JsonSerializationList();
        }

        // реализация интерфейса IEnumerable
        public IEnumerator GetEnumerator() => Requests.GetEnumerator();

        // вывод списка в таблицу
        public void ShowTable(string name = "Заявки", string info = "Исходные данные")
        {
            // вывод шапки таблицы
            ShowHead(Requests.Count, name, info);

            // вывод элементов в таблицу
            ShowElements(Requests);

            // вывод подавала таблицы
            ShowLine();
        }

        // вывод шапки таблицы
        public static void ShowHead(int size, string name = "Заявки", string info = "Исходные данные")
        {
            //                       10                     30                                    41
            WriteColorXY("     ╔════════════╦════════════════════════════════╦═══════════════════════════════════════════╗\n", textColor:ConsoleColor.Magenta);
            WriteColorXY("     ║            ║                                ║                                           ║", textColor:ConsoleColor.Magenta);
            WriteColorXY("Размер: ", 7, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{size, 2}", textColor: ConsoleColor.Green);
            WriteColorXY("Название: ", 20, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{name,-20}", textColor: ConsoleColor.Green);
            WriteColorXY("Инфо: ", 53, textColor: ConsoleColor.DarkYellow);
            WriteColorXY($"{info,-35}", textColor: ConsoleColor.Green);
            Console.WriteLine();

            //                    2       10                20                10                20                10
            WriteColorXY("     ╠════╦═══════╩════╦══════════════════════╦════╩═══════╦══════════════════════╦════════════╣\n", textColor: ConsoleColor.Magenta);
            WriteColorXY("     ║    ║            ║                      ║            ║                      ║            ║", textColor:ConsoleColor.Magenta);
            WriteColorXY("N ", 7, textColor: ConsoleColor.DarkYellow);
            WriteColorXY("  Заявка  ", 12, textColor: ConsoleColor.DarkYellow);
            WriteColorXY("  Пункт назначения  ", 25, textColor: ConsoleColor.DarkYellow);
            WriteColorXY("   Рейс   ", 48, textColor: ConsoleColor.DarkYellow);
            WriteColorXY("     Покупатель     ", 61, textColor: ConsoleColor.DarkYellow);
            WriteColorXY("Жел. дата ", 84, textColor: ConsoleColor.DarkYellow);
            Console.WriteLine();

            WriteColorXY("     ╠════╬════════════╬══════════════════════╬════════════╬══════════════════════╬════════════╣\n", textColor: ConsoleColor.Magenta);
        }

        // вывод элементов в таблицу
        public static void ShowElements(IEnumerable<RequestOnTicket> collection)
        {
            // порядковый номер элемента
            int i = 1;

            // вывод элементов
            foreach (var item in collection)
                item.ShowElem(i++);
        }

        // вывод подвала таблицы
        public static void ShowLine() =>
            WriteColorXY("     ╚════╩════════════╩══════════════════════╩════════════╩══════════════════════╩════════════╝\n", textColor: ConsoleColor.Magenta);

        #endregion
    }
}
