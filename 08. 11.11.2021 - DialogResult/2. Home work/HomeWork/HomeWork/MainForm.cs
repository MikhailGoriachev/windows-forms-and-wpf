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

/* Задача 1. Разработайте приложение Windows Forms с использованием изученных элементов интерфейса (строковое меню, контекстное меню, панель инструментов, лист-бокс, комбо-бокс, строка состояния, строки ввода, чек-боксы и радиокнопки). 
 * Разработайте класс Television (производитель и тип телевизора, диагональ экрана, строка с описанием дефекта, фамилия и инициалами мастера, фамилия и инициалы владельца, стоимость ремонта).
 * Разработайте класс RepairShop (коллекция Television, название ремонтной мастерской, адрес ремонтной мастерской).
 * Приложение должно иметь следующий функционал:
 * •	Начальное формирование данных ремонтной мастерской (коллекция телевизоров от 12 до 15 штук)
 * •	Добавление телевизора в коллекцию
 * •	Редактирование выбранного телевизора в отдельной форме
 * •	Редактирование данных ремонтной мастерской
 * •	Упорядочивание коллекции телевизоров
 *      o	По производителю и типу
 *      o	По убыванию диагонали экрана
 *      o	По мастеру, выполняющему ремонт
 *      o	По владельцу телевизора
 * •	Выборка и вывод в отдельной форме коллекции телевизоров с минимальной стоимостью ремонта
 * •	Выборка и вывод в отдельной форме коллекции телевизоров, ремонтируемых выбранным мастером
 * •	Выборка и вывод в отдельной форме коллекции телевизоров, с заданной диагональю экрана 
 * В меню и контекстных меню (ListBox, MainForm) включите команды выхода, вывода окна со сведениями о программе и ее разработчике
*/

namespace HomeWork
{
    // Главная форма
    public partial class MainForm : Form
    {
        // ремонтная мастерская
        private RepairShop _repair;

        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();

            // инициализация полей
            _repair = new RepairShop { Name = "Восток Сервис", Address = "Проспект Панфилова, 1А" };

            // установка связи лист-бокса и коллекции данных
            UpdateCommunication();

            // установка лямбда выражений для упорядочивания коллекции в тег
            MsiOrderByDiagonal.Tag = (Action)_repair.OrderByDiagonal;
            MsiOrderByMaster.Tag = (Action)_repair.OrderByMaster;
            MsiOrderByModel.Tag = (Action)_repair.OrderByModel;
            MsiOrderByOwner.Tag = (Action)_repair.OrderByOwner;
            CmiOrderByDiagonal.Tag = (Action)_repair.OrderByDiagonal;
            CmiOrderByMaster.Tag = (Action)_repair.OrderByMaster;
            CmiOrderByModel.Tag = (Action)_repair.OrderByModel;
            CmiOrderByOwner.Tag = (Action)_repair.OrderByOwner;
            TsiOrderByDiagonal.Tag = (Action)_repair.OrderByDiagonal;
            TsiOrderByMaster.Tag = (Action)_repair.OrderByMaster;
            TsiOrderByModel.Tag = (Action)_repair.OrderByModel;
            TsiOrderByOwner.Tag = (Action)_repair.OrderByOwner;

            // установка значения состояния для запуска формы выборки коллекции в тег
            MsiSelectionByDiagonal.Tag = SelectionByForm.States.DiagonalMode;
            MsiSelectionByMaster.Tag = SelectionByForm.States.MasterMode;
            MsiSelectionByMinPrice.Tag = SelectionByForm.States.MinPriceMode;
            CmiSelectionByDiagonal.Tag = SelectionByForm.States.DiagonalMode;
            CmiSelectionByMaster.Tag = SelectionByForm.States.MasterMode;
            CmiSelectionByMinPrice.Tag = SelectionByForm.States.MinPriceMode;
            TsiSelectionDiagonal.Tag = SelectionByForm.States.DiagonalMode;
            TsiSelectionMaster.Tag = SelectionByForm.States.MasterMode;
            TsiSelectionMinPrice.Tag = SelectionByForm.States.MinPriceMode;
        }

        // выход из приложения
        private void Exit_Command(object sender, EventArgs e) => Application.Exit();

        // информация о приложении
        private void ProgramInfo_Comand(object sender, EventArgs e) => new FormInfo().ShowDialog();

        // формирование коллекции
        private void InitializationCoolection_Command(object sender, EventArgs e)
        {
            // очистка коллекции телевизоров
            _repair.Clear();

            // инициализация коллекции
            _repair.Initialization();

            // обновление связи
            UpdateCommunication();
        }

        // обновление связи лист-бокса и коллекции данных
        private void UpdateCommunication()
        {
            // установка источника данных
            LbxTelevisions.DataSource = null;
            LbxTelevisions.DataSource = _repair.Televisions;

            // установка метода для вывода 
            LbxTelevisions.DisplayMember = "ShowElem";

            // обновление количества элементов в статуса
            SlbInfoCountElement.Text = $"Количество выбранных элементов: {_repair.Count}";
        }

        // очистка коллекции
        private void Clear_Command(object sender, EventArgs e)
        {
            // очистка 
            _repair.Clear();

            // обновление связи
            UpdateCommunication();
        }

        // добавление коллекции 
        private void AddRange_Command(object sender, EventArgs e)
        {
            // очистка 
            _repair.Initialization();

            // обновление связи
            UpdateCommunication();
        }

        // удаление элемента
        private void Remove_Command(object sender, EventArgs e)
        {
            // удаление элемента (т.к. удаление не по индексу, защита от некорретного индекса не требуется)
            _repair.Remove((Television)LbxTelevisions.SelectedItem);

            // обновление связи
            UpdateCommunication();
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
            _repair.Insert(0, televisionForm.television);

            // обновление связи
            UpdateCommunication();
        }

        // редактирование выбранного элемента
        private void Edit_Command(object sender, EventArgs e)
        {
            // если не выбран элемент
            if (LbxTelevisions.SelectedItem == null) 
                return;

            // форма редактирования 
            new TelevisionForm((Television)LbxTelevisions.SelectedItem).ShowDialog();

            // обновление связи
            UpdateCommunication();
        }

        // загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // загрузка данных о ремонтной мастерской
            TxbNameRepairShop.Text = _repair.Name;
            TxbAddress.Text = _repair.Address;
        }

        // редактирование данных о мастерской
        private void EditRepairShop_Command(object sender, EventArgs e)
        {
            // форма для редактирования данных о мастерсой
            new RepairShopForm(_repair).ShowDialog();

            // загрузка данных о ремонтной мастерской
            TxbNameRepairShop.Text = _repair.Name;
            TxbAddress.Text = _repair.Address;
        }

        // упорядочивание по компаратору
        private void OrderBy_Command(object sender, EventArgs e)
        {
            // упорядочивание
            ((Action)((ToolStripMenuItem)sender).Tag).Invoke();

            // обновление связи
            UpdateCommunication();
        }

        // выборка
        private void Selection_Command(object sender, EventArgs e) =>
            // упорядочивание
            new SelectionByForm(_repair, (SelectionByForm.States)((ToolStripMenuItem)sender).Tag).ShowDialog();
    }
}
