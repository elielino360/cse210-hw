
Address address1 = new("15 thomas St", "Idaho", "CA", "United State");

// Create customer
Customer customer1 = new("Elijah Jeremiah", address1);


Product product1 = new("Biscuit", 1, 10.99m, 2);
Product product2 = new("Coke", 2, 19.99m, 1);


Order order1 = new(customer1);
order1.AddProduct(product1);
order1.AddProduct(product2);


Console.WriteLine("Order Details:");
Console.WriteLine(order1.GetPackingLabel());
Console.WriteLine(order1.GetShippingLabel());
Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

Console.WriteLine("\n---------------------------\n");


Address address2 = new("Lekki Garden St", "Ajah", "Lagos", "Nigeria");


Customer customer2 = new("Mark Prince", address2);


Product product3 = new("Pjamas", 3, 15.50m, 1);
Product product4 = new("Shirt", 4, 12.75m, 3);


Order order2 = new(customer2);
order2.AddProduct(product3);
order2.AddProduct(product4);


Console.WriteLine("Order Details:");
Console.WriteLine(order2.GetPackingLabel());
Console.WriteLine(order2.GetShippingLabel());
Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
