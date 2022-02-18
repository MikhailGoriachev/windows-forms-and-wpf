using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManyForms
{
    public partial class ThirdForm : Form
    {
        private MainForm _form;

        public ThirdForm()
        {
            InitializeComponent();
        }
        
        public ThirdForm(MainForm form, string text)
        {
            InitializeComponent();

            _form = form;
            textBox1.Text = text;
        }

        private void ThirdForm_FormClosing(object sender, FormClosingEventArgs e) {
            _form.SetLabel(textBox1.Text);
        }
    }
}
