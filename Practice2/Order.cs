using System.Text;

namespace Practice2
{
    
    public class Order
    {
        private Customer _customer;
        public List<Product> _products;
        private int _orderNumber;
        private double _subtotal;
        private double _shipping;


        public Order(Customer customer)
        {
            _products = new List<Product>();
            _customer = customer;
            _orderNumber = OrderNumberGenerator.NewOrderNumber();
            _shipping = customer.IsLocationUsa() ? 5 : 35;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
            _subtotal += product.GetTotalPrice();
        }
        
        public List<Product> GetProducts()
        {
            return _products;
        }
        
        public Address GetShippingAddress()
        {
            return _customer.Address;
        }

        public string PackingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("==================================================");
            label.AppendLine($"ORDER: {_orderNumber}");
            label.AppendLine("==================================================");
            foreach (Product product in _products)
            {
                label.AppendLine($"# {product.GetName()} Id: {product.GetId()} Price: {product.GetTotalPrice():C}");
            }
            label.AppendLine("--------------------------------------------------");
            label.AppendLine($"SubTotal: {_subtotal:C}");
            label.AppendLine($"Shipping: {_shipping:C}");
            label.Append($"Total: {_subtotal + _shipping:C}");
            return label.ToString();
        }
        
        public string ShippingLabel()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine("------------------ SHIPPING ----------------------");
            label.AppendLine($"Customer Name: {_customer.Name}");
            label.Append($"{_customer.Address.GetAddress()}");
            return label.ToString();
        }

       

    }


    
}