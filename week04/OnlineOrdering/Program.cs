using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Phoenix", "Arizona", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 899.99, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P1002", 24.50, 2));
        order1.AddProduct(new Product("Keyboard", "P1003", 45.00, 1));

        Address address2 = new Address("456 King Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Johnson", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P2001", 199.99, 2));
        order2.AddProduct(new Product("HDMI Cable", "P2002", 12.99, 3));

        Console.WriteLine("========================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("========================================");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        Console.WriteLine("========================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("========================================");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}