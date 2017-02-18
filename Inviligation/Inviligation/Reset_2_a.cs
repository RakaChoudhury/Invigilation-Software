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
    public partial class Reset_2_a : Form
    {
        int a;

        public Reset_2_a(int flag)
        {
            a = flag;
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f = new Home_Admin();
            f.Show();
            this.Hide();
        }

        private void Reset_2_a_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
