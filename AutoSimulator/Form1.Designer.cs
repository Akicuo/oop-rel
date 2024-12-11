namespace FIFO_Puffer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyEngineStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.StatusIndicator = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto wählen: ";
            // 
            // comboBoxAutos
            // 
            this.comboBoxAutos.FormattingEnabled = true;
            this.comboBoxAutos.Location = new System.Drawing.Point(123, 22);
            this.comboBoxAutos.Name = "comboBoxAutos";
            this.comboBoxAutos.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAutos.TabIndex = 1;
            this.comboBoxAutos.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutos_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "0 PS";
            // 
            // keyEngineStart
            // 
            this.keyEngineStart.Image = ((System.Drawing.Image)(resources.GetObject("keyEngineStart.Image")));
            this.keyEngineStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.keyEngineStart.Location = new System.Drawing.Point(16, 73);
            this.keyEngineStart.Name = "keyEngineStart";
            this.keyEngineStart.Size = new System.Drawing.Size(71, 71);
            this.keyEngineStart.TabIndex = 3;
            this.keyEngineStart.UseVisualStyleBackColor = true;
            this.keyEngineStart.Click += new System.EventHandler(this.keyEngineStart_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(16, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 67);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(16, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 74);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(474, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 121);
            this.button3.TabIndex = 6;
            this.button3.Text = "Gas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(344, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 121);
            this.button4.TabIndex = 7;
            this.button4.Text = "Bremse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(83, 133);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(325, 37);
            this.progressBar2.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.textBox1.ForeColor = System.Drawing.Color.Chartreuse;
            this.textBox1.Location = new System.Drawing.Point(30, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(242, 58);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(309, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(99, 58);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Location = new System.Drawing.Point(123, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 213);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(20, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 58);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // StatusIndicator
            // 
            this.StatusIndicator.BackColor = System.Drawing.Color.Crimson;
            this.StatusIndicator.ForeColor = System.Drawing.Color.DarkRed;
            this.StatusIndicator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusIndicator.Location = new System.Drawing.Point(67, 62);
            this.StatusIndicator.Name = "StatusIndicator";
            this.StatusIndicator.Size = new System.Drawing.Size(33, 37);
            this.StatusIndicator.TabIndex = 13;
            this.StatusIndicator.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 446);
            this.Controls.Add(this.StatusIndicator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keyEngineStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAutos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OOP - Auto (NLJ)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button keyEngineStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button StatusIndicator;
        private System.Windows.Forms.Button button5;
    }
}

