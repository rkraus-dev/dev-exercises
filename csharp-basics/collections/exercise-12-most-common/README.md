# Exercise 12 – Most Common Element
Finding the most frequently occurring element in a list using a Dictionary.

## Task
Given a list of strings with duplicates, find the element that appears most often without using LINQ.

## Approach
Used a foreach loop to iterate over the list and count occurrences in a Dictionary. ContainsKey checks if the element already exists — if so, the counter is incremented, otherwise a new entry is added with count 1. A second foreach iterates over the Dictionary to find the key with the highest value, using the same min/max pattern as array searching.

## Example Output
``` 
Drops: Sword Coin Coin Shield Coin Sword Potion Coin
Most common drop: Coin (4x)
```

## Time Complexity
O(n) — single pass to count, single pass to find the maximum.