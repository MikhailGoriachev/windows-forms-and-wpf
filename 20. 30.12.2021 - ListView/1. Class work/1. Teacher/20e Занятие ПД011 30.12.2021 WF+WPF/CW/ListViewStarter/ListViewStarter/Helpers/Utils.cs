using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ListViewStarter.Helpers
{
    public class Utils
    {
        // представление для пустой строки результата
        public const string EmptyResult = "--- '' ---";
        public static string CalcDontNeed = "Расчет не задан";

        // формирование Uri из имени файла, файлы изображений в папке проекта
        // Images, действие при построении для каждого файла изображения - Resource
        // формат Uri для имени файла в ресурсах проекта
        // pack://application:,,,/Папка/файл.ext, так, для нашего проекта это будет
        // pack://application:,,,/Images/Cat0.jpg
        public static ImageSource BuildImageSource(string folderName, string fileName) {
            BitmapImage image = new BitmapImage();

            image.BeginInit();
            image.UriSource = new Uri($"pack://application:,,,/Images/{folderName}/{fileName}");
            image.EndInit();

            return image;
        } // BuildImageSource
    }
}
