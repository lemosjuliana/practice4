using System;
namespace Practice2
{
    public class Customer 
    {
        private string _customerName;
        private string _customerCountry;

        public Customer
        {

        }

        public void SetCustumerCountry(string country)
        {
            _customerCountry = country;

        }

        public bool IsLocationUsa()
        {
            if (_customerCountry == "United States")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}