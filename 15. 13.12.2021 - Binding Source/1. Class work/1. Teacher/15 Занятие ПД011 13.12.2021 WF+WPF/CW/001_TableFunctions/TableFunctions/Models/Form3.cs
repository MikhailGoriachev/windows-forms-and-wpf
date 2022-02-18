using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableFunctions.Models
{
    public partial class Form3 : Form
    {
        // Только для упрощения создадим коллекцию объектов прямо в классе формы
        private List<Person> _persons;

        // коллекциию создадим в конструкторе
        public Form3() {
            InitializeComponent();

            // пример стилизации конкретного столбца
            ColSalary.CellTemplate.Style.Font = new Font("Verdana", 10);

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

            // !! В DataSource надо будет записать ссылку на коллекцию из контроллера 
            BnsPerson.DataSource = _persons;
            DgvPersons.DataSource = BnsPerson;
        } // Form3

        // событие CellFormatting - стилизация ячейки по ее значению
        private void SetCellStyle(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex != 1) return;

            int age = ((Person) BnsPerson[e.RowIndex]).Age;
            if (age <= 30)
                e.CellStyle.BackColor = Color.GreenYellow;
            else if (age > 30 && age < 60)
                e.CellStyle.BackColor = Color.Bisque;
            else {
                e.CellStyle.BackColor = Color.BurlyWood;
            } // if
        } // SetCellStyle

        private void RemoveAt_Command(object sender, EventArgs e) {
            if (DgvPersons.SelectedRows.Count == 0) return;

            int index = DgvPersons.SelectedRows[0].Index;
            (BnsPerson.DataSource as List<Person>).RemoveAt(index);
            
            // перестроить привязку - обновить коллекцию в DataGridView
            BnsPerson.ResetBindings(false);

            // TODO: скорректировать код для корректной обработки "последней строки"
            DgvPersons.Rows[index].Selected = true;
        } // RemoveAt_Command

        // Изменение текущей записи
        private void UpdateAt_Command(object sender, EventArgs e) {
            if (DgvPersons.SelectedRows.Count == 0) return;

            int index = DgvPersons.SelectedRows[0].Index;
            (BnsPerson.DataSource as List<Person>)[index].Salary += 5_000;

            // перестроить привязку - обновить коллекцию в DataGridView
            BnsPerson.ResetBindings(false);
            DgvPersons.Rows[index].Selected = true;
        }

        // Добавление записи
        private void Add_Command(object sender, EventArgs e) {
            // запомнить текущую строку
            int index = DgvPersons.SelectedRows[0].Index;

            // добавить запись в коллекцию 
            (BnsPerson.DataSource as List<Person>).Add(new Person {
                FullName = "Романофф Н.А.", Age = 34, City = "Горловка",
                Salary = 42_000
            });

            // перестроить привязку - обновить коллекцию в DataGridView
            BnsPerson.ResetBindings(false);
            DgvPersons.Rows[index].Selected = true;
        }

        // строка в которой был клик делаем текущей
        private void DgvPersons_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            if (e.Button != MouseButtons.Right || e.RowIndex == -1) return;
            
            DgvPersons.Rows[e.RowIndex].Selected = true;
        }


    }
}
