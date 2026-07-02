Dictionary<string, double> pricelist = new Dictionary<string, double>
{
    {"Bread", 0.99},
    {"Milk", 0.50},
    {"Apple", 0.20}
};

pricelist.Add("Flour", 0.39);
pricelist["Bread"] = 1.10;
pricelist.Remove("Apple");

if (!pricelist.TryGetValue("Banana", out double price))
{
    Console.WriteLine("Product not found");
}


foreach (KeyValuePair<string, double> product in pricelist)
{
    Console.WriteLine($"{product.Key}: {product.Value}");
}