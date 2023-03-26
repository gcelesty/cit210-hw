using System;

public class Product
{
    private string _prodName;
    private string _productId;

    private double _price;
    private int _quantity;

    public Product(string prodName, string productId, double price, int quantity)
    {
        _prodName = prodName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string ProdName()
    {
        return _prodName;
    }
    public double Price
    {
        get
        {
            return _price;
        }
        set
        {
            _price = value;
        }
    }
    public string ProductId()
    {
        return _productId; 
    }
    public int Quantity
    {
        get
        {
            return _quantity;
        }
        set
        {
            _quantity = value;
        }
    }
    public double priceOfProduct()
    {
        return _price * _quantity;
    }
}