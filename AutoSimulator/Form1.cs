using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIFO_Puffer
{
    public partial class Form1 : Form
    {
        public Auto auto = null;

        public Form1()
        {
            InitializeComponent();
            
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (auto != null) 
            {
                auto.Auftanken();
                progressBar2.Value = auto.TankFuellstand;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }
        }



        private void comboBoxAutos_SelectedIndexChanged_1(object sender, EventArgs e)
        {          
            auto = (Auto)comboBoxAutos.SelectedItem;
            UpdateUI();
        }

        private void keyEngineStart_Click(object sender, EventArgs e)
        {
            if (auto != null)
            { 
                if (auto.TankFuellstand != 0)
                {
                    if (!auto.IstMotorGestartet)
                    {
                        auto.StarteMotor();
                        StatusIndicator.BackColor = Color.Green;
                    }
                    else
                    {
                        auto.SchalteMotorAus();
                        StatusIndicator.BackColor = Color.Red;
                    }
                }
            }

            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (auto != null)
                if (auto.IstMotorGestartet)
                {
                    auto.GibGas();           
                }
                else
                {
                    MessageBox.Show("Der Motor ist nicht gestartet.");
                }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }

            UpdateUI();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (auto != null)
                if (auto.IstMotorGestartet)
                {
                    auto.Bremse();        
                }

                else
                {
                    MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
                }

            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream(Properties.Resources.honk);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(ms);
           
            player.Play();
        }

        private void UpdateUI()
        {
            if (auto != null)
            {
                textBox2.Text = auto.AktuellerGang.ToString();
                textBox1.Text = Convert.ToString(auto.AktuelleGeschwindigkeit);
                progressBar2.Value = auto.TankFuellstand;
                label2.Text = auto.PS + " PS";
            }
         

        }

    }
}












