# Array Remove Duplicates V2
Removing duplicate values from an array using nested loops, without HashSet or LINQ.

## Task
Given an integer array containing duplicate values, remove all duplicates using only loops and a helper array.

## Approach
Used a nested loop approach. The outer loop iterates through the original array. The inner loop checks if the current value already exists in the cleaned array by comparing each element up to the current counter. If no duplicate is found, the value is added to the cleaned array and the counter is incremented.

## Example Output
```
Original: 1 2 3 2 4 3 5 1
Cleaned: 1 2 3 4 5
``` 

## Time Complexity
O(n²) — for each element, all previously added elements are checked. Less efficient than the HashSet approach (O(n)).