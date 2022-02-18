using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Views;       // формы
using HomeWork.Models;      // модели
using HomeWork.Controllers; // контроллеры
using System.IO;

/* Задача 1. Разработайте приложение Windows Forms с использованием изученных
 * элементов интерфейса (строковое меню, контекстное меню, панель инструментов,
 * лист-бокс, комбо-бокс, строка состояния, строки ввода, чек-боксы и радиокнопки).
 * 
 * Разработайте класс Television (производитель и тип телевизора, диагональ экрана, 
 * строка с описанием дефекта, фамилия и инициалами мастера, фамилия и инициалы 
 * владельца, стоимость ремонта).
 * 
 * Разработайте класс RepairShop (коллекция Television, название ремонтной мастерской, 
 * адрес ремонтной мастерской).
 * 
 * Приложение должно иметь следующий функционал (при помощи пунктов меню, контекстного
 * меню, кнопок панели инструментов):
 *     •	Сворачивать приложение в трей, восстанавливать форму приложения из 
 *          контекстного меню иконки в трее. В этом же контекстом меню разметсите команды 
 *          для завершения приложения, вызова формы со сведениями о приложении и разработчике
 *     •	Начальное формирование данных ремонтной мастерской (коллекция телевизоров 
 *          от 12 до 15 штук)
 *     •	Сохранение данных ремонтной мастерской в выбранном файле – сериализация в
 *          формате JSON. Файл для сохранения выбирать стандартным диалогом 
 *     •	Загрузка данных ремонтной мастерской из выбранного файла в – десериализация
 *          формате JSON. Файл для загрузки выбирать стандартным диалогом
 *     •	Изменение шрифта для отображения коллекции телевизоров в ListBox главного 
 *          окна. Выбор шрифта выполняйте при помощи стандартного диалога
 *     •	Изменение фона ListBox отображения коллекции телевизоров в главной форме 
 *          при помощи стандартного диалога 
 *     •	Изменение цвета символов в ListBox отображения коллекции телевизоров в главной 
 *          форме при помощи стандартного диалога 
 *     •	Добавление телевизора в коллекцию, сериализация данных
 *     •	Удаление телевизора из коллекции – выдача телевизора владельцу после ремонта, 
 *          сериализация данных
 *     •	Редактирование выбранного телевизора в отдельной форме, сериализация данных
 *     •	Редактирование данных ремонтной мастерской, сериализация данных
 *     •	Упорядочивание коллекции телевизоров, вывод упорядоченной копии коллекции в
 *          отдельной вкладке:
 *              o	По производителю и типу
 *              o	По убыванию диагонали экрана
 *              o	По мастеру, выполняющему ремонт
 *              o	По владельцу телевизора
 *              o	По стоимости ремонта
 *     •	Выборка и вывод в отдельной вкладке главной формы коллекции телевизоров с 
 *          минимальной стоимостью ремонта. При выборе команды переходить на вкладку
 *     •	Выборка и вывод в отдельной вкладке главной формы коллекции телевизоров, 
 *          ремонтируемых выбранным мастером. При выборе команды переходить на вкладку
 *     •	Выборка и вывод в отдельной вкладке главной формы коллекции телевизоров, с 
 *          заданной диагональю экрана. При выборе команды переходить на вкладку
 *     •	Выборка и вывод в отдельной вкладке главной формы коллекции телевизоров, 
 *          заданного владельца. При выборе команды переходить на вкладку
 *     
 * В меню и контекстных меню (ListBox, MainForm) включите команды выхода, вывода окна со 
 * сведениями о программе и ее разработчике
 * 
*/

namespace HomeWork
{
    // Главная форма
    public partial class MainForm : Form
    {
        // констроллер ремонтной мастерской
        private RepairShopController _controller;

        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();

            // инициализация полей
            _controller = new RepairShopController();

            // установка наименования сортировки для упорядочивания коллекции в тег
            MsiOrderByDiagonal.Tag      = "Убыванию диагонали экрана";
            MsiOrderByMaster.Tag        = "Мастеру, выполняющему ремонт";
            MsiOrderByModel.Tag         = "Производителю и типу";
            MsiOrderByOwner.Tag         = "Владельцу телевизора";
            MsiOrderByPriceAscend.Tag   = "Возрастанию цены";
            MsiOrderByPriceDescend.Tag  = "Убыванию цены";
            CmiOrderByDiagonal.Tag      = "Убыванию диагонали экрана";
            CmiOrderByMaster.Tag        = "Мастеру, выполняющему ремонт";
            CmiOrderByModel.Tag         = "Производителю и типу";
            CmiOrderByOwner.Tag         = "Владельцу телевизора";
            CmiOrderByPriceAscend.Tag   = "Возрастанию цены";
            CmiOrderByPriceDescend.Tag  = "Убыванию цены";
            TsiOrderByDiagonal.Tag      = "Убыванию диагонали экрана";
            TsiOrderByMaster.Tag        = "Мастеру, выполняющему ремонт";
            TsiOrderByModel.Tag         = "Производителю и типу";
            TsiOrderByOwner.Tag         = "Владельцу телевизора";
            TsiOrderByPriceAscend.Tag   = "Возрастанию цены";
            TsiOrderByPriceDescend.Tag  = "Убыванию цены";

            // установка значения состояния для запуска формы выборки коллекции в тег
            MsiSelectionByDiagonal.Tag  = "Диагонали";
            MsiSelectionByMaster.Tag    = "Мастеру";
            MsiSelectionByMinPrice.Tag  = "Минимальной стоимости";
            MsiSelectionByOwner.Tag     = "Владельцу";
            CmiSelectionByDiagonal.Tag  = "Диагонали";
            CmiSelectionByMaster.Tag    = "Мастеру";
            CmiSelectionByMinPrice.Tag  = "Минимальной стоимости";
            CmiSelectionByOwner.Tag     = "Владельцу";
            TsiSelectionDiagonal.Tag    = "Диагонали";
            TsiSelectionMaster.Tag      = "Мастеру";
            TsiSelectionMinPrice.Tag    = "Минимальной стоимости";
            TsiSelectionOwner.Tag       = "Владельцу";
        }

        // загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // установка сортировки в комбо-бокс
            CbxOrderBy.SelectedIndex = 0;

            // установка обработчика события выбора сотрировки в комбо-боксе
            CbxOrderBy.SelectedIndexChanged += CbxOrderBy_SelectedIndexChanged;

            // установка текущей вкладки
            TbcMain.SelectedTab = TbcMain.TabPages[0];
            TbcMain_SelectedIndexChanged(this, e);

            // установка значения по умолчанию в комбо-бокс вида выборки
            CbxSelectionBy.SelectedItem = CbxSelectionBy.Items[0];

            // форма для выбора/создания мастерской
            SelectRepairShopForm selectRepairShopForm = new SelectRepairShopForm(_controller);

            // получение результата формы
            DialogResult result = selectRepairShopForm.ShowDialog();

            // если был выбран пункт "Выход"
            if (result == DialogResult.Abort) 
                Close();        

            // установка контроллера
            _controller = selectRepairShopForm.Controller;

            // установка связи лист-бокса и коллекции данных
            UpdateCommunication();

            // загрузка данных о ремонтной мастерской
            TxbNameRepairShop.Text = _controller.Repair.Name;
            TxbAddress.Text = _controller.Repair.Address;

            // установка последнего действия в статус
            SlbHistory.Text = "Форма загружена";

            // установка пути к файлу сохранения
            SlbFileSave.Text = $" Файл сохранения: {new FileInfo(_controller.SaveFile).Name}";
        }

        // выход из приложения
        private void Exit_Command(object sender, EventArgs e) => Application.Exit();

        // информация о приложении
        private void ProgramInfo_Comand(object sender, EventArgs e) => new FormInfo().ShowDialog();

        // формирование коллекции
        private void InitializationCoolection_Command(object sender, EventArgs e)
        {
            // очистка коллекции телевизоров
            _controller.Clear();

            // инициализация коллекции
            _controller.Initialization();

            // обновление связи
            UpdateCommunication();

            // сохранение в файл
            _controller.Save();

            // установка последнего действия в статус
            SlbHistory.Text = "Формирование коллекции";
        }

        // лист-бокс с телевизорами на текущей вкладке
        private ListBox _LbxCurrent;

        // обновление связи лист-бокса и коллекции данных
        private void UpdateCommunication()
        {
            // установка источника данных
            _LbxCurrent.DataSource = null;
            _LbxCurrent.DataSource = _controller.Televisions;

            // установка метода для вывода 
            _LbxCurrent.DisplayMember = "ShowElem";

            // обновление количества элементов в статуса
            SlbInfoCountElement.Text = $"Количество элементов: {_controller.Count}";
        }

        // очистка коллекции
        private void Clear_Command(object sender, EventArgs e)
        {
            // очистка 
            _controller.Clear();

            // обновление связи
            UpdateCommunication();

            // установка последнего действия в статус
            SlbHistory.Text = "Очистка коллекции телевизоров";

            // сохранение в файл
            _controller.Save();
        }

        // добавление коллекции 
        private void AddRange_Command(object sender, EventArgs e)
        {
            // очистка 
            _controller.Initialization(100);

            // обновление связи
            UpdateCommunication();

            // установка последнего действия в статус
            SlbHistory.Text = "Добавление коллекции телевизоров";

            // сохранение в файл
            _controller.Save();
        }

        // удаление элемента
        private void Remove_Command(object sender, EventArgs e)
        {
            // удаление элемента (т.к. удаление не по индексу, защита от некорретного индекса не требуется)
            _controller.Remove((Television)_LbxCurrent.SelectedItem);

            // обновление связи
            UpdateCommunication();

            // установка последнего действия в статус
            SlbHistory.Text = "Удаление выбранного телевизора";

            // сохранение в файл
            _controller.Save();
        }

        // добавление телевизора
        private void AddTelevision_Command(object sender, EventArgs e)
        {
            // форма создания
            TelevisionForm televisionForm = new TelevisionForm();

            // если создание отменено
            if (televisionForm.ShowDialog() != DialogResult.OK) 
                return;

            // добавление созданного телевизора в коллекцию
            _controller.Insert(0, televisionForm.television);

            // обновление связи
            UpdateCommunication();

            // установка последнего действия в статус
            SlbHistory.Text = "Добавление телевизора";

            // сохранение в файл
            _controller.Save();
        }

        // редактирование выбранного элемента
        private void Edit_Command(object sender, EventArgs e)
        {
            // если не выбран элемент
            if (_LbxCurrent.SelectedItem == null) 
                return;

            // форма редактирования 
            new TelevisionForm((Television)_LbxCurrent.SelectedItem).ShowDialog();

            // обновление связи
            UpdateCommunication();

            // установка последнего действия в статус
            SlbHistory.Text = "Редактирование выбранного телевизора";

            // сохранение в файл
            _controller.Save();
        }

        // редактирование данных о мастерской
        private void EditRepairShop_Command(object sender, EventArgs e)
        {
            // форма для редактирования данных о мастерсой
            var repairShopForm = new RepairShopForm(_controller.Repair, _controller.SaveFile);

            // запуск формы
            if (repairShopForm.ShowDialog() != DialogResult.OK)
                return;

            // загрузка данных о ремонтной мастерской
            TxbNameRepairShop.Text = _controller.Repair.Name;
            TxbAddress.Text = _controller.Repair.Address;

            // если файл сохранения изменился
            if (_controller.SaveFile != repairShopForm.SaveFile)
                _controller.JsonSerialization(repairShopForm.SaveFile);

            // установка файла для сохранения
            _controller.SaveFile = repairShopForm.SaveFile;

            // установка последнего действия в статус
            SlbHistory.Text = "Редактирование данных о мастерской";

            // сохранение в файл
            _controller.Save();

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpTelevisions;
        }

        // упорядочивание по компаратору
        private void SelectOrderBy_Command(object sender, EventArgs e)
        {
            // если вызвана уже установленная сортировка 
            if (CbxOrderBy.SelectedItem == ((ToolStripMenuItem)sender).Tag)
                CbxOrderBy_SelectedIndexChanged(sender, e);

            // установка сортировки в комбо-боксе
            CbxOrderBy.SelectedItem = ((ToolStripMenuItem)sender).Tag;
        }

        // упорядочивание по компаратору
        private void OrderBy_Command(object sender, EventArgs e)
        {
            // упорядочивание
            (Func<List<Television>> func, string name) televisionsOrder = ((Func<List<Television>>, string))((Control)sender).Tag;
            
            // установка связи
            LbxTelevisionsOrder.DataSource = null;
            LbxTelevisionsOrder.DataSource = televisionsOrder.func.Invoke();
            LbxTelevisionsOrder.DisplayMember = "ShowElem";

            // установка последнего действия в статус
            SlbHistory.Text = "Упорядочивание";
        }

        // выборка
        private void Selection_Command(object sender, EventArgs e)
        {
            // переход на вкладку "Выборка"
            TbcMain.SelectedTab = TbpSelectionBy;

            // установка значения в комбо-боксе выбора вида выборки
            CbxSelectionBy.SelectedItem = ((ToolStripMenuItem)sender).Tag;

            // установка последнего действия в статус
            SlbHistory.Text = "Выборка";
        }

        // загрузка из файла
        private void LoadFile_Command(object sender, EventArgs e)
        {
            // получение результата формы
            if (OfdLoad.ShowDialog() != DialogResult.OK) return;

            // выбор файла для сохранения
            _controller.SaveFile = OfdLoad.FileName;

            // десериализация из файла
            _controller.Load();

            // обновление связи
            UpdateCommunication();

            // загрузка данных о ремонтной мастерской
            TxbNameRepairShop.Text = _controller.Repair.Name;
            TxbAddress.Text = _controller.Repair.Address;

            // установка последнего действия в статус
            SlbHistory.Text = "Загрузка из файла";

            // установка пути к файлу сохранения
            SlbFileSave.Text = $" Файл сохранения: {new FileInfo(_controller.SaveFile).Name}";

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpTelevisions;
        }

        // сохранение в файл
        private void SaveFile_Command(object sender, EventArgs e)
        {
            // получение результата формы
            if (SfdSave.ShowDialog() != DialogResult.OK) return;

            // выбор файла для сохранения
            _controller.SaveFile = SfdSave.FileName;

            // сериализация в файл
            _controller.Save();

            // обновление связи
            UpdateCommunication();

            // установка последнего действия в статус
            SlbHistory.Text = "Сохранение в файл";

            // установка пути к файлу сохранения
            SlbFileSave.Text = $" Файл сохранения: {new FileInfo(_controller.SaveFile).Name}";

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpTelevisions;
        }

        // создание мастерской
        private void CreateRepairShop_Command(object sender, EventArgs e)
        {
            // форма для создания данных о мастерсой
            var repairForm = new RepairShopForm();

            // форма для создания данных о мастерсой
            if (repairForm.ShowDialog() != DialogResult.OK)
                return;

            // установка ссылки на новую мастерскую
            _controller.Repair = repairForm.Repair;

            // установка файла для сохранения
            _controller.SaveFile = repairForm.SaveFile;

            // загрузка данных о ремонтной мастерской
            TxbNameRepairShop.Text = _controller.Repair.Name;
            TxbAddress.Text = _controller.Repair.Address;

            // установка последнего действия в статус
            SlbHistory.Text = "Создание мастерской";

            // обновление связи
            UpdateCommunication();

            // сохранение в файл
            _controller.Save();

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpTelevisions;
        }

        // изменение шрифта лист-бокса
        private void ChangeFont_Command(object sender, EventArgs e)
        {
            // запуск формы выбора шрифта
            if (FdgChangeFontList.ShowDialog() != DialogResult.OK)
                return;

            // применение шрифта
            LbxTelevisions.Font = LbxTelevisionsOrder.Font = LbxTelevisionsSelection.Font = FdgChangeFontList.Font;
        }

        // изменение фона лист-бокса
        private void BackColor_Click(object sender, EventArgs e)
        {
            // запуск формы выбора цвета
            if (CdgChangeColorList.ShowDialog() != DialogResult.OK)
                return;

            // применение цвета
            LbxTelevisions.BackColor = LbxTelevisionsOrder.BackColor = 
                LbxTelevisionsSelection.BackColor = CdgChangeColorList.Color;
        } 
        
        // изменение цвета шрифта лист-бокса
        private void FontColor_Click(object sender, EventArgs e)
        {
            // запуск формы выбора цвета
            if (CdgChangeColorList.ShowDialog() != DialogResult.OK)
                return;

            // применение цвета
            LbxTelevisions.ForeColor = LbxTelevisionsOrder.ForeColor =
                LbxTelevisionsSelection.ForeColor = CdgChangeColorList.Color;
        }

        // сворачивание в трей
        private void ToTray_Command(object sender, EventArgs e)
        {
            // сворачивание приложения
            this.Hide();

            // отображение иконки в трее
            NtiMain.Visible = true;
        }

        // восстановить из трея
        private void FromTray_Command(object sender, EventArgs e)
        {
            // отображение приложения
            this.Show();

            // скрыть иконку в трее
            NtiMain.Visible = false;
        }

        // выбор вкладок
        private void TbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TbcMain.SelectedIndex)
            {
                // выбор вкладки "Телевизоры"
                case 0:

                    // установка текущего лист-бокса с телевизорами
                    _LbxCurrent = LbxTelevisions;

                    // включение всех кнопок для редактирования
                    TsiAddElem.Enabled = TsiEditElem.Enabled = TsiRemove.Enabled =
                        MsiAddElem.Enabled = MsiAddRange.Enabled = MsiClear.Enabled =
                        MsiRemove.Enabled = MsiInitialization.Enabled = CmiAddElem.Enabled = 
                        CmiAddRange.Enabled = CmiClear.Enabled = CmiEditElem.Enabled = 
                        CmiRemove.Enabled = CmiInitialization.Enabled = true;

                    break;

                // выбор вкладки "Сортировка"
                case 1:

                    // установка текущего лист-бокса с телевизорами
                    _LbxCurrent = LbxTelevisionsOrder;

                    // установки вида сортировки в тег
                    CbxOrderBy_SelectedIndexChanged(CbxOrderBy, EventArgs.Empty);

                    // выключение всех кнопок для редактирования
                    TsiAddElem.Enabled = TsiEditElem.Enabled = TsiRemove.Enabled =
                        MsiAddElem.Enabled = MsiAddRange.Enabled = MsiClear.Enabled =
                        MsiRemove.Enabled = MsiInitialization.Enabled = CmiAddElem.Enabled =
                        CmiAddRange.Enabled = CmiClear.Enabled = CmiEditElem.Enabled =
                        CmiRemove.Enabled = CmiInitialization.Enabled = false;

                    break;

                // выбор вкладки "Выборка"
                case 2:

                    // установка текущего лист-бокса с телевизорами
                    _LbxCurrent = LbxTelevisionsSelection;

                    // установка режима выборки
                    SetMode_Command(this, e);

                    // выключение всех кнопок для редактирования
                    TsiAddElem.Enabled = TsiEditElem.Enabled = TsiRemove.Enabled =
                        MsiAddElem.Enabled = MsiAddRange.Enabled = MsiClear.Enabled =
                        MsiRemove.Enabled = MsiInitialization.Enabled = CmiAddElem.Enabled =
                        CmiAddRange.Enabled = CmiClear.Enabled = CmiEditElem.Enabled =
                        CmiRemove.Enabled = CmiInitialization.Enabled = false;

                    break;

                default:
                    break;
            }

            // обновление привязки
            // UpdateCommunication();
        }

        // выбор сортировки в комбо-боксе
        private void CbxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbxOrderBy.SelectedItem)
            {
                case "Производителю и типу":
                    CbxOrderBy.Tag = ((Func<List<Television>>)_controller.OrderByModel, "Производителю и типу");
                    break;

                case "Убыванию диагонали экрана":
                    CbxOrderBy.Tag = ((Func<List<Television>>)_controller.OrderByDiagonal, "Убыванию диагонали экрана");
                    break;

                case "Мастеру, выполняющему ремонт":
                    CbxOrderBy.Tag = ((Func<List<Television>>)_controller.OrderByMaster, "Мастеру, выполняющему ремонт");
                    break;

                case "Владельцу телевизора":
                    CbxOrderBy.Tag = ((Func<List<Television>>)_controller.OrderByOwner, "Владельцу телевизора");
                    break;

                case "Возрастанию цены":
                    CbxOrderBy.Tag = ((Func<List<Television>>)_controller.OrderByPriceAscend, "Возрастанию цены");
                    break;

                case "Убыванию цены":
                    CbxOrderBy.Tag = ((Func<List<Television>>)_controller.OrderByPriceDescend, "Убыванию цены");
                    break;
            }

            // сортировка
            OrderBy_Command(CbxOrderBy, EventArgs.Empty);

            // установка активной вкладки на вкладку "Сортировка"
            TbcMain.SelectedIndex = 1;
        }


        #region Выборка

        // состояния
        public enum States
        {
            // выборка с минимальной стоимостью
            MinPriceMode,
            // выборка по мастеру
            MasterMode,
            // выборка по владельцу
            OwnerMode,
            // выборка по диагонали
            DiagonalMode
        }

        // коллекция выбранных данных
        private List<Television> _televisions = new List<Television>();

        // текущее состояние 
        private States _state;

        // установка режима
        private void SetMode_Command(object sender, EventArgs e)
        {
            switch (CbxSelectionBy.SelectedItem)
            {
                // выборка с минимальной стоимостью
                case "Минимальной стоимости":
                    _state = States.MinPriceMode;
                    CbxParameter.Visible = false;
                    LblParameter.Visible = false;
                    break;
                // выборка по мастеру
                case "Мастеру":
                    _state = States.MasterMode;
                    LblParameter.Text = "Мастер";
                    CbxParameter.Items.Clear();
                    CbxParameter.Items.AddRange(_controller.Repair.Masters);
                    if (CbxParameter.Items.Count > 0) CbxParameter.SelectedIndex = 1;
                    CbxParameter.Visible = true;
                    LblParameter.Visible = true;
                    break;
                // выборка по владельцу
                case "Владельцу":
                    _state = States.OwnerMode;
                    LblParameter.Text = "Владелец";
                    CbxParameter.Items.Clear();
                    CbxParameter.Items.AddRange(_controller.Repair.Owners);
                    if (CbxParameter.Items.Count > 0) CbxParameter.SelectedIndex = 1;
                    CbxParameter.Visible = true;
                    LblParameter.Visible = true;
                    break;
                // выборка по диагонали
                case "Диагонали":
                    _state = States.DiagonalMode;
                    LblParameter.Text = "Диагональ";
                    CbxParameter.Items.Clear();
                    CbxParameter.Items.AddRange(new[] { "22", "26", "32", "37", "40", "42", "46", "50", "60", "65" });
                    CbxParameter.SelectedIndex = 2;
                    CbxParameter.Visible = true;
                    LblParameter.Visible = true;
                    break;
            }

            // выборка
            Selection_Command();
        }

        // выборка 
        private void Selection_Command()
        {
            // очистка коллекции с выбранными данными
            _televisions.Clear();

            // если коллекция с телевизорами пуста
            if (_controller.Count == 0)
            {
                // установка связи при выборке
                UpdateCommunicationSelection();
                return;
            }

            switch (_state)
            {
                // выборка с минимальной стоимостью
                case States.MinPriceMode:
                    _televisions = _controller.SelectByMinPrice();
                    break;
                // выборка по мастеру
                case States.MasterMode:
                    _televisions = _controller.SelectByMaster((string)CbxParameter.SelectedItem);
                    break;
                // выборка по владельцу
                case States.OwnerMode:
                    _televisions = _controller.SelectByOwner((string)CbxParameter.SelectedItem);
                    break;
                // выборка по диагонали
                case States.DiagonalMode:
                    _televisions = _controller.SelectByDiagonal(double.Parse((string)CbxParameter.SelectedItem));
                    break;
            }

            // установка связи при выборке
            UpdateCommunicationSelection();

            // вывод в статус количества отобранных элементов
            SlbInfoCountElement.Text = $"Количество выбранных элементов: {_televisions.Count()}";
        }

        // установка связи при выборке
        private void UpdateCommunicationSelection()
        {
            // установка источника данных
            _LbxCurrent.DataSource = null;
            _LbxCurrent.DataSource = _televisions;

            // установка метода для вывода 
            _LbxCurrent.DisplayMember = "ShowElem";

            // обновление количества элементов в статуса
            SlbInfoCountElement.Text = $"Количество элементов: {_controller.Count}";
        }

        // выбор параметра
        private void CbxParameter_SelectedIndexChanged(object sender, EventArgs e) =>
            Selection_Command();

        #endregion
    }
}
