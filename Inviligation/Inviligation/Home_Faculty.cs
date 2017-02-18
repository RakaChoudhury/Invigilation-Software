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
    public partial class Home_Faculty : Form
    {
        public Home_Faculty()
        {
            InitializeComponent();
        }

        private void Home_Faculty_Load(object sender, EventArgs e)
        {

        }

        private void ll_InvSch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Invigilation_Schedule_f();
            f.Show();
            this.Hide();
           
        }

        private void ll_LeaApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Leave_Application_f();
            f.Show();
            this.Hide();
           
        }

        private void ll_PerSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Personal_Settings_f();
            f.Show();
            this.Hide();
           
        }
    }
}
