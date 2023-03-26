using System;
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvence;
    private string _country;

    public Address(string streetAddress, string city, string stateProvence, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvence = stateProvence;
        _country = country;
    }
    public string StreetAddress
    {
        get
        {
            return _streetAddress;
        }
        set
        {
            _streetAddress = value;
        }
    }
    
    public string City
    {
        get
        {
            return _city;
        }
        set{
            _city = value;
        }
    }
    public string StateProvence
    {
        get
        {
            return _stateProvence;
        }
        set
        {
            _stateProvence = value;
        }
    }
    public string Country
    {
        get
        {
            return _country;
        }
        set{
            _country = value;
        }
    }
    // return whether address is USA or not
    public Boolean CountryFinder()
    {
        return _country == "USA";
    }

    // returns address strings into one string with newline when needed
    public string CustAddress()
    {
        string address = $"{StreetAddress} \n {City}, {StateProvence}  {Country} ";
        return address;
    } 
}