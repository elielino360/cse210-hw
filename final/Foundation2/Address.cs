public class Address
{
    // Attributes
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

  
    public string StreetAddress { get => streetAddress; set => streetAddress = value; }
    public string City { get => city; set => city = value; }
    public string StateProvince { get => stateProvince; set => stateProvince = value; }
    public string Country { get => country; set => country = value; }


    public bool IsInUSA()
    {
        return country.ToUpper() == "USA";
    }
    public override string ToString()
    {
        return $"{streetAddress}, {city}, {stateProvince}, {country}";
    }
}