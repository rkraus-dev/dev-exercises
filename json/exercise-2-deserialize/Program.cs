using System.Text.Json;

string singleItemJson = """{"Name":"Wand","Amount":1,"IsRare":false}""";
Item item1 = JsonSerializer.Deserialize<Item>(singleItemJson);
Console.WriteLine($"{item1.Name}, {item1.Amount}, {item1.IsRare}");


string itemsJson = """[{"Name":"Wand","Amount":1,"IsRare":false},{"Name":"Sword","Amount":1,"IsRare":true}]""";
List<Item> items = JsonSerializer.Deserialize<List<Item>>(itemsJson);

foreach (Item item in items)
{
    Console.WriteLine($"{item.Name}, {item.Amount}, {item.IsRare}");
}

string brokenJson = """{"Name":"Wand","Amount":1,"IsRare":false"""; 
try
{
    Item brokenItem = JsonSerializer.Deserialize<Item>(brokenJson);
}
catch (JsonException ex)
{
    Console.WriteLine("Failed to parse JSON: " + ex.Message);
}


class Item
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public bool IsRare { get; set; }

}