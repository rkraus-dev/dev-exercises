string name = "Name";
string level = "Level";
string mana = "Mana";
string gold = "Gold";

string rudeus = "Rudeus Greyrat";
int rudeusLevel = 42;
double rudeusMana = 9823.77;
double rudeusGold = 1500.75;

string eris = "Eris Boreas";
int erisLevel = 38;
double erisMana = 4200.00;
double erisGold = 800.50;

string roxy = "Roxy Migurdia";
int roxyLevel = 55;
double roxyMana = 15000.00;
double roxyGold = 3200.25;


Console.WriteLine("=== Character Table ===");
Console.WriteLine($"{name.PadRight(20)} | {level.PadRight(8)} | {mana.PadRight(10)} | {gold.PadRight(8)} ");
Console.WriteLine($"{rudeus,-20} | {rudeusLevel,-8} | {rudeusMana,10:N2} | {rudeusGold,8:N2} G");
Console.WriteLine($"{eris,-20} | {erisLevel,-8} | {erisMana,10:N2} | {erisGold,8:N2} G");
Console.WriteLine($"{roxy,-20} | {roxyLevel,-8} | {roxyMana,10:N2} | {roxyGold,8:N2} G");
