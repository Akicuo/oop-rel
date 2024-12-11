using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
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
        public Auto auto;
        public bool carSelected = true;

        public Form1()
        {
            InitializeComponent();
            
            
            comboBoxAutos.Items.Add(new Auto("Porsche", 250));
            comboBoxAutos.Items.Add(new Auto("Opel", 90));
            comboBoxAutos.Items.Add(new Auto("Ferrari", 370));

        }




        public void ChangeGearDependingOnSpeed()
        {
            int m = 1;
            if (auto.AktuelleGeschwindigkeit > -100 && auto.AktuelleGeschwindigkeit <= 10) // between -100 and 10
            {
                m = 1;
            } else if (auto.AktuelleGeschwindigkeit > 11 && auto.AktuelleGeschwindigkeit <= 20)
            {
                m = 2;
            }
            else if (auto.AktuelleGeschwindigkeit > 20 && auto.AktuelleGeschwindigkeit <= 40)
            {
                m = 3;
            }
            else if (auto.AktuelleGeschwindigkeit > 40 && auto.AktuelleGeschwindigkeit <= 70)
            {
                m = 4;
            }
            else if (auto.AktuelleGeschwindigkeit > 70 && auto.AktuelleGeschwindigkeit <= 100)
            {
                m = 5;
            }
            else if (auto.AktuelleGeschwindigkeit >= 101)
            {
                m = 6;
            }
            textBox2.Text = m.ToString();
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
            carSelected = true; 



            label2.Text = auto.PS + " PS";


        }

        private void keyEngineStart_Click(object sender, EventArgs e)
        {
            if (carSelected)
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
        public void tio()
        {
            StatusIndicator.BackColor = Color.Red;
        }






        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (carSelected)
                if (auto.IstMotorGestartet)
                {
                    auto.GibGas();
                    textBox1.Text = Convert.ToString(auto.AktuelleGeschwindigkeit);
                    progressBar2.Value = auto.TankFuellstand;
                    ChangeGearDependingOnSpeed();
                }
                
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (auto != null)
                if (auto.IstMotorGestartet)
                {
                    auto.Bremse();
                    textBox1.Text = Convert.ToString(auto.AktuelleGeschwindigkeit);
                    progressBar2.Value = auto.TankFuellstand;
                    ChangeGearDependingOnSpeed();
                }

                else
                {
                    MessageBox.Show("Bitte wählen Sie zuerst ein Auto aus.");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Lyan_Labaguis\source\repos\AutoSimulator\honk.wav");
            player.Play();
        }
    }
}












