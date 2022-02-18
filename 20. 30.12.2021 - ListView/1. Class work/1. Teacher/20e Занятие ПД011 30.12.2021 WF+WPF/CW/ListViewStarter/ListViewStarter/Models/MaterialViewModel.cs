namespace ListViewStarter.Models
{
    // данные по материалу для получения и отображения плотности
    internal class MaterialViewModel
    {
        // название материала
        public string Name { get; set; }
        
        // плотность материала, кг/м3
        public double Density { get; set; }
        
        // имя файла изображения материала
        public string ImageFile { get; set; }
    } // class MaterialViewModel
}
