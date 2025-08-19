using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseWebshop.Model
{
    public class Order : Customer
    {
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }

        public int CustomerID { get; set; } // Fremmednøgle
        public Customer Customer { get; set; } // Navigation til Customer


    }
}
