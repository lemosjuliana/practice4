namespace Practice2
{
    public class Order
    {
        private string _customer;
        private Address _address;
        private int _orderNumber;
        public List<Product> _product = new List<Product>();  
    }

    public Order()
    {

    }

    public void SetOrderNumber(int orderNumber)
    {
        _orderNumber = orderNumber;
    }

    public void SetCustomerName(string customer)
    {
        _customer = customer;
    }

    public void AddOrder(Product product)
    {
        _product.Add(product);
    }
    public List<Product> GetProducts()
    {
        return _product;
    }
    internal void SetAddressOrder(Address address)
    {
        _address = address;
    }
    internal Address GetAddressOrder()
    {
        return _address;
    }

    public string PackingLabel()
    {
        double totalCost = 0;
        string listPack = "***************** PACKING **********************" + Environment.NewLine; 
        listPack += $"{this._customer} / Order Number: {this._orderNumber}" + Environment.NewLine;
        foreach (Product product in this._product)
        {
            double priceProduct = product.GetPriceProduct();
            double quantityProduct = product.GetQuantityProduct();
            string productId = product.GetProductId();
            string name = product.GetName();
            double finalPrice =  priceProduct * quantityProduct;
            totalCost = totalCost + finalPrice;
            listPack += $"Quantity Product: {quantityProduct} ID: {productId} Final Price: ${finalPrice.ToString()}" + Environment.NewLine;
        }
        listPack += $"Total: ${totalCost.ToString("0.00")}";
        return listPack;
    }
    public string ShippingLabel()
    {
        string listShip = "***************** SHIPPING **********************" + Environment.NewLine; 
        listShip += $"{this._customer}" + Environment.NewLine; 
        listShip += _address.getAddress() + Environment.NewLine; 
        return listShip;
    }




    
}