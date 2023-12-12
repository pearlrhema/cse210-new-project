public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    } 

    public bool IsInUSA()
    {
        if (_country.ToUpper() == "USA"|| _country.ToUpper() == "UNITED STATES"){

            return true;
        }
        return false;
    }

    public string GetAddressString()
    {
        return $"Street Address : {_streetAddress}\n" 
            + $"City : {_city}\n"
            + $"State : {_state};\n"
            + $"Country : {_country}";
    }
}