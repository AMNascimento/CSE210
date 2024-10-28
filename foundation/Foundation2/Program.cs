using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Keyboard","BRL1011", 24.99m, 3);
        Product product2 = new Product("Monitor","BRL1023", 243.99m, 1);
        Product product3 = new Product("Cellphone","BRL2051", 531.45m, 10);
        Product product4 = new Product("Christmas Tree","GHT3487", 15.99m, 2);
        Product product5 = new Product("Pencil","LBB0021", 0.5m, 40);
        Product product6 = new Product("Car","GMM8455", 31750.00m, 1);
        Product product7 = new Product("Table","BRL1011", 375.05m, 5);
        
        Address address1 = new Address("101 Main St", "Boston", "MA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        Address address2 = new Address("Av. Paulista, 1055", "São Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("João Silva", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);
        order2.AddProduct(product1);
        
        Console.WriteLine("--- PRODUCT 1 ---");
        Console.WriteLine("\nPacking Label\n");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label\n");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total: ${order1.CalculateTotalCost()}");

        Console.WriteLine("--- PRODUCT 2 ---");
        Console.WriteLine("\nPacking Label\n");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label\n");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total: ${order2.CalculateTotalCost()}");

    }
}