public class Customer
{
    // Attributes
    private string name;
    private Address address;

    // Constructors
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Getters and setters
    public string Name { get => name; set => name = value; }
    public Address Address { get => address; set => address = value; }

    // Method to check if customer is in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}