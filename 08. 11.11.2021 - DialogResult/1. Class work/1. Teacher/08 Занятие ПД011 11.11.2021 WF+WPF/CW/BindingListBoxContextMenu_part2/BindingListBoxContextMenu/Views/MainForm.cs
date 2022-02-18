using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BindingListBoxContextMenu.Models;

namespace BindingListBoxContextMenu.Views
{
    public partial class MainForm : Form
    {
        // коллекция данных
        private List<Worker> _workers;

        public MainForm () {
            InitializeComponent();

            // коллекция для отображения --  только для примера -- в ДЗ используйте внешние классы для 
            // хранения данных
            _workers = new List<Worker> {
                new Worker {Id =  1, FullName="Сидоров Р.Г.",   Position="пекарь",  Age=21 },
                new Worker {Id =  2, FullName="Афанасьев П.Л.", Position="токарь",  Age=22 },
                new Worker {Id =  3, FullName="Тохтамыш О.Л.",  Position="слесарь", Age=33 },
                new Worker {Id =  4, FullName="Северова Н.Г.",  Position="повар",   Age=24 },
                new Worker {Id =  5, FullName="Восточная К.К.", Position="токарь",  Age=19 },
                new Worker {Id =  6, FullName="Цветкова Е.Г.",  Position="админ",   Age=52 }
            };

            // привязка коллекции данных к ListBox
            WorkersBind();

            // назначить обработчик события выбора элемента в ListBox
            LbxWorkers.SelectedIndexChanged += LbxWokers_SelectedIndexChanged;
        } // MainForm


        // показать выбранного работника в TextBox - C(R)UD
        private void LbxWokers_SelectedIndexChanged (object sender, EventArgs e) {
            // свойство SelectedItem возвращает из коллекции _workers элемент, 
            // соответствующий выбранному в ListBox элементу
            // проблема в классной работе была связана с использованием
            // свойства SelectedIndex, после перехода на SelectedItem пробема ушла :)
            Worker worker = (Worker)LbxWorkers.SelectedItem;
            TxbWorker.Text = $"{DateTime.Now:dd/MM/yyyy HH:mm:ss}\r\n{worker}";
        } // LbxWokers_SelectedIndexChanged


        // удаление работинка из коллекции CRU(D) - по клавише Delete
        private void LbxWokers_KeyDown (object sender, KeyEventArgs e) {

            // если не Delete или нет выбранного элемента - молча уходим
            if (e.KeyData != Keys.Delete) return;

            Delete_Command(sender, EventArgs.Empty);
        } // LbxWokers_KeyDown


        // Выполнение привязки к данным для Листбокса 
        // Привязка ListBox к списку _workers (может быть любая коллекция
        // т.е. объект класса, реализующий интерфейс IEnumerable<>)
        private void WorkersBind () {
            LbxWorkers.DataSource = null;       // остановить текущую привязку
            LbxWorkers.DataSource = _workers;   // источник данных - связанная со списком коллекция
            LbxWorkers.DisplayMember = "TableRow";  // отображаемое в списке свойство/атрибут
            LbxWorkers.ValueMember = "Id";      // поле, значение которого возвращет метод SelectedValue
        } // PersonsBind


        // Удаление выбранного работника из коллекции
        private void Delete_Command (object sender, EventArgs e) {
            if (LbxWorkers.SelectedIndex < 0)
                return;

            // удаление записи данных 
            _workers.RemoveAt(LbxWorkers.SelectedIndex);

            WorkersBind();
        } // Delete_Command


        // завершение работы приложения
        private void Exit_Command (object sender, EventArgs e) =>
            Application.Exit();

        // добавление работника - будет выполнено на занятии 11.11.2021
        private void AddWorker_Command(object sender, EventArgs e) {

            WorkerForm workerForm = new WorkerForm();
            DialogResult dialogResult = workerForm.ShowDialog();

            // если окно закрыто не по кнопке "Добавить" - молча уходим
            if (dialogResult != DialogResult.OK) return;

            // получить данные из свойства формы
            Worker worker = workerForm.Worker;
            _workers.Add(worker);

            // обновить привязку
            WorkersBind();
        } // AddWorker_Command

        private void WorkerEdit_Command(object sender, EventArgs e) {
            // если нет выбранного работника - уходим
            if (LbxWorkers.SelectedIndex < 0)
                return;

            // передача данных в форму
            WorkerForm workerForm = new WorkerForm("Редактировать данные работника", "Сохранить");
            workerForm.Worker = _workers[LbxWorkers.SelectedIndex];

            if (workerForm.ShowDialog() != DialogResult.OK) return;

            // получить данные
            _workers[LbxWorkers.SelectedIndex] = workerForm.Worker;

            WorkersBind();
        }
    } // class MainForm
}
