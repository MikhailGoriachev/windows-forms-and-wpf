using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Utilities
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


        // коллекция персон
        public static (string surname, string name, string patronymic)[] Persons = new[]{
            ("Юрковский",   "Марк",      "Максимилианович"),
            ("Якубовская",  "Диана",     "Павловна"),
            ("Шапиро",      "Федор",     "Федорович"),
            ("Вожжаев",     "Сергей",    "Денисович"),
            ("Хроменко",    "Игорь",     "Владимирович"),
            ("Пелых",       "Марина",    "Ульяновна"),
            ("Лапотникова", "Тамара",    "Оскаровна"),
            ("Огородников", "Сергей",    "Иванович"),
            ("Яйло",        "Екатерина", "Николаевна"),
            ("Лосева",      "Инна",      "Степановна"),
            ("Михайлович",  "Анна",      "Валентиновна"),
            ("Тарапата",    "Михаил",    "Исаакович"),
            ("Трубихин",    "Эдуард",    "Михайлович"),
            ("Чмыхало",     "Олег",      "Тарасович"),
            ("Князьков",    "Степан",    "Сидорович"),
            ("Потемкина",   "Наталья",   "Павловна"),
            ("Гритченко",   "Степан",    "Романович"),
            ("Селиванов",   "Александр", "Михайлович"),
            ("Царькова",    "Лариса",    "Ильинична"),
            ("Яструб",      "Владимир",  "Данилович"),
            ("Мелашенко",   "Александр", "Алексеевич"),
            ("Пономаренко", "Владислов", "Дмитриевич"),
            ("Хавалджи",    "Любовь",    "Амировна"),
            ("Пархоменко",  "Ирина",     "Владимировна"),
            ("Демидова",    "Алина",     "Александровна"),
            ("Лысенко",     "Елена",     "Егоровна"),
            ("Федосенко",   "Оксана",    "Владимировна"),
            ("Богатырева",  "Екатерина", "Алексеевна"),
            ("Иванова",     "Валентина", "Степановна"),
            ("Ильюшин",     "Сергей",    "Юрьевич")
        };


        // получить данные персоны
        public static (string surname, string name, string patronymic) GetPerson() => Persons[GetRand(0, Persons.Length)];


        // города 
        public static string[] Cities = new[]
        {
            "Донецк",
            "Киев",
            "Москва",
            "Макеевка",
            "Львов",
            "Кривой Рог"
        };


        // получить название города
        public static string GetCity() => Cities[GetRand(0, Cities.Length)];


        // типы изданий 
        public static string[] TypesOfEdition = new[]
        {
            "Журнал",
            "Газета",
            "Альманах",
            "Каталог"
        };

        
        // получить тип издания
        public static string GetTypesOfEdition() => TypesOfEdition[GetRand(0, TypesOfEdition.Length)];

        // типы изданий 
        public static string[] Streets = new[]
        {
            "Петровского",
            "Артёма",
            "Горького",
            "Садовая",
            "Содовая",
            "Крамарчука",
            "Дерибасовская"
        };


        // получить тип издания
        public static string GetStreets() => Streets[GetRand(0, Streets.Length)];

        
        // тип и название издания
        public static (string title, string type, string index)[] Editions = new[]
        {            
            ("Новинки Avon",             TypesOfEdition[3], "75418"),
            ("Новинки Oriflame",         TypesOfEdition[3], "87951"),
            ("Аргументы и факты",        TypesOfEdition[1], "87956"),
            ("Вечерняя Москва",          TypesOfEdition[1], "98516"),
            ("Известия",                 TypesOfEdition[1], "14657"),
            ("National Geographic",      TypesOfEdition[0], "23165"),
            ("Glamour",                  TypesOfEdition[0], "19851"),
            ("Земля моя кормилица",      TypesOfEdition[2], "98416"),
            ("Земля и люди",             TypesOfEdition[1], "95184"),
            ("Образ жизни",              TypesOfEdition[2], "23154"),
            ("Литературный оверлок",     TypesOfEdition[2], "65484"),
            ("Мы все с планеты",         TypesOfEdition[2], "32134"),
            ("Правда",                   TypesOfEdition[1], "21654"),
            ("Природа Европы",           TypesOfEdition[1], "21891"),
            ("Правда",                   TypesOfEdition[1], "87941"),
            ("Правда",                   TypesOfEdition[1], "89512"),
            ("Земля и люди",             TypesOfEdition[1], "95175")
        };

        
        
        // полученить тип и название издания
        public static (string title, string type, string index) GetEdition() => Editions[GetRand(0, Editions.Length)];


        // получить дату подписки
        public static DateTime GetDate() => new DateTime(GetRand(15, 21) + 2000, GetRand(1, 12), GetRand(1, 25));


        // период подписки 
        public static int[] Duration => new[] { 1, 3, 6, 12 };


        // получить период подписки
        public static int GetDuration() => Duration[GetRand(0, Duration.Length)];
        
    }
}