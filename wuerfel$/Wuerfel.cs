using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _sdberbe
{
    public class Wuerful
    {
        public Random rnd = new Random();

        public int Werfen()
        {


            return rnd.Next(1, 6);

        }
    }
}
