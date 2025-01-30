public class Customer
{
    public string Name { get; set; }
    public Address CustomerAddress { get; set; }

    public bool IsInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}
