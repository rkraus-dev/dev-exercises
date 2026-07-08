# Array Bubble Sort
Sorting an array in ascending order using Bubble Sort without Array.Sort() or LINQ.

## Task
Given an integer array, sort all elements in ascending order using the Bubble Sort algorithm.

## Approach
Used a while loop with a boolean flag to track whether any swaps occurred during a pass. At the start of each pass the flag is set to true. If a swap occurs, the flag is set to false, forcing another pass. The loop stops when a full pass completes with no swaps. A for loop handles the comparisons, swapping adjacent elements using a temp variable when the left element is greater than the right.

## Example Output
```
Original: 42 17 85 3 66 29
Sorted: 3 17 29 42 66 85
``` 

## Time Complexity
O(n²) — worst case, every element is compared with every other element. O(n) best case when the array is already sorted.