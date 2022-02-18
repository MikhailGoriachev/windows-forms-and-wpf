using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnGreeting_Click(object sender, EventArgs e)
        {
            string str = @"    |\_/|   ****************************  (\_/) " + "\n" +
            @"   / @ @ \  *  ""Purrrfectly pleasant""  * (='.'=)" + "\n" +
            @"  ( > o < ) * Poppy Prinz * ("")_("")" + "\n" +
            @"   '>>x<<' * (pprinz@example.com)   *" + "\n" +
            "\n" + 
            @"    / O \   ****************************"; 
            LblGreeting.Text = str;
            tmrFirst.Enabled = true;
        }

        private void BtnQuit_Click(object sender, EventArgs e) => Application.Exit();

        private void tmrFirst_Tick(object sender, EventArgs e)
        {
            LblGreeting.Text = "";
            tmrFirst.Enabled = false;
        }
    }
}
