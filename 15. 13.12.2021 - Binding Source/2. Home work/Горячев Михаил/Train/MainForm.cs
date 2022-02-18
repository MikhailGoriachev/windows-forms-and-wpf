using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train.Models;         // модели
using Train.Controllers;    // контроллеры
using Train.Utilities;      // утилиты

/*
 *  Задача 1.
 *  Разработайте приложение-макет для продажи билетов на поезд. Разработать класс 
 *  Поезд, хранящий коллекцию объектов класса Вагон. Максимальное количество 
 *  вагонов в поезде 20. Поезд характеризуется номером (цифры и буквы), пунктом
 *  отправления и пунктом назначения. 
 *  Класс Вагон характеризуется количеством купе, массивом купе, максимальной
 *  вместимостью купе.
 *  Купе - свойства: тип, количество мест, список мест (номер -> состояние).
 *  В главной форме разместить TreeView, отображающий поезд. В DataGridView 
 *  выводить текущий состав поезда в вагонах.
 *  Вагоны отличаются количеством мест в купе:
 *      • СВ		    – 2 места, 9 купе
 *      • Купейный	    – 4 места, 9 купе 
 *      • Плацкартный 	– 6 мест,  9 купе
 *  При помощи меню, контекстного меню, кнопок панели инструментов реализовать:
 *      • добавление вагона(тип вагона задаем в меню или соответствующей кнопкой)
 *      • удаление вагона
 *      • покупка билета
 *      • возврат билета
 *      • сохранять данные о поезде в файл (JSON)
 *      • чтение данных поезда из файла (JSON)
 *  	
 *  И сохранение в файл и чтение из файла - при помощи диалогов выбора файлов и 
 *  техники Drag'n'Drop.
 *  В строку состояния выводить информацию:
 *      1.всего вагонов
 *      2.всего мест / продано билетов
 *      3.СВ: вагонов / продано билетов
 *      4.купейный: вагонов / продано билетов
 *      5.плацкарт: вагонов / продано билетов
*/

namespace Train
{
    public partial class MainForm : Form
    {
        // контроллер поезда
        private TrainController _controller = new TrainController();

        #region Конструкторы

        // конструктор по умолчанию
        public MainForm()
        {
            InitializeComponent();

            // установка значений
            _controller = new TrainController();
            BndTrain.DataSource = _controller.CurrentWagon.Seats;
        }

        #endregion

        #region Общие обработчики

        // загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // заполнение дерева
            _controller.ShowTreeView(TrvTrain);
        }

        #region Сохранение/Загрузка данных

        // открытие файла через форму
        private void Open_Command(object sender, EventArgs e)
        {
            // выбор файла
            if (OfdMain.ShowDialog() != DialogResult.OK)
                return;

            // установка файла
            _controller.LoadToFile(OfdMain.FileName, BndTrain);
        }


        // сохранение файла через форму
        private void SaveAs_Command(object sender, EventArgs e)
        {
            // выбор файла
            if (SfdMain.ShowDialog() != DialogResult.OK)
                return;

            // установка файла
            _controller.SaveToFile(SfdMain.FileName);
        }


        #region TreeView

        // выбор вагона
        private void TrvTrain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
                return;

            switch (e.Node.Level)
            {
                // поезд
                case 0:
                    return;

                // вагон
                case 1:
                    SelectWagon((Wagon)e.Node.Tag);
                    break;

                // купе
                case 2:
                    SelectWagon((Wagon)e.Node.Parent.Tag);
                    break;

                // место
                case 3:
                    SelectWagon((Wagon)e.Node.Parent.Parent.Tag);
                    break;

                default:
                    break;
            }

        }

        #endregion

        #region Общие методыъ

        // выбор вагона 
        public void SelectWagon(Wagon wagon)
        {
            // установка вагона 
            _controller.CurrentWagon = wagon;

            // привязка к вагону
            BndTrain.DataSource = _controller.CurrentWagon.Seats;

            // вывод номера вагона в GroupBox
            GbxWagon.Text = GbxWagon.Text.Remove(GbxWagon.Text.IndexOf(':'));
            GbxWagon.Text += $": № {wagon.Number} - {wagon.TytleType}";
        }

        #endregion

        #endregion

        #endregion

    }
}
