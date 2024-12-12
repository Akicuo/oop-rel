using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warenkorb
{
    public partial class Form1 : Form
    {

        public List<OrderItem> orderItems = new List<OrderItem>();
        public int inBasket = 0;
        public Form1()
        {
            InitializeComponent();

            
             




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
                Product p = new Product();
                p.Name = reader["product_name"].ToString();
                p.Price = double.Parse(reader["price"].ToString());

                ProductChoiceCB.Items.Add(p);
                
            }

            show_c_form(0);
            

        }
        public void show_c_form(byte c)
        {
            // show_c_form = Show Certain Form using a byte var to decide between two

            // to show 'Warenkorb' use 1
            // to show 'Choices' use 0

            bool c2;
            if (c == 0) c2 = false;
            else c2 = true;

            WarenkorbV2.Visible = c2;
            labelGesammtSumme.Visible = c2;
            CancelButton.Visible = c2;
            ResultSCTB.Visible = c2;

            c2 = !c2; // use opposite value 

            ProduktLabel.Visible = c2;
            AmountLabel.Visible = c2;
            ProductChoiceCB.Visible = c2;
            AmountDUD.Visible = c2;
            SubmitButton.Visible = c2;
            WarenkorbIcon.Visible = c2;
            linkLabel1.Visible = c2;
            AmountTB.Visible = c2;
        }

        
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel1.Text == "Warenkorb anzeigen")
            {
                show_c_form(1);
                Update_Cart_Textbox();
                Update_Total_Cost();
                


            }

        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            show_c_form(0);
        }
        

        private void Update_Cart_Textbox()
        {
            ResultSCTB.Text = string.Empty;
            
            ResultSCTB.Text += "Product Name\t\tAmount\t\tPrice\r\n";

            foreach (var orderItem in orderItems)
            {
                string spacing = "\t\t\t";
                if (orderItem.Product.Name.ToString().Length >= 8) { spacing = "\t\t"; }
                if (orderItem.Product.Name.ToString().Length >= 16) { spacing = "\t\t"; }
                if (orderItem.Product.Name.ToString().Length >= 20) { spacing = "\t"; }
                if (orderItem.Product.Name.ToString().StartsWith("Bio")) { spacing += "\t"; }
                ResultSCTB.Text += $"{orderItem.Product.Name}{spacing}{orderItem.Quantity}\t\t{orderItem.GetAmount()}\r\n";
            }
        }
        private void Update_Total_Cost()
        {
            double total = 0;
            foreach (var item in orderItems) {
                total += item.GetAmount();
                    }
            labelGesammtSumme.Text = $"Gesamtsumme: {total}";
        }





        private void SubmitButton_Click(object sender, EventArgs e)
        {


            if (ProductChoiceCB.SelectedItem == null)
            {
                return;
            }


            
                OrderItem orderItem = new OrderItem();
                // MessageBox.Show("1");



                orderItem.Product = (Product)ProductChoiceCB.SelectedItem;
                orderItem.Quantity = int.Parse(AmountDUD.Value.ToString());
                // MessageBox.Show("2");

                foreach (OrderItem item in orderItems)
                {
                    if (item.Product.Name == orderItem.Product.Name)
                    {
                        if (int.Parse(AmountDUD.Value.ToString()) == 0)
                        {
                            inBasket--;
                            AmountTB.Text = $"({inBasket})";
                            orderItems.Remove(item);

                        }
                    item.Quantity = orderItem.Quantity;
                        return;
                    }
                }
                    // will continue below if no if statement is reached
                    orderItems.Add(orderItem);
                    inBasket++;


                    AmountTB.Text = $"({inBasket})";
                }
            

        private void AmountDUD_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
    }

