using System;
using System.Windows.Forms;

namespace _sdberbe
{

    
    
    public partial class Form1 : Form
    {
        Wuerful mt = new Wuerful();
        int prevRoll = -1;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {


            int currentRoll = mt.Werfen();

            while (currentRoll == prevRoll)
            {
                currentRoll = mt.Werfen();
            }
             CurrentRoll.Text = currentRoll.ToString();

            if (currentRoll != prevRoll)
            {
                if (prevRoll != -1)
                {
                    LastRoll.Text = "Letzter Wurf: " + prevRoll;
                }

                prevRoll = currentRoll;
            }
        }
    }
    
}