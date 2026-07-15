# Exercise 2 – Swap
Practicing ref parameters by swapping two integer values inside a method.

## Task
Implement a Swap method that takes two integers by reference and swaps their values. Print the values before and after the swap.

## Approach
Used ref parameters to pass variables by reference instead of by value. This allows the method to modify the original variables directly. Inside the method, a temp variable saves one value before it gets overwritten.

## Example Output
```
Before: a = 10, b = 25
After:  a = 25, b = 10
```

## Time Complexity
O(1) — constant time, no loops.