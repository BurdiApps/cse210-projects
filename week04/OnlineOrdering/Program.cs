using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        var address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("Alice Smith", address1);
        var customer2 = new Customer("Bob Lee", address2);

        // Create products
        var prodA = new Product("Laptop", "A100", 999.99, 1);
        var prodB = new Product("Mouse", "B200", 25.50, 2);
        var prodC = new Product("Keyboard", "C300", 45.00, 1);
        var prodD = new Product("Monitor", "D400", 150.00, 2);

        // Create orders
        var order1 = new Order(customer1);
        order1.AddProduct(prodA);
        order1.AddProduct(prodB);

        var order2 = new Order(customer2);
        order2.AddProduct(prodC);
        order2.AddProduct(prodD);

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}\n");
    }
}