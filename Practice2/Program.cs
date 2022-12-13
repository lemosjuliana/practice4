using System;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();

            //Customer
            Address peter = new Address();
            peter.setAddress("221 B Baker Street", "London", "UK", "England");

            Address lucy = new Address();
            lucy.setAddress("555 Main Street", "Miami", "Florida", "USA");

            
            //  Order
            Product usaOrder = new Product();
            usaOrder.name("USA Order");
            usaOrder.priceProduct(5.00);
            usaOrder.productId("usa");
            usaOrder.quantityProduct(1);

            Product internationalOrder = new Product();
            internationalOrder.name("International Order");
            internationalOrder.priceProduct(5.00);
            internationalOrder.productId("int");
            internationalOrder.quantityProduct(1);


            // Products
            Product mirror = new Product();
            mirror.name("mirror");
            mirror.priceProduct(20.00);
            mirror.productId("mir001");
            mirror.quantityProduct(1);
            
            Product chair = new Product();
            chair.name("chair");
            chair.priceProduct(80.00);
            chair.productId("cha002");
            chair.quantityProduct(4);

            Product pillow = new Product();
            pillow.name("pillow");
            pillow.priceProduct(20.00);
            pillow.productId("pil003");
            pillow.quantityProduct(1);
            
            Product headphones = new Product();
            headphones.name("headphones");
            headphones.priceProduct(20.00);
            headphones.productId("hea004");
            headphones.quantityProduct(1);


            // Orders
            Order order1 = new Order(); 
            order1.SetOrderNumber(001);           
            order1.SetCustomerName("Peter");
            order1.SetAddressOrder(peter);
           
            order1.AddOrder(mirror);
            order1.AddOrder(chair);

            Order order2 = new Order(); 
            order2.SetOrderNumber(002);           
            order2.SetCustomerName("Lucy");
            order2.SetAddressOrder(lucy);
           
            order2.AddOrder(pillow);
            order2.AddOrder(headphones);                      

            orderList.Add(order1);
            orderList.Add(order2);

            foreach (Order order in orderList)
            {
                Address orderAddress = order.GetOrderAddress();
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
