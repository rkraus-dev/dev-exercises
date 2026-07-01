# Method Overloading
Exercise practicing method overloading in C#.

## Task
Create at least three overloaded versions of a `DisplayInfo` method, each accepting a different combination of parameters. Call all overloads from `Main` to demonstrate that the correct overload is selected based on the arguments provided.

## Features
- `DisplayInfo(string)` printing only the name
- `DisplayInfo(string, int)` printing name and age
- `DisplayInfo(string, int, string)` printing name, age, and job
- Explicit `class Program` structure required, since local functions in top-level statements do not support overloading

## Example Output
```
Hey, my name is Robert
Hey, my name is Robert, im 28 years old.
Hey, my name is Robert, im 28 years old and my job is Developer
```

## Exercise
Methods

## Topics Practiced
- Method overloading
- Overload resolution
- Difference between local functions and class methods regarding overloading