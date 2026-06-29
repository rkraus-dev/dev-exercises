string? name = "Kazuma Satou";
string? title = null;
int? guildId = null;
string? lastLocation = null;

Console.WriteLine("=== Player Profile ===");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Title: {title ?? "No Title"}");
Console.WriteLine($"Guild ID: {guildId?.ToString() ?? "No Guild"}");
Console.WriteLine($"Location: {lastLocation ?? "Unknown"}");
Console.WriteLine($"Title Length: {title?.Length ?? 0}");