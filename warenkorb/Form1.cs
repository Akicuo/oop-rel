using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            List<Product> Productslist = new List<Product>();



            // Verbindung zur Datenbank herstellen
            string connectionString = "Server=mssql1.webland.ch;Database=d041e_blj;User Id=d041e_blj;Password=BljDbPw_01;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Abfrage vorbereiten
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "select * from products";

            // Abfrage ausführen 
            SqlDataReader reader = command.ExecuteReader();



            while (reader.Read())
            {
                linkLabel1.Text += reader.NextResult().ToString();
                Product p = new Product();
                p.Name = reader["product_name"].ToString();
                // p.Price = double.Parse(reader["product_price"].ToString());
                // p.Id = int.Parse(reader["product_id"].ToString());
                Productslist.Add(p);
                // etc ...
            }
            foreach (Product p in Productslist) {

                ProductChoiceCB.Items.Add(p.Name);
                    }
            show_form();

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

        private void WarenkorbV2_Click(object sender, EventArgs e)
        {

        }
    }
    }

