using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using static HomeWorkCSharp.Application.App.Utils;      // утилиты

namespace HomeWorkCSharp.Models
{
    // класс Список заявок на авиабилеты
    internal class RequestTicketList : IEnumerable
    {
        #region Свойства

        // список заявок
        public List<RequestOnTicket> Requests { get; set; }

        // размер списка заявок
        public int Length { get => Requests.Count; }

        // название файла для сохранения
        public string NameSaveFile { get; set; }

        #endregion

        #region Конструкторы, индексатор

        // конструктор по умолчанию
        public RequestTicketList() : this(new List<RequestOnTicket>(), @"..\..\TicketsBase.bin") { }

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

        // сохранение списка в бинарный файл
        public void SaveBinaryFile()
        {
            // сохранение всех элементов в файл
            using (BinaryWriter bw = new BinaryWriter(File.Create(NameSaveFile)))
            {
                foreach (RequestOnTicket ticket in Requests)
                    // запись элемента в файл
                    ticket.Write(bw);
            }
        }

        // загрузка списка из бинарного файла
        public void LoadBinaryFile()
        {
            // загрузка всех элементов из файла в список
            using (BinaryReader br = new BinaryReader(File.OpenRead(NameSaveFile)))
            {
                // очистка списка 
                Requests.Clear();

                // количество записей в файле
                int n = (int)new FileInfo(NameSaveFile).Length / RequestOnTicket.BinaryLength;

                // чтение файла и добавление элементов в список
                for (int i = 0; i < n; i++)
                    // чтение элемента из файла
                    Requests.Add(new RequestOnTicket(br));
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
            using (BinaryWriter bw = new BinaryWriter(new FileStream(NameSaveFile, FileMode.Open, FileAccess.ReadWrite)))
            {
                // установка позиции в файле в конец
                bw.Seek(0, SeekOrigin.End);

                // добавление заявки в файл
                request.Write(bw);

                // добавление заявки в список
                Requests.Add(request);
            }
        }

        // удаление заявки по номеру заявки из списка и сохранение списка в файл
        public void RemoveRequest(int numberRequest)
        {
            // удаление заявки из списка
            Requests.RemoveAt(Requests.FindIndex(item => item.NumberRequest == numberRequest));

            // запись списка в файл
            SaveBinaryFile();
        }

        // очистка списка и файла
        public void Clear()
        {
            // отчистка файла (пересоздание)
            using (File.Create(NameSaveFile)) { }

            // отчистка файла
            Requests.Clear();
        }

        // упорядочивание по номеру рейса 
        public void OrderByNumberFlight()
        {
            // упорядочивание по номеру рейса
            Requests.Sort((item1, item2) => item1.NumberFlight.CompareTo(item2.NumberFlight));

            // сохранение коллекции в файл
            SaveBinaryFile();
        }

        // упорядочивание по желаемой дате рейса 
        public void OrderByDate() =>
            // упорядочивание по желаемой дате рейса
            Requests.Sort((item1, item2) => item1.Date.CompareTo(item2.Date));

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
