using System.Text;
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
            StringBuilder label = new StringBuilder();
            label.AppendLine($"Address: {_streetAddress}");
            label.AppendLine($"City: {_city}");
            label.AppendLine($"State: {_stateOrProvince}");
            label.AppendLine($"Country: {_country}");
            return label.ToString(); 
        }

        public bool IsLocationUsa()
        {
            return _country.Equals("USA");
        }
    }

}