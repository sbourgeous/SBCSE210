using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", 101, 1000.0f, 1);
        Product product2 = new Product("Headphones", 102, 50.0f, 2);

        // Create address
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create customer
        Customer customer1 = new Customer("John Doe", address1);

        // Create order
        List<Product> productList1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productList1, customer1);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine(order1.CreateShippingLabel());

        // Create second order
        Product product3 = new Product("Phone", 103, 700.0f, 1);
        Address address2 = new Address("456 Maple Ave", "Sometown", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        List<Product> productList2 = new List<Product> { product3 };
        Order order2 = new Order(productList2, customer2);

        // Display second order details
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine(order2.CreateShippingLabel());
    }
}