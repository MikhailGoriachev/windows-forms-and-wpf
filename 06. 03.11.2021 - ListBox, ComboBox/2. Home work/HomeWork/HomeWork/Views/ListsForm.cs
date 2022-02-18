using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork.Utilities;       // утилиты

namespace HomeWork.Views
{
    public partial class ListsForm : Form
    {
        public ListsForm()
        {
            InitializeComponent();

            // установка значения по умолчанию для TbxInput
            TxbInput.Text = TxbInput.AutoCompleteCustomSource[Utils.GetRand(0, TxbInput.AutoCompleteCustomSource.Count - 1)];
        }

        // добавление введённого города в первый лист-бокс
        private void BtnAddListBoxFirst_Click(object sender, EventArgs e)
        {
            // если строка для ввода не пуста
            if (!String.IsNullOrWhiteSpace(TxbInput.Text))
                LbxFirst.Items.Add(TxbInput.Text);
        }

        // перемещение выбранного элемента во второй лист-бокс
        private void BtnMoveOneElemFirst_Click(object sender, EventArgs e) => MoveOneELemFirst();

        // перемещение выбранного элемента во второй лист-бокс
        private void MoveOneELemFirst()
        {
            // если индекс корректный
            if (LbxFirst.SelectedIndex != -1)
            {
                // добавление выбранного элемента во второй список
                LbxSecond.Items.Add(LbxFirst.SelectedItem);

                // удаление выбранного элемента из первого списка
                LbxFirst.Items.RemoveAt(LbxFirst.SelectedIndex);
            }
        }

        // перемещение выбранного элемента в первый лист-бокс
        private void BtnMoveOneElemSecond_Click(object sender, EventArgs e)
        {
            // если индекс корректный
            if (LbxSecond.SelectedIndex != -1)
            {
                // добавление выбранного элемента в первый список
                LbxFirst.Items.Add(LbxSecond.SelectedItem);

                // удаление выбранного элемента из второго списка
                LbxSecond.Items.RemoveAt(LbxSecond.SelectedIndex);
            }
        }

        // перемещение всех элементов из второго лист-бокса в первый 
        private void BtnMoveAllElemFirst_Click(object sender, EventArgs e)
        {
            // копирование всех элементов в первый лист-бокс
            LbxFirst.Items.AddRange(LbxSecond.Items);

            // отчистка второго лист-бокса
            LbxSecond.Items.Clear();
        }

        // перемещение всех элементов из первого лист-бокса во второй
        private void BtnMoveAllElemSecond_Click(object sender, EventArgs e)
        {
            // копирование всех элементов во второй лист-бокс
            LbxSecond.Items.AddRange(LbxFirst.Items);

            // отчистка первого лист-бокса
            LbxFirst.Items.Clear();
        }

        // очистка лист-боксов
        private void BtnClear_Click(object sender, EventArgs e) { LbxFirst.Items.Clear(); LbxSecond.Items.Clear(); }

        // добавление выбранного элемента во второй лист-бокс
        private void CbxCities_SelectedIndexChanged(object sender, EventArgs e) => LbxSecond.Items.Add(CbxCities.SelectedItem);
    }
}
