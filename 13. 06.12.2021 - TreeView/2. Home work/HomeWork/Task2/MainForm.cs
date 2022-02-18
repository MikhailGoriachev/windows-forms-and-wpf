using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals.Controllers;      // контроллеры
using Animals.Views;            // формы
using Animals.Models;           // модели

/*
 * Задача 2.Разработайте приложение для обработки коллекции животных, 
 * описываемых следующим классом Animal:
 * •	индекс иконки животного в коллекции ImageList, иконки есть 
 *      в папке Animals-mini
 * •	вид животного (те, для которых есть картинка в Animals-mini:
 *      кот, лев, слон, рыба, …)
 * •	кличка животного 
 * •	вес животного (в кг) 
 * •	возраст животного(в годах)
 * •	цвет(масть) животного, 
 * •	фамилия и инициалы владельца (Иванов И.И., …).
 * 
 * Создать коллекцию животных (не менее 20 животных), отобразить в 
 * главной вкладке окна приложения в элементе ListView. В отдельных 
 * вкладках также в ListView выводить:
 * •	выборку коллекции животных с максимальным весом
 * •	выборку коллекции животных, фамилия владельцев которых содержит
 *      заданную подстроку (подстроку вводить в этой же вкладке)
 * •	отсортированную по возрасту копию коллекции животных
 * •	отсортированную по виду копии коллекции животных
 * •	отсортированную по фамилиям владельцев копию коллекции животных
 * 
 * Реализовать добавление животных в коллекцию, редактирование данных 
 * животного в коллекции и удаление животных из коллекции. Создание 
 * животного выполняйте в отдельной форме, удаление – из главной вкладке, 
 * при помощи контекстного меню, клавиши Del, кнопки на панели инструментов. 
 * Используйте комбо-бокс для выбора вида животного. Используйте и другие  
 * изученные элементы интерфейса для построения интерфейса пользователя. 
 * 
 * Сохраняйте коллекцию в файле типа JSON, в папке App_Data у исполняемого  
 * файла. Загружайте коллекцию из файла JSON. Файл выбирайте при помощи  
 * стандартного диалога, а также при помощи перетаскивания на главную вкладку  
 * из Проводника. При первом запуске приложения или при отсутствии файла  
 * коллекции – создавайте коллекцию генератором.
 * 
 * Выводите текущее количество животных в коллекции и имя файла данных в строку  
 * состояния. 
 * 
 * В меню и контекстных меню (ListView, MainForm, NotifyIcon) включите команды  
 * выхода, вывода окна со сведениями о программе и ее разработчике.
*/

namespace Animals
{
    public partial class MainForm : Form
    {
        // контроллер коллекции животных
        private AnimalsController _controller;

        // перечисление сортировок
        public enum OrderType
        {
            // по возрасту 
            Age,
            // по виду
            Specials,
            // по фамилии владельца
            Owner
        } // OrderType

        // перечисление выборок
        public enum SelectionType
        {
            // с максимальным весом
            MaxWeight,
            // с фамилиями владельцев, которые содержат заданную подстроку
            OwnerSurnameSubString
        } // SelectionType

        // текущая выбранная сортировка на вкладке "Сортировка"
        private OrderType _order;

        // текущая выбранная выборка на вкладке "Выборка"
        private SelectionType _selection;

        #region Конструкторы


        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();

            // инициализация полей
            _controller = new AnimalsController();

            // запись в тег элементов видов сортировки
            MsiOrderByAge.Tag                   = OrderType.Age;
            MsiOrderBySpecials.Tag              = OrderType.Specials;
            MsiOrderByOwner.Tag                 = OrderType.Owner;
            TsiOrderByAge.Tag                   = OrderType.Age;
            TsiOrderBySpecials.Tag              = OrderType.Specials;
            TsiOrderByOwner.Tag                 = OrderType.Owner;
            CmiAnimalsOrderByAge.Tag            = OrderType.Age;
            CmiAnimalsOrderBySpecials.Tag       = OrderType.Specials;
            CmiAnimalsOrderByOwner.Tag          = OrderType.Owner;

            // запись в тег элементов видов выборки
            MsiSelectionWhereMaxWeight.Tag          = SelectionType.MaxWeight;
            MsiSelectionWhereOwner.Tag              = SelectionType.OwnerSurnameSubString;
            TsiSelectionWhereMaxWeight.Tag          = SelectionType.MaxWeight;
            TsiSelectionWhereOwner.Tag              = SelectionType.OwnerSurnameSubString;
            CmiAnimalsSelectionWhereMaxWeight.Tag   = SelectionType.MaxWeight;
            CmiAnimalsSelectionWhereOwner.Tag       = SelectionType.OwnerSurnameSubString;

        } // MainForm


        #endregion

        #region Свойства

        // доступ к полю _order, и установка значения с применением сортировки
        public OrderType Order
        {
            get => _order;
            set
            {
                // переход на вкладку "Сортировка"
                TbcMain.SelectedTab = TbpOrderBy;

                // если значение отличается от текущего 
                if (_order == value)
                    return;

                // установка значения
                _order = value;

                // сортировка
                OrderBy();
            }
        }


        // доступ к полю _selection, и установка значения с применением выборки
        public SelectionType Selection
        {
            get => _selection;
            set
            {
                // переход на вкладку "Выборка"
                TbcMain.SelectedTab = TbpSelectionWhere;

                // если значение отличается от текущего 
                if (_selection == value)
                    return;

                // установка значения
                _selection = value;

                // выборка
                SelectionWhere();
            }
        }


        #endregion

        #region Методы 

        #region Обработчики событий


        // загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // вывод коллекции животных в ListView
            _controller.ShowListView(LvwAnimals);

            // вывод пути к файлу для сохранения в статус
            ShowFileInfoStatus();

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // текущая выбранная сортировка на вкладке "Сортировка"
            _order = OrderType.Age;

            // установка значения в ComboBox сортировки
            SetOrderComboBox();

            // текущая выбранная выборка на вкладке "Выборка"
            _selection = SelectionType.MaxWeight;

            // установка значения в ComboBox сортировки выборки
            SetSelectionComboBox();

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpMain;

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // MainForm_Load


        // выход из приложения
        private void Exit_Command(object sender, EventArgs e) => Application.Exit();


        // сернуть в трей
        private void ToTray_Command(object sender, EventArgs e)
        {
            // отображение иконки в трее
            NicToTray.Visible = true;

            // скрытие формы
            this.Hide();
        } // ToTray_Command


        // восстановить из трея
        private void FromTray_Command(object sender, EventArgs e)
        {
            // скрытие иконки в трее
            NicToTray.Visible = false;

            // отображение формы
            this.Show();

        } // FromTray_Command


        // выбор вкладки
        private void SelectedTabPage_Command(object sender, EventArgs e)
        {
            switch (TbcMain.SelectedIndex)
            {
                // "Главная"
                case 0:

                    // включение редактирующих элементов интерфейса
                    MsiAddElem.Enabled =                            // добавление элемента
                        TsiAddElem.Enabled =
                        CmiAnimalsAddElem.Enabled =
                        MsiRemoveElem.Enabled =                     // удаление элемента
                        TsiRemoveElem.Enabled =
                        CmiAnimalsRemoveElem.Enabled =
                        MsiAddRange.Enabled =                       // добавление коллекции
                        CmiAnimalsAddRange.Enabled = 
                        MsiEditElem.Enabled =                       // редактирование выбранного элемента
                        TsiEditElem.Enabled =
                        CmiAnimalsEditElem.Enabled =
                        MsiClear.Enabled =
                        CmiAnimalsClear.Enabled = true;            // очистка коллекции

                    break;

                // "Сортировка"
                case 1:

                    // выключение редактирующих элементов интерфейса
                    MsiAddElem.Enabled =                            // добавление элемента
                        TsiAddElem.Enabled =
                        CmiAnimalsAddElem.Enabled =
                        MsiRemoveElem.Enabled =                     // удаление элемента
                        TsiRemoveElem.Enabled =
                        CmiAnimalsRemoveElem.Enabled =
                        MsiAddRange.Enabled =                       // добавление коллекции
                        CmiAnimalsAddRange.Enabled =
                        MsiEditElem.Enabled =                       // редактирование выбранного элемента
                        TsiEditElem.Enabled =
                        CmiAnimalsEditElem.Enabled =
                        MsiClear.Enabled = 
                        CmiAnimalsClear.Enabled = false;            // очистка коллекции

                    // сортировка
                    OrderBy();

                    break;

                // "Выборка"
                case 2:

                    // выключение редактирующих элементов интерфейса
                    MsiAddElem.Enabled =                            // добавление элемента
                        TsiAddElem.Enabled =
                        CmiAnimalsAddElem.Enabled =
                        MsiRemoveElem.Enabled =                     // удаление элемента
                        TsiRemoveElem.Enabled =
                        CmiAnimalsRemoveElem.Enabled =
                        MsiAddRange.Enabled =                       // добавление коллекции
                        CmiAnimalsAddRange.Enabled =
                        MsiEditElem.Enabled =                       // редактирование выбранного элемента
                        TsiEditElem.Enabled =
                        CmiAnimalsEditElem.Enabled =
                        MsiClear.Enabled =
                        CmiAnimalsClear.Enabled = false;            // очистка коллекции

                    // выборка
                    SelectionWhere();

                    // установка фокуса на поисковую строку для ввода фамилии владельца
                    TbxSearch.Focus();

                    break;

                default:
                    break;
            }
        } // SelectedTabPage_Command

        #region Загрузка и сохранение данных


        // выбор и открытие файла с данными с помощью диалогового окна
        private void OpenFile_Command(object sender, EventArgs e)
        {
            if (OfdOpenFile.ShowDialog() != DialogResult.OK)
                return;

            // название файла 
            string file = OfdOpenFile.FileName;

            // загрузка данных из файла 
            if (!_controller.LoadToFile(file, LvwAnimals)) {
                // вывод сообщения об ошибке
                MessageBox.Show($"Ошибка загрузки из файла: {file}", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // вывод пути к файлу для сохранения в статус
            ShowFileInfoStatus();

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // переход на главную вкладку
            TbcMain.SelectedTab = TbpMain;

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // OpenFile_Command


        // выбор и сохранение в файл данных с помощью диалогового окна
        private void SaveFile_Command(object sender, EventArgs e)
        {
            if (SfdSaveFile.ShowDialog() != DialogResult.OK)
                return;

            // сохранение данных в файл
            _controller.SaveToFile(SfdSaveFile.FileName);

            // вывод пути к файлу для сохранения в статус
            ShowFileInfoStatus();
        } // SaveFile_Command


        // DragEnter над формой
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            // переход на главную фотку 
            TbcMain.SelectedTab = TbpMain;

            // изменение цвета ListView на главной форме
            LvwAnimals.BackColor = Color.CornflowerBlue;

        } // MainForm_DragEnter


        // DragDrop над формой
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // изменение цвета ListView на главной форме
            LvwAnimals.BackColor = Color.Silver;
        }


        // DragLeave над формой
        private void MainForm_DragLeave(object sender, EventArgs e) => LvwAnimals.BackColor = Color.Silver;


        // DragEnter над ListView
        private void LvwAnimals_DragEnter(object sender, DragEventArgs e)
        {
            // установка действия 
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

            // изменение цвета ListView на главной форме
            LvwAnimals.BackColor = Color.SpringGreen;

        } // LvwAnimals_DragEnter


        // DragDrop над ListView
        private void LvwAnimals_DragDrop(object sender, DragEventArgs e)
        {
            // проверка на тип содержания
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            // изменение цвета ListView на главной форме
            LvwAnimals.BackColor = Color.Silver;

            // название файла 
            string file = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];

            // загрузка данных из файла 
            if (!_controller.LoadToFile(file, LvwAnimals))
            {
                // вывод сообщения об ошибке
                MessageBox.Show($"Ошибка загрузки из файла: {file}", "Ошибка данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // вывод пути к файлу для сохранения в статус
            ShowFileInfoStatus();

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // LvwAnimals_DragDrop


        #endregion


        // выбор сортировки в ComboBox
        private void CbxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbxOrderBy.SelectedItem)
            {
                case "По возрасту":
                    Order = OrderType.Age;
                    break;

                case "По виду":
                    Order = OrderType.Specials;
                    break;

                case "По владельцу":
                    Order = OrderType.Owner;
                    break;

                default:
                    break;
            }

        } // CbxOrderBy_SelectedIndexChanged


        // выбор сортировки из элемента интерфейса
        private void SelectedOrderBy_Command(object sender, EventArgs e)
        {
            // установка сортировки и сортировка
            Order = (OrderType)((ToolStripItem)sender).Tag;

            // установка текущей сортировки в ComboBox
            SetOrderComboBox();
        } // SelectedOrderBy_Command


        // выбор выборки в ComboBox
        private void CbxSelectionWhere_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbxSelectionWhere.SelectedItem)
            {
                case "По максимальному весу":
                    Selection = SelectionType.MaxWeight;
                    break;

                case "По фамилии владельца":
                    Selection = SelectionType.OwnerSurnameSubString;
                    break;

                default:
                    break;
            }

        } // CbxSelectionWhere_SelectedIndexChanged


        // изменение в строке ввода для поиска
        private void TbxSearch_TextChanged(object sender, EventArgs e)
        {
            _controller.ShowListView(LvwAnimalsSelectionWhere, _controller.SelectionWhereOwner(TbxSearch.Text));
        } // TbxSearch_TextChanged


        // погашение нажатия цифр
        private void TbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // код нажатой клавиши
            Keys code = e.KeyCode;

            if (code >= Keys.D0 && code <= Keys.D9 || code >= Keys.NumPad0 && code <= Keys.NumPad9)
                e.SuppressKeyPress = true;
        } // TbxSearch_KeyDown


        // выбор выборки из элемента интерфейса
        private void SelectedSelectionBy_Command(object sender, EventArgs e)
        {
            // установка сортировки и сортировка
            Selection = (SelectionType)((ToolStripItem)sender).Tag;

            // установка текущей сортировки в ComboBox
            SetSelectionComboBox();
        } // SelectedOrderBy_Command


        // добавление коллекции животных
        private void AddRange_Command(object sender, EventArgs e)
        {
            // добавление коллекции
            _controller.AddRange();

            // обновление инфорайции в ListView
            _controller.ShowListView(LvwAnimals, _controller.AnimalsZoo);

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // AddRange_Command


        // очистка коллекции животных
        private void Clear_Command(object sender, EventArgs e)
        {
            // очистка коллекции
            _controller.Clear();

            // обновление инфорайции в ListView
            _controller.ShowListView(LvwAnimals, _controller.AnimalsZoo);

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // Clear_Command


        // добавление животного в коллекцию
        private void AddElem_Command(object sender, EventArgs e)
        {
            // форма для редактирования 
            AnimalForm animalForm = new AnimalForm();

            // запуск формы
            if (animalForm.ShowDialog() != DialogResult.OK)
                return;

            // добавление элемента
            _controller.Add(animalForm.AnimalElem);

            // вывод измененного элемента
            _controller.ShowListView(LvwAnimals, _controller.AnimalsZoo);

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // AddElem_Command


        // удаление выбранного животного из коллекции
        private void RemoveElem_Command(object sender, EventArgs e)
        {
            // если элемент не выбран
            if (LvwAnimals.SelectedItems.Count == 0)
                return;

            // индекс элемента для удаления
            int index = LvwAnimals.SelectedIndices[0];

            // удаление элемента по индексу
            _controller.RemoveAt(index);

            // удаление элемента в ListView
            LvwAnimals.Items.RemoveAt(index);

            // установка выделения на следующий элемент
            if (LvwAnimals.Items.Count != 0)
            {
                // если индекс выходит за пределы коллекции
                if (LvwAnimals.Items.Count != index)
                    LvwAnimals.SelectedIndices.Add(index);
                else 
                    LvwAnimals.SelectedIndices.Add(index - 1);
            }

            // вывод количества элементов в коллекции животных в статус
            ShowAmountStatus();

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        } // RemoveElem_Command


        // изменение выранного элемента в коллекции
        private void EditElem_Command(object sender, EventArgs e)
        {
            // если нет выбранного элемента
            if (LvwAnimals.SelectedItems.Count == 0)
                return;

            // индекс элемента
            int index = LvwAnimals.SelectedIndices[0];

            // форма для редактирования 
            AnimalForm animalForm = new AnimalForm(_controller.AnimalsZoo[index]);

            // запуск формы
            if (animalForm.ShowDialog() != DialogResult.OK)
                return;

            // вывод измененного элемента
            LvwAnimals.Items[index] = _controller.AnimalsZoo[index].GetListViewItem();

            // вывод в TreeView
            _controller.ShowTreeView(TviMain);

        }


        // вывод информации о программе
        private void InfoProgram_Command(object sender, EventArgs e) => new FormInfo().ShowDialog();


        // выбор элемента в ListView на главной вкладке
        private void LvwAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {

            // если не выбран элемент
            if (LvwAnimals.SelectedItems.Count == 0)
                return;

            // выбранный элемент
            Animal animal = _controller.AnimalsZoo[LvwAnimals.SelectedIndices[0]];
        }


        #endregion

        #region Общие методы


        // установка типа сортировки в ComboBox 
        public void OrderBy()
        {
            // установка вкладки "Сортировка" активной
            if (TbcMain.SelectedTab != TbpOrderBy)
                TbcMain.SelectedTab = TbpOrderBy;
            else
            {
                // сортировка
                switch (_order)
                {
                    // по возрасту 
                    case OrderType.Age:
                        _controller.ShowListView(LvwAnimalsOrderBy, _controller.OrderByAge());
                        break;
                    // по виду
                    case OrderType.Specials:
                        _controller.ShowListView(LvwAnimalsOrderBy, _controller.OrderBySpecials());
                        break;
                    // по фамилии владельца
                    case OrderType.Owner:
                        _controller.ShowListView(LvwAnimalsOrderBy, _controller.OrderByOwner());
                        break;
                } // OrderBy
            }
        }


        // установка сортировки в ComboBox по состоянию поля Order
        private void SetOrderComboBox()
        {
            switch (_order)
            {
                // по возрасту 
                case OrderType.Age:
                    CbxOrderBy.SelectedItem = "По возрасту";
                    break;
                // по виду
                case OrderType.Specials:
                    CbxOrderBy.SelectedItem = "По виду";
                    break;
                // по фамилии владельца
                case OrderType.Owner:
                    CbxOrderBy.SelectedItem = "По владельцу";
                    break;
            } // OrderBy

        } // CbxOrderBy_SelectedIndexChanged



        // выборка из коллекции
        public void SelectionWhere()
        {
            // установка вкладки "Выборка" активной
            if (TbcMain.SelectedTab != TbpSelectionWhere)
                TbcMain.SelectedTab = TbpSelectionWhere;
            else
            {
                // выборка
                switch (_selection)
                {
                    // с максимальным весом 
                    case SelectionType.MaxWeight:

                        // если вкладка находится в режиме выборки с поиском
                        if (GbxAnimalsSelectionWhere.Location != GbxSelectionSearch.Location)
                        {
                            GbxAnimalsSelectionWhere.Location =
                                new Point(GbxSelectionSearch.Location.X, GbxSelectionSearch.Location.Y);
                            GbxAnimalsSelectionWhere.Height += GbxSelectionSearch.Height;
                        }

                        // скрыть GroupBox для поиска
                        GbxSelectionSearch.Visible = false;

                        // выборка и вывод
                        _controller.ShowListView(LvwAnimalsSelectionWhere, _controller.SelectionWhereWeight());

                        break;

                    // с фамилиями владельцев, которые содержат заданную подстроку
                    case SelectionType.OwnerSurnameSubString:

                        // если вкладка находится в режиме выборки без поиска
                        if (GbxAnimalsSelectionWhere.Location == GbxSelectionSearch.Location)
                        {
                            GbxAnimalsSelectionWhere.Location = 
                                new Point(GbxSelectionSearch.Location.X, GbxSelectionSearch.Location.Y + GbxSelectionSearch.Height);
                            GbxAnimalsSelectionWhere.Height -= GbxSelectionSearch.Height;
                        }

                        // скрыть GroupBox для поиска
                        GbxSelectionSearch.Visible = true;

                        // выборка и вывод
                        _controller.ShowListView(LvwAnimalsSelectionWhere, _controller.SelectionWhereOwner(""));

                        // установка фокуса на поисковую строку для ввода фамилии владельца
                        TbxSearch.Focus();

                        // заполенение коллекции для автодополнения 
                        TbxSearch.AutoCompleteCustomSource.Clear();
                        TbxSearch.AutoCompleteCustomSource.AddRange(_controller.SurnamesOwners);

                        break;

                } // OrderBy
            }
        } // SelectionWhere


        // установка выборки в ComboBox по состоянию поля Selection
        private void SetSelectionComboBox()
        {
            switch (_selection)
            {
                // по максимальному весу
                case SelectionType.MaxWeight:
                    CbxSelectionWhere.SelectedItem = "По максимальному весу";
                    break;
                // по фамилии владельца
                case SelectionType.OwnerSurnameSubString:
                    CbxSelectionWhere.SelectedItem = "По фамилии владельца";
                    break;
            } // switch

        } // SetSelectionComboBox


        // обновление информации о файле сохранения в статусе
        public void ShowFileInfoStatus() =>
            StiFile.Text = StiFile.Text.Remove(StiFile.Text.IndexOf(':') + 1) + " " + _controller.SaveFile;  


        // обновление информации о количестве элементов в коллекции животных в статусе
        public void ShowAmountStatus() =>
            StiAmount.Text = StiAmount.Text.Remove(StiAmount.Text.IndexOf(':') + 1) + " " + _controller.Count;


        #endregion

        #endregion

    }
}
