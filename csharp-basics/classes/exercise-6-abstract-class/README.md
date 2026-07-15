# Abstract Class
Exercise practicing abstract classes and abstract methods in C#.

## Task
Create an abstract `Shape` class with an abstract `CalculateArea()` method and a regular `PrintInfo()` method. Create at least two derived classes (`Circle`, `Rectangle`) that inherit from `Shape`, forward constructor parameters via `base(...)`, and are forced to implement `CalculateArea()` with their own formula.

## Features
- Abstract `Shape` class with a `Name` property and abstract `CalculateArea()` method
- Non-abstract `PrintInfo()` method calling the overridden `CalculateArea()` implementation
- `Circle` derived class calculating area using `π × r²`
- `Rectangle` derived class calculating area using `Height × Width`
- Constructor chaining via `: base(...)`

## Example Output
```
Name: Circle, Area: 467.5016
Name: Rectangle, Area: 12
```

## Exercise
Classes & OOP

## Topics Practiced
- Abstract classes
- Abstract methods
- Mandatory method overriding
- Constructor chaining with base()
- Polymorphic method calls (CalculateArea() resolved at runtime)