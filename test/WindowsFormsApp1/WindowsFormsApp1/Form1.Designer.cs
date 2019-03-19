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
            this.grafDir = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grafText = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fileDir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.questText = new System.Windows.Forms.RichTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.AnswerQuest = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
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
            this.grafPanel.Location = new System.Drawing.Point(9, 108);
            this.grafPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grafPanel.Name = "grafPanel";
            this.grafPanel.Size = new System.Drawing.Size(491, 541);
            this.grafPanel.TabIndex = 0;
            // 
            // grafDir
            // 
            this.grafDir.Location = new System.Drawing.Point(9, 59);
            this.grafDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grafDir.Name = "grafDir";
            this.grafDir.Size = new System.Drawing.Size(121, 26);
            this.grafDir.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.grafDir);
            this.groupBox2.Location = new System.Drawing.Point(507, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(326, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Graf";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grafText);
            this.panel1.Location = new System.Drawing.Point(9, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 153);
            this.panel1.TabIndex = 11;
            // 
            // grafText
            // 
            this.grafText.BackColor = System.Drawing.Color.White;
            this.grafText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grafText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grafText.Location = new System.Drawing.Point(0, 0);
            this.grafText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grafText.Name = "grafText";
            this.grafText.ReadOnly = true;
            this.grafText.Size = new System.Drawing.Size(308, 151);
            this.grafText.TabIndex = 7;
            this.grafText.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 25);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Input manual";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileDir
            // 
            this.fileDir.Location = new System.Drawing.Point(10, 60);
            this.fileDir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fileDir.Name = "fileDir";
            this.fileDir.Size = new System.Drawing.Size(121, 26);
            this.fileDir.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.AnswerQuest);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.fileDir);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(507, 360);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(326, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Pertanyaan";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.questText);
            this.panel2.Location = new System.Drawing.Point(10, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 182);
            this.panel2.TabIndex = 15;
            // 
            // questText
            // 
            this.questText.BackColor = System.Drawing.Color.White;
            this.questText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questText.Location = new System.Drawing.Point(0, 0);
            this.questText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.questText.Name = "questText";
            this.questText.ReadOnly = true;
            this.questText.Size = new System.Drawing.Size(127, 180);
            this.questText.TabIndex = 13;
            this.questText.Text = "";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 26);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 24);
            this.checkBox2.TabIndex = 14;
            this.checkBox2.Text = "Input manual";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // AnswerQuest
            // 
            this.AnswerQuest.BackColor = System.Drawing.Color.White;
            this.AnswerQuest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerQuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnswerQuest.Enabled = false;
            this.AnswerQuest.FormattingEnabled = true;
            this.AnswerQuest.ItemHeight = 20;
            this.AnswerQuest.Location = new System.Drawing.Point(188, 96);
            this.AnswerQuest.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AnswerQuest.Name = "AnswerQuest";
            this.AnswerQuest.Size = new System.Drawing.Size(128, 182);
            this.AnswerQuest.TabIndex = 13;
            this.AnswerQuest.DoubleClick += new System.EventHandler(this.questText_DoubleClick);
            this.AnswerQuest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AnswerQuest_MouseDoubleClick);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(143, 170);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(43, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "=>";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 59);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 29);
            this.button4.TabIndex = 8;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.Location = new System.Drawing.Point(18, 612);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 29);
            this.button6.TabIndex = 4;
            this.button6.Text = "Refresh Graf";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 656);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grafPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            this.TopMost = true;
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
        private System.Windows.Forms.TextBox grafDir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox fileDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox AnswerQuest;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox grafText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox questText;
    }
}

