using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Models;      // моделей
using HomeWork.Utilities;   // утилит

namespace HomeWork.Controllers
{
    internal class Controller
    {
        // коллекция электроприборов
        private List<ElectricalAppliance> _appliances;

        #region Свойства 

        // доступ к полю _appliances
        public List<ElectricalAppliance> Appliances { get => _appliances; set => _appliances = value; }

        #endregion

        #region Конструкторы 

        // конструктор по умолчанию 
        public Controller() : this(new List<ElectricalAppliance>()) { }

        // конструктор инициализирующий
        public Controller(List<ElectricalAppliance> appliances)
        {
            // установка ссылки на коллекцию 
            _appliances = appliances;

            // установка значений
            Initialization();
        }

        #endregion

        #region Методы

        #region Инициализация

        // коды электроприборов
        private enum ApplianceCode
        {
            // пылесос
            VacuumCleaner,
            // утюг
            FlatIron,
            // тостер
            Toaster,
            // фен 
            HairDryer,
            // чайник
            ElectricKettle
        }

        // инициализация
        public void Initialization()
        {
            // заполнение коллекции
            for (int i = 0; i < Utils.GetRand(10, 15); i++)
                _appliances.Add(FactoryMethod(Utils.GetRand(1, 6)));
        }

        // фабричный метод элекстроприборов
        private ElectricalAppliance FactoryMethod(int code)
        {
            switch (code)
            {
                // пылесос
                case (int)ApplianceCode.VacuumCleaner:
                    return new ElectricalAppliance { Name = "Пылесос", Power = 1600, Price = 15_000 };
                // утюг
                case (int)ApplianceCode.FlatIron:
                    return new ElectricalAppliance { Name = "Утюг", Power = 1200, Price = 5_000 };
                // тостер
                case (int)ApplianceCode.Toaster:
                    return new ElectricalAppliance { Name = "Тостер", Power = 700, Price = 2_500 };
                // фен 
                case (int)ApplianceCode.HairDryer:
                    return new ElectricalAppliance { Name = "Фен", Power = 1400, Price = 3_000 };
                // чайник
                case (int)ApplianceCode.ElectricKettle:
                    return new ElectricalAppliance { Name = "Чайник", Power = 800, Price = 1_500 };
                default:
                    goto case (int)ApplianceCode.VacuumCleaner;
            }
        }

        #endregion

        #region Перемешивание коллекции 

        // Перемешивание коллекции 
        public void Shuffle()
        {
            // размер коллекции 
            int n = _appliances.Count;

            for (int i = 0, k = Utils.GetRand(0, n); i < n; i++, k = Utils.GetRand(0, n))
                (_appliances[i], _appliances[k]) = (_appliances[k], _appliances[i]);
        }

        #endregion

        #region Сортировки 

        // сортировка по названию прибора
        public void OrderByName() => _appliances.Sort((item1, item2) => item1.Name.CompareTo(item2.Name));

        // сортировка по мощности
        public void OrderByPower() => _appliances.Sort((item1, item2) => item1.Power.CompareTo(item2.Power));

        #endregion

        #endregion
    }
}
