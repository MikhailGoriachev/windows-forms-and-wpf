using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;             // элементы Windows Forms

namespace Animals.Models
{
    // зоопарк
    [DataContract]
    internal class ZooModel
    {
        [DataMember]
        // название зоопарка 
        public string Title { get; set; }

        [DataMember]
        // коллекция животных
        public List<Animal> AnimalsZoo { get; set; }

        [DataMember]
        // индекс картинки в ListView
        public int IdImage { get; set; }

        #region Конструкторы

        // конструктор по умолчанию
        public ZooModel() : this("Мой дом", new List<Animal>(), 16) { }

        // конструктор инициализирующий
        public ZooModel(string title, List<Animal> animalsZoo, int idImage)
        {
            // установка значений
            Title = title;
            AnimalsZoo = animalsZoo;
            IdImage = idImage;
        }

        #endregion

        #region Методы

        // создание TreeNode
        public TreeNode GetTreeNode()
        {
            // элемент TreeNode
            TreeNode treeNode = new TreeNode(Title, IdImage, IdImage);

            // добавление записей 
            AnimalsZoo.ForEach(item => treeNode.Nodes.Add(item.GetTreeNode()));

            return treeNode;
        }

        #endregion
    }
}
