using System;

class Program
{
    static void Main(string[] args)
    {   
        // customers

        // glossier store
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Address address1 = new Address("8523 Melrose Ave", "West Hollywood", "California", "USA");
        // Console.ForegroundColor = ConsoleColor.DarkBlue;
        Customer customer1 = new Customer("Emily Weiss", address1);
        
        // golf le fleur
        // Console.ForegroundColor = ConsoleColor.DarkRed;
        Address address2 = new Address("4011 Sunset Blvd", "Los Angeles", "California","USA");
        // Console.ForegroundColor = ConsoleColor.DarkBlue;
        Customer customer2 = new Customer("Tyler Okonma",address2);

        // cafe in canada
        // Console.ForegroundColor = ConsoleColor.DarkRed;
        Address address3 = new Address("6380 Fallsview Blvd", "Niagara Falls", "Ontario", "CANADA");
        // Console.ForegroundColor = ConsoleColor.DarkBlue;
        Customer customer3 = new Customer("Tim Hortons", address3);

        // products
        Product product1 = new Product("Golf Le Fleur Perfume", "11111", 79.99, 3);
        Product product2 = new Product("Glossier Perfume", "11112", 64.00, 1);
        Product product3 = new Product("Bagel Sandwich", "11113", 6.78, 1);
        Product product4 = new Product("Le Fleur Stick Set", "11114", 21.99, 2);
        Product product5 = new Product("Balm DotCom", "11115", 14.00, 1);
        Product product6 = new Product("Cloud Paint", "11116", 20.00, 1);

        // 1st order
        Order order1 = new Order(new List<Product>{product1, product2, product3},customer1);

        // 2nd Order
        Order order2 = new Order(new List<Product>{product3, product4, product6},customer2);

        // 3rd order
        Order order3 = new Order(new List<Product>{product1, product5, product3},customer3);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total:{ order1.TotalCost():C}");
        Console.WriteLine();

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total:{ order2.TotalCost():C}"); 
        Console.WriteLine();     

        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine($"Total:{ order3.TotalCost():C}");         
    }
}