namespace ShoppingCart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shopping Cart");

            Console.Write("Enter Customer ID: ");
            int custId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            string custName = Console.ReadLine();

            Customer customer = new Customer(custId, custName);

            Console.Write("Enter Order ID: ");
            int orderId = Convert.ToInt32(Console.ReadLine());

            Order order = new Order(orderId);

            Console.Write("Enter Number of Products: ");
            int productCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"\n--- Product #{i + 1} ---");

                Console.Write("Product ID: ");
                int pid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Product Name: ");
                string pname = Console.ReadLine();

                Console.Write("Product Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Discount (%): ");
                double discount = Convert.ToDouble(Console.ReadLine());

                Product product = new Product(pid, pname, price, discount);

                Console.Write("Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                LineItem item = new LineItem(100 + i, qty, product);
                order.AddItem(item);
            }

            customer.AddOrder(order);

            // Display all details here (no separate method)
            foreach (var ord in customer.Orders)
            {
                Console.WriteLine($"\nCustomer ID: {customer.Id}, Name: {customer.Name}");
                Console.WriteLine($"Order ID: {ord.Id}, Date: {ord.Date}");

                Console.WriteLine("\nID\tName\tQty\tPrice\tDiscounted\tTotal");
                foreach (var li in ord.LineItems)
                {
                    double discounted = li.Product.CalculateDiscountedPrice();
                    double total = li.CalculateLineItemCost();

                    Console.WriteLine($"{li.Product.Id}\t{li.Product.Name}\t{li.Quantity}\t{li.Product.Price}\t{discounted:0.00}\t\t{total:0.00}");
                }

                Console.WriteLine($"\nTotal Order Cost: ₹{ord.CalculateOrderPrice():0.00}");
            }


        }
    }
}
