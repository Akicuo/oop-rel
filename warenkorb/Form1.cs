using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warenkorb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 100; i++)
            {
                AmountDUD.Items.Add(i.ToString());
            }
        }
        public void show_form()
        {
            // first invisibilize the elements of the shopping cart page
            WarenkorbV2.Visible = false;
            labelGesamtSumme.Visible = false;
            CancelButton.Visible = false;
            ResultSCTB.Visible = false;
            // and visible the rest
            ProduktLabel.Visible = true;
            AmountLabel.Visible = true;
            ProductChoiceCB.Visible = true;
            AmountDUD.Visible = true;
            SubmitButton.Visible = true;
            WarenkorbIcon.Visible = true;
            linkLabel1.Visible = true;
            AmountTB.Visible = true;
        }

        public void show_sc()
        {
            // first visibilize the elements of the shopping cart page
            WarenkorbV2.Visible = true;
            labelGesamtSumme.Visible = true;
            CancelButton.Visible = true;
            ResultSCTB.Visible = true;

            // and invisible the rest
            ProduktLabel.Visible = false;
            AmountLabel.Visible = false;
            ProductChoiceCB.Visible = false;
            AmountDUD.Visible = false;
            SubmitButton.Visible = false;
            WarenkorbIcon.Visible = false;
            linkLabel1.Visible = false;
            AmountTB.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel1.Text == "Warenkorb anzeigen")
            {
                show_sc();
                
            }

        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            show_form();
        }


    }
    }

