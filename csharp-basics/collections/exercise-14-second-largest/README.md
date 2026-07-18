# Exercise 14 – Second Largest
Finding the largest and second largest values in an array without Sort() or LINQ.

## Task
Given an integer array, find the largest and second largest values using loops only.

## Approach
Used two separate foreach loops for clarity. The first finds the largest value by tracking the maximum. The second skips the largest value with continue and finds the next highest using a simple comparison.

## Example Output
```
Stats: 42 17 85 3 66 29
Largest: 85
Second largest: 66
```

## Time Complexity
O(n) — two separate passes through the array.