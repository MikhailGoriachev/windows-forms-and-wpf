using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Models;              // модели
using HomeWork.Utilities;           // утилиты

/*
 * Задача 1. Разработайте приложение Windows Presentation Foundation c использованием 
 * изученных элементов интерефейса. В кнопочном меню главного окна должны быть кнопки 
 * «Списки Дедов Морозов и Снегурочек», «Ремонт телевизоров», «О программе», «Выход».
 * Разработайте класс для представления данных актера, играющего роль Деда Мороза: 
 * фамилия, имя, отчество, цвет полушубка, количество подарков, которые способен 
 * перенести актер.
 * 
 * Разработайте класс для представления данных актрисы, играющей роль Снегурочки: 
 * фамилия, имя, отчество, цвет полушубка, количество стихотворений, которые знает 
 * актриса, количество игр для детей, которые может организовать актриса.   
 * 
 * Разработайте класс для представления телевизора в ремонтной мастерской: производитель 
 * и тип телевизора, диагональ экрана, строка с описанием дефекта, фамилия и инициалами 
 * мастера, фамилия и инициалы владельца, стоимость ремонта.
 * 
 * Разработайте класс для представления ремонтной мастерской: коллекция телевизоров в 
 * ремонте, название ремонтной мастерской, адрес ремонтной мастерской.
 * 
 * Окно отображения списков Дедов Морозов и Снегурочек показывает два ListView с данными 
 * актеров. Список Дед Морозов задавайте из ресурсов ListView, список Снегурочек – из кода. 
 * 
 * В каждом списке – 12, …, 20 записей.
 * 
 * Окно отображения данных по ремонту телевизоров должно иметь следующий функционал 
 * (за счет командных кнопок в самом окне):
 * •	Начальное формирование данных ремонтной мастерской (коллекция телевизоров от 
 *      12 до 15 штук)
 * •	Добавление телевизора в коллекцию
 * •	Редактирование выбранного телевизора коллекции
 * •	Упорядочивание коллекции телевизоров
 *      o	По производителю и типу
 *      o	По убыванию диагонали экрана
 *      o	По мастеру, выполняющему ремонт
 *      o	По владельцу телевизора
 * •	Выборка и вывод в отдельном окне коллекции телевизоров с минимальной стоимостью
 *      ремонта
 * •	Выборка и вывод в отдельном окне коллекции телевизоров, ремонтируемых выбранным 
 *      мастером
 * •	Выборка и вывод в отдельном окне коллекции телевизоров, с заданной диагональю 
 *      экрана 
*/

namespace HomeWork.Controllers
{
    // Класс Контроллер обработки по заданию
    internal class RepairShopController
    {
        // ремонтная мастерская
        private RepairShopModel _repairShop;

        public RepairShopModel RepairShop
        {
            get => _repairShop; 
            set => _repairShop = value; 
        }


        // доступ к телевизорам в мастерской
        public List<TelevisionModel> Televisions { 
            get => _repairShop.Televisions; 
            set => _repairShop.Televisions = value; 
        }

        #region Конструкторы 

        // конструктор по умолчанию
        public RepairShopController() : this(new RepairShopModel { Address = Utils.GetInfoRepairShop().Address, 
                                                                   Name = Utils.GetInfoRepairShop().Name, 
                                                                   Televisions = RepairShopModel.GenerateTelevision() }) { }


        // конструктор инициализирующий
        public RepairShopController(RepairShopModel repairShop)
        {
            // установка значений
            _repairShop = repairShop;
        }

        #endregion

        #region Методы

        // переформирование коллекции телевизоров
        public void Initialization(int n = 15) =>
            _repairShop.Televisions = RepairShopModel.GenerateTelevision(n);


        // добавление телевизора
        public void Add(TelevisionModel television) => _repairShop.Add(television);


        // добавление телевизора
        public void AddRange(List<TelevisionModel> televisions) => _repairShop.Televisions.AddRange(televisions);


        // удаление телевизора
        public void Remove(TelevisionModel television) => _repairShop.Remove(television);


        // удаление телевизора по индексу
        public void RemoveAt(int index) => _repairShop.RemoveAt(index);


        // очистка списка
        public void Clear() => _repairShop.Clear();


        // упорядочивание по производителю и типу
        public void OrderByModel() => Televisions = Televisions.OrderBy(item => item.Model).ToList();


        // упорядочивание по убыванию диагонали экрана
        public void OrderByDiagonalDesc() => Televisions = Televisions.OrderByDescending(item => item.Diagonal).ToList();


        // упорядочивание по мастеру, выполняющему ремонт
        public void OrderByMaster() => Televisions = Televisions.OrderBy(item => item.Master).ToList();


        // упорядочивание по владельцу телевизора
        public void OrderByOwner() => Televisions = Televisions.OrderBy(item => item.Owner).ToList();


        // выборка и вывод в отдельном окне коллекции телевизоров с минимальной стоимостью ремонта
        public List<TelevisionModel> SelectWhereMinPrice() => Televisions
                                                                .Where(item => item.Price == Televisions.Min(i => i.Price))
                                                                .ToList();


        // Выборка и вывод в отдельном окне коллекции телевизоров, ремонтируемых выбранным мастером
        public List<TelevisionModel> SelectWhereMaster(string master) => Televisions
                                                                        .Where(item => item.Master == master)
                                                                        .ToList();


        // Выборка и вывод в отдельном окне коллекции телевизоров, с заданной диагональю экрана
        public List<TelevisionModel> SelectWhereDiagonal(int diagonal) => Televisions
                                                                        .Where(item => item.Diagonal == diagonal)
                                                                        .ToList();

        #endregion

    }
}
