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
using Microsoft.Win32;              // для диалоговых окон

using HomeWork.Controllers;         // контроллеры
using HomeWork.Models.Task2;        // модели второго задания
using HomeWork.Views.Task2;         // окно для выбора выборки

namespace HomeWork.Views.Task2
{
    /// <summary>
    /// Interaction logic for Task2Window.xaml
    /// </summary>
    public partial class Task2Window : Window
    {
        // контроллер обработки по заданию 1 (Список сотрудников)
        private Task2Controller _controller;

        public Task2Controller Controller
        {
            get => _controller;
            set => _controller = value;
        }


        // текущая сортировка 
        private Action _orderAction;


        // текущая выборка
        private Action _selectedAction;

        #region Конструкторы


        // конструктор по умолчанию
        public Task2Window() : this(new Task2Controller()) { }


        // конструктор иницализирующий
        public Task2Window(Task2Controller task2Controller)
        {
            InitializeComponent();

            // установка значений
            _controller = task2Controller;
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

            // установка обработчика события смены вида сортировки в combo-box
            CmbOrder.SelectionChanged += CmbOrder_SelectionChanged;

            // установка обработчика события смены вида выборки в combo-box
            CmbSelected.SelectionChanged += CmbSelected_SelectionChanged;

            // установка названия сортировки
            SetOrderInfo("Сортировка по индексу издания");

            // установка названия и параметра выборки
            SetSeletionInfo("Подписки по периоду", _controller.Periods[0].ToString());

            // установка сортировки
            _orderAction = () => SetData(DgvPeriodicalsOrdered, _controller.OrderByIndex(), "Упорядочено элементов: ");

            // установка выборки
            _selectedAction = () => SetData(DgvPeriodicalsSelected, _controller.SelectionWhereDuration(_controller.Periods[0]), "Выбрано элементов: ");
        }


        // выбор элемента в DataGrid
        private void DgvPeriodicals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // выбранный элемент
            PeriodicalModel periodical = DgvPeriodicals.SelectedItem as PeriodicalModel;

            // если элемент не выбран
            if (periodical == null)
            {
                // установка значения полей по умолчанию
                SetDefaultInfo();
                return;
            }

            // получение ссылки на объект ресурса
            PeriodicalModel res = Resources["SelectPeriodical"] as PeriodicalModel;

            // установка значений в объект
            res.FullName = periodical.FullName;
            res.Title = periodical.Title;
            res.Index = periodical.Index;
            res.Duration = periodical.Duration;
            res.DateSubscribe = periodical.DateSubscribe;
            res.Street = periodical.Street;
            res.Home = periodical.Home;
            res.Apartment = periodical.Apartment;
            res.TypeEdition = periodical.TypeEdition;
        }


        // выбор элемента в DataGrid. Вкладка "Сортировка"
        private void DgvPeriodicalsOrdered_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // выбранный элемент
            PeriodicalModel periodical = DgvPeriodicalsOrdered.SelectedItem as PeriodicalModel;

            // если элемент не выбран
            if (periodical == null)
            {
                // установка значения полей по умолчанию
                SetDefaultInfo();
                return;
            }

            // получение ссылки на объект ресурса
            PeriodicalModel res = Resources["SelectPeriodical"] as PeriodicalModel;

            // установка значений в объект
            res.FullName = periodical.FullName;
            res.Title = periodical.Title;
            res.Index = periodical.Index;
            res.Duration = periodical.Duration;
            res.DateSubscribe = periodical.DateSubscribe;
            res.Street = periodical.Street;
            res.Home = periodical.Home;
            res.Apartment = periodical.Apartment;
            res.TypeEdition = periodical.TypeEdition;

            e.Handled = true;
        }


        // выбор элемента в DataGrid. Вкладка "Выборка"
        private void DgvPeriodicalsSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // выбранный элемент
            PeriodicalModel periodical = DgvPeriodicalsSelected.SelectedItem as PeriodicalModel;

            // если элемент не выбран
            if (periodical == null)
            {
                // установка значения полей по умолчанию
                SetDefaultInfo();
                return;
            }

            // получение ссылки на объект ресурса
            PeriodicalModel res = Resources["SelectPeriodical"] as PeriodicalModel;

            // установка значений в объект
            res.FullName = periodical.FullName;
            res.Title = periodical.Title;
            res.Index = periodical.Index;
            res.Duration = periodical.Duration;
            res.DateSubscribe = periodical.DateSubscribe;
            res.Street = periodical.Street;
            res.Home = periodical.Home;
            res.Apartment = periodical.Apartment;
            res.TypeEdition = periodical.TypeEdition;

            e.Handled = true;
        }


        // закрытие окна
        private void Exit_Click(object sender, RoutedEventArgs e) => Close();


        // формирование списка подписок
        private void Initialization_Click(object sender, RoutedEventArgs e)
        {
            // формирование списка
            _controller.Initialization();

            // обновление данных в окне
            UpdateData();
        }


        // добавление коллекции подписок
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


        // добавить подписку
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // окно для добавления подписки
            PeriodicalWindow window = new PeriodicalWindow();

            // получение результата окна
            if (window.ShowDialog() == false)
                return;

            // добавление подписки
            _controller.Add(window.Periodical.Clone());

            // обновление данных
            UpdateData();
        }


        // изменить выбранного сотрудника
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если подписка не выбрана
            if (DgvPeriodicals.SelectedItems.Count == 0)
            {
                SetDefaultInfo();
                return;
            }

            // выбранная подписка
            PeriodicalModel periodical = DgvPeriodicals.SelectedItem as PeriodicalModel;

            // окно для редактирование подписки
            PeriodicalWindow window = new PeriodicalWindow(periodical);

            // получение результата окна
            if (window.ShowDialog() == false)
                return;

            // применение изменений
            periodical.FullName = window.Periodical.FullName;
            periodical.Title = window.Periodical.Title;
            periodical.Index = window.Periodical.Index;
            periodical.Duration = window.Periodical.Duration;
            periodical.DateSubscribe = window.Periodical.DateSubscribe;
            periodical.Street = window.Periodical.Street;
            periodical.Home = window.Periodical.Home;
            periodical.Apartment = window.Periodical.Apartment;

            // обновление данных
            UpdateData();
        }


        // удалить выбранную подписку
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            // удаление
            _controller.Remove(DgvPeriodicals.SelectedItem as PeriodicalModel);

            // обновление данных в окне
            UpdateData();
        }


        // сортировка выбор сортировки по клику на элемент управления
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            // установка значения в Combo-Box
            CmbOrder.SelectedItem = ((MenuItem)sender).Tag;

            // если вкладка сортировки не выбрана, это означает, что текущий вид сортировки равен новому
            // из-за этого сработает событие на ComboBox
            if (TbcMain.SelectedItem != TbpOrdered)
                // запуск сортировки
                CmbOrder_SelectionChanged(sender, null);
        }


        // запуск сортировки по кнопке
        private void StartOrder_Click(object sender, RoutedEventArgs e) =>
            CmbOrder_SelectionChanged(sender, null);

        // выбор сортировки в Combo-box
        private void CmbOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // получение названия сортировки
            string orderBy = CmbOrder.SelectedItem.ToString();

            // установка названия сортировки
            SetOrderInfo(orderBy);

            // сортировка
            switch (orderBy)
            {
                case "Сортировка по индексу издания":
                    _orderAction = () => SetData(DgvPeriodicalsOrdered, _controller.OrderByIndex(), "Упорядочено элементов: ");
                    break;
                case "Сортировка по адресу подписчика":
                    _orderAction = () => SetData(DgvPeriodicalsOrdered, _controller.OrderByAddress(), "Упорядочено элементов: ");
                    break;
                case "Сортировка по убыванию периода подписки":
                    _orderAction = () => SetData(DgvPeriodicalsOrdered, _controller.OrderByDuration(), "Упорядочено элементов: ");
                    break;
                case "Сортировка по типу издания":
                    _orderAction = () => SetData(DgvPeriodicalsOrdered, _controller.OrderByTypeEdition(), "Упорядочено элементов: ");
                    break;
                default:
                    break;
            }

            // если текущая вкладка является вкладкой сортировки
            if (TbcMain.SelectedItem == TbpOrdered)
                _orderAction.Invoke();

            // переход на вкладку сортировки
            TbcMain.SelectedItem = TbpOrdered;

        }


        // выбор выборки по клику на элемент управления
        private void Selected_Click(object sender, RoutedEventArgs e)
        {
            // установка значения в Combo-Box
            CmbSelected.SelectedItem = ((MenuItem)sender).Tag;


            // если вкладка сортировки не выбрана, это означает, что текущий вид выборки равен новому
            // из-за этого сработает событие на ComboBox
            if (TbcMain.SelectedItem != TbpSelected)
                CmbSelected_SelectionChanged(sender, null);

        }

        // запуск выборки по кнопке
        private void StartSelection_Click(object sender, RoutedEventArgs e) =>
            CmbSelected_SelectionChanged(sender, null);


        // выбор выборки в Combo-box
        private void CmbSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // получение названия выборки
            string selectWhere = CmbSelected.SelectedItem.ToString();

            // окно для выбора параметра выборки
            SelectSelection window;

            // выбранный параметр
            string param = string.Empty;

            // сортировка
            switch (selectWhere)
            {
                case "Подписки по типу издания":

                    // выбор параметра 
                    window = new SelectSelection(_controller.TypesEdition, "Тип издания", "Подписки по типу издания");

                    // запуск формы
                    if (window.ShowDialog() != true)
                        return;

                    // значение параметра
                    param = window.Parameter;

                    // установка выборки
                    _selectedAction = () => SetData(DgvPeriodicalsSelected, _controller.SelectionWhereTypeEdition(window.Parameter), "Выбрано элементов: ");
                    break;

                case "Подписки по периоду":

                    // выбор параметра 
                    window = new SelectSelection(_controller.Periods.Select(p => p.ToString()).ToList(), "Период подписки", "Подписки по периоду");

                    // запуск формы
                    if (window.ShowDialog() != true)
                        return;

                    // значение параметра
                    param = window.Parameter;

                    // установка выборки
                    _selectedAction = () => SetData(DgvPeriodicalsSelected, _controller.SelectionWhereDuration(int.Parse(window.Parameter)), "Выбрано элементов: ");
                    break;

                case "Подписки по подписчику":

                    // выбор параметра 
                    window = new SelectSelection(_controller.FullNameSubscribers, "Подписчик", "Подписки по подписчику");

                    // запуск формы
                    if (window.ShowDialog() != true)
                        return;

                    // значение параметра
                    param = window.Parameter;

                    // установка выборки
                    _selectedAction = () => SetData(DgvPeriodicalsSelected, _controller.SelectionWhereFullName(window.Parameter), "Выбрано элементов: ");
                    break;

                case "Подписки по названию издания":

                    // выбор параметра 
                    window = new SelectSelection(_controller.Titles, "Название издания", "Подписки по названию издания");

                    // запуск формы
                    if (window.ShowDialog() != true)
                        return;

                    // значение параметра
                    param = window.Parameter;

                    // установка выборки
                    _selectedAction = () => SetData(DgvPeriodicalsSelected, _controller.SelectionWhereTitle(window.Parameter), "Выбрано элементов: ");
                    break;

                default:
                    return;
            }

            // установка информции о выборке
            SetSeletionInfo(selectWhere, param);

            // если текущая вкладка является вкладкой сортировки
            _selectedAction.Invoke();

            // переход на вкладку сортировки
            TbcMain.SelectedItem = TbpSelected;            
        }


        // открытие окна с информацией о программе 
        private void InfoProgram_Click(object sender, RoutedEventArgs e) => new ProgramInfoWindow().ShowDialog();


        // выбор вкладки в tab-control
        private void TbcMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {            
            switch (TbcMain.SelectedIndex)
            {
                // главная
                case 0:
                    // включение редактирующих кнопок
                    IsEnabledEditControl(true);

                    // скрытие label с количесвом элементов на вкладке (нужен для вкладки сортировки и выборки)
                    LblAmountElemTab.Visibility = Visibility.Hidden;

                    break;

                // сортировка
                case 1:

                    // выключение редактирующих кнопок
                    IsEnabledEditControl(false);

                    // сортировка
                    _orderAction.Invoke();

                    // установка значения информационных полей по умолчанию
                    SetDefaultInfoOrdered();
                    break;

                // выборка
                case 2:

                    // выключение редактирующих кнопок
                    IsEnabledEditControl(false);

                    // выборка
                    _selectedAction.Invoke();

                    // установка значения информационных полей по умолчанию
                    SetDefaultInfoSelected();
                    break;

                default:
                    break;
            }
        }


        // сохранение данных с выбором пути к файлу через стандартный диалог
        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog
            {
                DefaultExt = "json",
                FileName = "periodicals.json",
                Filter = "Файлы JSON (*.json) |*.json| Все файлы (*.*) |*.*"
            };

            // запуск окна
            if (dialog.ShowDialog() != true)
                return;

            // установка пути к файлу
            _controller.SaveFile = dialog.FileName;

            // сохранение данных
            _controller.Save();

            // установка главной вкладки, как активной
            TbcMain.SelectedItem = TbpMain;
        }


        // сохранение данных с выбором пути к файлу через стандартный диалог
        private void Load_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                DefaultExt = "json",
                FileName = "periodicals.json",
                Filter = "Файлы JSON (*.json) |*.json| Все файлы (*.*) |*.*"
            };

            // запуск окна
            if (dialog.ShowDialog() != true)
                return;

            // установка пути к файлу
            _controller.SaveFile = dialog.FileName;

            // загрузка данных
            _controller.Load();

            // установка главной вкладки, как активной
            TbcMain.SelectedItem = TbpMain;

            // обновление окна
            Window_Loaded(sender, e);
        }

        #endregion


        #region Общие методы


        // установка значений по умолчанию информационных полей о выбранном элементе (справа от списка)
        public void SetDefaultInfo() => TbxInfoTitle.Text = TbxInfoTypeEdition.Text = TbxInfoFullName.Text = TbxInfoDuration.Text = "─────";


        // установка значений по умолчанию информационных полей о выбранном элементе (справа от списка) Вкладка "Сортировка"
        public void SetDefaultInfoOrdered() => TbxInfoOrderedTitle.Text = TbxInfoOrderedTypeEdition.Text = 
                                               TbxInfoOrderedFullName.Text = TbxInfoOrderedDuration.Text = "─────";


        // установка значений по умолчанию информационных полей о выбранном элементе (справа от списка) Вкладка "Сортировка"
        public void SetDefaultInfoSelected() => TbxInfoSelectedTitle.Text = TbxInfoSelectedTypeEdition.Text = 
                                               TbxInfoSelectedFullName.Text = TbxInfoSelectedDuration.Text = "─────";


        // обновление информации о количестве элементов в статус-баре
        public void UpdateStatus()
        {
            // текст в текст-блоке
            string text = TblAmountElem.Text;

            // обрезание строки по символу ':'
            text = text.Remove(text.LastIndexOf(':') + 2);

            // обновление информации о количестве элементов
            TblAmountElem.Text = text + _controller.Periodicals.Count().ToString();
        }


        // обновление информации о количестве элементов в статус-баре
        // вид передаваемого заголовка колчиества элементов: "Название: "
        public void SetData(DataGrid grid, List<PeriodicalModel> periodicals, string labelCount)
        {
            // обновление привязки DataGrid
            grid.ItemsSource = null;
            grid.ItemsSource = periodicals;

            // отбражение label
            LblAmountElemTab.Visibility = Visibility.Visible;

            // обновление информации о количестве элементов
            LblAmountElemTab.Text = labelCount + periodicals.Count().ToString();
        }


        // обновление привязки в DataGrid
        public void UpdateBinding()
        {
            DgvPeriodicals.ItemsSource = null;
            DgvPeriodicals.ItemsSource = _controller.Periodicals;
        }


        // обновление данных о сотрудниках в окне
        public void UpdateData()
        {
            // обновление информации о количестве элементов в статус-баре
            UpdateStatus();

            // обновление привязки в DataGrid
            UpdateBinding();
        }


        // установка информации о типе сортировки 
        public void SetOrderInfo(string orderName)
        {
            TbxInfoOrdered.Text = orderName;
        }


        // установка информации о выборке
        public void SetSeletionInfo(string selectionName, string param)
        {
            TbxInfoSelected.Text = selectionName;
            TbxParamSelected.Text = param;
        }


        // включение выключение реактирующих элементов управления
        public void IsEnabledEditControl(bool value)
        {
            // скрытие элементов управления
            MniControl.Visibility = value ? Visibility.Visible : Visibility.Collapsed;

            // выключение элементов управления
            TsiAdd.Visibility = TsiEdit.Visibility = TsiRemove.Visibility = TsiInit.Visibility = TsiAddRange.Visibility = value 
                                                                                                                    ? Visibility.Visible 
                                                                                                                    : Visibility.Hidden;
        }


        #endregion

        #endregion

    }
}
