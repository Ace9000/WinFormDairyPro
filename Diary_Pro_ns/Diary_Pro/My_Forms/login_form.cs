using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Pro.My_Forms
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_form_Load(object sender, EventArgs e)
        {
            user_info_loader();
        }
        public void user_info_loader()
        {
            txtUser.Text = Diary_Pro.Properties.Settings.Default.User_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "")

            {
                MessageBox.Show("Please enter your password");
                return;
            }

            if(txtPass.Text == Diary_Pro.Properties.Settings.Default.User_pass)

            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Pass not correct");

            }
        }
    }
}
