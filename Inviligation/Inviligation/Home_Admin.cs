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
    public partial class Home_Admin : Form
    {
        public Home_Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ll_InvSch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Invigilation_Schedule_a();
            f.Show();
            this.Hide();
           
        }

    

        private void ll_LeaAp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Leave_Application_a();
            f.Show();
            this.Hide();
        }

        private void ll_PerSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Personal_Settings_a();
            f.Show();
            this.Hide();
        }

        private void ll_FacUpd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to reset??");
            {   Form f = new Reset_1_a();
                 f.Show();
                 this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

     
    }
}
