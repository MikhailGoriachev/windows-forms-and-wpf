using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingListBoxContextMenu.Models
{
    // класс для привязки к элементу интерфейса, binding
    public class Worker
    {
        public static int MaxId = 0;

        public int Id      { get; set; }   // идентфикационный номер
        public string FullName { get; set; }   // имя персоны
        public string Position { get; set; }   // должность
        public int Age     { get; set; }   // возраст в годах

        public override string ToString() =>
            $"Id = {Id};\r\nFullName = {FullName};\r\nPosition = {Position};\r\nAge = {Age}";

        public string TableRow =>
            $"{Id, 5}  │ {FullName, -20} │ {Position, -15} │ {Age, 5} ";
    } // class Worker
}
