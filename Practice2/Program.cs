using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();

            // Customers
            Customer peter = new Customer("Peter", new Address("221 B Baker Street", "London", "UK", "England"));
            Customer lucy = new Customer("Lucy", new Address("555 Main Street", "Miami", "Florida", "USA"));

            // Products
            Product mirror = new Product("mirror", "mir001", 20.00, 1);
            Product chair = new Product("chair", "cha002", 80.00, 4);
            Product pillow = new Product("pillow", "pil003", 10.00, 1);
            Product headphones = new Product("headphones", "hea004", 40.00, 2);

            // Orders
            Order order1 = new Order(peter); 
            order1.AddProduct(mirror);           
            order1.AddProduct(chair);                     

            Order order2 = new Order(lucy); 
            order2.AddProduct(mirror);           
            order2.AddProduct(chair);                     

            // 
            orders.Add(order1);
            orders.Add(order2);

            foreach (Order order in orders)
            {
                Console.WriteLine(order.PackingLabel());
                Console.WriteLine();
                Console.WriteLine(order.ShippingLabel());
                Console.WriteLine();
            }

        }
    }
}
