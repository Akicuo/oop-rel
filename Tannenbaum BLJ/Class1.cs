using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum_BLJ
{
    public class Tanne
    {
        public int Stammbreite { get; set; }
        public int Stammhoehe { get; set; }
        public int Kronenhoehe { get; set; }
        private string zeichnung;

        public string getZeichnung
        {
            get { return zeichnung; }
            private set { zeichnung = value; }
        }

        public void Zeichne()
        {
            zeichnung = string.Empty;
            int breite_krone = Kronenhoehe * 2 - 1;

            for (int i = 1; i <= Kronenhoehe; i++)
            {
                int links_space_count = (breite_krone - (i * 2 - 1)) / 2;
                if (links_space_count < 0) links_space_count = 0;
                string links_space = new string(' ', links_space_count);
                string sternchen = new string('*', i * 2 - 1);
                zeichnung += links_space + sternchen + Environment.NewLine;
            }
            int stamm_space_count = (breite_krone - Stammbreite) / 2;
            if (stamm_space_count < 0) stamm_space_count = 0;
            string stamm_space = new string(' ', stamm_space_count);
            for (int i = 0; i < Stammhoehe; i++)
            {
                zeichnung += (stamm_space + new string('*', Stammbreite)) + Environment.NewLine;
            }
        }
    }
}
