int questDifficulty = 7;

string reward = questDifficulty == 10 ? "Reward: Mythic Artifact" : questDifficulty >= 8 ? "Reward: Legendary Sword" : "Reward: Common Potion";

Console.WriteLine(reward);