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
    public partial class Memo_form : Form
    {
        public Memo_form()
        {
            InitializeComponent();
        }
        private void Memo_form_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void btnTxtColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void btnBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }
        private void btnLeftAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void btnCenterAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void btnRightAlign_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void btnIncrese_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = richTextBox1.SelectionIndent;
            i = i - 10;
            richTextBox1.SelectionIndent = i;
        }

        private void btnDecrese_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = richTextBox1.SelectionIndent;
            i = i + 10;
            richTextBox1.SelectionIndent = i;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();

        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnNew.Enabled = false;
            btnSave.Enabled = true;

            txtID.Text = Diary_Pro.Properties.Settings.Default.last_memo_id.ToString();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            
            Int32 last_id;
            last_id = Diary_Pro.Properties.Settings.Default.last_memo_id;
            last_id = last_id + 1;
            Diary_Pro.Properties.Settings.Default.last_memo_id = last_id;
            Diary_Pro.Properties.Settings.Default.Save();
            
            string fn = @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\" + last_id.ToString() + ".rtf";
            string fn_title = @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\" + last_id.ToString() + ".txt";
            string fn_date = @"C:\Users\anast\OneDrive\Desktop\C#\2022\Podatoci\Phone_Book\" + last_id.ToString() + ".txt";

            System.IO.File.WriteAllText(fn_title, txtTitle.Text, Encoding.UTF8);
            System.IO.File.WriteAllText(fn_date, txtDate.Text, Encoding.UTF8);
            richTextBox1.SaveFile(fn);

            //fn = Application.StartupPath + "\\My_Forms\\data\\docs\\" + last_id.ToString() + ".rtf";
            //fn_title = Application.StartupPath + "\\My_Forms\\data\\docs\\title_1" + last_id.ToString() + ".txt";
            //fn_date = Application.StartupPath + "\\My_Forms\\data\\docs\\date_" + last_id.ToString() + ".txt";

        }

    }
}
