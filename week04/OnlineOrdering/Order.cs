public class Order
{
    public List<Product> Products { get; set; }
    public Customer OrderCustomer { get; set; }

    public decimal CalculateTotalPrice()
    {
        decimal totalCost = 0;
        foreach (var product in Products)
        {
            totalCost += product.CalculateTotalCost();
        }

        decimal shippingCost = OrderCustomer.IsInUSA() ? 5m : 35m; // USA = $5, Else = $35
        return totalCost + shippingCost;
    }

    public string GeneratePackingLabel()
    {
        var label = "";
        foreach (var product in Products)
        {
            label += $"{product.Name} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return OrderCustomer.CustomerAddress.GetFullAddress();
    }
}
