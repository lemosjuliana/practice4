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
            Order order1 = new Order(peter, new Address("221 B Baker Street", "London", "UK", "England")); 
            order1.AddProduct(mirror);           
            order1.AddProduct(chair);                     

            orderList.Add(order1);
            orderList.Add(order2);

            foreach (Order order in orders)
            {
                Address orderAddress = order.Address();
                if (orderAddress.USA() == true)
                {
                    order.AddOrder(usaOrder);
                }
                else
                {
                    order.AddOrder(intOrder);
                }

                string thisPackingLabel = order.PackingLabel();
                Console.WriteLine(thisPackingLabel);
                Console.WriteLine();

                string thisShippingLabel = order.ShippingLabel();
                Console.WriteLine(thisShippingLabel);
                Console.WriteLine();

        }
    }
}
