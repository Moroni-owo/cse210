using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1 ---
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Homer Simpson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Duff Beer Pack", "A001", 12.99, 2));
        order1.AddProduct(new Product("Donuts Box", "B155", 5.50, 3));

        // --- Order 2 ---
        Address address2 = new Address("Av. Los Incas 1500", "Cusco", "Cusco", "Peru");
        Customer customer2 = new Customer("Raúl Moroni", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Inca Kola Bottle", "C777", 3.20, 5));
        order2.AddProduct(new Product("Peruvian Coffee Bag", "D200", 18.50, 1));
        order2.AddProduct(new Product("Alpaca Keychain", "E009", 4.99, 2));

        // --- Display Results ---
        DisplayOrder(order1);
        Console.WriteLine("----------------------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}\n");
    }
}
