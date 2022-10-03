using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SahibindenBot
{
    public partial class linkler : Form
    {
        public linkler()
        {
            InitializeComponent();
        }

        private void linker_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Properties.Settings.Default.linkler;
        }

        private void linker_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.linkler = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void linker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.linkler = richTextBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
