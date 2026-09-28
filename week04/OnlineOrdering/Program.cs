//Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. 
// Call the methods to get the packing label, the shipping label, and the total price of the order, and display the results 
// of these methods.

using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address1 = new Address("1646 N Chestnut Cir.", "Mesa", "Arizona", "USA");
        Customer customer1 = new Customer("Sam Owens", address1);
        Product product1 = new Product("milk", 85936, 3, 2);
        Product product2 = new Product("Cheese", 45831, 5.61, 1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("ORDER#2:");
        Address address2 = new Address("501 E 4th Place", "Brisbane", "Queensland", "Australia");
        Customer customer2 = new Customer("Jawoodle", address2);
        Product product3 = new Product("Bread", 78154, 3.25, 3);
        Product product4 = new Product("Cake", 32748, 12.86, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        


        Console.Clear();
        
        Console.WriteLine("ORDER #1:");
        Console.WriteLine();

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order1.SumOfProducts()}");

        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();
        
        Console.WriteLine("ORDER #2:");
        Console.WriteLine();

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Cost: ${order2.SumOfProducts()}");
        
    }
}