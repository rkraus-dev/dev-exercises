# Exercise 6 – 2D Arrays
Working with two-dimensional arrays: grid traversal, counting, and position finding.

## Task
Create a 3x3 string grid containing enemies ("E"), allies ("A"), and empty cells ("."). Print the grid, count all enemies, and find the position of the first enemy.

## Approach
Used nested for loops with GetLength(0) and GetLength(1) to keep the code flexible. Counting and printing are combined in a single pass. A second nested loop finds the first enemy position and exits early with return.

## Example Output
```
Battle Grid:
. E .
A . E
. . A

Enemy count: 2
First enemy at: [0, 1]
``` 

## Time Complexity
O(n*m) — full grid traversal for counting, early exit for first enemy search.