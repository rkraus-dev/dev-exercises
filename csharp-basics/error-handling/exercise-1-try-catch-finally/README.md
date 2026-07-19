# Try / Catch / Finally
Exercise practicing exception handling with try, catch, and finally in C#.

## Task
Create a `Divide(int a, int b)` method and call it three times, each wrapped in its own try/catch/finally block: once with valid values, once triggering a division by zero, and once triggering an array index out of range. Use specific catch blocks alongside a general fallback, and print a message in finally confirming each attempt is complete.

## Features
- `Divide(int, int)` method performing integer division
- Three independent try/catch/finally blocks
- Specific `DivideByZeroException` and `IndexOutOfRangeException` catch blocks
- General `catch (Exception ex)` as a fallback
- `finally` block printing a completion message for every attempt

## Example Output
```
5
Attempt finished.

Cannot divide by zero: Attempted to divide by zero.
Attempt finished.

Invalid index: Index was outside the bounds of the array.
Attempt finished.
```

## Exercise
Error Handling

## Topics Practiced
- try/catch/finally structure
- Specific vs. general exception catching
- Exception.Message
- DivideByZeroException, IndexOutOfRangeException