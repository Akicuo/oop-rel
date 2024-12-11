using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worttabelle
{
    public class WordTab
    {
        Dictionary<string, int> words = new Dictionary<string, int>();
        public string tab;
        public void AddWord(string word)
        {
            if (words.ContainsKey(word))
            {
                words[word] += 1;
            }
            else
            {
                words.Add(word, 1);
            }


        }

        public string GetTab()
        {
            tab = "Wort\t\tAnzahl\r\n--------------------------------------------\r\n";
            foreach (KeyValuePair<string, int> entry in words)
            {
                tab += $"{entry.Key}\t\t{entry.Value}\r\n";
            }
            return tab;

        }
        public void PrintTab(TextBox textBox)
        {
            textBox.Text = GetTab();
        }
    }
}
