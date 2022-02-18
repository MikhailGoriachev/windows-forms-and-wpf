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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;              // для работы со стандартными диалогками

using HomeWork.Controllers;         // контроллеры
using HomeWork.Models.Task1;        // модели первого задания

namespace HomeWork.Views.Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Task1Window : Window
    {
        // контроллер обработки по заданию 1 (Список сотрудников)
        private Task1Controller _controller;

        public Task1Controller Controller
        {
            get => _controller;
            set => _controller = value;
        }


        #region Конструкторы


        // конструктор по умолчанию
        public Task1Window() : this(new Task1Controller()) { }


        // конструктор иницализирующий
        public Task1Window(Task1Controller task1Controller)
        {
            InitializeComponent();

            // установка значений
            _controller = task1Controller;

            // подписка на события
            CmbBorder.SelectionChanged += CmbBorder_SelectionChanged;
        }


        #endregion

        #region Методы


        #region Обработчики событий

        // загрузка формы
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // обновление данных о сотрудниках в окне
            UpdateData();

            // установка значений информационных полей по умолчанию
            SetDefaultInfo();
        }


        // выбор элемента в DataGrid
        private void DgvEmployees_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // заполнение информационных столбцов
            EmployeeModel employee = DgvEmployees.SelectedItem as EmployeeModel;

            // если элемент не выбран
            if (employee == null) {
                // установка значения полей по умолчанию
                SetDefaultInfo();
                return;
            }

            // получение ссылки на ресурс
            EmployeeModel res = Resources["SelectEmployee"] as EmployeeModel;

            // установка значений в объект ресурса
            res.Surname     = employee.Surname;
            res.Name        = employee.Name;
            res.Patronymic  = employee.Patronymic;
            res.Age         = employee.Age;
            res.Salary      = employee.Salary;
            res.City        = employee.City;
        }


        // закрытие окна
        private void Exit_Click(object sender, RoutedEventArgs e) => Close();


        // формирование списка сотрудников
        private void Initialization_Click(object sender, RoutedEventArgs e)
        {
            // формирование списка
            _controller.Initialization();

            // обновление данных в окне
            UpdateData();
        }


        // добавление коллекции сотрудников
        private void AddRange_Click(object sender, RoutedEventArgs e)
        {
            // формирование списка
            _controller.AddRange();

            // обновление данных в окне
            UpdateData();
        }


        // очистка списка
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // формирование списка
            _controller.Clear();

            // обновление данных в окне
            UpdateData();
        }


        // добавить сотрудника
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // окно для добавления сотрудника
            EmployeeWindow window = new EmployeeWindow();

            // получение результата окна
            if (window.ShowDialog() == false)
                return;

            // добавление сотрудника
            _controller.Add(window.Employee.Clone());

            // обновление данных
            UpdateData();
        }


        // изменить выбранного сотрудника
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если сотрудник не выбран
            if (DgvEmployees.SelectedItems.Count == 0)
                return;

            // выбранный сотрудник
            EmployeeModel employee = DgvEmployees.SelectedItem as EmployeeModel;

            // окно для редактирование сотрудника
            EmployeeWindow window = new EmployeeWindow(employee);

            // получение результата окна
            if (window.ShowDialog() == false)
                return;

            // применение изменений
            employee.Surname    = window.Employee.Surname;
            employee.Name       = window.Employee.Name;
            employee.Patronymic = window.Employee.Patronymic;
            employee.City       = window.Employee.City;
            employee.Salary     = window.Employee.Salary;
            employee.Age        = window.Employee.Age;

            // обновление данных
            UpdateData();
        }


        // удалить выбранного сотрудника
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            // удаление
            _controller.Remove(DgvEmployees.SelectedItem as EmployeeModel);

            // обновление данных в окне
            UpdateData();
        }


        // сортировка 
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            // получение назвая сортировки
            string orderBy = ((MenuItem)e.OriginalSource).Header.ToString();

            // сортировка
            switch (orderBy)
            {
                case "Сортировка по фамилии":
                    _controller.SortBySurname();
                    break;
                case "Сортировка по имени":
                    _controller.SortByName();
                    break;
                case "Сортировка по отчеству":
                    _controller.SortByPatronymic();
                    break;
                case "Сортировка по убыванию оклада":
                    _controller.SortBySalaryDesc();
                    break;
                default:
                    break;
            }

            // обновление данных
            UpdateData();
        }


        // выбор сортировки в комбо-боксе
        private void CmbBorder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CmbBorder.SelectedValue)
            {
                case "Сортировка по фамилии":
                    _controller.SortBySurname();
                    break;
                case "Сортировка по имени":
                    _controller.SortByName();
                    break;
                case "Сортировка по отчеству":
                    _controller.SortByPatronymic();
                    break;
                case "Сортировка по убыванию оклада":
                    _controller.SortBySalaryDesc();
                    break;
                default:
                    break;
            }

            // обновление данных
            UpdateData();
        }


        // открытие окна с информацией о программе 
        private void InfoProgram_Click(object sender, RoutedEventArgs e) => new ProgramInfoWindow().ShowDialog();


        // сохранить данные с выбором файла через стандартный диалог
        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            // диалоговое окно для выбора файла
            SaveFileDialog dialog = new SaveFileDialog
            {
                FileName = "employee.json",
                DefaultExt = "json",
                Filter = "Файлы JSON (*.json)|*.json|Все файлы (*.*)|*.*"
            };

            // выбор файла
            if (dialog.ShowDialog() != true)
                return;

            // установка названия файла
            _controller.SaveFile = dialog.FileName;

            // сохранение данных
            _controller.Save();
        }


        // загрузка данных с выбором файла через стандартный диалог
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            // диалоговое окно для выбора файла
            OpenFileDialog dialog = new OpenFileDialog
            {
                FileName = "employee.json",
                DefaultExt = "json",
                Filter = "Файлы JSON (*.json)|*.json|Все файлы (*.*)|*.*"
            };

            // выбор файла
            if (dialog.ShowDialog() != true)
                return;

            // установка названия файла
            _controller.SaveFile = dialog.FileName;

            // загрузка данных
            _controller.Load();

            // обновление окна
            Window_Loaded(sender, e);
        }


        // Drop на DataGrid главной формы
        private void DgvEmployees_Drop(object sender, DragEventArgs e)
        {
            // если это не файл
            if (e.Data.GetFormats().Contains(DataFormats.FileDrop))
            {
                // установка имени файла
                _controller.SaveFile = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

                // загрузка данных
                _controller.Load();

                // обновление окна
                Window_Loaded(sender, e);
            }
        }

        #endregion


        #region Общие методы


        // установка значений по умолчанию информационных полей о выбранном элементе (справа от списка)
        public void SetDefaultInfo() => TbxInfoAge.Text = TbxInfoName.Text = TbxInfoPatronymic.Text = TbxInfoSalary.Text = TbxInfoSurname.Text = TbxInfoCity.Text = "─────";


        // обновление информации о количестве элементов в статус-баре
        public void UpdateStatus()
        {
            // текст в текст-блоке
            string text = TblAmountElem.Text;

            // обрезание строки по символу ':'
            text = text.Remove(text.LastIndexOf(':') + 2);

            // обновление информации о количестве элементов
            TblAmountElem.Text = text + _controller.Employees.Count().ToString();
        }


        // обновление привязки в DataGrid
        public void UpdateBinding()
        {
            DgvEmployees.ItemsSource = null;
            DgvEmployees.ItemsSource = _controller.Employees;
        }


        // обновление данных о сотрудниках в окне
        public void UpdateData()
        {
            // обновление информации о количестве элементов в статус-баре
            UpdateStatus();

            // обновление привязки в DataGrid
            UpdateBinding();
        }

        #endregion

        #endregion

    }
}
