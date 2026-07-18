int[] stats = { 42, 17, 85, 3, 66, 29 };

// print stats
Console.Write("Stats:");
foreach(int stat in stats)
{
    Console.Write(stat + " ");
}
Console.WriteLine();

//find largest number
int largestNumber = stats[0];
foreach(int stat in stats)
{
    if(stat > largestNumber)
        largestNumber = stat;
}
Console.WriteLine($"Largest: {largestNumber}");

// find second largest number
int secondLargestNumber = stats[0];
foreach(int stat in stats)
{
    if(stat == largestNumber)
        continue;
    else if(stat > secondLargestNumber)
        secondLargestNumber = stat;
    
}
Console.WriteLine($"Second largest: {secondLargestNumber}");
