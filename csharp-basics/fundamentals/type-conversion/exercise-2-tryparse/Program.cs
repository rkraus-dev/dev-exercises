bool manaParseSuccess = int.TryParse("9823", out int manaValue);
bool nameParseSuccess = int.TryParse("Rudeus", out int nameValue);

Console.WriteLine("=== TryParse Demo ===");
Console.WriteLine($"Input: \"9823\" → Success: {manaParseSuccess} | Value: {manaValue}");
Console.WriteLine($"Input: \"Rudeus\" → Success: {nameParseSuccess} | Value: {nameValue}");