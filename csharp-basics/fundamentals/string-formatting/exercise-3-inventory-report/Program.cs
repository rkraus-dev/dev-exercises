string healingName= "Healing Potion";
int healingQuantity = 15;
decimal healingPricePerUnit = 5.99m;
decimal healingTotalValue = healingPricePerUnit * healingQuantity;

string manaName= "Mana Crystal";
int manaQuantity = 8;
decimal manaPricePerUnit = 24.99m;
decimal manaTotalValue = manaPricePerUnit * manaQuantity;

string teleportName= "Teleport Scroll";
int teleportQuantity = 3;
decimal teleportPricePerUnit = 99.99m;
decimal teleportTotalValue = teleportPricePerUnit * teleportQuantity;

decimal grandTotal = healingTotalValue + manaTotalValue + teleportTotalValue;

Console.WriteLine("=== Inventory Report ===");
Console.WriteLine($"Item                 | Qty  | Price/Unit  | Total");
Console.WriteLine($"{healingName, -20} | {healingQuantity,-4} | {healingPricePerUnit,11:N2} | {healingTotalValue, 10:N2}");
Console.WriteLine($"{manaName, -20} | {manaQuantity,-4} | {manaPricePerUnit,11:N2} | {manaTotalValue, 10:N2}");
Console.WriteLine($"{teleportName, -20} | {teleportQuantity,-4} | {teleportPricePerUnit,11:N2} | {teleportTotalValue, 10:N2}");
Console.WriteLine($"{new string('─', 53)}");
Console.WriteLine($"Grand Total: {grandTotal,40:N2}");
