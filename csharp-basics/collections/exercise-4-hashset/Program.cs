// Aufgabe 1
HashSet<string> fruits1 = new HashSet<string> {"Banana", "Apple", "Kiwi"};
HashSet<string> fruits2 = new HashSet<string> {"Apple", "Orange", "Strawberry", "Kiwi"};

// Aufgabe 2
fruits1.Add("Apple");
Console.WriteLine(fruits1.Count);

// Aufgabe 3
HashSet<string> copyFruit1 = new HashSet<string>(fruits1);
copyFruit1.IntersectWith(fruits2);

foreach (string fruit in copyFruit1)
{
    Console.WriteLine(fruit);
}

// Aufgabe 4
HashSet<string> copyFruit2 = new HashSet<string>(fruits1);
copyFruit2.ExceptWith(fruits2);

foreach (string fruit in copyFruit2)
{
    Console.WriteLine(fruit);
}