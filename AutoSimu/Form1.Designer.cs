namespace _sdberbe
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
            this.rollButton = new System.Windows.Forms.Button();
            this.CurrentRoll = new System.Windows.Forms.Label();
            this.LastRoll = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(42, 28);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(75, 49);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Würfeln";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrentRoll
            // 
            this.CurrentRoll.AutoSize = true;
            this.CurrentRoll.Location = new System.Drawing.Point(203, 42);
            this.CurrentRoll.Name = "CurrentRoll";
            this.CurrentRoll.Size = new System.Drawing.Size(18, 20);
            this.CurrentRoll.TabIndex = 1;
            this.CurrentRoll.Text = "?";
            // 
            // LastRoll
            // 
            this.LastRoll.AutoSize = true;
            this.LastRoll.Location = new System.Drawing.Point(38, 140);
            this.LastRoll.Name = "LastRoll";
            this.LastRoll.Size = new System.Drawing.Size(109, 20);
            this.LastRoll.TabIndex = 2;
            this.LastRoll.Text = "Letzer Wurf: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 222);
            this.Controls.Add(this.LastRoll);
            this.Controls.Add(this.CurrentRoll);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label CurrentRoll;
        private System.Windows.Forms.Label LastRoll;
    }
}

