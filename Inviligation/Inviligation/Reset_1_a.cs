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
    public partial class Reset_1_a : Form
    {
        int flag;
        public Reset_1_a()
        {
           
            InitializeComponent();
           
        }

      
        private void Reset_1_a_Load(object sender, EventArgs e)
        {
          
        }

        private void ll_1y_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flag = 1;
            Form f = new Reset_2_a(flag);
            f.Show();
            this.Hide();
        }

        private void ll_2y_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flag = 2;
            Form f = new Reset_2_a(flag);
            f.Show();
            this.Hide();

        }

        private void ll_3y_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flag = 3;
            Form f = new Reset_2_a(flag);
            f.Show();
            this.Hide();
        }

        private void ll_4y_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            flag = 4;
            Form f = new Reset_2_a(flag);
            f.Show();
            this.Hide();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {

            Form f = new Home_Admin();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }






    }
}
