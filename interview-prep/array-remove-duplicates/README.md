# Array Remove Duplicates
Removing duplicate values from an array without LINQ.

## Task
Given an integer array containing duplicate values, remove all duplicates and return only unique elements.

## Approach
Iterated through the original array and added each element to a HashSet, which automatically discards duplicates. The resulting HashSet was then copied into a new array for output.

## Example Output
```
Original: 1 2 3 2 4 3 5 1
Cleaned: 1 2 3 4 5
```

## Time Complexity
O(n) — single pass to fill the HashSet, single pass to copy to array. HashSet operations are O(1).
