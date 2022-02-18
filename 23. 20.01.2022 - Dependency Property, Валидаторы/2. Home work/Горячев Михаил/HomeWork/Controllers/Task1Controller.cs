using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeWork.Models;              // модели 
using HomeWork.Models.Task1;        // модели для задания 1

/*    
 *  Задача 1. Разработайте приложение Windows Presentation Foundation 
 *  для закрепления изученных тем. 
 *  Разработайте класс с использованием свойств зависимости для 
 *  представления данных сотрудника: фамилия, имя, отчество, возраст,
 *  оклад, город проживания. Используйте корректирующие валидаторы для 
 *  возраста (от 0 до 190), оклада (от 0 до 1 000 000).
 *  
 *  В главном окне разместите кнопку для добавления данных сотрудника
 *  в коллекцию, коллекцию отображайте в DataGrid с форматированием 
 *  ячеек, заданием шаблонов ячеек, заголовков.
 *  
 *  Коллекцию упорядочивайте по фамилии, имени, отчества сотрудника.
 *  
 *  Добавление данных сотрудника реализуйте в отдельном окне с 
 *  использованием привязки, свойств зависимости.
 *  
 *  Для выбранной строки в DataGrid реализуйте редактирование в том же 
 *  окне, что и добавление, удаление записи из коллекции (это может быть 
 *  контекстное меню или другая реализация по Вашему выбору).
*/

namespace HomeWork.Controllers
{
    // Класс Контроллер обработки персон по заданию 1
    public class Task1Controller
    {
        // коллекция сотрудников 
        private List<EmployeeModel  > _employees;

        public List<EmployeeModel> Employees
        {
            get => _employees;
            set => _employees = value;
        }


        #region Конструкторы


        // конструктор по умолчанию
        public Task1Controller() : this(new List<EmployeeModel>().GetEmployees()) { }


        // конструктор инициализирующий
        public Task1Controller(List<EmployeeModel> employees)
        {
            // установка значений
            _employees = employees;
        }


        #endregion

        #region Методы


        // формирование коллекции сотрудников
        public void Initialization() => _employees = new List<EmployeeModel>().GetEmployees();


        // добавление сотрудника
        public void Add(EmployeeModel employee) => _employees.Add(employee);


        // удаление сотрудника
        public void Remove(EmployeeModel employee) => _employees.Remove(employee);


        // удаление сотрудника по индексу
        public void RemoveAt(int index) => _employees.RemoveAt(index);


        // очистка списка сотрудников
        public void Clear() => _employees.Clear();


        // добавление коллекции сотрудников
        public void AddRange(int n = 15) => _employees.AddRange(new List<EmployeeModel>().GetEmployees(n));


        // сортировка по полю Фамилия
        public void SortBySurname() => _employees = _employees.OrderBy(e => e.Surname).ToList();


        // сортировка по полю Имя
        public void SortByName() => _employees = _employees.OrderBy(e => e.Name).ToList();


        // сортировка по полю Отчество
        public void SortByPatronymic() => _employees = _employees.OrderBy(e => e.Patronymic).ToList();


        #endregion
    }
}
