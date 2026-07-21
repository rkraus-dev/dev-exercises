using System.Text.Json;

Player player1 = new Player{ Name = "Hairo", Level = 3, IsOnline = true, Inventory = ["Coins", "Potion", "Stones"]};
string jsonString = JsonSerializer.Serialize(player1);

Console.WriteLine(jsonString);

List<Player> players = new List<Player>
{
    new Player { Name = "Kinoas", Level = 5,IsOnline = false, Inventory = new List<string> { "Sword" } },
    new Player { Name = "Katletka", Level = 8, IsOnline = true, Inventory = new List<string> { "Shield", "Potion" } }
};

string jsonString2 = JsonSerializer.Serialize(players);
Console.WriteLine(jsonString2);


class Player
{
    private string realName;
    public string Name { get; set; }
    public int Level { get; set; }
    public bool IsOnline {get; set;}
    public List<string> Inventory { get; set; } = new List<string>();
}