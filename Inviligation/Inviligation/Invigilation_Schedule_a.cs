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
    public partial class Invigilation_Schedule_a : Form
    {
        public Invigilation_Schedule_a()
        {
            InitializeComponent();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form f = new Home_Admin();
            f.Show();
            this.Hide();
        }
    }
}
