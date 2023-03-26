using System;

public class Order
{
    
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer; 
    }
    public List<Product> Prod
    {
        get
        {
            return _products;
        }
        set
        {
            _products = value;
        }
    }
    public Customer CustName
    {
        get{
            return _customer;
        }
        set{
            _customer = value;
        }
    }
    public string GetOrder()
    {
        string orders = $"{CustName}, {Prod}";
        return orders;
    }
    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.priceOfProduct();
        }
        if (_customer.CountryFinder())
        {
            total += 5;
        } 
        else
        {
            total += 35;
        }
        return total;
    }
    public string PackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += product.ProdName() + "(Product ID: " + product.ProductId() +")\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        Customer customer = _customer;
        string ship = customer.CustName() + "\n" + 
        customer.GetAddress().CustAddress();
        return ship;
    }
}