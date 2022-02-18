using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabControlListView.Models
{
	// подопытный класс
    public class Person
    {
        public int    Id { get; set; }
        public int    ImageId { get; set; }
        public string FullName { get; set; }
        public int    Age { get; set; }
        public int    Salary { get; set; }

        public override string ToString() {
            return $"{Id}. {FullName}, возраст {Age}, оклад {Salary} руб.";
        }

        private static readonly Random RandomGen = new Random();
        public static Person Generate() {

            Person person = new Person();

            string[] surnames = {
                "Иванова О.Г.", "Блаватская Е.Г.", "Романов Н.Г.", 
                "Дмитриев Г.Е.", "Свекольников Д.Н.", "Яковлев П.Р."
            };


            return new Person {
				Id = RandomGen.Next(10_000, 90_000),
                ImageId = RandomGen.Next(0, 14),   // индекс картинки в ImageList
                FullName = surnames[RandomGen.Next(0, surnames.Length)],
                Age = RandomGen.Next(23, 90),
                Salary = RandomGen.Next(10, 54) * 1000
        };
        } // Generate
    } // Person
}
