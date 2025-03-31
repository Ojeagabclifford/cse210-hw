
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

   public Address(string streetAddress, string city, string stateProvince,string country)
{
    _city = city;
    _streetAddress = streetAddress;
    _country = country;
    _stateProvince = stateProvince;
}

public void SetAddress(string streetAddress, string city, string stateProvince,string country)
{
    _city = city;
    _streetAddress = streetAddress;
    _country = country;
    _stateProvince = stateProvince;
}

    public string GetAdressDetails()
    {
        return $"{_streetAddress},{_city},{_stateProvince},{_country}";
    }


     public string GetUsaAdress()
    {
        if (_country =="usa")
        {
            return _country;
        }

        else
        {
            return _country;
        }
    }
}