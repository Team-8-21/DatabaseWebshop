using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseWebshop.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }

        public int CustomerID { get; set; } // Fremmednøgle

        // public Customer customer { get; set; } En anden mulighed, men henter en HEL Customer Object og kan være overflødigt. 



    }
}
