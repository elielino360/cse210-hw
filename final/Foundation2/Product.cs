using System;
using System.Collections.Generic;

public class Product
{
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    
    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    
    public string Name { get => name; set => name = value; }
    public int ProductId { get => productId; set => productId = value; }
    public decimal Price { get => price; set => price = value; }
    public int Quantity { get => quantity; set => quantity = value; }

    
    public decimal GetTotalCost()
    {
        return price * quantity;
    }
}
