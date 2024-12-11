using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FIFO_Puffer
{
    public class Auto
    {
        public int AktuelleGeschwindigkeit { get; set; }
        public int AktuellerGang { get; set; }
        public bool IstMotorGestartet { get; set; }
        public string Marke { get; set; }
        public int PS { get; set; }
        public int TankFuellstand { get; set; }

        public Auto(string marke, int ps)
        {
            Marke = marke;
            PS = ps; 
        }

        public void Auftanken()
        {
            if (IstMotorGestartet) { return; }
            if (TankFuellstand <= 95)
            {
                TankFuellstand += 5;
            }
        }

        public void Bremse()
        {
            if (AktuelleGeschwindigkeit > 0)
            {
                AktuelleGeschwindigkeit -= 5 * (PS / 50);
            }
        }



        public void GibGas()
        {
           

            if (!IstMotorGestartet)
            {
                MessageBox.Show("Der Motor ist nicht gestartet.");
                return;
            }


            int maxGeschwindigkeit = PS * 2;  

           
            if (AktuelleGeschwindigkeit >= maxGeschwindigkeit)
            {
                AktuelleGeschwindigkeit = maxGeschwindigkeit;
                MessageBox.Show("Maximale Geschwindigkeit erreicht.");
                return;
            }


            AktuelleGeschwindigkeit += 5 * (PS / 50);
            TankFuellstand -= 5;
            if (TankFuellstand <= 0)
    {
        TankFuellstand = 0;
        AktuelleGeschwindigkeit = 0;
        AktuellerGang = 1;
        SchalteMotorAus();
        

        
    }

            if (TankFuellstand <= 0)
            {
                TankFuellstand = 0;
                AktuelleGeschwindigkeit = 0;
                AktuellerGang = 1;
                SchalteMotorAus();

                
            }


        }

        public void Hupe()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"c:\Hupe.wav");
            player.Play();
        }

        public void SchalteMotorAus()
        {
            IstMotorGestartet = false;
        }

        public void StarteMotor()
        {
            IstMotorGestartet = true;
            
        }

        public override string ToString() => Marke;
    }
}