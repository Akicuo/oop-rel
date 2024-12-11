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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ProductChoiceCB = new System.Windows.Forms.ComboBox();
            this.ProduktLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.WarenkorbIcon = new System.Windows.Forms.Button();
            this.AmountTB = new System.Windows.Forms.Label();
            this.AmountDUD = new System.Windows.Forms.DomainUpDown();
            this.WarenkorbV2 = new System.Windows.Forms.Button();
            this.ResultSCTB = new System.Windows.Forms.TextBox();
            this.labelGesamtSumme = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductChoiceCB
            // 
            this.ProductChoiceCB.FormattingEnabled = true;
            this.ProductChoiceCB.Location = new System.Drawing.Point(225, 180);
            this.ProductChoiceCB.Name = "ProductChoiceCB";
            this.ProductChoiceCB.Size = new System.Drawing.Size(292, 28);
            this.ProductChoiceCB.TabIndex = 1;
            this.ProductChoiceCB.SelectedIndexChanged += new System.EventHandler(this.ProductChoiceCB_SelectedIndexChanged);
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
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(221, 228);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(58, 20);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Anzahl";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(343, 279);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(252, 54);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Zum Warenkorb hinzufügen";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(536, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(156, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Warenkorb anzeigen";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // WarenkorbIcon
            // 
            this.WarenkorbIcon.Enabled = false;
            this.WarenkorbIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarenkorbIcon.ForeColor = System.Drawing.Color.White;
            this.WarenkorbIcon.Image = ((System.Drawing.Image)(resources.GetObject("WarenkorbIcon.Image")));
            this.WarenkorbIcon.Location = new System.Drawing.Point(480, 25);
            this.WarenkorbIcon.Name = "WarenkorbIcon";
            this.WarenkorbIcon.Size = new System.Drawing.Size(50, 50);
            this.WarenkorbIcon.TabIndex = 7;
            this.WarenkorbIcon.UseVisualStyleBackColor = true;
            // 
            // AmountTB
            // 
            this.AmountTB.AutoSize = true;
            this.AmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.AmountTB.Location = new System.Drawing.Point(446, 40);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(28, 20);
            this.AmountTB.TabIndex = 8;
            this.AmountTB.Text = "(0)";
            // 
            // AmountDUD
            // 
            this.AmountDUD.Location = new System.Drawing.Point(307, 226);
            this.AmountDUD.Name = "AmountDUD";
            this.AmountDUD.Size = new System.Drawing.Size(120, 26);
            this.AmountDUD.TabIndex = 9;
            this.AmountDUD.Text = "0";
            // 
            // WarenkorbV2
            // 
            this.WarenkorbV2.Enabled = false;
            this.WarenkorbV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarenkorbV2.ForeColor = System.Drawing.Color.White;
            this.WarenkorbV2.Image = ((System.Drawing.Image)(resources.GetObject("WarenkorbV2.Image")));
            this.WarenkorbV2.Location = new System.Drawing.Point(28, 25);
            this.WarenkorbV2.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.WarenkorbV2.Name = "WarenkorbV2";
            this.WarenkorbV2.Size = new System.Drawing.Size(155, 116);
            this.WarenkorbV2.TabIndex = 10;
            this.WarenkorbV2.UseVisualStyleBackColor = true;
            this.WarenkorbV2.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResultSCTB
            // 
            this.ResultSCTB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultSCTB.Location = new System.Drawing.Point(28, 156);
            this.ResultSCTB.Multiline = true;
            this.ResultSCTB.Name = "ResultSCTB";
            this.ResultSCTB.Size = new System.Drawing.Size(641, 326);
            this.ResultSCTB.TabIndex = 11;
            this.ResultSCTB.TextChanged += new System.EventHandler(this.ResultSCTB_TextChanged);
            // 
            // labelGesamtSumme
            // 
            this.labelGesamtSumme.AutoSize = true;
            this.labelGesamtSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.labelGesamtSumme.Location = new System.Drawing.Point(58, 522);
            this.labelGesamtSumme.Name = "labelGesamtSumme";
            this.labelGesamtSumme.Size = new System.Drawing.Size(251, 30);
            this.labelGesamtSumme.TabIndex = 12;
            this.labelGesamtSumme.Text = "Gesamtsumme: 0.00";
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CancelButton.Location = new System.Drawing.Point(391, 514);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(236, 54);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Abrechen";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 608);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.labelGesamtSumme);
            this.Controls.Add(this.ResultSCTB);
            this.Controls.Add(this.WarenkorbV2);
            this.Controls.Add(this.AmountDUD);
            this.Controls.Add(this.AmountTB);
            this.Controls.Add(this.WarenkorbIcon);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ProduktLabel);
            this.Controls.Add(this.ProductChoiceCB);
            this.Name = "Form1";
            this.Text = "Bestellungen erfassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductChoiceCB;
        private System.Windows.Forms.Label ProduktLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button WarenkorbIcon;
        private System.Windows.Forms.Label AmountTB;
        private System.Windows.Forms.DomainUpDown AmountDUD;
        private System.Windows.Forms.Button WarenkorbV2;
        private System.Windows.Forms.TextBox ResultSCTB;
        private System.Windows.Forms.Label labelGesamtSumme;
        private System.Windows.Forms.Button CancelButton;
    }
}

