using System.Text;

namespace Practice3
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
 
        public Address(string street, string city, string state)
        {
            _streetAddress = street;
            _city = city;
            _stateOrProvince = state;
        }

        public string GetAddress()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine($"Address: {_streetAddress}");
            label.AppendLine($"City: {_city}");
            label.Append($"State: {_stateOrProvince}");
            return label.ToString(); 
        }


    }

}