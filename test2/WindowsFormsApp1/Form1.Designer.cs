namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.grafPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grafText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.questText = new System.Windows.Forms.RichTextBox();
            this.AnswerQuest = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.grafDir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBox2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.fileDir = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafPanel
            // 
            this.grafPanel.AccessibleName = "";
            this.grafPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafPanel.AutoSize = true;
            this.grafPanel.BackColor = System.Drawing.Color.White;
            this.grafPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grafPanel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grafPanel.Location = new System.Drawing.Point(8, 88);
            this.grafPanel.Name = "grafPanel";
            this.grafPanel.Size = new System.Drawing.Size(444, 445);
            this.grafPanel.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.grafDir);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(458, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Graf";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grafText);
            this.panel1.Location = new System.Drawing.Point(8, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 100);
            this.panel1.TabIndex = 11;
            // 
            // grafText
            // 
            this.grafText.BackColor = System.Drawing.Color.White;
            this.grafText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grafText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafText.Location = new System.Drawing.Point(0, 0);
            this.grafText.Name = "grafText";
            this.grafText.ReadOnly = true;
            this.grafText.Size = new System.Drawing.Size(287, 98);
            this.grafText.TabIndex = 7;
            this.grafText.Text = "";
            this.grafText.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.fileDir);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.AnswerQuest);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(458, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Pertanyaan";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.questText);
            this.panel2.Location = new System.Drawing.Point(9, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 142);
            this.panel2.TabIndex = 15;
            // 
            // questText
            // 
            this.questText.BackColor = System.Drawing.Color.White;
            this.questText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questText.Location = new System.Drawing.Point(0, 0);
            this.questText.Name = "questText";
            this.questText.ReadOnly = true;
            this.questText.Size = new System.Drawing.Size(112, 140);
            this.questText.TabIndex = 13;
            this.questText.Text = "";
            this.questText.WordWrap = false;
            // 
            // AnswerQuest
            // 
            this.AnswerQuest.BackColor = System.Drawing.Color.White;
            this.AnswerQuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerQuest.Enabled = false;
            this.AnswerQuest.FormattingEnabled = true;
            this.AnswerQuest.HorizontalScrollbar = true;
            this.AnswerQuest.ItemHeight = 20;
            this.AnswerQuest.Location = new System.Drawing.Point(183, 97);
            this.AnswerQuest.Name = "AnswerQuest";
            this.AnswerQuest.Size = new System.Drawing.Size(114, 142);
            this.AnswerQuest.TabIndex = 13;
            this.AnswerQuest.DoubleClick += new System.EventHandler(this.questText_DoubleClick);
            this.AnswerQuest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AnswerQuest_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Depth = 0;
            this.checkBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox1.Location = new System.Drawing.Point(3, 18);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Ripple = true;
            this.checkBox1.Size = new System.Drawing.Size(132, 30);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Input manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grafDir
            // 
            this.grafDir.Depth = 0;
            this.grafDir.Hint = "";
            this.grafDir.Location = new System.Drawing.Point(10, 54);
            this.grafDir.MaxLength = 32767;
            this.grafDir.MouseState = MaterialSkin.MouseState.HOVER;
            this.grafDir.Name = "grafDir";
            this.grafDir.PasswordChar = '\0';
            this.grafDir.SelectedText = "";
            this.grafDir.SelectionLength = 0;
            this.grafDir.SelectionStart = 0;
            this.grafDir.Size = new System.Drawing.Size(113, 28);
            this.grafDir.TabIndex = 8;
            this.grafDir.TabStop = false;
            this.grafDir.UseSystemPasswordChar = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Depth = 0;
            this.checkBox2.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox2.Location = new System.Drawing.Point(3, 21);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Ripple = true;
            this.checkBox2.Size = new System.Drawing.Size(132, 30);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Input manual";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // fileDir
            // 
            this.fileDir.Depth = 0;
            this.fileDir.Hint = "";
            this.fileDir.Location = new System.Drawing.Point(8, 58);
            this.fileDir.MaxLength = 32767;
            this.fileDir.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileDir.Name = "fileDir";
            this.fileDir.PasswordChar = '\0';
            this.fileDir.SelectedText = "";
            this.fileDir.SelectionLength = 0;
            this.fileDir.SelectionStart = 0;
            this.fileDir.Size = new System.Drawing.Size(114, 28);
            this.fileDir.TabIndex = 16;
            this.fileDir.TabStop = false;
            this.fileDir.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Depth = 0;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(118, 46);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = true;
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Depth = 0;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(222, 45);
            this.button3.MouseState = MaterialSkin.MouseState.HOVER;
            this.button3.Name = "button3";
            this.button3.Primary = true;
            this.button3.Size = new System.Drawing.Size(66, 36);
            this.button3.TabIndex = 16;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Depth = 0;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(222, 48);
            this.button2.MouseState = MaterialSkin.MouseState.HOVER;
            this.button2.Name = "button2";
            this.button2.Primary = true;
            this.button2.Size = new System.Drawing.Size(66, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Depth = 0;
            this.button4.Icon = null;
            this.button4.Location = new System.Drawing.Point(118, 48);
            this.button4.MouseState = MaterialSkin.MouseState.HOVER;
            this.button4.Name = "button4";
            this.button4.Primary = true;
            this.button4.Size = new System.Drawing.Size(91, 36);
            this.button4.TabIndex = 18;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.Depth = 0;
            this.button5.Icon = null;
            this.button5.Location = new System.Drawing.Point(134, 148);
            this.button5.MouseState = MaterialSkin.MouseState.HOVER;
            this.button5.Name = "button5";
            this.button5.Primary = true;
            this.button5.Size = new System.Drawing.Size(31, 36);
            this.button5.TabIndex = 20;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Depth = 0;
            this.button6.Icon = null;
            this.button6.Location = new System.Drawing.Point(12, 125);
            this.button6.MouseState = MaterialSkin.MouseState.HOVER;
            this.button6.Name = "button6";
            this.button6.Primary = true;
            this.button6.Size = new System.Drawing.Size(95, 36);
            this.button6.TabIndex = 20;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 537);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grafPanel);
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel grafPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox AnswerQuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox grafText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox questText;
        private MaterialSkin.Controls.MaterialCheckBox checkBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField grafDir;
        private MaterialSkin.Controls.MaterialSingleLineTextField fileDir;
        private MaterialSkin.Controls.MaterialCheckBox checkBox2;
        private MaterialSkin.Controls.MaterialRaisedButton button3;
        private MaterialSkin.Controls.MaterialRaisedButton button1;
        private MaterialSkin.Controls.MaterialRaisedButton button5;
        private MaterialSkin.Controls.MaterialRaisedButton button2;
        private MaterialSkin.Controls.MaterialRaisedButton button4;
        private MaterialSkin.Controls.MaterialRaisedButton button6;
    }
}

