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
    public partial class Leave_Application_f : Form
    {
        public Leave_Application_f()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form f = new Home_Faculty();
            f.Show();
            this.Hide();
           
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Form f = new Home_Faculty();
            f.Show();
            this.Hide();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
