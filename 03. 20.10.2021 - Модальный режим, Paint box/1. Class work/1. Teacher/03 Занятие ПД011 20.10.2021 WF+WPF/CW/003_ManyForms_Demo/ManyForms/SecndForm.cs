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
    public partial class SecndForm : Form
    {
        public SecndForm()
        {
            InitializeComponent();
        }

        // при загрузке формы настроить компоненты формы
        private void SecndForm_Load(object sender, EventArgs e) {
            pictureBox1.Image = Image.FromFile(@"..\..\Resources\000f888x.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
