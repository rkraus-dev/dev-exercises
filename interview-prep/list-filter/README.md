# List Filter
Filtering lists based on conditions without LINQ.

## Task
Filter a list of integers to keep only even numbers, and filter a list of strings to keep only items with more than 5 characters. Both without using LINQ.

## Approach
Used foreach loops to iterate over both lists. For integers, the modulo operator checks for even numbers. For strings, the Length property checks the character count. Matching elements are added to a new list via Add.

## Example Output
```
Numbers: 1 2 3 4 5 6 7 8
Even numbers: 2 4 6 8
Items: Sword Shield Bow Axe Crossbow Dagger
Long items: Shield Crossbow Dagger
```

## Time Complexity
O(n) — single pass through each list.