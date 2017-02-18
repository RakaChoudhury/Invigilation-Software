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
    public partial class Personal_Settings_a : Form
    {
        public Personal_Settings_a()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form f = new Home_Admin();
            f.Show();
            this.Hide();
        }
    }
}
