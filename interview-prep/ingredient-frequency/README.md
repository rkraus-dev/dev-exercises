# Ingredient Frequency
Practicing frequency counting with Dictionary<TKey, TValue>.

## Task
Count how often each string appears in an array and return the result as a
dictionary (item -> count). Afterwards list all items that appear more than once.
Null or empty input must be handled gracefully without crashing the caller.

## Approach
The array is traversed once; for each item, ContainsKey decides whether to
increment the existing counter or add the item with a count of 1. The guard
clause returns an empty dictionary instead of null, so callers can safely
iterate the result without extra null checks. Duplicate detection happens in
Main by scanning the finished dictionary for values greater than 1 and
collecting the keys in a list.

## Example Output
``` 
=== Alchemist's Satchel ===
Ingredients: moonherb, dragon-scale, moonherb, nightshade, moonherb, dragon-scale

moonherb x3
dragon-scale x2
nightshade x1

Duplicates found: moonherb, dragon-scale
```

## Time Complexity
O(n) - one pass over the array; each dictionary lookup and insert is O(1) on average.