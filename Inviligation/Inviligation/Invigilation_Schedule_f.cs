using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Inviligation
{
    public partial class Invigilation_Schedule_f : Form
    {
        public Invigilation_Schedule_f()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form f = new Home_Faculty();
            f.Show();
            this.Hide();
        }
    }
}
