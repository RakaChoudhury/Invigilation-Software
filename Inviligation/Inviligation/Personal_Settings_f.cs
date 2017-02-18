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
    public partial class Personal_Settings_f : Form
    {
        public Personal_Settings_f()
        {
            InitializeComponent();
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Form f = new Home_Faculty();
            f.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_NewPAs.Visible = true;
            lbl_OldPas.Visible = true;
            lbl_RetPas.Visible = true;
            txt_NewPas.Visible = true;
            txt_OldPas.Visible = true;
            txt_RetNew.Visible = true;
            rb_BacImg.Visible = false;
            rb_ChnCol.Visible = false;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbl_NewPAs.Visible = false ;
            lbl_OldPas.Visible = false;
            lbl_RetPas.Visible = false;
            txt_NewPas.Visible = false; 
            txt_OldPas.Visible = false;
            txt_RetNew.Visible = false;
            rb_BacImg.Visible = true;
            rb_ChnCol.Visible = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
