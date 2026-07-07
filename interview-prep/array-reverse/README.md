# Array Reverse
Reversing an array in place without using built-in reverse methods.

## Task
Given an integer array, reverse the order of its elements in place without using Array.Reverse() or LINQ.

## Approach
Used a for loop iterating only to the halfway point of the array. At each step, the first and last elements are swapped using a temp variable, then moving inward. Iterating only to the midpoint prevents elements from being swapped back to their original position.

## Example Output
```
Original: 1 2 3 4 5
Reversed: 5 4 3 2 1
```

## Time Complexity
O(n) — each element is visited once. O(1) space — swapped in place, no extra array needed.
git commit -m "docs(interview-prep): add README for array-reverse"