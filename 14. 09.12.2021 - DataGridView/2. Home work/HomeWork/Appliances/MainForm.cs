using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appliances.Controllers;     // контроллеры
using Appliances.Models;          // модели
using Appliances.Views;           // формы

/*  
 * Задача 1. Разработайте приложение Windows Forms с использованием изученных
 * элементов интерфейса (строковое меню, контекстное меню, панель инструментов, 
 * лист-бокс, комбо-бокс, строка состояния, строки ввода, чек-боксы и радиокнопки,
 * вкладки, DataGridView). 
 * 
 * Разработайте класс, описывающий электроприбор: название; мощность; цена; 
 * состояние прибора: включен/выключен; название комнаты, в которой размещен 
 * прибор (кухня, прихожая, …). 
 * 
 * Разработайте класс, описывающий электрооборудование квартиры: адрес квартиры,
 * условное название квартиры (Васин дом, Орлиная слободка, …) коллекция
 * электроприборов. Отдельно хранить названия комнат не надо.
 * 
 * Приложение должно использовать вкладки. Сведения о квартире и список 
 * электроприборов выводить в первой вкладке главной формы.  
 * 
 * Сведения о квартире разместить в виде дерева в TreeView в левой части вкладки, 
 * в правой части – вывод этих же сведений в DataGridView в табличном формате.
 * 
 * Выводить картинку состояния в таблицу не надо, только текст «включен» или «выключен».
 * 
 * При построении дерева используйте следующие соответствия: корень дерева – условное 
 * название квартиры, узлы – названия комнат, листья – электроприборы в комнате. 
 * Изображение узла дерева – условное обозначение электроприбора.
 * 
 * Приложение должно иметь следующий функционал (при помощи пунктов меню,
 * контекстного меню, кнопок панели инструментов):
 * •	Сворачивать приложение в трей, восстанавливать форму приложения из контекстного
 *      меню иконки в трее. В этом же контекстом меню разместите команды для завершения
 *      приложения, вызова формы со сведениями о приложении и разработчике
 * •	При запуске приложения проверять наличие в папке исполняемого файла папки App_Data
 *      и файла appliances.json с данными о квартире. Если папки и/или файл нет, то создать 
 *      папку, заполнить начальными данными объект, описывающий электрооборудование квартиры, 
 *      сериализовать данные в формате JSON
 * •	Выводить коллекцию электроприборов в DataGridView, состояние прибора отображать 
 *      текстом «включен», «выключен»   
 * •	Переформирование коллекции электроприборов и сведений о квартире с сериализацией 
 * •	Сохранение данных в выбранном файле – сериализация в формате JSON. Файл для 
 *      сохранения выбирать стандартным диалогом 
 * •	Загрузка данных из выбранного стандартным диалогом файла, перетаскиванием файла на 
 *      DataGridView главной вкладки, на TreeView главной вкладки, десериализация в формате 
 *      JSON. 
 * •	Добавление электроприбора в коллекцию (ввод данных в отдельной форме), сериализация 
 *      данных
 * •	Удаление электроприбора из коллекции, сериализация данных
 * •	Редактирование выбранного электроприбора в отдельной форме, сериализация данных
 * •	Редактирование названия квартиры, комнаты, электроприбора непосредственно в узлах 
 *      дерева – редактирование меток узлов дерева
 * •	Редактирование данных квартиры – адрес и название, сериализация данных
 * •	Упорядочивание копии коллекции электроприборов, вывод упорядоченной копии коллекции
 *      в отдельной вкладке. При выборе команды переходить на вкладку
 * o	По названию
 * o	По состоянию
 * o	По мощности
 * o	По убыванию цены
 * •	Включение/выключение выбранного электроприбора
 * •	Включение/выключение всех электроприборов квартиры
 * •	Включение и выключение всех электроприборов комнаты
 * •	Выборка и вывод в отдельной вкладке главной формы коллекции электроприборов, с 
 *      заданным названием. При выборе команды переходить на вкладку
 * •	Выборка и вывод в отдельной вкладке главной формы коллекции электроприборов 
 *      заданного состояния. При выборе команды переходить на вкладку
 * В меню и контекстных меню (DataGridView, MainForm, NotifyIcon) включите команды 
 * выхода, вывода окна со сведениями о программе и ее разработчике.
*/

namespace Appliances
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
            // загрузка коллекции в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // установка сообщения о количестве элементов в строке состояния
            UpdateStatusAmount();

            // установка значения в ComboBox выбора сортировки
            CbxOrderBy.SelectedItem = CbxOrderBy.Items[0];

            // установка значения в ComboBox выбора выборки
            CbxSelectionWhere.SelectedItem = CbxSelectionWhere.Items[0];

            // вывод пути к файлу сохранения в статус
            ShowPathFileStatus();

            // загрузка данных в TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // вывод названия дома в GroupBox
            GbxAppliances.Text = $" {_controller.Home.Title} ";
        }


        // dragEnter над формой
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            // проверка на содержимое
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // переход на главную вкладку
                TbcMain.SelectedTab = TbpMain;

                // изменение цвета DataGridView и TreeView
                TviMain.BackColor =
                    DgvAppliances.RowsDefaultCellStyle.BackColor = 
                    DgvAppliances.BackgroundColor = Color.CornflowerBlue;

                DgvAppliances.AlternatingRowsDefaultCellStyle.BackColor = Color.RoyalBlue;

                // установка эффекта
                e.Effect = DragDropEffects.Copy;
            }
            else
                // установка эффекта
                e.Effect = DragDropEffects.None;
        }


        // dragLeave над формой
        private void DragLeave_Command(object sender, EventArgs e)
        {
            // изменение цвета DataGridView и TreeView
            TviMain.BackColor = TviMain.BackColor = Color.Silver;

            // изменение цвета DataGridView и TreeView
            TviMain.BackColor =
                DgvAppliances.RowsDefaultCellStyle.BackColor = 
                DgvAppliances.BackgroundColor = Color.Silver;

            DgvAppliances.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro;
        }

        // drop на форму
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // установка цветов по умолчанию
            DragLeave_Command(sender, e);
        }


        // dragEnter над DataGridView
        private void DgvAppliances_DragEnter(object sender, DragEventArgs e)
        {
            // проверка на содержимое
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // изменение цвета DataGridView
                DgvAppliances.RowsDefaultCellStyle.BackColor =
                    DgvAppliances.BackgroundColor = Color.MediumSeaGreen;

                DgvAppliances.AlternatingRowsDefaultCellStyle.BackColor = Color.SpringGreen;

                // установка эффекта
                e.Effect = DragDropEffects.Copy;
            }
            else
                // установка эффекта
                e.Effect = DragDropEffects.None;
        }


        // drop на DataGridView
        private void DgvAppliances_DragDrop(object sender, DragEventArgs e)
        {
            // установка цветов по умолчанию
            MainForm_DragDrop(sender, e);

            // загрузка из файла
            LoadFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
        }

        // dragEnter над TreeView
        private void TreeView_DragEnter(object sender, DragEventArgs e)
        {
            // проверка на содержимое
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // изменение цвета DataGridView
                ((TreeView)sender).BackColor = Color.MediumSeaGreen;

                // установка эффекта
                e.Effect = DragDropEffects.Copy;
            }
            else
                // установка эффекта
                e.Effect = DragDropEffects.None;
        }


        // drop на TreeView
        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            // установка цветов по умолчанию
            MainForm_DragDrop(sender, e);

            // загрузка из файла
            LoadFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]);
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

            // обновление данных в DataGridView на вкладке "Сортировка"
            _controller.ShowDataGridView(DgvAppliancesOrdered, list);
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

            // обновление данных в DataGridView на вкладке "Выборка"
            _controller.ShowDataGridView(DgvAppliancesSelected, list);
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

            // зарузка из файла
            LoadFile(OfdAppliances.FileName);

            // вывод названия дома в GroupBox
            GbxAppliances.Text = $" {_controller.Home.Title} ";
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

            // вывод пути к файлу сохранения в статус
            ShowPathFileStatus();
        }


        // добавление коллекции приборов
        private void AddRange_Command(object sender, EventArgs e)
        {
            // добавление приборов
            _controller.Initialization();

            // сериализация 
            _controller.Serialization();

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // установка в рабочую коллекцию
            _controller.CurrentAppliances = _controller.Appliances;

            // обновления количества в статусе
            UpdateStatusAmount();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // вывод названия дома в GroupBox
            GbxAppliances.Text = $" {_controller.Home.Title} ";
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

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // обновления количества в статусе
            UpdateStatusAmount();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // редактирование выбранного элемента
        private void EditElem_Command(object sender, EventArgs e)
        {
            // если элемент не выбран
            if (DgvAppliances.SelectedRows.Count == 0)
                return;

            // индекс выбранного элемента
            int index = DgvAppliances.SelectedRows[0].Index;

            // запуск формы для редактирования
            if (new ApplianceForm(_controller.CurrentAppliances[index]).ShowDialog() != DialogResult.OK)
                return;

            // запись в файл
            _controller.Serialization();

            // обновление отображения элемента в DataGridView
            _controller.ShowDataGridViewChangeElem(DgvAppliances, _controller.CurrentAppliances, index);

            // обновления количества в статусе
            UpdateStatusAmount();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // удалить выбранный прибор
        private void DeleteElem_Command(object sender, EventArgs e)
        {
            // если прибор не выбран
            if (DgvAppliances.SelectedRows.Count == 0)
                return;

            // индекс выбранного элемента 
            int index = DgvAppliances.SelectedRows[0].Index;

            // удаление элемента по индексу
            _controller.RemoveAt(_controller.Appliances.IndexOf(_controller.CurrentAppliances[index]));

            // удаление элемента в DataGridView
            DgvAppliances.Rows.RemoveAt(index);
             
            // сохранение изменений
            _controller.Serialization();

            // обновления количества в статусе
            UpdateStatusAmount();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // удаление всех
        private void Clear_Command(object sender, EventArgs e)
        {
            // удалание приборов
            _controller.Clear();

            // сериализация 
            _controller.Serialization();

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // обновления количества в статусе
            UpdateStatusAmount();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // вывод названия дома в GroupBox
            GbxAppliances.Text = $" {_controller.Home.Title} ";
        }


        // включить все приборы
        private void StateOnAll_Command(object sender, EventArgs e)
        {
            // включение
            _controller.TurnPowerAll(true);

            // сериализация 
            _controller.Serialization();

            // вывод названия дома в GroupBox
            GbxAppliances.Text = $" {_controller.Home.Title} ";

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // перестроение TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // выключить все приборы
        private void StateOffAll_Command(object sender, EventArgs e)
        {
            // выключение
            _controller.TurnPowerAll(false);

            // сериализация 
            _controller.Serialization();

            // вывод названия дома в GroupBox
            GbxAppliances.Text = $" {_controller.Home.Title} ";

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // перестроение TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // включить выбраннный прибор
        private void StateOnElem_Command(object sender, EventArgs e)
        {
            // если прибор не выбран
            if (DgvAppliances.SelectedRows.Count == 0)
                return;

            // индекс прибора 
            int index = DgvAppliances.SelectedRows[0].Index;

            // включение прибора
            _controller.CurrentAppliances[index].TurnPower(true);

            // сохранение изменений
            _controller.Serialization();

            // изменение выбранного прибора в DataGridView
            _controller.ShowDataGridViewChangeElem(DgvAppliances, _controller.CurrentAppliances, index);

            // перестройка TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // выключить выбраннный прибор
        private void StateOffElem_Command(object sender, EventArgs e)
        {
            // если прибор не выбран
            if (DgvAppliances.SelectedRows.Count == 0)
                return;

            // индекс прибора 
            int index = DgvAppliances.SelectedRows[0].Index;

            // выключение прибора
            _controller.CurrentAppliances[index].TurnPower(false);

            // сохранение изменений
            _controller.Serialization();

            // изменение выбранного прибора в DataGridView
            _controller.ShowDataGridViewChangeElem(DgvAppliances, _controller.CurrentAppliances, index);

            // перестройка TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
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
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // вывод название дома в GroupBox
            GbxAppliances.Text = _controller.Home.Title;
        }


        // редактирование дома
        private void EditHome_Command(object sender, EventArgs e)
        {
            // запуск формы для редактирования 
            if (new HomeForm(_controller.Home).ShowDialog() != DialogResult.OK)
                return;

            // сохранение в файл
            _controller.Serialization();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // вывод название дома в GroupBox
            GbxAppliances.Text = _controller.Home.Title;
        }


        #region TreeView


        // выбор элемента TreeView
        private void TviMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // если элемент не выбран
            if (e.Node == null)
                return;

            // установка выбранного элемента активным
            TviMain.SelectedNode = e.Node;

            // вывод в DataGridView 
            switch (e.Node.Level)
            {
                // корень 
                case 0:
                    // вывод названия дома в GroupBox
                    GbxAppliances.Text = $" {e.Node.Text} ";

                    // установка коллекции для работы
                    _controller.CurrentAppliances = _controller.Appliances;

                    _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

                    // включение пункта "Управление" в контекстном меню TreeView
                    CmiTreeViewControl.Enabled = true;

                    // изменение текстовки пункта "Управление"
                    CmiTreeViewControl.Text = $"Управление домом: {e.Node.Text}";

                    break;
                // комната
                case 1:
                    // положить в тег элемента его текущий Label (необходимо для переименование комнат)
                    e.Node.Tag = e.Node.Text;

                    // вывод названия комнаты в GroupBox
                    GbxAppliances.Text = $" {e.Node.Text} ";

                    // коллекция для работы
                    var appliances = _controller.SelectionWhereRoom(e.Node.Text);

                    // установка коллекции для работы
                    _controller.CurrentAppliances = appliances;

                    // вывод приборов комнаты
                    _controller.ShowDataGridView(DgvAppliances, appliances);

                    // включение пункта "Управление" в контекстном меню TreeView
                    CmiTreeViewControl.Enabled = true;

                    // изменение текстовки пункта "Управление"
                    CmiTreeViewControl.Text = $"Управление комнатой: {e.Node.Text}";

                    break;
                // прибор
                case 2:
                    // коллекция для работы
                    var appliances1 = _controller.SelectionWhereRoom(e.Node.Parent.Text);

                    // установка коллекции для работы
                    _controller.CurrentAppliances = appliances1;

                    _controller.ShowDataGridView(DgvAppliances, appliances1);

                    // вывод названия комнаты в GroupBox
                    GbxAppliances.Text = $" {e.Node.Parent.Text} ";

                    break;
                default:
                    break;
            }
        }


        // редактирование названия узла
        private void TviMain_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            // новое название
            string label = e.Label;

            // если строка пуста
            if (string.IsNullOrWhiteSpace(label)) {
                e.CancelEdit = true;
                return;
            }

            // выбранный элемент node
            TreeNode node = e.Node;

            // изменение названия
            switch (e.Node.Level)
            {
                // корень 
                case 0:
                    // вывод в DataGridView элементов дома
                    _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

                    // вывод названия дома в GroupBox
                    GbxAppliances.Text = $" {e.Label} ";

                    // переименование дома
                    _controller.Home.Title = e.Label;

                    break;
                // комната
                case 1:
                    // вывод в DataGridView элементов комнаты
                    _controller.ShowDataGridView(DgvAppliances, _controller.SelectionWhereRoom(e.Node.Text));

                    // вывод названия комнаты в GroupBox
                    GbxAppliances.Text = $" {e.Label} ";

                    // переименование комнаты в приборах
                    _controller.ChangeRoom(e.Label, _controller.SelectionWhereRoom(node.Tag.ToString()));

                    // переформирование дерева
                    _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

                    break;

                // прибор
                case 2:
                    // получение коллекции элементов комнаты
                    List<ElectricalAppliance> appliances = _controller.SelectionWhereRoom(node.Parent.Text);

                    // переименование комнаты по индексу
                    appliances[node.Index].Name = e.Label;

                    // вывод в DataGridView элементов комнаты
                    _controller.ShowDataGridView(DgvAppliances, appliances);

                    break;
                default:
                    break;
            }

            // сериализация 
            _controller.Serialization();
        }


        // включить все приборы в рабочей коллекции
        private void TurnOnSelection_Command(object sender, EventArgs e)
        {
            _controller.CurrentAppliances.ForEach(item => item.TurnPower(true));

            // сериализация 
            _controller.Serialization();

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.CurrentAppliances);

            // обновление данных в TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // сохранение 
            _controller.Serialization();
        }


        // выключить все приборы в рабочей коллекции
        private void TurnOffSelection_Command(object sender, EventArgs e)
        {
            _controller.CurrentAppliances.ForEach(item => item.TurnPower(false));

            // сериализация 
            _controller.Serialization();

            // обновление данных в DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.CurrentAppliances);

            // обновление данных в TreeView
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);

            // сохранение 
            _controller.Serialization();
        }


        // включение выбранного прибора
        private void TurnOnSelectTreeView_Command(object sender, EventArgs e)
        {
            // включение прибора
            (TviMain.SelectedNode.Tag as ElectricalAppliance).TurnPower(true);

            // обновление DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.CurrentAppliances);

            // обновление состояния в TreeView
            TviMain.SelectedNode.ImageIndex = TviMain.SelectedNode.SelectedImageIndex = 4;

            // сохранение 
            _controller.Serialization();
        }


        // выключение выбранного прибора
        private void TurnOffSelectTreeView_Command(object sender, EventArgs e)
        {
            // включение прибора
            (TviMain.SelectedNode.Tag as ElectricalAppliance).TurnPower(false);

            // обновление DataGridView
            _controller.ShowDataGridView(DgvAppliances, _controller.CurrentAppliances);

            // обновление состояния в TreeView
            TviMain.SelectedNode.ImageIndex = TviMain.SelectedNode.SelectedImageIndex = 3;

            // сохранение 
            _controller.Serialization();
        }

        // нажатие на запись в таблице (любой кнопкой мыши)
        private void DgvAppliances_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // если нажатие было не по строке таблицы
            if (e.RowIndex == -1)
                return;

            // установка строки таблицы, по которой было произведено нажатие, как активной
            DgvAppliances.Rows[e.RowIndex].Selected = true;
        }


        #endregion

        #endregion

        #endregion

        #region Общие методы

        // загрузка из файла 
        public void LoadFile(string nameFile)
        {
            // текущий путь к файлу
            string oldFile = _controller.SaveFile;

            // установка пути к файлу
            _controller.SaveFile = nameFile;

            // загрузка данных из файла 
            if (!_controller.Deserialization())
            {
                // установка старого имени файла
                _controller.SaveFile = oldFile;

                // вывод сообщения об ошибке
                MessageBox.Show($"Ошибка загрузки из файла: {nameFile}", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // вывод загруженных данных
            _controller.ShowDataGridView(DgvAppliances, _controller.Appliances);

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpMain;

            // обновление количества элементов в статусе
            UpdateStatusAmount();

            // вывод пути к файлу сохранения в статус
            ShowPathFileStatus();

            // перестроение TreeView 
            _controller.ShowTreeView(TviMain, CmsTreeViewAppliance);
        }


        // вывод пути к файлу сохранения в статус
        public void ShowPathFileStatus() =>
            // вставка пути к файлу
            StiSaveFile.Text = StiSaveFile.Text.Remove(StiSaveFile.Text.IndexOf(":") + 1) + " "
            + _controller.SaveFile.Substring(_controller.SaveFile.LastIndexOf('\\'));

        // обновление сообщения о количестве элементов в строке состояния
        public void UpdateStatusAmount() => StiAmount.Text = $"Количество приборов: {_controller.Count}";

        #endregion

        #endregion
    }
}
