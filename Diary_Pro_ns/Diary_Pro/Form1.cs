using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           Diary_Pro.My_Forms.login_form lg_form = new Diary_Pro.My_Forms.login_form();
           lg_form.ShowDialog();

            get_time();
            get_calender();
            verLabel.Text = Application.ProductVersion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit!", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerlabel_Tick(object sender, EventArgs e)
        {
            get_time();

        }
        public void get_time()
        {
            timerlabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void get_calender()
        {
            System.Globalization.GregorianCalendar g;
            g= new System.Globalization.GregorianCalendar();
            lblYear.Text = g.GetYear(DateTime.Now).ToString();
            lblMonth.Text = g.GetMonth(DateTime.Now).ToString();
            lblDate.Text = g.GetDayOfMonth(DateTime.Now).ToString();
            lblDay.Text = g.GetDayOfWeek(DateTime.Now).ToString();

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary_Pro.My_Forms.AboutUs ab_form = new Diary_Pro.My_Forms.AboutUs();
            ab_form.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary_Pro.My_Forms.users_mang users_Mang = new My_Forms.users_mang();
            users_Mang.Show();
        }

        private void lockApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary_Pro.My_Forms.login_form lg_form = new My_Forms.login_form();
            lg_form.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Diary_Pro.My_Forms.Memo_form memo_Form = new Diary_Pro.My_Forms.Memo_form();
            memo_Form.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Diary_Pro.My_Forms.Search_memo Search_Form = new Diary_Pro.My_Forms.Search_memo();
            Search_Form.Show();
            
        }
    }
}
