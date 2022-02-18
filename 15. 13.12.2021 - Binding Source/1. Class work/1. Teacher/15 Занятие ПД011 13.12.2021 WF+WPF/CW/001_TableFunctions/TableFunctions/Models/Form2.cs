using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TableFunctions.Models
{
    // пример заполнения DataGridView данными коллекции
    // !! это только начало изучения DataGridView - в дальнейшем работа 
    // !! с коллекциями будет выполняться при помощи привязки через
    // !! DataSource
    public partial class Form2 : Form
    {
        // Только для упрощения создадим коллекцию объектов прямо в классе формы
        private List<Person> _persons;

        // коллекциию создадим в конструкторе
        public Form2() {
            InitializeComponent();

            // начальное заполнение коллекции объектов
            _persons = new List<Person>(new [] {
                new Person {FullName = "Ямпольский О.Д.", Age = 26, Salary = 23000, City = "Ясиноватая"},
                new Person {FullName = "Димитриев Л.Е.",  Age = 22, Salary = 23000, City = "Макеевка"},
                new Person {FullName = "Петров А.Ю.",     Age = 54, Salary = 27000, City = "Моспино"},
                new Person {FullName = "Васечкина О.К.",  Age = 21, Salary = 29000, City = "Ждановка"},
                new Person {FullName = "Жужа Н.Е.",       Age = 76, Salary = 32000, City = "Хрящеватая"},
                new Person {FullName = "Армавирова Ф.Е.", Age = 43, Salary = 38000, City = "Еленовка"},
                new Person {FullName = "Терновская У.К.", Age = 48, Salary = 29000, City = "Макеевка"},
                new Person {FullName = "Цветовод А.Е.",   Age = 51, Salary = 41000, City = "Ларино"},
                new Person {FullName = "Волк С.М.",       Age = 39, Salary = 18000, City = "Ломакино"}});
        } // Form2


        // Заполнение DataGridView проведем в обработчике события загрузки формы
        // !! В дальнейшем будем использовать свойство DataSource для работы с
        // !! коллекциями данных
        private void Form2_Load(object sender, EventArgs e) {
            // конечно, чистить строки пустой таблицы избыточно, но для
            // демонстрации возможностей - годится
            DgvPersons.Rows.Clear();

            int i = 0;
            foreach (var person in _persons) {
                DgvPersons.RowCount++;

                // задать данные для отображения в ячейке, можно также настроить 
                // стиль для конкретной ячейки.
                // Для примера настроим выравнивание
                DgvPersons[0, i].Value = i+1;
                DgvPersons[0, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DgvPersons[1, i].Value = person.FullName;
                DgvPersons[1, i].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

                DgvPersons[2, i].Value = person.Age;
                DgvPersons[2, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                // зададим конкретный формат выводимых данных
                DgvPersons[3, i].Value = $"{person.Salary:n2}";
                DgvPersons[3, i].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DgvPersons[4, i].Value = person.City;
                DgvPersons[4, i].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                ++i;
            } // foreach person
        } // Form2_Load


        // Отобразить данные коллекции, соответствующие выбранной строке
        // в MessageBox - обработчик пункта контекстного меню DataGridView
        private void ShowSelected_Command(object sender, EventArgs e) {
            // ничего не выбрано - молча уходим
            if (DgvPersons.SelectedRows.Count == 0) return;

            // Отобразить данные, соответствующие выбранной строке таблицы
            // DgvPersons.SelectedRows[0].Index - индекс выбранной строки
            Person person = _persons[DgvPersons.SelectedRows[0].Index];

            MessageBox.Show(
                $"В таблице выбрана строка с номером {DgvPersons.SelectedRows[0].Index}\n" +
                    $"Фамилия И.О.: {person.FullName}\n" +
                    $"Возраст, лет: {person.Age}\n" +
                    $"Оклад, руб.: {person.Salary} руб.\n" +
                    $"Город проживания: {person.City}",
                "К сведению", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // ShowSelected_Command


        // Закрыть форму - обработчик пункта контекстного меню DataGridView
        private void Close_Command(object sender, EventArgs e) => Close();
    } // class Form2
}
