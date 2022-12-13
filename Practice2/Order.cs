using System.Text;

namespace Practice2
{
    
    public class Order
    {
        private Customer _customer;
        private Address _shippingAddress;
        public List<Product> _products;
        private int _orderNumber;
        private double _totalCost;


        public Order(Customer customer, Address shippingAddress)
        {
            _products = new List<Product>();
            _customer = customer;
            _shippingAddress = shippingAddress;
            _orderNumber = OrderNumberGenerator.NewOrderNumber();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            _totalCost += product.GetTotalPrice();
        }
        
        public List<Product> GetProducts()
        {
            return _products;
        }
        
        public Address GetShippingAddress()
        {
            return _shippingAddress;
        }

        public string PackingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("****************** PACKING **********************");
            label.AppendLine($"Order Number: {_orderNumber}");
            label.AppendLine("*************************************************");
            foreach (Product product in _products)
            {
                label.AppendLine($"Name: {product.GetName()} ID: {product.GetId()} SubTotal: {product.GetTotalPrice():C}");
            }
            label.AppendLine("**************************************************");
            label.AppendLine($"Total Order: {_totalCost:C}");
            label.AppendLine("**************************************************");
            return label.ToString();
        }
        
        public string ShippingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("****************** SHIPPING **********************");
            label.AppendLine($"Customer Name: {_customer.Name}");
            label.AppendLine($"Customer Address: {_shippingAddress.GetAddress}");
            label.AppendLine("**************************************************");
            return label.ToString();
        }

       

    }


    
}