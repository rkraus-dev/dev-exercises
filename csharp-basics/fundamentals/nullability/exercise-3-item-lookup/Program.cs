string? itemName = "Excalibur";
int? itemID = null;
decimal? itemPrice = null;
decimal? discountedPrice = null;
string? itemDescription = null;

Console.WriteLine("=== Item Lookup ===");
Console.WriteLine($"Item Name: {itemName}");
Console.WriteLine($"Item ID: {itemID?.ToString() ?? "No ID"}");
Console.WriteLine($"Price: {itemPrice?.ToString() ?? "No Price"}");
Console.WriteLine($"Discounted: {discountedPrice?.ToString() ?? "No Price"}");
Console.WriteLine($"Description: {itemDescription ?? "No description available"}");
Console.WriteLine($"Name Length: {itemName?.Length ?? 0}");