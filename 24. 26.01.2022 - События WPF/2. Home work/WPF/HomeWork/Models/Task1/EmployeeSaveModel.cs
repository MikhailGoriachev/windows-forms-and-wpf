using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;     // для сериализации       

namespace HomeWork.Models.Task1
{
    // Класс Модель для записи в формате JSON объекта EmployeeModel
    [DataContract]
    public class EmployeeSaveModel
    {
        // фамилия
        [DataMember]
        public string Surname { get; set; }


        // имя
        [DataMember]
        public string Name { get; set; }


        // отчество
        [DataMember]
        public string Patronymic { get; set; }


        // возраст
        [DataMember]
        public int Age { get; set; }


        // оклад
        [DataMember]
        public int Salary { get; set; }


        // город проживания
        [DataMember]
        public string City { get; set; }


        #region Конструкторы

        // конструктор по умолчанию
        public EmployeeSaveModel() : this(new EmployeeModel()) { }


        // конструктор инициализирующий
        public EmployeeSaveModel(EmployeeModel employeeModel)
        {
            // установка значений
            SetValue(employeeModel);
        }

        #endregion

        #region Методы

        // установка значений из модели
        public void SetValue(EmployeeModel employeeModel)
        {
            Surname     = employeeModel.Surname;
            Name        = employeeModel.Name;
            Patronymic  = employeeModel.Patronymic;
            Age         = employeeModel.Age;
            Salary      = employeeModel.Salary;
            City        = employeeModel.City;
        }


        // получение EmployeeModel
        public EmployeeModel GetEmployeeModel() =>
            new EmployeeModel
            {
                Surname = Surname,
                Name = Name,
                Patronymic = Patronymic,
                Age = Age,
                Salary = Salary,
                City = City
            };


        #endregion
    }
}
