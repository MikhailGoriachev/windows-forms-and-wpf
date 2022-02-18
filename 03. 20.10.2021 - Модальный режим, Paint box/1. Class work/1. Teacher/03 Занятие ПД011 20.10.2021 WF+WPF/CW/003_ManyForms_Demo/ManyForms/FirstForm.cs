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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        } // FirstForm

        public string GetText() { return txbString.Text; }
        public void SetText(string text) { txbString.Text = text; }

        public bool GetMode() { return chbMode.Checked; }
        public void SetMode(bool value) { chbMode.Checked = value; }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.Show();
        }
    }
}
