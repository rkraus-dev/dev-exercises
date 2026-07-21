using System.Text.Json;

JsonSerializerOptions options = new JsonSerializerOptions
{
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
};

JsonSerializerOptions option2 = new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
};

Item item1 = new Item
{
    Name = "Sword",
    Amount = 1,
    IsRare = true
};

// Serialize without options
string json1 = JsonSerializer.Serialize(item1);
Console.WriteLine($"Serialize without options: {json1}");
Console.WriteLine();

// Serialize with WriteItend option
string json2 = JsonSerializer.Serialize(item1, options);
Console.WriteLine($"Serialize with options: {json2}");

//Deserialize
string json3 = """{"name": "Sword", "amount": 1, "isRare": true}""";
Item item2 = JsonSerializer.Deserialize<Item>(json3, option2);
Console.WriteLine($"{item2.Name}, {item2.Amount}, {item2.IsRare}");
class Item
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public bool IsRare { get; set; }
}