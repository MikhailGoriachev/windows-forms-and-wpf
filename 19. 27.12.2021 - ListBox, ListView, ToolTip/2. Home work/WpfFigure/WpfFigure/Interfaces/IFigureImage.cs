using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFigure.Interfaces
{
    // Интерфейс Изображение фигуры
    internal interface IFigureImage
    {
        // получение названия файла изображения фигуры
        string GetImageFileName();
    }
}
