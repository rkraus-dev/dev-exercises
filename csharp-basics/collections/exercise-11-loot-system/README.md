# Exercise 11 – Loot System
Choosing the right collection for the right purpose in a practical loot tracking scenario.

## Task
Build a loot system that tracks possible drops, counts collected items, and ensures legendary items can only appear once in the inventory.

## Approach
Used a string array for possible drops since the list is fixed and never changes. A Dictionary tracks collected items with their count, allowing direct value updates via index access. A HashSet stores legendary items to enforce uniqueness, with the Add return value used to detect duplicate drops.

## Example Output
```
Possible drops:
Coin
Slime
Feather

Collected Drops:
Coin: 200
Slime: 87
Feather: 10

Try adding sword to list.... Success: False
Legendary drop:
Sword
```

## Time Complexity
O(n) — linear passes for iteration. All individual operations (Add, Remove, Contains) are O(1).