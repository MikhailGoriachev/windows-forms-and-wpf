using System.Windows;
using System.Windows.Controls;
using DependencyPropertyDemo.Models;

namespace DependencyPropertyDemo.Views
{
    /// <summary>
    /// Логика взаимодействия для FoxWindow.xaml
    /// </summary>
    public partial class FoxWindow : Window
    {
        // объект данных
        private Fox _fox;
        public Fox Fox => _fox;

        #region Конструкторы
        public FoxWindow() {
            InitializeComponent(); 
            
            // Программный доступ к ресурсам окна:
            _fox = (Fox)Resources["Foxy"];   // получить ссылку на ресурс
            _fox.Age = 10;                   // меняем свойство - меняем значение ресурса
            _fox.Weight = 15.2;              // меняем свойство - меняем значение ресурса
        } // FoxWindow

        public FoxWindow(int age, double weight) {
            InitializeComponent();

            // Программный доступ к ресурсам окна:
            _fox = (Fox)Resources["Foxy"];   // получить ссылку на ресурс
            _fox.Age = age;                  // меняем свойство - меняем значение ресурса
            _fox.Weight = weight;            // меняем свойство - меняем значение ресурса
        } // FoxWindow 

        public FoxWindow(Fox fox) {
            InitializeComponent();

            // Программный доступ к ресурсам окна:
            _fox = (Fox)Resources["Foxy"];  // получить ссылку на ресурс

            // загружаем свойства из передаваемого объекта
            _fox.Age = fox.Age;                  // меняем свойство - меняем значение ресурса
            _fox.Weight = fox.Weight;            // меняем свойство - меняем значение ресурса
            _fox.Title = fox.Title;
            
            // нельзя изменить весь ресурс! только отдельные свойства
            // _fox = fox;
        } // FoxWindow
        #endregion


        // Увеличение веса и возраста лисы
        private void BtnUp_Click(object sender, RoutedEventArgs e) {
            _fox.Weight += 2d;
            _fox.Age += 3;
        } // BtnUp_Click


        // Уменьшение веса и возраста лисы
        private void BtnDown_Click(object sender, RoutedEventArgs e) {
            _fox.Weight -= 2d;
            _fox.Age -= 3;
        } // BtnDown_Click
        

        // При закрытии окна обеспечиваем - true в результате диалога
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        =>
            DialogResult = true;
    } // class FoxWindow
}
