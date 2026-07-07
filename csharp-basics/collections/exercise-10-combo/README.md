
# Exercise 10 – Collections Combo
Combining arrays, lists, dictionaries, and hash sets in a single cohesive exercise.

## Task
Manage a kingdom by storing starter classes in an array, tracking active heroes in a list, recording quest completions in a dictionary, and logging visited cities in a hash set.

## Approach
Loaded the array into a list via foreach, then added and removed heroes. Registered each active hero in a dictionary with a starting quest count of zero and incremented values directly via index access. Used a HashSet to prevent duplicate cities, capturing the return value of Add to detect duplicates.

## Example Output
``` 
Warrior
Mage
Archer

Adding Riverdale (duplicate)... Success: False

Heroes:
Warrior
Archer
Healer

Quest-Stats:
Warrior: 2
Archer: 1
Healer: 1

Visited cities:
Henessys
Riverdale
```

## Time Complexity
O(n) — linear passes for iteration and dictionary population. All individual operations (Add, Remove, Contains) are O(1).