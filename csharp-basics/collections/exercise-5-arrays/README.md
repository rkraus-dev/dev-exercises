# Exercise 5 – Arrays
Working with fixed-size arrays: iteration, searching, and element replacement.

## Task
Create a string array with 5 weapons. Print all elements with their index, find the weapon with the longest name, replace one element, and print the updated array.

## Approach
Used a for loop to print elements with index. A foreach loop iterates over the array to find the longest name by comparing string lengths. The element at index 2 is replaced directly via index access.

## Example Output
```
Inventory:
[0] Sword
[1] Shield
[2] Bow
[3] Axe
[4] Dagger

Strongest weapon: Shield (6 chars)

Replacing slot 2...

Updated Inventory:
[0] Sword
[1] Shield
[2] Crossbow
[3] Axe
[4] Dagger
```

## Time Complexity
O(n) — single pass to print, single pass to find the strongest weapon.