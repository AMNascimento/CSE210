using System.Security.Authentication;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateCode;
    private string _country;

    public Address(string streetAddress, string city, string stateCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateCode = stateCode;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateCode}\n{_country}";
    }
}