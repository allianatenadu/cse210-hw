public class Program
{
    public static void Main(string[] args)
    {
        // Create Products
        Product product1 = new Product { Name = "Laptop", ProductID = "P123", Price = 799.99m, Quantity = 2 };
        Product product2 = new Product { Name = "Mouse", ProductID = "P124", Price = 29.99m, Quantity = 3 };

        // Create Address
        Address address = new Address { Street = "123 Main St", City = "Anytown", State = "CA", Country = "USA" };

        // Create Customer
        Customer customer = new Customer { Name = "John Doe", CustomerAddress = address };

        // Create Order
        Order order = new Order { Products = new List<Product> { product1, product2 }, OrderCustomer = customer };

        // Display results
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GeneratePackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GenerateShippingLabel());

        Console.WriteLine("\nTotal Price: " + order.CalculateTotalPrice());
    }
}
