using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWebshop.Model
{
    internal class PointSystem
    {
        public int PointID { get; set; }
        public int OrderID { get; set; }
        public int PointTransaction { get; set; }

        public int PointBalance { get; set; }

        public PointSystem(int pointId, int orderId, int pointTransaction, int pointBalance)
        {
            PointID = pointId;
            OrderID = orderId;
            PointTransaction = pointTransaction;
            PointBalance = pointBalance;
        }
        public void AddPoints(int points)
        {
            PointTransaction = points;
            PointBalance += points;
        }
        
        public bool UsePoints(int points)
        {
            if (points <= 0 || PointBalance < points) return false;
            PointTransaction = -points;
            PointBalance -= points;
            return true;
        }
    }
}
