string? guild = null;
int? rank = null;


Console.WriteLine("=== Null Checks ===");
Console.WriteLine($"Guild: {guild ?? "No Guild"}");
Console.WriteLine($"Rank: {rank?.ToString() ?? "Unranked"}");
Console.WriteLine($"Name Length: {guild?.Length ?? 0}");
Console.WriteLine($"Guild after ??=: {guild ??= "Adventurers Guild"}");