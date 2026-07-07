# Exercise 8 – Dictionary
Working with key-value pairs: adding, updating, searching, and removing entries.

## Task
Create a Dictionary of skills with their levels. Add a new skill, upgrade an existing one, check if a skill exists, remove a skill, and print the updated dictionary.

## Approach
Used Dictionary<string, int> with skill names as keys and levels as values. Added entries with Add, updated values via index access and the ++ operator, checked membership with ContainsKey, and removed entries with Remove. Iterated with foreach using KeyValuePair to print all entries.

## Example Output
``` 
Skills:
Fireball: 3
Dodge: 1
Shield Bash: 2

Adding Heal...
Upgrading Fireball...

Assassin in skill tree: False

Removing Dodge...

Updated Skills:
Fireball: 4
Shield Bash: 2
Heal: 1
```

## Time Complexity
O(1) — Add, Remove, ContainsKey and index access are all constant time. O(n) for iteration.