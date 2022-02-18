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

using ListViewStarter.Models;


namespace ListViewStarter.Views
{
    /// <summary>
    /// Логика взаимодействия для BodyListWindow.xaml
    /// </summary>
    public partial class BodyListWindow : Window
    {
        public BodyListWindow() {
            InitializeComponent();

            LsvBodies.ItemsSource = new List<IVolumetricBody>(new IVolumetricBody [] {
                new Conoid {RadiusTop = 1, RadiusBottom = 2, Height = 1},
                new Conoid {RadiusBottom = 3, RadiusTop = 2, Height = 1},
                new Sphere {Radius = 1},
                new Cylinder() {Radius = 2, Height = 1},
                new Sphere {Radius = 10},
                new Cylinder {Radius = 2, Height = 4},
                new Parallelepiped {A=1, B=2, C= 3},
                new Parallelepiped {A = 4, B = 5, C= 2},
            });
        }
    }
}
