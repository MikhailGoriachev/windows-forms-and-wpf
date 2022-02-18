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
using HomeWork.Controllers;     // контроллеры
using HomeWork.Models;          // модели
using HomeWork.Utilities;       // утилиты

namespace HomeWork.Views
{
    /// <summary>
    /// Interaction logic for ListRepairShopWindow.xaml
    /// </summary>
    public partial class ListRepairShopWindow : Window
    {
        // контроллер по заданию
        private RepairShopController _controller;

        #region Конструкторы 

        // конструктор по умолчанию
        public ListRepairShopWindow()
        {
            InitializeComponent();

            // установка значений
            _controller = new RepairShopController();

        } // ListRepairShopWindow

        #endregion

        #region Методы

        #region Обработчики событий

        // загрузка формы
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // обновление привязки
            UpdateBinding();

            // вывод данных о мастерской
            TbxAddress.Text = _controller.RepairShop.Address;
            TbxTitle.Text = _controller.RepairShop.Name;

        } // Window_Loaded


        // добавление телевизора
        private void AddTelevision_Click(object sender, RoutedEventArgs e)
        {
            // запуск формы добавления телевизора
            TelevisionWindow window = new TelevisionWindow();

            // запуск формы
            if (window.ShowDialog() == false)
                return;

            // добавление телевизора в коллекцию
            _controller.Add(window.Television);

            // обновление привязки
            UpdateBinding();

        } // AddTelevision_Click


        // редактирование телевизора
        private void EditTelevision_Click(object sender, RoutedEventArgs e)
        {
            // если телевизор не выбран
            if (LviTelevisions.SelectedItem == null)
                return;

            // запуск формы редактирования телевизора
            new TelevisionWindow(LviTelevisions.SelectedItem as TelevisionModel).ShowDialog();

            // обновление привязки
            UpdateBinding();

        } // EditTelevision_Click


        // удаление телевизора
        private void RemoveTelevision_Click(object sender, RoutedEventArgs e)
        {
            // удаление выбранного телевизора
            _controller.Remove(LviTelevisions.SelectedItem as TelevisionModel);

            // обновление привязки
            UpdateBinding();
        } // RemoveTelevision_Click


        // cформировать новую коллекцию
        private void Init_Click(object sender, RoutedEventArgs e)
        {
            // формирование новой коллекции телевизоров
            _controller.Initialization();

            // обновление привязки
            UpdateBinding();
        }


        // добавить коллекцию
        private void AddRange_Click(object sender, RoutedEventArgs e)
        {
            // добавление коллекции телевизоров
            _controller.AddRange(RepairShopModel.GenerateTelevision(15));

            // обновление привязки
            UpdateBinding();
        }


        // очистить список телевизоров
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // очистка списка телевизоров
            _controller.Clear();

            // обновление привязки
            UpdateBinding();
        }


        // сортировка телевизоров
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            // сортировка
            switch (CmbOrderBy.SelectedItem)
            {
                case "По производителю и типу":
                    _controller.OrderByModel();
                    break;

                case "По убыванию диагонали экрана":
                    _controller.OrderByDiagonalDesc();
                    break;

                case "По мастеру, выполняющему ремонт":
                    _controller.OrderByMaster();
                    break;

                case "По владельцу телевизора":
                    _controller.OrderByOwner();
                    break;
            }

            // обновление привязки
            UpdateBinding();

        } // Order_Click


        // выборка телевизоров
        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            // выборка
            switch (CmbSelectionBy.SelectedItem)
            {
                case "Минимальная стоимость ремонта":
                    new SelectedTelevistionsWindow(_controller.SelectWhereMinPrice(), "Минимальная стоимость ремонта").ShowDialog();
                    break;

                case "По мастеру":

                    // окно выбора значения для выборки
                    SelectWindow windowMaster = new SelectWindow("Выборка телевизоров по мастеру", "Выбор мастера", _controller.RepairShop.Masters);

                    // выбор значения для выборки
                    if (windowMaster.ShowDialog() == false)
                        return;

                    // выборка
                    new SelectedTelevistionsWindow(_controller.SelectWhereMaster(windowMaster.SelectionValue),
                                                    $"Выборка по мастеру - {windowMaster.SelectionValue}").ShowDialog();

                    break;

                case "По диагонали экрана":

                    // окно выбора значения для выборки
                    SelectWindow windowDiagonal = new SelectWindow("Выборка телевизоров по диагонали экрана", "Выбор диагонали экрана", Utils.Diagonals);

                    // выбор значения для выборки
                    if (windowDiagonal.ShowDialog() == false)
                        return;

                    // выборка
                    new SelectedTelevistionsWindow(_controller.SelectWhereDiagonal(int.Parse(windowDiagonal.SelectionValue)), 
                                                    $"Выборка по диагонали экрана - {windowDiagonal.SelectionValue}").ShowDialog();

                    break;
            }

            // обновление привязки
            UpdateBinding();

        } // Order_Click

        #endregion


        #region Общие методы

        // обновление привязки
        public void UpdateBinding()
        {
            LviTelevisions.ItemsSource = null;
            LviTelevisions.ItemsSource = _controller.Televisions;
        } // UpdateBinding


        #endregion

        #endregion
    }
}
