using System.Text;
namespace Practice2
{   /// <summary>
    /// A particular place.
    /// 
    /// The responsibility of Address is to keep track of the street Address, city, state or province and country. 
    /// </summary> 
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;

        /// <summary>
        /// Constructs a new instance of Address.
        /// </summary>
        /// <param name="streetAddress">The given street Address.</param>
        /// <param name="city">The given city.</param>
        /// <param name="stateOrProvince">The given state or province.</param>
        /// <param name="country">The given country.</param>

        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateOrProvince = stateOrProvince;
            _country = country;
        }
         /// <summary>
        /// Gets the Country.
        /// </summary>
        /// <returns>the country</returns>
        public string GetCountry()
        {
            return _country;
        }

        /// <summary>
        /// Gets the Address.
        /// </summary>
        /// <returns>The label with address info</returns>
        public string GetAddress()
        {
            StringBuilder label = new StringBuilder();
            label.AppendLine($"Address: {_streetAddress}");
            label.AppendLine($"City: {_city}");
            label.AppendLine($"State: {_stateOrProvince}");
            label.AppendLine($"Country: {_country}");
            return label.ToString(); 
        }
        /// <summary>
        /// Checks if the country is USA.
        /// </summary>
        /// <returns>true if country is USA</returns>
        public bool IsLocationUsa()
        {
            return _country.Equals("USA");
        }
    }

}