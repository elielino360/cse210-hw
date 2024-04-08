public class Order
{

    private List<Product> products;
    private Customer customer;

    
    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        totalCost += GetShippingCost();
        return totalCost;
    }

    
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"- {product.Name} (ID: {product.ProductId})\n";
        }
        return label;
    }

    
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name}\n{customer.Address}";
    }


    private decimal GetShippingCost()
    {
        return customer.IsInUSA() ? 5 : 35;
    }
}