# Calculator
Method overloading demonstration using basic arithmetic operations with optional rounding.

## Task
Implement a Calculator class with overloaded Add and Subtract methods. Each operation supports integer input, double input, and double input with a specified number of decimal places for rounding.

## Approach
Created a public Calculator class with three overloads per operation. The rounding variant uses Math.Round with the decimals parameter to control precision.

## Example Output
```
Add(2, 3)          → 5
Add(2.5, 1.3)      → 3.8
Add(2.567, 1.234, 2) → 3.8
Subtract(10, 3)          → 7
Subtract(5.5, 2.1)       → 3.4
Subtract(5.567, 2.234, 2) → 3.33
``` 

## Time Complexity
O(1) — each method performs a single arithmetic operation.