namespace Practice2
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateOrProvince;
        private string _country;
    }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvincy = stateOrProvince;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetAddress()
    {
        string address = "";
        // como fazer isso?

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