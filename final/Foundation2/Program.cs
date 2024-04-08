
Address address1 = new Address("15 thomas St", "Idaho", "CA", "United State");

// Create customer
Customer customer1 = new Customer("Elijah Jeremiah", address1);


Product product1 = new Product("Biscuit", 1, 10.99m, 2);
Product product2 = new Product("Coke", 2, 19.99m, 1);

// Create order
Order order1 = new Order(customer1);
order1.AddProduct(product1);
order1.AddProduct(product2);

// Display order details
Console.WriteLine("Order Details:");
Console.WriteLine(order1.GetPackingLabel());
Console.WriteLine(order1.GetShippingLabel());
Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

Console.WriteLine("\n---------------------------\n");


Address address2 = new Address("Lekki Garden St", "Ajah", "Lagos", "Nigeria");

// Create customer
Customer customer2 = new("Mark Prince", address2);

// Create products
Product product3 = new("Pjamas", 3, 15.50m, 1);
Product product4 = new("Shirt", 4, 12.75m, 3);

// Create order
Order order2 = new Order(customer2);
order2.AddProduct(product3);
order2.AddProduct(product4);

// Display order details
Console.WriteLine("Order Details:");
Console.WriteLine(order2.GetPackingLabel());
Console.WriteLine(order2.GetShippingLabel());
Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
