void CreateCharacter(string name, int level = 1, int health = 100, string characterClass = "Adventurer")
{
    Console.WriteLine($"{name} - Level {level} - HP {health} - Class: {characterClass}");
}

CreateCharacter("Eris");
CreateCharacter("Rudeus", 10);
CreateCharacter("Kinoas", health: 90);
CreateCharacter("Hairo", level: 999, health: 100, characterClass: "God");