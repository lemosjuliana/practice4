namespace Practice2
{
    public class Product
    {
        private string _name;
        private string _productId;
        private double _priceProduct;
        private int _quantityProduct;

        public Product(string name, string productId, double priceProduct, int quantityProduct)
    {
        _name = name;
        _productId = productId;
        _priceProduct = priceProduct;
        _quantityProduct = quantityProduct;
    }

     public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

     public double GetPriceProduct()
    {
        return _priceProduct;
    }

     public int GetQuantityProduct()
    {
        return _quantityProduct;
    }

     public string GetProductDetails()
    {
        return $"Name: {_name}; ID: {_productId}; Price: {_priceProduct}; Quantity: {_quantityProduct}.";
    }

    }
}