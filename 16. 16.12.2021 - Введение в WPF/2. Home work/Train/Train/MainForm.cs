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
using Train.Views;          // формы

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

            // выбор вагона
            SelectWagon(_controller.CurrentWagon != null ? _controller.Wagons[0] : null);

            // запись в тег вида вагонов
            MsiAddSleeper.Tag           = Wagon.TypeWagon.Sleeper;
            MsiAddCorridor.Tag          = Wagon.TypeWagon.Corridor;
            MsiAddReserved.Tag          = Wagon.TypeWagon.Reserved;
            CmiTviTrainAddSleeper.Tag   = Wagon.TypeWagon.Sleeper;
            CmiTviTrainAddCorridor.Tag  = Wagon.TypeWagon.Corridor;
            CmiTviTrainAddReserved.Tag  = Wagon.TypeWagon.Reserved;
            TsiAddSleeper.Tag           = Wagon.TypeWagon.Sleeper;
            TsiAddCorridor.Tag          = Wagon.TypeWagon.Corridor;
            TsiAddReserved.Tag          = Wagon.TypeWagon.Reserved;

            // запись в тег делегатов сортировки
            MsiOrderBySellDesc.Tag              = (Action)_controller.SortBySellSeatDesc;
            MsiOrderByNumberWagonAsc.Tag        = (Action)_controller.SortByNumberWagonAscend;
            MsiOrderByNumberWagonDesc.Tag       = (Action)_controller.SortByNumberWagonDesc;
            CmiTviTrainBySellDesc.Tag           = (Action)_controller.SortBySellSeatDesc;
            CmiTviTrainByNumberWagonAsc.Tag     = (Action)_controller.SortByNumberWagonAscend;
            CmiTviTrainByNumberWagonDesc.Tag    = (Action)_controller.SortByNumberWagonDesc;
            CmiTviWagonBySellDesc.Tag           = (Action)_controller.SortBySellSeatDesc;
            CmiTviWagonByNumberWagonAsc.Tag     = (Action)_controller.SortByNumberWagonAscend;
            CmiTviWagonByNumberWagonDesc.Tag    = (Action)_controller.SortByNumberWagonDesc;
        }

        #endregion

        #region Общие обработчики

        // загрузка формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            // заполнение дерева
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();

            // установка значения по умолчанию в ComboBox выбора сортировки
            TsiCmbOrderBy.SelectedItem = TsiCmbOrderBy.Items[0];
        }


        // выход из приложения
        private void Exit_Command(object sender, EventArgs e) => Application.Exit();


        // удаление выбранного вагона
        private void RemoveWagon_Command(object sender, EventArgs e)
        {
            // если нет выбранных вагонов
            if (DgvWagon.SelectedRows.Count == 0)
                return;

            // индекс текущего вагона
            int index = _controller.Wagons.IndexOf(_controller.CurrentWagon);

            // удаление вагона
            _controller.RemoveAt(index);

            // обновление данных

            // если коллекция вагонов пуста
            if (_controller.CountWagons == 0)
                SelectWagon(null);
            // если выбранный вагон является последним
            else if (index == _controller.CountWagons)
                SelectWagon(_controller.Wagons[index - 1]);
            // иначе
            else
                SelectWagon(_controller.Wagons[index]);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // клик по кнопке выбора вида добавления поезда
        private void TsiAddWagon_Click(object sender, EventArgs e) =>
            TsiAddCorridor.Enabled =
            TsiAddReserved.Enabled =
            TsiAddSleeper.Enabled = _controller.CountWagons < _controller.Train.MaxCountWagons;


        // клик по пункту меню "Управление"
        private void MsiControl_Click(object sender, EventArgs e) =>
            MsiAddCorridor.Enabled =
            MsiAddReserved.Enabled =
            MsiAddSleeper.Enabled = _controller.CountWagons < _controller.Train.MaxCountWagons;


        // формирование данных
        private void Initialization_Command(object sender, EventArgs e)
        {
            // создание поезда
            _controller.Train = TrainController.FactoryMethodTrain();

            // запись в файл
            _controller.Serialization();

            // установка первого вагона активным
            SelectWagon(_controller.Wagons[0]);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // добавление вагона
        private void AddWagon_Command(object sender, EventArgs e)
        {
            // добавление вагона
            _controller.AddWagon((Wagon.TypeWagon)((ToolStripItem)sender).Tag);

            // переход на созданный вагон
            SelectWagon(_controller.Wagons[_controller.Wagons.Count - 1]);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // удалить все вагоны
        private void Clear_Command(object sender, EventArgs e)
        {
            // добавление вагона
            _controller.Clear();

            // переход на созданный вагон
            SelectWagon(null);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // сортировка вагонов 
        private void OrderBy_Command(object sender, EventArgs e)
        {
            // сортировка
            ((Action)((ToolStripItem)sender).Tag).Invoke();

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);
        }

        // сортировка вагонов с помощью ComboBox
        private void CmbOrderBy_Command(object sender, EventArgs e)
        {
            // сортировка
            switch (TsiCmbOrderBy.Text)
            {
                case "по убыванию количества проданных мест":
                    _controller.SortBySellSeatDesc();
                    break;
                case "по возрастанию номеров вагонов":
                    _controller.SortByNumberWagonAscend();
                    break;
                case "по убыванию номеров вагонов":
                    _controller.SortByNumberWagonDesc();
                    break;

                default:
                    break;
            }

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);
        }


        // информация о программе
        private void InfoProgram_Command(object sender, EventArgs e) => new FormInfo().ShowDialog();

        #region Сохранение/Загрузка данных

        // открытие файла через форму
        private void Open_Command(object sender, EventArgs e)
        {
            // выбор файла
            if (OfdMain.ShowDialog() != DialogResult.OK)
                return;

            // установка файла
            if (!_controller.LoadToFile(OfdMain.FileName))
                return;

            // установка первого вагона активным
            SelectWagon(_controller.Wagons[0]);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
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


        #region Drag'n'Drop

        #region Форма

        // DragDrop над Формой
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // установка цветов
            TviTrain.BackColor = Color.DarkGray;
            SetColorsDataGridView(Color.DarkGray, Color.Gainsboro, Color.DarkGray);
        }

        // DragEnter над Формой
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // установка эффекта
                e.Effect = DragDropEffects.Copy;

                // установка цветов
                TviTrain.BackColor = Color.Turquoise;
                SetColorsDataGridView(Color.Turquoise, Color.Turquoise, Color.DarkTurquoise);
            }
            else
                // установка эффекта
                e.Effect = DragDropEffects.None;
        }

        // DragLeave над Формой
        private void MainForm_DragLeave(object sender, EventArgs e)
        {
            // установка цветов
            TviTrain.BackColor = Color.DarkGray;
            SetColorsDataGridView(Color.DarkGray, Color.Gainsboro, Color.DarkGray);
        }

        #endregion

        #region DataGridView

        // DragDrop над DataGridView
        private void DgvWagon_DragDrop(object sender, DragEventArgs e)
        {
            // установка цветов
            TviTrain.BackColor = Color.DarkGray;
            SetColorsDataGridView(Color.DarkGray, Color.Gainsboro, Color.DarkGray);

            // установка файла
            if (!_controller.LoadToFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
                return;

            // установка первого вагона активным
            SelectWagon(_controller.Wagons[0]);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
        }

        // DragEnter над DataGridView
        private void DgvWagon_DragEnter(object sender, DragEventArgs e)
        {
            // установка эффекта
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

            // установка цветов
            TviTrain.BackColor = Color.Turquoise;
            SetColorsDataGridView(Color.SeaGreen, Color.SeaGreen, Color.DarkSeaGreen);
        }

        // DragLeave над DataGridView
        private void DgvWagon_DragLeave(object sender, EventArgs e)
        {
            // установка цветов
            TviTrain.BackColor = Color.DarkGray;
            SetColorsDataGridView(Color.DarkGray, Color.Gainsboro, Color.DarkGray);

        }
        #endregion

        #region TreeView

        // DragDrop над TreeView
        private void TviTrain_DragDrop(object sender, DragEventArgs e)
        {
            // установка цветов
            TviTrain.BackColor = Color.DarkGray;
            SetColorsDataGridView(Color.DarkGray, Color.Gainsboro, Color.DarkGray);

            // установка файла
            if (!_controller.LoadToFile(((string[])e.Data.GetData(DataFormats.FileDrop))[0]))
                return;

            // установка первого вагона активным
            SelectWagon(_controller.Wagons[0]);

            // обновление TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // заполнение StatusStrip
            UpdateStatusStrip();
        }

        // DragEnter над TreeView
        private void TviTrain_DragEnter(object sender, DragEventArgs e)
        {
            // установка эффекта
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;

            // установка цветов
            TviTrain.BackColor = Color.SeaGreen;
            SetColorsDataGridView(Color.Turquoise, Color.Turquoise, Color.DarkTurquoise);
        }

        // DragLeave над TreeView
        private void TviTrain_DragLeave(object sender, EventArgs e)
        {
            // установка цветов
            TviTrain.BackColor = Color.DarkGray;
            SetColorsDataGridView(Color.DarkGray, Color.Gainsboro, Color.DarkGray);

        }

        #endregion

        #endregion

        #endregion

        #region DataGridView

        // выбор места (любой клавишей мыши)
        private void DgvWagon_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // если клик не по ячейке таблицы
            if (e.RowIndex == -1)
                return;

            DgvWagon.Rows[e.RowIndex].Selected = true;
        }


        // продажа билета DataGridVeiw
        private void CmiDgvSeatCell_Click(object sender, EventArgs e)
        {
            // если нет выбранного места
            if (DgvWagon.Rows.Count == 0)
                return;

            // индекс выбранного элемента
            int index = DgvWagon.SelectedRows[0].Index;

            // продажа билета
            _controller.CurrentWagon.Seats[index].State = true;

            // обновление DataGridView
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // обновление изображения для записи в TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // установка выбранного элемента, как активного 
            DgvWagon.Rows[index].Selected = true;

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // возврат билета DataGridVeiw
        private void CmiDgvSeatBack_Click(object sender, EventArgs e)
        {
            // если нет выбранного места
            if (DgvWagon.Rows.Count == 0)
                return;

            // индекс выбранного элемента
            int index = DgvWagon.SelectedRows[0].Index;

            // продажа билета
            _controller.CurrentWagon.Seats[index].State = false;

            // обновление DataGridView
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // обновление изображения для записи в TreeView
            _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

            // установка выбранного элемента, как активного 
            DgvWagon.Rows[index].Selected = true;

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // запуск контекстного меню места
        private void CmsDgvSeat_Opening(object sender, CancelEventArgs e)
        {
            // если не выбран элемент
            if (DgvWagon.SelectedRows.Count == 0)
                return;

            // индекс выбранного элемента
            int index = DgvWagon.SelectedRows[0].Index;

            (CmiDgvSeatBack.Enabled, CmiDgvSeatSell.Enabled) 
                = (_controller.CurrentWagon.Seats[index]).State
                ? (true, false)
                : (false, true);
        }

        #endregion

        #region TreeView

        // продать билет 
        private void SeatSell_Command(object sender, EventArgs e)
        {
            // продажа билета
            ((Seat)TviTrain.SelectedNode.Tag).State = true;

            // обновление DataGridView
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // обновление изображения для записи в TreeView
            TviTrain.SelectedNode.ImageIndex = TviTrain.SelectedNode.SelectedImageIndex = 4;

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // вернуть билет 
        private void SeatBack_Command(object sender, EventArgs e)
        {
            // возврат билета
            ((Seat)TviTrain.SelectedNode.Tag).State = false;

            // обновление DataGridView
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // обновление изображения для записи в TreeView
            TviTrain.SelectedNode.ImageIndex = TviTrain.SelectedNode.SelectedImageIndex = 3;

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // открытие контекстного меню места
        private void CmsTviSeat_Opening(object sender, CancelEventArgs e) =>
            (CmiTviSeatBack.Enabled, CmiTviSeatSell.Enabled) = ((Seat)TviTrain.SelectedNode.Tag).State
                ? (true, false)
                : (false, true);


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


        // выбор узла в TreeView (любой клавишой мыши)
        private void TviTrain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // выбранный элемент
            TviTrain.SelectedNode = e.Node;
        }


        // продать все билеты выбранного купе
        private void CoupeSellAll_Command(object sender, EventArgs e)
        {
            // выбранная node 
            TreeNode node = TviTrain.SelectedNode;

            // продать все билеты купе
            _controller.CoupeSellAll((Coupe)node.Tag, true);

            // обновление значков всех мест
            foreach (TreeNode item in node.Nodes)
                item.ImageIndex = item.SelectedImageIndex = 4;

            // обновить данные в DataGridView
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // вернуть все билеты выбранного купе
        private void CoupeBackAll_Command(object sender, EventArgs e)
        {
            // выбранная node 
            TreeNode node = TviTrain.SelectedNode;

            // продать все билеты купе
            _controller.CoupeSellAll((Coupe)node.Tag, false);

            // обновление значков всех мест
            foreach (TreeNode item in node.Nodes)
                item.ImageIndex = item.SelectedImageIndex = 3;

            // обновить данные в DataGridView
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // заполнение StatusStrip
            UpdateStatusStrip();
        }


        // запуск контекстного меню купе
        private void CmsTviCoupe_Opening(object sender, CancelEventArgs e)
        {
            // выбранное купе
            Coupe coupe = (Coupe)TviTrain.SelectedNode.Tag;

            // количество мест в купе
            var n = coupe.CountSeats;

            if (n.amount != n.busy && n.busy != 0)
            {
                (CmiTviCoupeBackAll.Enabled, CmiTviCoupeSellAll.Enabled) = (true, true);
                return;
            }

            bool flag = n.amount == n.busy;

            (CmiTviCoupeBackAll.Enabled, CmiTviCoupeSellAll.Enabled) = (flag, !flag);
        }


        // запуск контекстного меню поезда
        private void CmsTviTrain_Opening(object sender, CancelEventArgs e) =>
            CmiTviTrainAddCorridor.Enabled =
            CmiTviTrainAddReserved.Enabled =
            CmiTviTrainAddSleeper.Enabled = _controller.CountWagons < _controller.Train.MaxCountWagons;

        #endregion

        #endregion

        #region Общие методы

        // выбор вагона 
        public void SelectWagon(Wagon wagon)
        {
            // установка вагона 
            _controller.CurrentWagon = wagon;

            // если ссылка на вагон null
            if (_controller.CurrentWagon == null)
            {
                // очистка DataGridView
                BndTrain.DataSource = null;

                // обновление TreeView
                _controller.ShowTreeView(TviTrain, CmsTviTrain, CmsTviWagon, CmsTviCoupe, CmsTviSeat);

                // вывод номера вагона в GroupBox
                GbxWagon.Text = GbxWagon.Text.Remove(GbxWagon.Text.IndexOf(':'));
                GbxWagon.Text += $": № Вагон не выбран";

                return;
            }

            // привязка к вагону
            BndTrain.DataSource = _controller.ViewCurrentWagon;

            // вывод номера вагона в GroupBox
            GbxWagon.Text = GbxWagon.Text.Remove(GbxWagon.Text.IndexOf(':'));
            GbxWagon.Text += $": № {wagon.Number} - {wagon.TytleType}";
        }


        // установка цветов для DataGridView
        public void SetColorsDataGridView(Color back, Color evenColor, Color oddColor)
        {
            DgvWagon.BackColor = back;                                          // цвет DataGridView (это не цвет самой таблицы)
            DgvWagon.RowsDefaultCellStyle.BackColor = evenColor;                // цвет четных строк
            DgvWagon.AlternatingRowsDefaultCellStyle.BackColor = oddColor;      // цвет нечётных строк
        }


        // обновление данных в StatusStrip
        public void UpdateStatusStrip()
        {
            // количество вагонов по типам
            var countWagons = _controller.CountWagonsTypes;

            // 1. Всего вагонов в поезде
            StiAmountWagons.Text = StiAmountWagons.Text.Remove(StiAmountWagons.Text.IndexOf(':'));
            StiAmountWagons.Text += $": {countWagons.Amount}";

            // 2. Всего мест в поезде / продано билетов

            // места в поезде
            var countSeats = _controller.CountSeats;

            StiAmountSeats.Text = StiAmountSeats.Text.Remove(StiAmountSeats.Text.IndexOf(':'));
            StiAmountSeats.Text += $": {countSeats.amount} / {countSeats.busy}";

            // 3. СВ: вагонов / мест / продано билетов

            // места в вагоне
            countSeats = _controller.CountSeatsSleeper;

            StiSleeper.Text = StiSleeper.Text.Remove(StiSleeper.Text.IndexOf(':'));
            StiSleeper.Text += $": {countWagons.Sleeper} / {countSeats.amount} / {countSeats.busy}";


            // 4. купейный: вагонов / мест / продано билетов

            // места в вагоне
            countSeats = _controller.CountSeatsCorridor;

            StiCorridor.Text = StiCorridor.Text.Remove(StiCorridor.Text.IndexOf(':'));
            StiCorridor.Text += $": {countWagons.Corridor} / {countSeats.amount} / {countSeats.busy}";


            // 5. плацкарт: вагонов / мест / продано билетов

            // места в вагоне
            countSeats = _controller.CountSeatsReserved;

            StiReserved.Text = StiReserved.Text.Remove(StiReserved.Text.IndexOf(':'));
            StiReserved.Text += $": {countWagons.Reserved} / {countSeats.amount} / {countSeats.busy}";
        }

        #endregion

    }
}
