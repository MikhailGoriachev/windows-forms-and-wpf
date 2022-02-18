using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Радиокнопки, RadioButton
 */
namespace RadioButtonsDemo
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        } // MainForm


        // опрос радиокнопок в обработчике клика по кнопке Button
        private void Button1_Click(object sender, EventArgs e) {
            // radioButton1.Checked - свойство радиокнопки, хранящее ее состояние
            //                        true : отмечена
            //                        false: не отмечена
            MessageBox.Show(
                $"Состояния радиокнопок:\n" +
                $"radiobutton1: {radioButton1.Checked}\n" +
                $"radiobutton2: {radioButton2.Checked}\n" +
                $"radiobutton3: {radioButton3.Checked}\n" +
                $"radiobutton4: {radioButton4.Checked}", "К сведению", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        } // Button1_Click


        // один обработчик сбытия клика для всех радиокнопок
        private void RadioButton_Click(object sender, EventArgs e) {
            RadioButton rb = sender as RadioButton;
            
            // выводим состояние отмеченной радиокнопки в поле текста кнопки
            // (да, на святое покусились :) )
            button2.Text = $"{rb.Text}";
        } // RadioButton_Click

        private void Button2_Click(object sender, EventArgs e) {
            MessageBox.Show("Не кликайте по мне, кликайте по правой группе радиокнопок",
                "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        } // Button2_Click
    } // class MainForm
}
