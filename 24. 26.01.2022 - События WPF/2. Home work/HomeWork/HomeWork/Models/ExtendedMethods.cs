using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeWork.Utilities;           // утилиты
using HomeWork.Models.Task1;        // модели задания 1
using HomeWork.Models.Task2;        // модели задания 2

namespace HomeWork.Models
{
    // Класс Расширяющие методы
    public static class ExtendedMethods
    {
        #region Расширяющие методы для задания 1

        // генерация списка сотрудников
        public static List<EmployeeModel> GetEmployees(this List<EmployeeModel> employees, int n = 15)
        {
            List<EmployeeModel> list = new List<EmployeeModel>();

            for (int i = 0; i < n; i++)
                list.Add(EmployeeModel.GetEmployee());

            return list;
        }

        #endregion

        #region Расширяющие методы для задания 2

        // генерация списка подписок
        public static List<PeriodicalModel> GetPeriodicals(this List<PeriodicalModel> periodicals, int n = 15)
        {
            List<PeriodicalModel> list = new List<PeriodicalModel>();

            for (int i = 0; i < n; i++)
                list.Add(PeriodicalModel.GetPeriodical());

            return list;
        }


        #endregion


    }
}
