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
    public partial class sure : Form
    {
        public sure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.sure = textBox1.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void sure_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.sure;
        }
    }
}
