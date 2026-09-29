using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(string name,string productID,double price,int quantity)
    {
        _products.Add(new Product(name,productID,price,quantity));
    }

    public double TotalCostOrder()
    {
        double total = 0;
        foreach(Product product in _products)
        {
            total += product.TotalCostProduct();
        }
        return total;
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        if (_customer.UsaCityzen())
        {
            totalPrice += TotalCostOrder() + 5;
        }
        else
        {
            totalPrice += TotalCostOrder() + 35;
        }
        return totalPrice;
    }

    public void PackingLabel()
    {
        foreach(Product product in _products)
        {
            Console.WriteLine($"""
            Product Name : {product.GetProductName()}
            Product ID : {product.GetProductID()}
            Price : {product.GetProductPrice()} $
            Quantity : {product.GetProductQuantity()} units
            """);
            Console.WriteLine("-----------------------------------");
        }
    }

    public void ShippingLabel()
    {
        string ship = $"""
        Customer Name : {_customer.GetCustomerName()}
        Customer Address : {_customer.GetCustomerAddress()}
        """;
        Console.WriteLine(ship);
        Console.WriteLine("-----------------------------------");
    }

    
}