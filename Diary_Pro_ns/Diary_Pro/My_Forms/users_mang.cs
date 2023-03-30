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
    public partial class users_mang : Form
    {
        public users_mang()
        {
            InitializeComponent();
        }
        private void users_mang_Load(object sender, EventArgs e)
        {
            txtUser.Text = Properties.Settings.Default.User_name;
            txtPass.Text = Properties.Settings.Default.User_pass;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(txtUser.Text == "")

            {
                MessageBox.Show("User name is empty");
            }

            if(txtPass.Text != txtComfirm.Text)

            {
                MessageBox.Show("Password don't match");
            }

            Diary_Pro.Properties.Settings.Default.User_name = txtUser.Text;
            Diary_Pro.Properties.Settings.Default.User_pass = txtPass.Text;
            Diary_Pro.Properties.Settings.Default.Save();

            string fn;
            fn = openFileDialog1.FileName;
            string df;
            df = Application.StartupPath + @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\big-one.jpg";
            //System.IO.File.Copy(fn,df,true);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fn;
            fn = openFileDialog1.FileName;
            pictureBox1.Load(fn);

        }
    }
}
