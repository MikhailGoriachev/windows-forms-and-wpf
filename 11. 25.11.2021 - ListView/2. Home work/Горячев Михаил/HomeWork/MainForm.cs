using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Controllers;     // контроллеры
using HomeWork.Models;          // модели
using HomeWork.Views;           // формы

/*  
 *  Задача 1. Разработайте приложение Windows Forms с использованием изученных 
 *  элементов интерфейса (строковое меню, контекстное меню, панель инструментов,
 *  лист-бокс, комбо-бокс, строка состояния, строки ввода, чек-боксы и радиокнопки,
 *  вкладки, ListView). 
 *  
 *  Разработайте класс, описывающий электроприбор (название, мощность, цена, 
 *  состояние прибора: включен / выключен). 
 *  
 *  Разработайте класс, описывающий электрооборудование квартиры: адрес квартиры,
 *  коллекция электроприборов. 
 *  
 *  Приложение должно использовать вкладки. Сведения о квартире и список 
 *  электроприборов выводить в первой вкладке главной формы.  Приложение должно 
 *  иметь следующий функционал (при помощи пунктов меню, контекстного меню, кнопок
 *  панели инструментов):
 *      •	Сворачивать приложение в трей, восстанавливать форму приложения из 
 *          контекстного меню иконки в трее. В этом же контекстом меню разместите 
 *          команды для завершения приложения, вызова формы со сведениями о приложении
 *          и разработчике
 *      •	При запуске приложения проверять наличие в папке исполняемого файла папки
 *          App_Data и файла appliances.json с данными о квартире. Если папки и/или 
 *          файл нет, то создать папку, заполнить начальными данными объект, описывающий 
 *          электрооборудование квартиры, сериализовать данные в формате JSON
 *      •	Выводить коллекцию электроприборов в ListView в табличном формате, 
 *          состояние прибора отображать картинкой   
 *      •	Переформирование коллекции электроприборов и сведений о квартире с 
 *          сериализацией 
 *      •	Сохранение данных в выбранном файле – сериализация в формате JSON. 
 *          Файл для сохранения выбирать стандартным диалогом 
 *      •	Загрузка данных из выбранного стандартным диалогом файла, десериализация
 *          в формате JSON. 
 *      •	Добавление электроприбора в коллекцию (ввод данных в отдельной форме), 
 *          сериализация данных
 *      •	Удаление электроприбора из коллекции, сериализация данных
 *      •	Редактирование выбранного электроприбора в отдельной форме, сериализация 
 *          данных
 *      •	Редактирование данных квартиры, сериализация данных
 *      •	Упорядочивание коллекции электроприборов, вывод упорядоченной копии
 *          коллекции в отдельной вкладке. При выборе команды переходить на вкладку
 *          o	По названию
 *          o	По состоянию
 *          o	По мощности
 *          o	По убыванию цены
 *      •	Включение/выключение выбранного электроприбора
 *      •	Включение/выключение всех электроприборов квартиры
 *      •	Выборка и вывод в отдельной вкладке главной формы коллекции электроприборов, 
 *          с заданным названием. При выборе команды переходить на вкладку
 *      •	Выборка и вывод в отдельной вкладке главной формы коллекции электроприборов 
 *          заданного состояния. При выборе команды переходить на вкладку
 *          
 *  В меню и контекстных меню (ListBox, MainForm) включите команды выхода, вывода окна 
 *  со сведениями о программе и ее разработчике.
*/
namespace HomeWork
{
    public partial class MainForm : Form
    {
        // обработчик по заданию 
        private HomeAppliancesController _controller;


        #region Конструкторы


        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();

            // установка значений
            _controller = new HomeAppliancesController();

            // запись названия сортировки в тег элементов
            MsiOrderByTitle.Tag = "По названию";
            MsiOrderByState.Tag = "По состоянию";
            MsiOrderByPower.Tag = "По мощности";
            MsiOrderByPrice.Tag = "По убыванию цены";
            CmiAppliancesOrderByTitle.Tag = "По названию";
            CmiAppliancesOrderByState.Tag = "По состоянию";
            CmiAppliancesOrderByPower.Tag = "По мощности";
            CmiAppliancesOrderByPrice.Tag = "По убыванию цены";
            TsiOrderByTitle.Tag = "По названию";
            TsiOrderByState.Tag = "По состоянию";
            TsiOrderByPower.Tag = "По мощности";
            TsiOrderByPrice.Tag = "По убыванию цены";

            // запись названия выборки в тег элементов
            MsiSelectionWhereTitle.Tag = "По названию";
            MsiSelectionWhereState.Tag = "По состоянию";          
            CmiAppliancesSelectionWhereTitle.Tag = "По названию";
            CmiAppliancesSelectionWhereState.Tag = "По состоянию";          
            TsiSelectionWhereTitle.Tag = "По названию";
            TsiSelectionWhereState.Tag = "По состоянию";      
        }


        #endregion

        #region Методы

        #region Обработчики событий формы


        // загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // загрузка коллекции в ListView
            ShowListView(LviAppliances, _controller.Appliances);

            // загрузка информации в информационные блоки
            TbxAddress.Text = _controller.Home.Address;

            // установка значений полей по умолчанию
            SetDefault();

            // установка сообщения о количестве элементов в строке состояния
            UpdateStatusAmount();

            // установка значения в ComboBox выбора сортировки
            CbxOrderBy.SelectedItem = CbxOrderBy.Items[0];

            // установка значения в ComboBox выбора выборки
            CbxSelectionWhere.SelectedItem = CbxSelectionWhere.Items[0];
        }


        // смена вкладки 
        private void TbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TbcMain.SelectedIndex)
            {
                // "Главная"
                case 0:

                    // выключение всех редактирующих кнопок
                    MsiControl.Enabled =
                        MsiEditElem.Enabled =
                        MsiHome.Enabled =
                        CmiAppliancesAddElem.Enabled =
                        CmiAppliancesAddRange.Enabled =
                        CmiAppliancesClear.Enabled =
                        CmiAppliancesDeleteElem.Enabled =
                        CmiAppliancesStateAllOff.Enabled =
                        CmiAppliancesStateAllOn.Enabled =
                        CmiAppliancesStateOffElem.Enabled =
                        CmiAppliancesStateOnElem.Enabled =
                        CmiEditElem.Enabled =
                        TsiAddElem.Enabled =
                        TsiDeleteElem.Enabled =
                        TsiEditElem.Enabled =
                        TsiTurnOnElem.Enabled =
                        TsiTurnOffElem.Enabled = true;

                    break;

                // "Сортировка"
                case 1:

                    // вызов сортировки
                    OrderBy_Command(sender, e);

                    // выключение всех редактирующих кнопок
                    MsiControl.Enabled =
                        MsiEditElem.Enabled =
                        MsiHome.Enabled =
                        CmiAppliancesAddElem.Enabled =
                        CmiAppliancesAddRange.Enabled =
                        CmiAppliancesClear.Enabled =
                        CmiAppliancesDeleteElem.Enabled =
                        CmiAppliancesStateAllOff.Enabled =
                        CmiAppliancesStateAllOn.Enabled =
                        CmiAppliancesStateOffElem.Enabled =
                        CmiAppliancesStateOnElem.Enabled =
                        CmiEditElem.Enabled =
                        TsiAddElem.Enabled =
                        TsiDeleteElem.Enabled =
                        TsiEditElem.Enabled = 
                        TsiTurnOnElem.Enabled = 
                        TsiTurnOffElem.Enabled = false;

                    break;

                // "Выборка"
                case 2:

                    // обновление данных в параметрах выборки
                    SelectionWhereTypeSelect_Command(sender, e);

                    // вызов выборки
                    SelectionWhere_Command(sender, e);

                    // выключение всех редактирующих кнопок
                    MsiControl.Enabled =
                        MsiEditElem.Enabled =
                        MsiHome.Enabled =
                        CmiAppliancesAddElem.Enabled =
                        CmiAppliancesAddRange.Enabled =
                        CmiAppliancesClear.Enabled =
                        CmiAppliancesDeleteElem.Enabled =
                        CmiAppliancesStateAllOff.Enabled =
                        CmiAppliancesStateAllOn.Enabled =
                        CmiAppliancesStateOffElem.Enabled =
                        CmiAppliancesStateOnElem.Enabled =
                        CmiEditElem.Enabled =
                        TsiAddElem.Enabled =
                        TsiDeleteElem.Enabled =
                        TsiEditElem.Enabled =
                        TsiTurnOnElem.Enabled =
                        TsiTurnOffElem.Enabled = false;

                    break;

                default:
                    break;
            }
        }


        // выбор элемента в ListView
        private void LviAppliances_SelectedIndexChanged(object sender, EventArgs e)
        {
            // установка значений информационных полей по умолчанию
            SetDefault();

            // если нет выбранного элемента
            if (LviAppliances.SelectedItems.Count == 0)
                return;

            // выбранный элемент
            ElectricalAppliance item = _controller.Appliances[LviAppliances.SelectedIndices[0]];

            // вывод данных выбранного элемента в информационный блок
            TbxState.Text = item.StateActive ? "Включен" : "Выключен";
            TbxTitle.Text = item.Name;
            TbxPower.Text = item.Power.ToString();
            TbxPrice.Text = item.Price.ToString();
            TbxDateTime.Text = item.DateTimeStateChange.ToString();
        }


        // выбор сортировки НЕ из комбо-бокса
        private void SelectOrderBy_Command(object sender, EventArgs e)
        {
            // установка из тега название сортировки в комбо-бокс
            CbxOrderBy.SelectedItem = ((ToolStripMenuItem)sender).Tag;

            // перход на вкладку "Сортировка"
            TbcMain.SelectedIndex = 1;
        }


        // выбор сортировки в комбо-боксе
        private void OrderBy_Command(object sender, EventArgs e)
        {
            // отсортированная коллекция
            List<ElectricalAppliance> list = new List<ElectricalAppliance>();

            switch (CbxOrderBy.SelectedItem)
            {
                case "По названию":
                    list =_controller.OrderByName();
                    break;

                case "По состоянию":
                    list = _controller.OrderByState();
                    break;

                case "По мощности":
                    list = _controller.OrderByPower();
                    break;

                case "По убыванию цены":
                    list = _controller.OrderByPrice();
                    break;

                default:
                    break;
            }

            // обновление данных в ListView на вкладке "Сортировка"
            ShowListView(LviAppliancesOrderBy, list);
        }


        // выбор выборки НЕ из комбо-бокса
        private void SelectSelectionWhere_Command(object sender, EventArgs e)
        {
            // название выборки
            string selectType = ((ToolStripMenuItem)sender).Tag.ToString();

            // массив параметров для выбора 
            List<string> parameters = new List<string>();

            // название выборки
            string titleSelection = "";

            // название параметра
            string titleParam = "";

            // запуск формы для выбора параметров
            switch (selectType)
            {
                case "По названию":
                    parameters.AddRange(_controller.Home.TitlesAppliances);
                    titleSelection = "Выборка по названию прибора";
                    titleParam = "Название прибора";
                    break;

                case "По состоянию":
                    parameters.AddRange(new[] { "Включен", "Выключен" });
                    titleSelection = "Выборка по состоянию прибора";
                    titleParam = "Состояние прибора";
                    break;

                default:
                    break;
            }

            // форма для выбора параметров
            SelectionParamsForm form = new SelectionParamsForm(titleSelection, titleParam, parameters.ToArray());

            // запуск формы 
            if (form.ShowDialog() != DialogResult.OK)
                return;

            // перход на вкладку "Выборка"
            TbcMain.SelectedIndex = 2;

            // установка параметров для выборки
            CbxSelectionWhere.SelectedItem = selectType;
            CbxSelectionParams.SelectedItem = form.Parameter;
        }


        // выбор выборки в комбо-боксе
        private void SelectionWhereTypeSelect_Command(object sender, EventArgs e)
        {
            // очистка элементов лист-бокса с параметрами отбора
            CbxSelectionParams.Items.Clear();

            switch (CbxSelectionWhere.SelectedItem)
            {
                case "По названию":
                    CbxSelectionParams.Items.AddRange(_controller.Home.TitlesAppliances.ToArray());
                    break;

                case "По состоянию":
                    CbxSelectionParams.Items.AddRange(new[] { "Включен", "Выключен" });
                    break;

                default:
                    break;
            }

            // если коллекция пуста 
            if (_controller.Count == 0)
                return;

            // установка значения по умолчанию
            CbxSelectionParams.SelectedItem = CbxSelectionParams.Items[0];
        }


        // выборка по параметру
        private void SelectionWhere_Command(object sender, EventArgs e)
        {
            // выбранная коллекция
            List<ElectricalAppliance> list = new List<ElectricalAppliance>();

            // если коллекция НЕ пуста 
            if (_controller.Count != 0)
            {
                switch (CbxSelectionWhere.SelectedItem)
                {
                    case "По названию":
                        list = _controller.SelectionWhereName(CbxSelectionParams.SelectedItem.ToString());
                        break;

                    case "По состоянию":
                        list = _controller.SelectionWhereState(CbxSelectionParams.SelectedItem.ToString() == "Включен");
                        break;

                    default:
                        break;
                }            
            }

            // обновление данных в ListView на вкладке "Выборка"
            ShowListView(LviAppliancesSelection, list);
        }


        #region Общие обработчики

        // выход из приложения
        private void Exit_Command(object sender, EventArgs e) => Application.Exit();


        // загрузка данных из файла
        private void Load_Command(object sender, EventArgs e)
        {
            // выбор файла
            if (OfdAppliances.ShowDialog() != DialogResult.OK)
                return;

            // установка пути к файлу
            _controller.SaveFile = OfdAppliances.FileName;

            // загрузка данных
            _controller.Deserialization();

            // вывод загруженных данных
            ShowListView(LviAppliances, _controller.Appliances);

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpMain;
        }


        // сохранение данных в файл
        private void SaveAs_Command(object sender, EventArgs e)
        {
            // выбор файла для сохранения
            if (SfdAppliances.ShowDialog() != DialogResult.OK)
                return;

            // установка пути к файлу
            _controller.SaveFile = SfdAppliances.FileName;

            // сохранение данных
            _controller.Serialization();
        }


        // добавление коллекции приборов
        private void AddRange_Command(object sender, EventArgs e)
        {
            // добавление приборов
            _controller.Initialization();

            // сериализация 
            _controller.Serialization();

            // обновление данных в ListView
            ShowListView(LviAppliances, _controller.Appliances);

            // обновления количества в статусе
            UpdateStatusAmount();

        }


        // добавление прибора
        private void AddElem_Command(object sender, EventArgs e)
        {
            // форма для создания 
            ApplianceForm form = new ApplianceForm();

            // запуск формы для заполнения 
            if (form.ShowDialog() != DialogResult.OK)
                return;

            // добавление элемента
            _controller.Add(form.Appliance);

            // запись в файл
            _controller.Serialization();

            // обновление данных в ListView
            ShowListView(LviAppliances, _controller.Appliances);

            // обновления количества в статусе
            UpdateStatusAmount();
        }


        // редактирование выбранного элемента
        private void EditElem_Command(object sender, EventArgs e)
        {
            // если элемент не выбран
            if (LviAppliances.SelectedItems.Count == 0)
                return;

            // индекс выбранного элемента
            int index = LviAppliances.SelectedIndices[0];

            // запуск формы для редактирования
            new ApplianceForm(_controller.Appliances[index]).ShowDialog();

            // запись в файл
            _controller.Serialization();

            // обновление отображения элемента в ListView
            ShowChangeListViewElem(LviAppliances, _controller.Appliances, index);

            // обновления количества в статусе
            UpdateStatusAmount();
        }


        // удалить выбранный прибор
        private void DeleteElem_Command(object sender, EventArgs e)
        {
            // если прибор не выбран
            if (LviAppliances.SelectedItems.Count == 0)
                return;

            // индекс выбранного элемента 
            int index = LviAppliances.SelectedIndices[0];

            // удаление элемента по индексу
            _controller.RemoveAt(index);
            LviAppliances.Items.RemoveAt(index);

            // сохранение изменений
            _controller.Serialization();

            // обновления количества в статусе
            UpdateStatusAmount();
        }


        // удаление всех
        private void Clear_Command(object sender, EventArgs e)
        {
            // удалание приборов
            _controller.Clear();

            // сериализация 
            _controller.Serialization();

            // обновление данных в ListView
            ShowListView(LviAppliances, _controller.Appliances);

            // обновления количества в статусе
            UpdateStatusAmount();
        }


        // включить все приборы
        private void StateOnAll_Command(object sender, EventArgs e)
        {
            // включение
            _controller.TurnPowerAll(true);

            // сериализация 
            _controller.Serialization();

            // обновление данных в ListView
            ShowListView(LviAppliances, _controller.Appliances);
        }


        // включить все приборы
        private void StateOffAll_Command(object sender, EventArgs e)
        {
            // выключение
            _controller.TurnPowerAll(false);

            // сериализация 
            _controller.Serialization();

            // обновление данных в ListView
            ShowListView(LviAppliances, _controller.Appliances);
        }


        // включить выбраннный прибор
        private void StateOnElem_Command(object sender, EventArgs e)
        {
            // если прибор не выбран
            if (LviAppliances.SelectedIndices.Count == 0)
                return;

            // индекс прибора 
            int index = LviAppliances.SelectedIndices[0];

            // включение прибора
            _controller.TurnPower(index, true);

            // сохранение изменений
            _controller.Serialization();

            // изменение выбранного прибора в ListView
            ShowChangeListViewElem(LviAppliances, _controller.Appliances, index);
        }


        // выключить выбраннный прибор
        private void StateOffElem_Command(object sender, EventArgs e)
        {
            // если прибор не выбран
            if (LviAppliances.SelectedIndices.Count == 0)
                return;

            // индекс прибора 
            int index = LviAppliances.SelectedIndices[0];

            // выключение прибора
            _controller.TurnPower(index, false);

            // сохранение изменений
            _controller.Serialization();

            // изменение выбранного прибора в ListView
            ShowChangeListViewElem(LviAppliances, _controller.Appliances, index);
        }


        // вывод информации о программе
        private void InfoProgram_Command(object sender, EventArgs e) => new FormInfo().ShowDialog();


        // свернуть в трей
        private void ToTray_Command(object sender, EventArgs e)
        {
            // скрыть приложение 
            this.Hide();

            // отобразить иконку в трее
            NtiTray.Visible = true;
        }

        // развернуть из трея
        private void FromTray_Command(object sender, EventArgs e)
        {
            // скрыть приложение 
            this.Show();

            // отобразить иконку в трее
            NtiTray.Visible = false;
        }


        // создание дома
        private void CreateHome_Command(object sender, EventArgs e)
        {
            // форма для создания 
            HomeForm form = new HomeForm();

            // запуск формы
            if (form.ShowDialog() != DialogResult.OK)
                return;

            // установка дома в контроллер
            _controller.Home = form.Home;

            // сохранение в файл
            _controller.Serialization();

            // обновление данных на форме
            TbxAddress.Text = _controller.Home.Address;
            ShowListView(LviAppliances, _controller.Appliances);
        }


        // редактирование дома
        private void EditHome_Command(object sender, EventArgs e)
        {
            // запуск формы для редактирования 
            new HomeForm(_controller.Home).ShowDialog();

            // сохранение в файл
            _controller.Serialization();

            // обновление данных на форме
            TbxAddress.Text = _controller.Home.Address;
        }


        #endregion

        #endregion

        #region Общие методы


        // вывод коллекции приборов в ListView
        public void ShowListView(ListView listView, List<ElectricalAppliance> listData)
        {
            // очистка коллекции данных ListView
            listView.Items.Clear();

            // заполнение ListView
            listData.ForEach(item =>
            {
                // создание элемента (строки)
                ListViewItem listViewItem = new ListViewItem();

                // установка значения первого столбца
                listViewItem.ImageIndex = item.StateActive ? 1 : 0;

                // добавление остальных элементов
                listViewItem.SubItems.AddRange(new[] { $"{item.Name}", $"{item.Power}", $"{item.Price}" });

                // добавление строки в ListView
                listView.Items.Add(listViewItem);
            });
        }


        // изменение элемента в отображении ListView
        public void ShowChangeListViewElem(ListView listView, List<ElectricalAppliance> listData, int index)
        {
            // элемент (строка) в ListView
            ListViewItem item = listView.Items[index];

            // прибор 
            ElectricalAppliance appliance = listData[index];

            // изменение картинки
            item.ImageIndex = appliance.StateActive ? 1 : 0;

            // очистка подэлементов элементов
            item.SubItems.Clear();

            // запись подэлементов
            item.SubItems.AddRange(new[] { $"{appliance.Name}", $"{appliance.Power}", $"{appliance.Price}" });
        }


        // установка значений по умолчанию для полей информационного блока
        public void SetDefault() 
            => TbxTitle.Text = TbxDateTime.Text = TbxPower.Text = TbxPrice.Text = TbxState.Text = "────────────────";


        // обновление сообщения о количестве элементов в строке состояния
        public void UpdateStatusAmount() => StiAmount.Text = $"Количество приборов: {_controller.Count}";

        #endregion

        #endregion

    }
}
