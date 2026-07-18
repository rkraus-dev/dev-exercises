# Character Sheet

Combining fundamentals: variables, type conversion, operators, string formatting, and null checks.

## Task
Read a hero name and level from the user. Validate the level input and calculate combat stats based on predefined strength and HP values.

## Approach
Used Console.ReadLine with ?? for null fallback on the name input. Level is validated with a while loop combining TryParse and range check. Stats are calculated using arithmetic operators and formatted with :F2 for two decimal places.

## Example Output
```
--- Character Sheet ---
Enter your hero's name: Arthur
Enter your level (1-10): 5
Name: Arthur
Level: 5
Strength: 30
Is Alive: True
Total Damage: 150
HP after attack: 85.00
```

## Time Complexity
O(1) — constant time, no loops over data.