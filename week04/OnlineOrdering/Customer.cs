using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name,Address addres)
    {
        _name = name;
        _address = addres;
    }

    public bool UsaCityzen()
    {
        bool check;
        if (_address.IsUsa())
        {
            check = true;
        }
        else
        {
            check = false;
            
        }
        return check;
    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetCustomerAddress()
    {
        return _address.ShowAdress();
    }

}