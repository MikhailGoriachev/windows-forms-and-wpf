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
using HomeWork.Models.Task1;      // модели 

namespace HomeWork.Views
{
    /// <summary>
    /// Interaction logic for RepairShopWindow.xaml
    /// </summary>
    public partial class RepairShopWindow : Window
    {

        // ремонтная мастерская для работы
        public RepairShopModel RepairShop { get; set; }

        #region Конструкторы 

        // конструктор формы в режиме создания телевизора
        public RepairShopWindow()
        {
            InitializeComponent();

            // установка значений
            RepairShop = RepairShopModel.FactoryMethod();

            // инициализация полей
            InitWindow();
        }

        // конструктор формы в режиме редактирования телевизора
        public RepairShopWindow(RepairShopModel repairShop)
        {
            InitializeComponent();

            // установка значений
            RepairShop = repairShop;
            LblHeader.Content = "Редактирование ремонтной мастерской";
            Title = "Редактирование ремонтной мастерской";
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
            RepairShop.Name    = TbxName.Text;
            RepairShop.Address = TbxAddress.Text;

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
            TbxName.Text = RepairShop.Name;
            TbxAddress.Text = RepairShop.Address;
        }


        // проверка валидности ввода 
        public bool Validation() => !string.IsNullOrWhiteSpace(TbxName.Text) &&
                                    !string.IsNullOrWhiteSpace(TbxAddress.Text);



        #endregion

    }
}
