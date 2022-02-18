using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals.Models;           // модели
using Animals.Controllers;      // контроллеры
using Animals.Utilities;        // утилиты

namespace Animals.Views
{
    public partial class AnimalForm : Form
    {
        // животное 
        private Animal _animalElem;

        #region Конструкторы

        // создание формы в режиме создания
        public AnimalForm()
        {
            InitializeComponent();

            // установка значений
            _animalElem = AnimalsController.FactoryMethod((AnimalsController.AnimalCode)Utils.GetRand(0, 15));

            // вывод информации о животном
            CbxSpecials.SelectedItem    = _animalElem.Specials;
            TbxName.Text                = _animalElem.Name;
            TbxOwner.Text               = _animalElem.Owner;
            CbxColors.SelectedItem      = _animalElem.Сolor;
            NudAge.Value                = _animalElem.Age;
            NudWeight.Value             = (decimal)_animalElem.Weight;

            // спрятать элементы для вывода информации о текущих данных (используется для создания)
            GbxCurrentData.Visible = false;

            // уменьшение формы
            this.Height = this.Height - 200;

            // изменение надписи на кнопке "Сохранить"
            BtnOK.Text = "Добавить";

        }

        // создание формы в режиме редактирования
        public AnimalForm(Animal animal)
        {
            InitializeComponent();

            // установка значений
            _animalElem = animal;

            // вывод информации о животном
            TbxCurrentSpecials.Text = _animalElem.Specials;
            TbxCurrentName.Text     = _animalElem.Name;
            TbxCurrentOwner.Text    = _animalElem.Owner;
            TbxCurrentColor.Text    = _animalElem.Сolor;
            TbxCurrentAge.Text      = _animalElem.Age.ToString();
            TbxCurrentWeight.Text   = $"{_animalElem.Weight:n5}";

            // вывод информации о животном для изменения данных
            CbxSpecials.SelectedItem    = _animalElem.Specials;
            TbxName.Text                = _animalElem.Name;
            TbxOwner.Text               = _animalElem.Owner;
            CbxColors.SelectedItem      = _animalElem.Сolor;
            NudAge.Value                = _animalElem.Age;
            NudWeight.Value             = (decimal)_animalElem.Weight;
        }

        #endregion

        #region Свойства

        // доступ к полю _animal
        public Animal AnimalElem
        {
            get => _animalElem;
            set => _animalElem = value;
        }

        #endregion

        #region Свойства

        // нажатие на кнопку "Сохраненить/Создать"
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // установка значений
            _animalElem.Specials    = CbxSpecials.SelectedItem.ToString();
            _animalElem.Name        = TbxName.Text;
            _animalElem.Owner       = TbxOwner.Text;
            _animalElem.Сolor       = CbxColors.SelectedItem.ToString();
            _animalElem.Age         = (int)NudAge.Value;
            _animalElem.Weight      = (double)NudWeight.Value;
        }

        #endregion

        // выбор вида животного
        private void CbxSpecials_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbxSpecials.SelectedItem)
            {
                case "Птица":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Bird;
                    break;
                case "Бык":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Bull;
                    break;
                case "Кошка":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Cat;
                    break;
                case "Корова":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Cow;
                    break;
                case "Собака":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Dog;
                    break;
                case "Утка":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Duck;
                    break;
                case "Слон":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Elephant;
                    break;
                case "Рыба":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Fish;
                    break;
                case "Лошадь":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Horse;
                    break;
                case "Божья коровка":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Ladybug;
                    break;
                case "Леопард":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Leopard;
                    break;
                case "Лев":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Lion;
                    break;
                case "Лобстер":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Lobster;
                    break;
                case "Заяц":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Rabbit;
                    break;
                case "Улитка":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Snail;
                    break;
                case "Черепаха":
                    _animalElem.IdImage = (int)AnimalsController.AnimalCode.Turtle;
                    break;
            }
        }


        // изменение текста в TextBox
        private void TbxName_TextChanged(object sender, EventArgs e) => CheckText();

        // валидация поля ввода фамилии и инициалиов владельца
        private void TbxOwner_Validating(object sender, CancelEventArgs e) =>
            ErpOwner.SetError(TbxOwner, CheckText() ? "" : "Строка должна иметь вид: Фаилия И. О.");

        // изменение текста в поле ввода фамилии и инициалиов владельца
        private void TbxOwner_TextChanged(object sender, EventArgs e)
        {
            // включение/выключение кнопки, если строка непустая/пустая
            BtnOK.Enabled = !String.IsNullOrWhiteSpace(TbxOwner.Text);

            // выключение отображения ошибки
            ErpOwner.SetError(TbxOwner, "");
        }

        // проверка содержания текста в TextBox
        private bool CheckText()
        {
            // текст в поле ввода владельца
            string owner = TbxOwner.Text;

            // размер строки
            int n = owner.Length;

            // включение/выключение кнопки 
            return BtnOK.Enabled = !(String.IsNullOrWhiteSpace(TbxName.Text) 
                || n < 7 
                || owner[n - 1] != '.' 
                || owner[n - 3] != ' ' 
                || owner[n - 4] != '.' 
                || owner[n - 6] != ' ');
        }

        // погашение нажатия цифр
        private void KeyDown_Command(object sender, KeyEventArgs e)
        {
            // код нажатой клавиши
            Keys code = e.KeyCode;

            if (code >= Keys.D0 && code <= Keys.D9 || code >= Keys.NumPad0 && code <= Keys.NumPad9)
                e.SuppressKeyPress = true;
        }
    }
}