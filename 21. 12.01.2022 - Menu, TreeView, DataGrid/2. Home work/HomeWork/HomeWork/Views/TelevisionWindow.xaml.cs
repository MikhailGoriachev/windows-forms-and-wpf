using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HomeWork.Models;


namespace HomeWork.Views
{
    /// <summary>
    /// Interaction logic for TelevisionWindow.xaml
    /// </summary>
    public partial class TelevisionWindow : Window
    {
        // телевизор для работы
        public TelevisionModel Television { get; set; }

        #region Конструкторы 

        // конструктор формы в режиме создания телевизора
        public TelevisionWindow()
        {
            InitializeComponent();

            // установка значений
            Television = RepairShopModel.FactoryMethodTelevisions();

            // инициализация полей
            InitWindow();
        }

        // конструктор формы в режиме редактирования телевизора
        public TelevisionWindow(TelevisionModel television)
        {
            InitializeComponent();

            // установка значений
            Television = television;
            LblHeader.Content = "Редактирование телевизора";
            Title = "Редактирование телевизора";
            BtnOk.Content = "Сохранить";

            // инициализация полей
            InitWindow();
        }

        #endregion

        #region Методы

        #region Обработчики событий 

        // нажатие на кнопку "Добавить" | "Сохранить"
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            // установка значений в модель
            Television.Defect       = TbxDefect.Text;
            Television.Master       = TbxMaster.Text;
            Television.Model        = TbxModel.Text;
            Television.Owner        = TbxOwner.Text;
            Television.Price        = int.Parse(TbxPrice.Text);
            Television.Diagonal     = int.Parse(CmbDiagonal.SelectedItem.ToString());

            DialogResult = true;

            Close();
        }


        // изменение текста
        private void Tbx_TextChanged(object sender, TextChangedEventArgs e) => BtnOk.IsEnabled = Validation();


        #endregion

        // инициализация полей формы данными из телевизора
        public void InitWindow()
        {
            // установка значений
            TbxDefect.Text           = Television.Defect;
            TbxMaster.Text           = Television.Master;
            TbxModel.Text            = Television.Model;
            TbxOwner.Text            = Television.Owner;
            TbxPrice.Text            = Television.Price.ToString();
            CmbDiagonal.SelectedItem = Television.Diagonal.ToString();
        }


        // проверка валидности ввода 
        public bool Validation() => !string.IsNullOrWhiteSpace(TbxDefect.Text) &&
                                    !string.IsNullOrWhiteSpace(TbxMaster.Text) &&
                                    !string.IsNullOrWhiteSpace(TbxModel.Text) &&
                                    !string.IsNullOrWhiteSpace(TbxOwner.Text) &&
                                    int.TryParse(TbxPrice.Text, out int i);



        #endregion

    }
}
