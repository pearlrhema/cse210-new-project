using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products1 = new()
        {
            new Product("Stapler", "STA.2", 2.50f, 2),
            new Product("Tape", "TPE01", 6.15f, 1),
            new Product("Envelope", "EVN35", 15.70f, 1)
        };
        List<Product> products2 = new()
        {
            new Product("12kg cylinder", "12KG", 9.56f, 1),
            new Product("60kg cylinder", "60KG", 20.25f, 4),
            new Product("8kg cylinder","8KG", 12.52f, 5)
        };
        Order order1 = new(products1, new Customer("Godwin Essien", new Address("20 calabar Itu St", "Ikot Ekpene", "Akwa Ibom", "NIGERIA")));
        Order order2 = new(products2, new Customer("John Doe", new Address("123 Main St", "Bryn Mawr", "Pennsylvania", "USA")));
        // Order order3 = new(products1, new Customer("John Doe", new Address("2970 Circle Drive", "Houston", "Texas", "USA")));
        // Order order4 = new(products1, new Customer("John Doe", new Address("Riviera Golf, 08 BP 2656", "Abidjab", "Abidjan", "Ivory Coast"))); 
        
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.ProductLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.ProductLabel());
    }
}