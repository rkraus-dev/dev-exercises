using System.Text;

string[] parts = {
    "The ancient dragon ",
    "guards the hidden treasure ",
    "of the lost kingdom."
};

StringBuilder sb = new StringBuilder();
foreach (string part in parts)
    sb.Append(part);

Console.WriteLine($"Scroll: {sb}");

Console.WriteLine($"Contains 'dragon': {sb.ToString().Contains("dragon")}");

sb.Replace("dragon", "wizard");
Console.WriteLine($"After replace: {sb}");

string text = sb.ToString();

string reversed = "";
for (int i = text.Length - 1; i >= 0; i--)
    reversed += text[i];

Console.WriteLine($"Reversed: {reversed}");

Console.WriteLine($"Is palindrome: {text == reversed}");