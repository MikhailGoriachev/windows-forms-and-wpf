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
    /// Interaction logic for DataGridRepairShopWindow.xaml
    /// </summary>
    public partial class DataGridRepairShopWindow : Window
    {
        // контроллер по заданию
        private RepairShopController _controller;


        // делегат сортировки
        private Func<List<TelevisionModel>> _actionOrder;


        // делегат выборки
        private Func<List<TelevisionModel>> _actionSelection;


        #region Конструкторы 

        // конструктор по умолчанию
        public DataGridRepairShopWindow()
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

            // обновление информации о количестве элементов
            UpdateCount();

            // сортировка по умолчанию
            ShowOrdered((_actionOrder = () => _controller.OrderByModel()).Invoke(), "По производителю и типу", "Производитель", false);

            // выборка по умолчанию
            ShowSelection((_actionSelection = () => _controller.SelectWhereMinPrice()).Invoke(), "Минимальная стоимость ремонта", "Минимальная стоимость", selectTab: false);

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

            // обновление данных в DataGrid во всех вкладках
            UpdateTabs();

        } // AddTelevision_Click


        // редактирование телевизора
        private void EditTelevision_Click(object sender, RoutedEventArgs e)
        {
            // если телевизор не выбран
            if (DgdTelevisions.SelectedItem == null)
                return;

            // запуск формы редактирования телевизора
            if (new TelevisionWindow(DgdTelevisions.SelectedItem as TelevisionModel).ShowDialog() == false)
                return;

            // обновление данных в DataGrid во всех вкладках
            UpdateTabs();

        } // EditTelevision_Click


        // удаление телевизора
        private void RemoveTelevision_Click(object sender, RoutedEventArgs e)
        {
            // если телевизор не выбран
            if (DgdTelevisions.SelectedItem == null)
                return;

            // удаление выбранного телевизора
            _controller.Remove(DgdTelevisions.SelectedItem as TelevisionModel);

            // обновление данных в DataGrid во всех вкладках
            UpdateTabs();

        } // RemoveTelevision_Click


        // cформировать новую коллекцию
        private void Init_Click(object sender, RoutedEventArgs e)
        {
            // формирование новой коллекции телевизоров
            _controller.Initialization();

            // обновление данных в DataGrid во всех вкладках
            UpdateTabs();

        } // Init_Click


        // добавить коллекцию
        private void AddRange_Click(object sender, RoutedEventArgs e)
        {
            // добавление коллекции телевизоров
            _controller.AddRange(RepairShopModel.GenerateTelevision(15));

            // обновление данных в DataGrid во всех вкладках
            UpdateTabs();

        } // AddRange_Click


        // очистить список телевизоров
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            // очистка списка телевизоров
            _controller.Clear();

            // обновление данных в DataGrid во всех вкладках
            UpdateTabs();

        } // Clear_Click


        // выбор сортировки в меню
        private void MenuItemOrder_Click(object sender, RoutedEventArgs e)
        {
            // установка значения в ComboBox выбора сортировки
            CmbOrderBy.SelectedItem = ((MenuItem)e.OriginalSource).Tag;

            // сортировка
            Order_Click(sender, e);

        } // MenuItemOrder_Click


        // сортировка телевизоров
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            // сортировка
            switch (CmbOrderBy.SelectedItem)
            {
                case "По производителю и типу":
                    ShowOrdered((_actionOrder = () => _controller.OrderByModel()).Invoke(), "По производителю и типу", "Производитель");
                    break;

                case "По убыванию диагонали экрана":
                    ShowOrdered((_actionOrder = () => _controller.OrderByDiagonalDesc()).Invoke(), "По убыванию диагонали экрана", "Диагональ");
                    break;

                case "По мастеру, выполняющему ремонт":
                    ShowOrdered((_actionOrder = () =>_controller.OrderByMaster()).Invoke(), "По мастеру, выполняющему ремонт", "Мастер");
                    break;

                case "По владельцу телевизора":
                    ShowOrdered((_actionOrder = () =>_controller.OrderByOwner()).Invoke(), "По владельцу телевизора", "Владелец");
                    break;
            }

        } // Order_Click


        // выбор сортировки в меню
        private void MenuItemSelection_Click(object sender, RoutedEventArgs e)
        {
            // установка значения в ComboBox выбора выборки
            CmbSelectionBy.SelectedItem = ((MenuItem)e.OriginalSource).Tag;

            // выборка
            Selection_Click(sender, e);

        } // MenuItemSelection_Click


        // выборка телевизоров
        private void Selection_Click(object sender, RoutedEventArgs e)
        {
            // выборка
            switch (CmbSelectionBy.SelectedItem)
            {
                case "Минимальная стоимость ремонта":
                    // вывод выборки
                    ShowSelection((_actionSelection = () => _controller.SelectWhereMinPrice()).Invoke(), "Минимальная стоимость ремонта", "Минимальная стоимость");
                    break;

                case "По мастеру":

                    // окно выбора значения для выборки
                    SelectWindow windowMaster = new SelectWindow("Выборка телевизоров по мастеру", "Выбор мастера", _controller.RepairShop.Masters);

                    // выбор значения для выборки
                    if (windowMaster.ShowDialog() == false)
                        return;

                    // вывод выборки
                    ShowSelection((_actionSelection = () => _controller.SelectWhereMaster(windowMaster.SelectionValue)).Invoke(),
                                                                "Выборка по мастеру", "Мастер", "Мастер", windowMaster.SelectionValue);

                    break;

                case "По диагонали экрана":

                    // окно выбора значения для выборки
                    SelectWindow windowDiagonal = new SelectWindow("Выборка телевизоров по диагонали экрана", "Выбор диагонали экрана", Utils.Diagonals);

                    // выбор значения для выборки
                    if (windowDiagonal.ShowDialog() == false)
                        return;

                    // вывод выборки
                    ShowSelection((_actionSelection = () => _controller.SelectWhereDiagonal(int.Parse(windowDiagonal.SelectionValue))).Invoke(),
                                                                "Выборка по диагонали экрана", "Диагональ", "Диагональ", windowDiagonal.SelectionValue);

                    break;
            }
        } // Order_Click


        #region Меню


        // выход 
        private void Exit_Click(object sender, RoutedEventArgs e) => Close();


        // новая мастерская 
        private void CreateRepairShop_Click(object sender, RoutedEventArgs e)
        {
            // окно для создания мастерской
            RepairShopWindow window = new RepairShopWindow();

            // получение результата
            if (window.ShowDialog() == false)
                return;

            // установка мастерской
            _controller.RepairShop = window.RepairShop;

            // обновление данных в окне
            Window_Loaded(sender, e);

            // переход на главную вкладку
            TbcMain.SelectedItem = TbiMain;

        } // CreateRepairShop_Click


        // изменить мастерскую
        private void EditRepairShop_Click(object sender, RoutedEventArgs e)
        {
            // окно для редактирования мастерской
            RepairShopWindow window = new RepairShopWindow(_controller.RepairShop);

            // получение результата
            if (window.ShowDialog() == false)
                return;

            // обновление данных в окне
            Window_Loaded(sender, e);

            // переход на главную вкладку
            TbcMain.SelectedItem = TbiMain;

        } // EditRepairShop_Click


        // выбор вкладки
        private void TbcMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (TbcMain.SelectedIndex)
            {
                // "Телевизоры в ремонте"
                case 0:
                    // включение редактируюший кнопок
                    ActiveEditControls(true);
                    break;

                // "Выборка"
                case 1:
                    goto case 2;

                // "Сортировка"
                case 2:
                    // выключение редактируюший кнопок
                    ActiveEditControls(false);
                    break;

                default:
                    break;
            }
        }


        #endregion


        #endregion


        #region Общие методы


        // вывод выборки
        public void ShowSelection(List<TelevisionModel> televisions, string titleSelection, string headerTab, string nameParam = "", string valueParam = "", bool selectTab = true)
        {
            // если нет параметра то скрыть информационные поля параметров
            LblSelectionParam.Visibility = TbxSelectionParam.Visibility = string.IsNullOrWhiteSpace(nameParam) && string.IsNullOrWhiteSpace(valueParam) 
                                                                            ? Visibility.Hidden 
                                                                            : Visibility.Visible;

            // переход на вкладку выборки
            if (selectTab)
                TbcMain.SelectedItem = TbiSelected;

            // вывод информации о выборке
            TbxSelectionWhere.Text      = titleSelection;
            LblSelectionParam.Content   = nameParam;
            TbxSelectionParam.Text      = valueParam;

            // вывод телевизоров
            DgdSelectedTelevisions.ItemsSource = null;
            DgdSelectedTelevisions.ItemsSource = televisions;

            // установка типа выборки в заголовок вкладки
            LblHeaderSelected.Content = $"Выборка: {headerTab}";

        } // ShowSelection


        // вывод сортировки
        public void ShowOrdered(List<TelevisionModel> televisions, string titleOrder, string headerTab, bool selectTab = true)
        {
            // переход на вкладку сортировки
            if (selectTab)
                TbcMain.SelectedItem = TbiOrdered;

            // вывод информации о сортировке 
            TbxOrderBy.Text = titleOrder;

            // вывод телевизоров
            DgdOrderedTelevisions.ItemsSource = null;
            DgdOrderedTelevisions.ItemsSource = televisions;

            // установка типа сортировки в заголовок вкладки
            LblHeaderOrdered.Content = $"Сортировка: {headerTab}";

        } // ShowOrdered


        // обновление привязки
        public void UpdateBinding()
        {
            DgdTelevisions.ItemsSource = null;
            DgdTelevisions.ItemsSource = _controller.Televisions;
        } // UpdateBinding


        // обновление данных в DataGrid во всех вкладках
        public void UpdateTabs()
        {
            DgdTelevisions.ItemsSource = DgdOrderedTelevisions.ItemsSource = DgdSelectedTelevisions.ItemsSource = null;
            DgdTelevisions.ItemsSource = _controller.Televisions;
            DgdOrderedTelevisions.ItemsSource = _actionOrder.Invoke();
            DgdSelectedTelevisions.ItemsSource = _actionSelection.Invoke();

            // обновление информации о количестве элементов
            UpdateCount();
        }


        // обновление информации о количестве элементов
        public void UpdateCount()
        {
            // обновление количества элементов в заголовке вкладки "Телевизоры в ремонте"
            LblHeaderMain.Content = $"Телевизоры в ремонте: {_controller.Count}";

            // обновление количества элементов в статус-баре
            LblStatusCount.Content = $"Количество телевизоров: {_controller.Count}";
        }


        // выключение/включение редактирующих кнопок
        public void ActiveEditControls(bool value)
        {
            BtnAddTelevision.Visibility =
                BtnEditTelevision.Visibility =
                BtnRemoveTelevision.Visibility =
                BtnInit.Visibility =
                BtnAddRange.Visibility =
                BtnClear.Visibility =
                MniTelevisions.Visibility =
                SepToolBar1.Visibility =
                SepToolBar2.Visibility = value ? Visibility.Visible : Visibility.Hidden;

            MniTelevisions.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion

        #endregion

    }
}
