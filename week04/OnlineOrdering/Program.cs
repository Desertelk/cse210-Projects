using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main st", "Salt Lake City", "UT", 12345, "USA");

        Customer customer1 = new Customer("Pablo", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Pen", "P207", 5, 5.99m));
        order1.AddProduct(new Product("Paper", "P001", 2, 29.99m));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\n----------------------------\n");

        Address address2 = new Address("Urb Previ Naranjal Mz 1, Lt 1", "Los Olivos", "Lima", 15304, "Peru");
        Customer customer2 = new Customer("Evelyn", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Computer", "C200", 1, 899.99m));
        order2.AddProduct(new Product("Mouse", "M302", 2, 89.99m));
        order2.AddProduct(new Product("Keyboard", "K382", 1, 69.99m));

        Console.Write(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
    }
}