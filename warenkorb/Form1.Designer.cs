namespace warenkorb
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ProduktLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(221, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(292, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // ProduktLabel
            // 
            this.ProduktLabel.AutoSize = true;
            this.ProduktLabel.Location = new System.Drawing.Point(137, 183);
            this.ProduktLabel.Name = "ProduktLabel";
            this.ProduktLabel.Size = new System.Drawing.Size(68, 20);
            this.ProduktLabel.TabIndex = 2;
            this.ProduktLabel.Text = "Produkt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProduktLabel);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form1";
            this.Text = "Bestellungen erfassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label ProduktLabel;
    }
}

