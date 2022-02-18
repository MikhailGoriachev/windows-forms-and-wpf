using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using HomeWork.Utilities;           // утилиты
using HomeWork.Models.Task1;        // модели

namespace HomeWork.Views.Task1
{
    /// <summary>
    /// Interaction logic for EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {
        // обрабатываемый сотрудник
        private EmployeeModel _employee;

        public EmployeeModel Employee => _employee;


        #region Конструкторы 


        // конструктор по умолчанию (Запуск формы в режиме создания)
        public EmployeeWindow()
        {
            InitializeComponent();

            // получение окна для запуска в режиме создания
            _employee = Resources["EmployeeRes"] as EmployeeModel;

            // новый объект
            EmployeeModel employee = EmployeeModel.GetEmployee();

            // установка новых данных
            _employee.Surname    = employee.Surname;
            _employee.Name       = employee.Name;
            _employee.Patronymic = employee.Patronymic;
            _employee.City       = employee.City;
            _employee.Age        = employee.Age;
            _employee.Salary     = employee.Salary;
        }


        // конструктор окна для запуска в режиме редактирования
        public EmployeeWindow(EmployeeModel employee)
        {
            InitializeComponent();

            // получение сотрудника из ресурсов
            _employee = Resources["EmployeeRes"] as EmployeeModel;

            // установка данных
            _employee.Surname    = employee.Surname;
            _employee.Name       = employee.Name;
            _employee.Patronymic = employee.Patronymic;
            _employee.City       = employee.City;
            _employee.Age        = employee.Age;
            _employee.Salary     = employee.Salary;

            // установка заголовка
            LblHeader.Content = Title = "Редактирование сотрудника из списка";

            // установка надписи на кнопке
            BtnOk.Content = "Сохранить";
        }

        #endregion


        #region Методы

        // загрузка окна
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // подписка на события
            TbxSurname.TextChanged    += TextBox_TextChanged;
            TbxName.TextChanged       += TextBox_TextChanged;
            TbxPatronymic.TextChanged += TextBox_TextChanged;
            TbxCity.TextChanged       += TextBox_TextChanged;
            TbxAge.TextChanged        += TextBox_TextChanged;
            TbxSalary.TextChanged     += TextBox_TextChanged;

        }


        // добавление/сохранение сотрудника
        private void BtnOk_Click(object sender, RoutedEventArgs e) => DialogResult = true;


        // обработка измений текста в полях ввода
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) =>
            BtnOk.IsEnabled = !string.IsNullOrWhiteSpace(TbxSurname.Text)
                           && !string.IsNullOrWhiteSpace(TbxName.Text)
                           && !string.IsNullOrWhiteSpace(TbxPatronymic.Text)
                           && !string.IsNullOrWhiteSpace(TbxCity.Text)
                           && int.TryParse(TbxAge.Text, out int i)
                           && int.TryParse(TbxSalary.Text, out i);


        #endregion

    }
}
