using System.Text;

List<string> shoppingList = new List<string> { "Steak", "Bananas", "Pasta", "Rice", "Chicken" };

StringBuilder sb = new StringBuilder();

int counter = 1;
foreach (string item in shoppingList)
{
    sb.AppendLine(counter + ". " + item);
    counter++;
}

sb.Insert(0, "Shopping List:\n");
sb.Replace("Chicken", "Shrimps");

Console.WriteLine(sb.ToString());
Console.WriteLine($"Length: {sb.Length}");