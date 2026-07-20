# Exercise 16 – Item Shop
Practicing Dictionary operations: adding, updating, searching, and finding the minimum value.

## Task
Manage a shop inventory stored as a Dictionary with item names as keys and prices as values. Add a new item, update a price, check if an item exists, find the cheapest item, and print the updated inventory.

## Approach
Used Dictionary<string, int> for key-value storage. Added entries with Add, updated values via index access. ContainsKey checks membership. The cheapest item is found by initializing the minimum value with int.MaxValue and iterating through all KeyValuePairs, tracking the lowest value and its key.

## Example Output
``` 
Shop inventory:
Sword: 150
Shield: 120
Potion: 30
Bow: 90
Armor: 200

Adding Elixir...
Price increase on Sword...

Dagger in shop: False

Cheapest item: Potion (30)

Updated inventory:
Sword: 175
Shield: 120
Potion: 30
Bow: 90
Armor: 200
Elixir: 80
``` 

## Time Complexity
O(n) — linear pass for iteration and minimum search. O(1) for Add, ContainsKey, and index access.