using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWebshop.Model
{
    public class Customer
    {
        public int CustomerID { get; set; } // Primærnøgle
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetName { get; set; }
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }

        public List<Order> Orders { get; set; } = new(); // Navigation til ordrer

       
    }
}
