using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ListViewStarter.Helpers;
using ListViewStarter.Models;

namespace ListViewStarter.Views
{
    /// <summary>
    /// Логика взаимодействия для BodyWindow.xaml
    /// </summary>
    public partial class BodyWindow : Window
    {
        // Модель - интерфейсный объект, для полиморфной работы 
        private IVolumetricBody _body;

        public BodyWindow() : this(new Conoid()) { }

        public BodyWindow(IVolumetricBody body) {
            InitializeComponent();
            _body = body;

            // Записать значения модели в элементы интерфейса, поля ввода
            // настроить поля интерфейса
            SetBodyParams();
            TxbDensity.Text = $"{_body.Density:n3}";

            // хардкодим :( 
            // установить соответствующую радиокнопку и изображение по плотности
            // плотность по умолчанию - плотность стали
            RbtSteel.IsChecked = true;
            ImgMaterial.Source = Utils.BuildImageSource( "Materials", Materials.Data["steel"].ImageFile);

            // чистить поля вывода результатов
            ClearResultControls(null, new RoutedEventArgs());
        } // BodyWindow


        #region Изменение цвета надписи на кнопке при перемещении курсора мыши на кнопку
        private void Button_MouseEnter(object sender, MouseEventArgs e) {
            Button btn = e.OriginalSource as Button;
            btn.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        } // Button_MouseEnter

        private void Button_MouseLeave(object sender, MouseEventArgs e) {
            Button btn = e.OriginalSource as Button;
            btn.Foreground = new SolidColorBrush(Colors.White);
        } // Button_MouseLeave
        #endregion

        
        // обработчик установки радиокнопок выбора материала, из которого создано тело
        private void RbtMaterial_Checked(object sender, EventArgs e) {
            RadioButton rbt = sender as RadioButton;
            MaterialViewModel viewModel = Materials.Data[(string) rbt.Tag];
            
            // задать картинку материала
            ImgMaterial.Source = Utils.BuildImageSource("Materials", viewModel?.ImageFile);

            // задать плотность материала
            _body.Density = viewModel.Density;

            // отобразить плотность материала в TextBox
            TxbDensity.Text = $"{_body.Density:f3}";

            // т.к. данные для расчета изменились, очищаем поле вывода результата
            TblArea.Text = TblVolume.Text = TblMass.Text = Utils.EmptyResult;
        } // RbtMaterial_Click


        // вычичсление для объемного тела по заданию
        private void Calculate_Click(object sender, RoutedEventArgs e) {
            try {
                // Получить данные от элементов управления в зависимости от типа тела
                GetBodyParams();

                // Вычислить параметры тела в зависимости от установленных чек-боксов
                TblArea.Text = CbxArea.IsChecked == true
                    ? $"{_body.Area:n3}"
                    : Utils.CalcDontNeed;

                TblVolume.Text = CbxVolume.IsChecked == true
                    ? $"{_body.Volume:n3}"
                    : Utils.CalcDontNeed;

                TblMass.Text = CbxMass.IsChecked == true
                    ? $"{_body.Mass:n3}"
                    : Utils.CalcDontNeed;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            } // try-catch
        } // Calculate_Click


        // Получить параметры тела из элементов ввода,
        // в зависимости от типа используем соответсвующие наборы элементов управления
        private void GetBodyParams() {
            switch (_body.Type) {
                // по умолчанию работаем с усеченным конусом
                default:
                    Conoid conoid = _body as Conoid;
                    conoid.RadiusTop = double.Parse(TxbParam1.Text);
                    conoid.RadiusBottom = double.Parse(TxbParam2.Text);
                    conoid.Height = double.Parse(TxbParam3.Text);
                    break;

                case BodyType.Cylinder:
                    Cylinder cylinder = _body as Cylinder;
                    cylinder.Radius = double.Parse(TxbParam1.Text);
                    cylinder.Height = double.Parse(TxbParam2.Text);
                    break;
                
                case BodyType.Sphere:
                    Sphere sphere = _body as Sphere;
                    sphere.Radius = double.Parse(TxbParam1.Text);
                    break;

                case BodyType.Parallelepiped:
                    Parallelepiped parallelepiped = _body as Parallelepiped;
                    parallelepiped.A = double.Parse(TxbParam1.Text);
                    parallelepiped.B = double.Parse(TxbParam2.Text);
                    parallelepiped.C = double.Parse(TxbParam3.Text);
                    break;
            } // switch
        } // GetBodyParams

        // Поместить параметры тела в элементы управления
        private void SetBodyParams() {
            switch (_body.Type) {
                // по умолчанию работаем с усеченным конусом
                default:
                    Conoid conoid = _body as Conoid;
                    TxbParam1.Text = $"{conoid.RadiusTop:n3}";
                    TxbParam2.Text = $"{conoid.RadiusBottom:n3}";
                    TxbParam3.Text = $"{conoid.Height:n3}";
                    break;

                case BodyType.Cylinder:
                    Cylinder cylinder = _body as Cylinder;
                    TxbParam1.Text = $"{cylinder.Radius:n3}";
                    TxbParam2.Text = $"{cylinder.Height:n3}";

                    GrbData.Header = "Ввод параметров цилиндра:";

                    TxbPromptParam1.Text = "Радиус, м:";
                    TxbPromptParam2.Text = "Высота, м:";
                    TxbPromptParam3.Visibility = TxbParam3.Visibility = Visibility.Hidden;
                    
                    // переместить элемент в строку после ввода высоты
                    Grid.SetRow(TxbPromptDensity, 2);
                    Grid.SetRow(TxbDensity, 2);

                    // установить картинку
                    ImgBody.Source = Utils.BuildImageSource("Bodies", "cylinder.png");
                    break;

                case BodyType.Sphere:
                    Sphere sphere = _body as Sphere;
                    TxbParam1.Text = $"{sphere.Radius:n3}";

                    GrbData.Header = "Ввод параметров сферы:";

                    TxbPromptParam1.Text = "Радиус, м:";
                    TxbPromptParam2.Visibility = TxbPromptParam3.Visibility = 
                        TxbParam2.Visibility = TxbParam3.Visibility = Visibility.Hidden;

                    // переместить элемент в строку после ввода радиуса
                    Grid.SetRow(TxbPromptDensity, 1);
                    Grid.SetRow(TxbDensity, 1);

                    // установить картинку
                    ImgBody.Source = Utils.BuildImageSource("Bodies", "sphere.png");
                    break;

                case BodyType.Parallelepiped:
                    Parallelepiped parallelepiped = _body as Parallelepiped;
                    TxbParam1.Text = $"{parallelepiped.A:n3}";
                    TxbParam2.Text = $"{parallelepiped.B:n3}";
                    TxbParam3.Text = $"{parallelepiped.C:n3}";

                    GrbData.Header = "Ввод параметров прямоугольного параллелепипеда:";

                    TxbPromptParam1.Text = "Сторона A, м:";
                    TxbPromptParam2.Text = "Сторона B, м:";
                    TxbPromptParam3.Text = "Сторона C, м:";

                    // установить картинку
                    ImgBody.Source = Utils.BuildImageSource("Bodies", "parallelepiped.png");
                    break;
            } // switch
        } // SetBodyParams

        // при установке или снятии чек-боксов режимов расчета чистить элементы управления
        // для вывода результатов расчетов
        private void ClearResultControls(object sender, RoutedEventArgs e) =>
            TblArea.Text = TblVolume.Text = TblMass.Text = Utils.EmptyResult;
        
    } // class BodyWindow
}
