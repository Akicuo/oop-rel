using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worttabelle
{
    public partial class Form1 : Form
    {
        WordTab wordTab = new WordTab();
        public Form1()
        {
            InitializeComponent();
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            if (InputBox.Text == "")
            {
                MessageBox.Show("Please have some text inside the string");
                return;
            }

            /* Will continue under this if the action above is not true */
            string[] words = InputBox.Text.Split(' ');
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
                wordTab.AddWord(word);
            }
            wordTab.PrintTab(OutputTextbox);




        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputTextbox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
