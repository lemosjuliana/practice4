namespace Practice2
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }

        public string GetCountry()
        {
            return _country;
        }

        public string GetAddress()
        {
            return $"Address: {_streetAddress} City: {_city} State: {_stateOrProvince} Country: {_country}" + Environment.NewLine; 
        }

        public bool IsLocationUsa()
        {
            return _country.Equals("USA");
        }
    }

}