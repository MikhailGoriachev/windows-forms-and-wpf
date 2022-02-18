using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace HomeWork.Models.Task2
{
    // Класс Модель периодического издания для сохранения в файл в JSON формате
    [DataContract]
    public class PeriodicalSaveModel
    {

        // фамилию и инициалы подписчика
        [DataMember]
        public string FullName { get; set; }


        // название издания
        [DataMember]
        public string Title { get; set; }


        // тип издания
        [DataMember]
        public string TypeEdition { get; set; }


        // индекс издания
        [DataMember]
        public string Index { get; set; }


        // дата начала подписки
        [DataMember]
        public DateTime DateSubscribe { get; set; }


        // период подписки (месяц)
        [DataMember]
        public int Duration { get; set; }


        // название улицы
        [DataMember]
        public string Street { get; set; }


        // номер дома
        [DataMember]
        public string Home { get; set; }


        // номер квартиры (если квартира отсутсвует значение: 0)
        [DataMember]
        public int Apartment { get; set; }


        #region Конструкторы

        // конструктор по умолчанию
        public PeriodicalSaveModel() { }


        // конструктор инициализирующий
        public PeriodicalSaveModel(PeriodicalModel periodical)
        {
            // установка значений
            SetValue(periodical);
        }

        #endregion

        #region Методы

        // установка значений полей из переодического издания
        public void SetValue(PeriodicalModel periodical)
        {
            FullName        = periodical.FullName;
            Title           = periodical.Title;
            Index           = periodical.Index;
            Duration        = periodical.Duration;
            DateSubscribe   = periodical.DateSubscribe;
            Street          = periodical.Street;
            Home            = periodical.Home;
            Apartment       = periodical.Apartment;
            TypeEdition     = periodical.TypeEdition;
        }


        // установка значений полей из переодического издания
        public PeriodicalModel GetPeriodicalModel()
        {
            PeriodicalModel model = new PeriodicalModel();

            model.FullName        = FullName;
            model.Title           = Title;
            model.Index           = Index;
            model.Duration        = Duration;
            model.DateSubscribe   = DateSubscribe;
            model.Street          = Street;
            model.Home            = Home;
            model.Apartment       = Apartment;
            model.TypeEdition     = TypeEdition;

            return model;
        }

        #endregion
    }
}
