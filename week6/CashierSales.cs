using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class CashierSales
    {
        public string CashierName { get; set; }
        public int CashierId { get; set; }
        public double DailySales { get; set; }

        public CashierSales(string cashierName, int cashierId, double dailySales)
        {
            CashierName = cashierName;
            CashierId = cashierId;
            DailySales = dailySales;
        }

        public override string ToString()
        {
            return $"Cashier #{CashierId}: {CashierName} - Rs. {DailySales:F2}";
        }
    }
}