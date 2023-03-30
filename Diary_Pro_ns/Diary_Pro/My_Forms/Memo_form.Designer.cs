namespace Diary_Pro.My_Forms
{
    partial class Memo_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memo_form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFont = new System.Windows.Forms.ToolStripButton();
            this.btnTxtColor = new System.Windows.Forms.ToolStripButton();
            this.btnBackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLeftAlign = new System.Windows.Forms.ToolStripButton();
            this.btnCenterAlign = new System.Windows.Forms.ToolStripButton();
            this.btnRightAlign = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnIncrese = new System.Windows.Forms.ToolStripButton();
            this.btnDecrese = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCopy = new System.Windows.Forms.ToolStripButton();
            this.btnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDo = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFont,
            this.btnTxtColor,
            this.btnBackColor,
            this.toolStripSeparator1,
            this.btnLeftAlign,
            this.btnCenterAlign,
            this.btnRightAlign,
            this.toolStripSeparator2,
            this.btnIncrese,
            this.btnDecrese,
            this.toolStripSeparator3,
            this.btnCopy,
            this.btnPaste,
            this.toolStripSeparator4,
            this.btnDo,
            this.btnUndo,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(1, 170);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFont
            // 
            this.btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFont.Image = global::Diary_Pro.Properties.Resources.font_16;
            this.btnFont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(29, 32);
            this.btnFont.Text = "Font";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnTxtColor
            // 
            this.btnTxtColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTxtColor.Image = global::Diary_Pro.Properties.Resources.forecolor;
            this.btnTxtColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTxtColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTxtColor.Name = "btnTxtColor";
            this.btnTxtColor.Size = new System.Drawing.Size(29, 32);
            this.btnTxtColor.Text = "Text Color";
            this.btnTxtColor.Click += new System.EventHandler(this.btnTxtColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBackColor.Image = ((System.Drawing.Image)(resources.GetObject("btnBackColor.Image")));
            this.btnBackColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(29, 32);
            this.btnBackColor.Text = "Back Color";
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // btnLeftAlign
            // 
            this.btnLeftAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLeftAlign.Image = global::Diary_Pro.Properties.Resources.text_align_left_16;
            this.btnLeftAlign.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLeftAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLeftAlign.Name = "btnLeftAlign";
            this.btnLeftAlign.Size = new System.Drawing.Size(29, 32);
            this.btnLeftAlign.Text = "Left Align";
            this.btnLeftAlign.Click += new System.EventHandler(this.btnLeftAlign_Click);
            // 
            // btnCenterAlign
            // 
            this.btnCenterAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCenterAlign.Image = global::Diary_Pro.Properties.Resources.text_align_center_16;
            this.btnCenterAlign.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCenterAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCenterAlign.Name = "btnCenterAlign";
            this.btnCenterAlign.Size = new System.Drawing.Size(29, 32);
            this.btnCenterAlign.Text = "Center Align";
            this.btnCenterAlign.Click += new System.EventHandler(this.btnCenterAlign_Click);
            // 
            // btnRightAlign
            // 
            this.btnRightAlign.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRightAlign.Image = global::Diary_Pro.Properties.Resources.text_align_right_16;
            this.btnRightAlign.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRightAlign.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRightAlign.Name = "btnRightAlign";
            this.btnRightAlign.Size = new System.Drawing.Size(29, 32);
            this.btnRightAlign.Text = "Right Align";
            this.btnRightAlign.Click += new System.EventHandler(this.btnRightAlign_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btnIncrese
            // 
            this.btnIncrese.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIncrese.Image = global::Diary_Pro.Properties.Resources.indent_increase_16;
            this.btnIncrese.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncrese.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIncrese.Name = "btnIncrese";
            this.btnIncrese.Size = new System.Drawing.Size(29, 32);
            this.btnIncrese.Text = "Increse";
            this.btnIncrese.Click += new System.EventHandler(this.btnIncrese_Click);
            // 
            // btnDecrese
            // 
            this.btnDecrese.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDecrese.Image = global::Diary_Pro.Properties.Resources.indent_decrease_16;
            this.btnDecrese.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDecrese.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDecrese.Name = "btnDecrese";
            this.btnDecrese.Size = new System.Drawing.Size(29, 32);
            this.btnDecrese.Text = "Decrese";
            this.btnDecrese.Click += new System.EventHandler(this.btnDecrese_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // btnCopy
            // 
            this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopy.Image = global::Diary_Pro.Properties.Resources.ic_content_copy_48px_16;
            this.btnCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(29, 32);
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPaste.Image = ((System.Drawing.Image)(resources.GetObject("btnPaste.Image")));
            this.btnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(29, 32);
            this.btnPaste.Text = "Paste";
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // btnDo
            // 
            this.btnDo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDo.Image = ((System.Drawing.Image)(resources.GetObject("btnDo.Image")));
            this.btnDo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(29, 32);
            this.btnDo.Text = "Do";
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = global::Diary_Pro.Properties.Resources.Redo_2_16;
            this.btnUndo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(29, 32);
            this.btnUndo.Text = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-3, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(588, 296);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 58);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save F5";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 35);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Memo F2";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(1, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 440);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Memo Details";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(158, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(80, 24);
            this.txtID.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Memo Date:";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(158, 72);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(370, 24);
            this.txtDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memo Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(158, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(370, 24);
            this.txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memo Title:";
            // 
            // Memo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(586, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Memo_form";
            this.Text = "Memo Registration";
            this.Load += new System.EventHandler(this.Memo_form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnFont;
        private System.Windows.Forms.ToolStripButton btnTxtColor;
        private System.Windows.Forms.ToolStripButton btnBackColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnLeftAlign;
        private System.Windows.Forms.ToolStripButton btnCenterAlign;
        private System.Windows.Forms.ToolStripButton btnRightAlign;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnIncrese;
        private System.Windows.Forms.ToolStripButton btnDecrese;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnCopy;
        private System.Windows.Forms.ToolStripButton btnPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDo;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
    }
}