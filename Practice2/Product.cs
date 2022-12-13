namespace Practice2
{
    public class Product
    {
        private string _name;
        private string _id;
        private double _totalPrice;
        private int _quantity;

        public Product(string name, string id, double price, int quantity)
        {
            // Sanity check...
            if (quantity < 1)
            {
                throw new InvalidDataException("There is no such thing as quantity equals ZERO.");
            }
            _name = name;
            _id = id;
            _quantity = quantity;
            _totalPrice = price * quantity;

        }

        public string GetName()
        {
            return _name;
        }

        public string GetId()
        {
            return _id;
        }

        public double GetTotalPrice()
        {
            return _totalPrice;
        }

        public double GetUnitPrice()
        {
            return _totalPrice / _quantity;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public string GetDetails()
        {
            return $"Name: {_name}; ID: {_id}; Price: {_totalPrice}; Quantity: {_quantity}.";
        }

    }
}