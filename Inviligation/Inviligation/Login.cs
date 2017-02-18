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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_username.Text = "Enter you username here";
            txt_password.Text = "Enter your password here";
           
               
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
           
        }
    }
}
