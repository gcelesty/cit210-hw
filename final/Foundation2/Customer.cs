using System;

public class Customer
{
    private string _customerName;
    public Address _address;
  
    public Customer(string customerName, Address address)
    {
        _customerName= customerName;
        _address = address;
    }

    public string CustomerName
    {
        get
        {
            return _customerName;
        }
        set
        {
            _customerName = value;
        }
    }
    
    public string CustName()
    {
        return _customerName;
    }
    public Address CustAddress
    {
        get
        {
            return _address;
        }
    }
    public Address GetAddress()
    {
        return _address;
    }
    public Boolean CountryFinder()
    {
        return _address.CountryFinder();
    }
}
