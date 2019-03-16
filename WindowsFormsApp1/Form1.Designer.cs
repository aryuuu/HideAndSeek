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
            this.grafPanel = new System.Windows.Forms.Panel();
            this.grafText = new System.Windows.Forms.RichTextBox();
            this.grafDir = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.questText = new System.Windows.Forms.RichTextBox();
            this.fileDir = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.answerText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grafPanel
            // 
            this.grafPanel.AccessibleName = "";
            this.grafPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grafPanel.AutoSize = true;
            this.grafPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grafPanel.Location = new System.Drawing.Point(12, 13);
            this.grafPanel.Name = "grafPanel";
            this.grafPanel.Size = new System.Drawing.Size(404, 443);
            this.grafPanel.TabIndex = 0;
            // 
            // grafText
            // 
            this.grafText.Location = new System.Drawing.Point(8, 51);
            this.grafText.Name = "grafText";
            this.grafText.ReadOnly = true;
            this.grafText.Size = new System.Drawing.Size(276, 161);
            this.grafText.TabIndex = 6;
            this.grafText.Text = "";
            // 
            // grafDir
            // 
            this.grafDir.Location = new System.Drawing.Point(8, 21);
            this.grafDir.Name = "grafDir";
            this.grafDir.Size = new System.Drawing.Size(108, 22);
            this.grafDir.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.grafDir);
            this.groupBox2.Controls.Add(this.grafText);
            this.groupBox2.Location = new System.Drawing.Point(422, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Graf";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // questText
            // 
            this.questText.Location = new System.Drawing.Point(8, 51);
            this.questText.Name = "questText";
            this.questText.ReadOnly = true;
            this.questText.Size = new System.Drawing.Size(117, 161);
            this.questText.TabIndex = 6;
            this.questText.Text = "";
            // 
            // fileDir
            // 
            this.fileDir.Location = new System.Drawing.Point(8, 21);
            this.fileDir.Name = "fileDir";
            this.fileDir.Size = new System.Drawing.Size(108, 22);
            this.fileDir.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(167, 49);
            this.answerText.Name = "answerText";
            this.answerText.ReadOnly = true;
            this.answerText.Size = new System.Drawing.Size(117, 161);
            this.answerText.TabIndex = 10;
            this.answerText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.answerText);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.fileDir);
            this.groupBox1.Controls.Add(this.questText);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(422, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Pertanyaan";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(127, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "=>";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(126, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Browse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grafPanel);
            this.Name = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel grafPanel;
        private System.Windows.Forms.RichTextBox grafText;
        private System.Windows.Forms.TextBox grafDir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox questText;
        private System.Windows.Forms.TextBox fileDir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox answerText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

