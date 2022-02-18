using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;             
using System.Runtime.Serialization;     // сериализация

namespace Train.Models
{
    // Класс Место
    [DataContract]
    public class Seat
    {
        // номер места
        [DataMember]
        private int _number;

        public int Number
        {
            get =>_number; 
            set => _number = value; 
        }


        // состояние (продано/свободно)
        [DataMember]
        private bool _state;

        public bool State
        {
            get => _state; 
            set => _state = value; 
        }

        #region Свойства

        // получение названия состояния
        public string StateTitle => _state ? "Продано" : "Свободно";

        #endregion

        #region Конструкторы

        // конструктор по умолчанию
        public Seat() : this(1, false) { }
        
        // конструктор по умолчанию
        public Seat(int number, bool state)
        {
            // установка значений
            _number = number;
            _state = state;
        }

        #endregion

        #region Методы

        // создание TreeNode
        public TreeNode GetTreeNode()
        {
            // индекс изображения
            int index = _state ? 4 : 3;

            var node = new TreeNode($"Место № { _number }", index, index);

            // установка ссылка на запись
            node.Tag = this;

            return node;
        }

        #endregion

    }
}
