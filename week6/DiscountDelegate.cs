using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4.week6
{
    public delegate double DiscountStrategy(double price);

    // Class containing discount methods and pricing logic
    public class PricingService
    {
        // Festival Discount: 20% off
        public static double FestivalDiscount(double price)
        {
            double discount = price * 0.20; // 20% discount
            return price - discount;
        }

        // Seasonal Discount: 10% off
        public static double SeasonalDiscount(double price)
        {
            double discount = price * 0.10; // 10% discount
            return price - discount;
        }

        // No Discount: returns price as it is
        public static double NoDiscount(double price)
        {
            return price;
        }

        // Method that calculates final price using a discount strategy
        public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        {
            // Apply the discount strategy and return the final price
            return strategy(originalPrice);
        }
    }
}