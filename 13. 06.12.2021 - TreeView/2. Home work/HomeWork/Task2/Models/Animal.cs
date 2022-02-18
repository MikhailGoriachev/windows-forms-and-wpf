using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;     // JSON сериализация
using System.Windows.Forms;             // элементы Windows Forms

/*
 * Класс Animal:
 * •	индекс иконки животного в коллекции ImageList
 * •	вид животного 
 * •	кличка животного 
 * •	вес животного (в кг) 
 * •	возраст животного(в годах)
 * •	цвет(масть) животного, 
 * •	фамилия и инициалы владельца (Иванов И.И., …).
*/

namespace Animals.Models
{
    [DataContract]
    // Класс Животное
    public class Animal
    {
        [DataMember]
        // индекс иконки животного в коллекции ImageList
        private int _idImage;

        [DataMember]
        // вид животного 
        private string _species;

        [DataMember]
        // кличка животного 
        private string _name;

        [DataMember]
        // вес животного (в кг) 
        private double _weight;

        [DataMember]
        // возраст животного(в годах)
        private int _age;

        [DataMember]
        // цвет(масть) животного, 
        private string _color;

        [DataMember]
        // фамилия и инициалы владельца (Иванов И.И., …).
        private string _owner;

        #region Свойства

        // доступ к полю _idImage
        public int IdImage { 
            get => _idImage; 
            set => _idImage = value >= 0 
                ? value 
                : throw new Exception("Animal: поле IdImage не может быть отрицательным!");
        }

        // доступ к полю _species
        public string Specials { 
            get => _species; 
            set => _species = !string.IsNullOrWhiteSpace(value) 
                ? value
                : throw new Exception("Animal: поле Special не может быть пустым!"); 
        }

        // доступ к полю _name
        public string Name { 
            get => _name; 
            set => _name = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new Exception("Animal: поле Name не может быть пустым!");
        }

        // доступ к полю _weight
        public double Weight { 
            get => _weight; 
            set => _weight = value >= 0 
                ? value 
                : throw new Exception("Animal: поле Weight не может быть отрицательным!");
        }

        // доступ к полю _age
        public int Age { 
            get => _age; 
            set => _age = value >= 0
                ? value
                : throw new Exception("Animal: поле Age должно быть больше нуля!");
        }

        // доступ к полю _color
        public string Сolor
        {
            get => _color;
            set => _color = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new Exception("Animal: поле Сolor не может быть пустым!");
        }

        // доступ к полю _owner
        public string Owner
        {
            get => _owner;
            set => _owner = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new Exception("Animal: поле Owner не может быть пустым!");
        }

        #endregion

        #region Методы 

        // вывод в ListView
        public void ShowListView(ListView listView)
        {
            // элемент для ListView
            ListViewItem listViewItem = new ListViewItem();

            // установка изображения 
            listViewItem.ImageIndex = _idImage;

            // заполенение остальных столбцов
            listViewItem.SubItems.AddRange(new[] { _species, _name, $"{_weight:n5}", _age.ToString(), _color, _owner });

            // добавление элемента в List View
            listView.Items.Add(listViewItem);
        }

        // вывод в ListView
        public ListViewItem GetListViewItem()
        {
            // элемент для ListView
            ListViewItem listViewItem = new ListViewItem();

            // установка изображения 
            listViewItem.ImageIndex = _idImage;

            // заполенение остальных столбцов
            listViewItem.SubItems.AddRange(new[] { _species, _name, $"{_weight:n5}", _age.ToString(), _color, _owner });

            return listViewItem;
        }


        // создание TreeNode
        public TreeNode GetTreeNode()
        {
            // элемент TreeNode
            TreeNode treeNode = new TreeNode($"{Specials} {Name}", IdImage, IdImage);
            treeNode.Nodes.Add(new TreeNode($"Вес: {_weight:n5}", 17, 17));
            treeNode.Nodes.Add(new TreeNode($"Владелец: {_owner}", 17, 17));

            // запись ссылки на элемент в тег
            treeNode.Tag = this;

            return treeNode;
        }

        #endregion
    }
}
