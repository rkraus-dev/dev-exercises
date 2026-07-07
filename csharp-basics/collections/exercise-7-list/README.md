# Exercise 7 – List

Working with dynamic lists: adding, removing, searching, and sorting elements.

## Task

Create a List of heroes, add and remove elements, check if a specific element exists, and print the sorted list.

## Approach

Used List<string> for dynamic sizing. Add and Remove modify the list directly. Contains returns a boolean for membership checks. Sort orders elements alphabetically in place. Iterated with a for loop using Count to print elements with their index.

## Example Output
```
Party:
[0] Archer
[1] Mage
[2] Warrior

Adding Healer...
Removing Mage...

Healer in party: True

Sorted Party:
[0] Archer
[1] Healer
[2] Warrior
```

## Time Complexity

O(n log n) — dominated by Sort. All other operations are O(1) or O(n).