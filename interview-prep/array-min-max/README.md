# Array Min Max
Finding the minimum and maximum values in an array without built-in methods.

## Task
Given an integer array, find the largest and smallest values without using Math.Max, Math.Min, or LINQ.

## Approach
Initialized both min and max with the first array element to handle negative numbers correctly. Iterated through the array in a single pass, updating max when a larger value is found and min when a smaller value is found. Printing and searching are combined in one loop for efficiency.

## Example Output
```
Stats: 42 17 85 3 66 29
Max: 85
Min: 3
```

## Time Complexity
O(n) — single pass through the array.