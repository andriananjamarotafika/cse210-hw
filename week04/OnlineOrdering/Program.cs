using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

//ABOUT CUSTOMER
Address address1 = new Address("123 Main Street Apt 4B", "SAN FRANCISCO", "CA", "USA");
Address address2 = new Address("VT 68L", "Andohanimandroseza", "TNR", "Madagascar");
Customer customer1 = new Customer("Jake Baker", address1);
Customer customer2 = new Customer("Heriniaina Andriananjamarotafika", address2);


//ORDER
Order order1 = new Order(customer1);
Order order2 = new Order(customer2);

//ADDING PRODUCT
order1.AddProduct("Apple", "DF192", 1.5, 3);
order1.AddProduct("Bag", "B321", 0.3, 1);
order1.AddProduct("Bottle of water", "BW3222", 3, 5);
order2.AddProduct("Cookie", "CO237", 10, 5);
order2.AddProduct("Soap", "SO6777", 2, 3);

ShowOrderDetails(order1);
ShowOrderDetails(order2);

void ShowOrderDetails(Order order)
{
    Console.WriteLine("__________________________________");
    order.ShippingLabel();
    order.PackingLabel();
    Console.WriteLine($"Total Price : {order.TotalPrice()} $");
    

}
