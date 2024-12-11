namespace worttabelle
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
            this.InputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.CountButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(138, 13);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(461, 89);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.AcceptsReturn = true;
            this.OutputTextbox.Location = new System.Drawing.Point(149, 112);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.ReadOnly = true;
            this.OutputTextbox.Size = new System.Drawing.Size(532, 255);
            this.OutputTextbox.TabIndex = 2;
            this.OutputTextbox.TextChanged += new System.EventHandler(this.OutputTextbox_TextChanged);
            // 
            // CountButton
            // 
            this.CountButton.Location = new System.Drawing.Point(618, 38);
            this.CountButton.Name = "CountButton";
            this.CountButton.Size = new System.Drawing.Size(115, 39);
            this.CountButton.TabIndex = 3;
            this.CountButton.Text = "Count";
            this.CountButton.UseVisualStyleBackColor = true;
            this.CountButton.Click += new System.EventHandler(this.CountButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountButton);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputBox);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Button CountButton;
        private System.Windows.Forms.Label label2;
    }
}

