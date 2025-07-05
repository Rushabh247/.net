using System;

namespace ProductApp
{
    internal  class Product
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }

        // Constructor
        public Product(int id, string name, double price, double discountPercentage)
        {
            Id = id;
            Name = name;
            Price = price;
            DiscountPercentage = discountPercentage;
        }

        // Method to calculate price after discount
        public double GetPriceAfterDiscount()
        {
            return Price - (Price * DiscountPercentage / 100);
        }

        // Method to display details
        public void DisplayDetails()
        {
            Console.WriteLine("Product ID: " + Id);
            Console.WriteLine("Product Name: " + Name);
            Console.WriteLine("Original Price: $" + Price);
            Console.WriteLine("Discount: " + DiscountPercentage + "%");
            Console.WriteLine("Price After Discount: $" + GetPriceAfterDiscount());
            Console.WriteLine("--------------------------------------");
        }
    }
}
