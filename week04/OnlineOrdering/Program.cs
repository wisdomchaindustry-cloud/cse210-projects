using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Customer customer1 = new Customer(
            "John Smith",
            address1
        );

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(
            "Laptop",
            "P100",
            850,
            1
        ));

        order1.AddProduct(new Product(
            "Mouse",
            "P200",
            25,
            2
        ));

        order1.AddProduct(new Product(
            "USB Cable",
            "P250",
            10,
            3
        ));

        Address address2 = new Address(
            "45 King Avenue",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer(
            "Emma Wilson",
            address2
        );

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(
            "Keyboard",
            "P300",
            75,
            1
        ));

        order2.AddProduct(new Product(
            "Monitor",
            "P400",
            300,
            2
        ));

        order2.AddProduct(new Product(
            "Headphones",
            "P500",
            120,
            1
        ));

        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine();

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine(
            $"Total Cost: ${order1.CalculateTotalCost()}"
        );

        Console.WriteLine();
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine(
            $"Total Cost: ${order2.CalculateTotalCost()}"
        );
    }
}