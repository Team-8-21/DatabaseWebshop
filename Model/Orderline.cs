using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWebshop.Model
{
    internal class Orderline
    {
        public int ProduktID { get; set; }
        public int OrderID { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public bool OrderStatus; // true = paid, false = not paid

       // public Order order { get; set; }
        public Orderline(int produktId, int orderId, int amount, int price, bool orderStatus)
        {
            ProduktID = produktId;
            OrderID = orderId;
            Amount = amount;
            Price = price;
            OrderStatus = orderStatus;
        }

        public void TotalPrice(int price)
        {
            Price = price * Amount;
        }

        public void SetAmount(int amount)
        {
            Amount = amount;
        }
    }
}
