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
    public partial class Search_memo : Form
    {
        public Search_memo()
        {
            InitializeComponent();
        }
        private void Search_memo_Load(object sender, EventArgs e)
        {

            groupBox1.Enabled = true;
            richTextBox2.Enabled = true;

            Int32 ic;
            ic = Diary_Pro.Properties.Settings.Default.last_memo_id;
            
            Int32 i;
            for(i=1 ; i<=ic; i++)
            {
                listBox1.Items.Add(i.ToString());
            }

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32 last_id;
            last_id = Diary_Pro.Properties.Settings.Default.last_memo_id;
            last_id = last_id + 1;
            Diary_Pro.Properties.Settings.Default.last_memo_id = last_id;
            Diary_Pro.Properties.Settings.Default.Save();

            Int32.TryParse(listBox1.Text, out last_id);

            string fn = @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\" + last_id.ToString() + ".rtf";
            string fn_title = @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\" + last_id.ToString() + ".txt";
            string fn_date = @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\" + last_id.ToString() + ".txt";

            richTextBox2.LoadFile(fn);
            txtTitle.Text = System.IO.File.ReadAllText(fn_title, Encoding.UTF8);
            txtDate.Text = System.IO.File.ReadAllText(fn_date, Encoding.UTF8);
            txtID.Text = last_id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 i;

            i = listBox1.FindStringExact(txtSearch.Text);
            listBox1.SelectedIndex = i;
        }
    }
}
