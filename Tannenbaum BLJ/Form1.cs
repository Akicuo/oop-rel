using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tannenbaum_BLJ
{

    public partial class Form1 : Form
    {
        static bool ContainsNonNumeric(string input)
        {
            
            return input.Any(c => !char.IsDigit(c));
        }
        Tanne t = new Tanne();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // "Tanne zeichnen" button
            if (ContainsNonNumeric(textBox2.Text) || ContainsNonNumeric(textBox3.Text) || ContainsNonNumeric(textBox4.Text))
            {
                MessageBox.Show("Inputx can only contain numbers");
                textBox2.Text = "";
                return;
            }
            t.Stammbreite = int.Parse(textBox2.Text);
            t.Stammhoehe = int.Parse(textBox3.Text);
            t.Kronenhoehe = int.Parse(textBox4.Text);
            t.Zeichne();
            textBox1.Text = t.getZeichnung.ToString();


        }

       
    }
}
