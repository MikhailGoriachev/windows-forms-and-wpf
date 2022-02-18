namespace TableFunctions.Models
{
    class Person
    {
        // фамилия и инициалы
        private string _fullName;
        public string FullName {
            get => _fullName;
            set => _fullName = value;
        } // FullName

        // возраст в годах
        private int _age;
        public int Age {
            get => _age;
            set => _age = value;
        } // Age

        // оклад, т.р.
        private int _salary;
        public int Salary {
            get => _salary;
            set => _salary = value;
        } // Salary

        // город проживания
        private string _city;
        public string City {
            get => _city;
            set => _city = value;
        } // City
    } // class Person
}
