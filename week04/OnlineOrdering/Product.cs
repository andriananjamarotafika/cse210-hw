using System;

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string productID ,double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCostProduct()
    {
        return _quantity * _price;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetProductPrice()
    {
        return _price;
    }

    public int GetProductQuantity()
    {
        return _quantity;
    }
}