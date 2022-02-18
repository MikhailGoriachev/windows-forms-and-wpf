using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;         // JSON сериализация
using System.Runtime.Serialization.Json;    // JSON сериализация
using System.IO;                            // потоки данных

namespace HomeWork.Models
{
    // Класс Домашние электроприборы
    [DataContract]
    public class HomeAppliances
    {
        [DataMember]
        // адрес квартиры
        private string _address;

        [DataMember]
        // коллекция электроприборов
        private List<ElectricalAppliance> _appliances;

        #region Конструкторы

        // конструктор по умолчанию
        public HomeAppliances()
        {
            // устнаовка значений
            _appliances = new List<ElectricalAppliance>();
        }

        #endregion

        #region Свойства 

        // доступ к полю _address
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        // доступ к полю _appliances
        public List<ElectricalAppliance> Appliances
        {
            get => _appliances;
            set => _appliances = value;
        }

        // размер коллекции приборов
        public int Count => _appliances.Count;

        // получение названий электроприборов
        public List<string> TitlesAppliances { get
            {
                // получение коллекции уникальных названий приборов
                SortedSet<string> set = new SortedSet<string>();

                _appliances.ForEach(item => set.Add(item.Name));

                return new List<string>(set);
            }
        }

        #endregion

        #region Методы

        // добавление элемента в коллекцию
        public void Add(ElectricalAppliance appliance) => _appliances.Add(appliance);

        // удаление элемента из коллекции по индексу
        public void RemoveAt(int index) => _appliances.RemoveAt(index);

        // удаление элемента из коллекции по ссылке
        public void Remove(ElectricalAppliance appliance) => _appliances.Remove(appliance);

        // сортировка коллекции приборов 
        public List<ElectricalAppliance> SortBy(Comparison<ElectricalAppliance> comparison)
        {
            // копия коллекции 
            List<ElectricalAppliance> appliances = new List<ElectricalAppliance>(_appliances);

            // сортировка по компаратору
            appliances.Sort(comparison);

            return appliances;
        }
        
        // выборка из коллекции приборов 
        public List<ElectricalAppliance> SelectWhere(Predicate<ElectricalAppliance> predicate) 
            => _appliances.FindAll(predicate);


        // сериализация в JSON формате
        public void Serialization(FileStream fs)
       {
            // форматтер
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(HomeAppliances));

            // сериализация
            serializer.WriteObject(fs, this);
        }

        // десериализация в JSON формате
        public static HomeAppliances Deserilization(FileStream fs)
        {
            // форматтер 
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(HomeAppliances));

            // десериализация
            return serializer.ReadObject(fs) as HomeAppliances;
        }

        // включение/выключение прибора по ссылке  
        public void TurnPower(ElectricalAppliance appliance, bool state) 
            => _appliances[_appliances.IndexOf(appliance)].TurnPower(state);

        // включение/выключение прибора по индексу
        public void TurnPower(int index, bool state) 
            => _appliances[index >= 0 && index < _appliances.Count ? index : 
                throw new Exception("HomeAppliances: Выход за пределы коллекции!")].TurnPower(state);

        // включение/выключение всех приборов
        public void TurnPowerAll(bool state) 
            => _appliances.ForEach(item => item.TurnPower(state));

        #endregion
    }
}
