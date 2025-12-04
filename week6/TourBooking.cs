using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public class TourBooking
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public int DurationInDays { get; set; }
        public bool IsInternational { get; set; }

        public TourBooking(string customerName, string destination, double price, int durationInDays, bool isInternational)
        {
            CustomerName = customerName;
            Destination = destination;
            Price = price;
            DurationInDays = durationInDays;
            IsInternational = isInternational;
        }

        public override string ToString()
        {
            string tourType = IsInternational ? "International" : "Domestic";
            return $"{CustomerName} | {Destination} ({tourType}) | Rs. {Price:F2} | {DurationInDays} days";
        }
    }

    // Transformed TourSummary class for report
    public class TourSummary
    {
        public string CustomerName { get; set; }
        public string Destination { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }

        public TourSummary(string customerName, string destination, string category, double price)
        {
            CustomerName = customerName;
            Destination = destination;
            Category = category;
            Price = price;
        }

        public override string ToString()
        {
            return $"Customer: {CustomerName,-20} | Destination: {Destination,-20} | Category: {Category,-15} | Price: Rs. {Price,10:F2}";
        }
    }
}