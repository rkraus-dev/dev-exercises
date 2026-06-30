int monsterHp = 50;
int attackDamage = 12;

while (monsterHp > 0)
{
    monsterHp -= attackDamage;
    Console.WriteLine($"Monster HP: {monsterHp}");
}

Console.WriteLine("The monster has been defeated!");