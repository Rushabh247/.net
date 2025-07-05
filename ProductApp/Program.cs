namespace ProductApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Wireless Mouse", 25.99, 10);

            
            Product product2 = new Product(102, "Bluetooth Speaker", 49.99, 15);

           
            product1.DisplayDetails();
            product2.DisplayDetails();
        }
    }
}
