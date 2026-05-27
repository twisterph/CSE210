using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Lake View Dr", "Lake Havasu City", "AZ", "USA");
        Customer customer1 = new Customer("Pablo Hinojosa", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM100", 15.99, 2));
        order1.AddProduct(new Product("USB-C Cable", "UC200", 8.50, 3));
        order1.AddProduct(new Product("Laptop Stand", "LS300", 32.99, 1));

        Address address2 = new Address("45 Los Alerces", "Santiago", "RM", "Chile");
        Customer customer2 = new Customer("Carlos Rivera", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Keyboard", "BK400", 24.99, 1));
        order2.AddProduct(new Product("Webcam", "WC500", 39.99, 1));
        order2.AddProduct(new Product("Headset", "HS600", 29.99, 2));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost():F2}");
        Console.WriteLine("------------------------------");
    }
}