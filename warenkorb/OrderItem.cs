using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warenkorb
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double GetAmount()
        {
            return Product.Price * Quantity;
        }
    }
}
