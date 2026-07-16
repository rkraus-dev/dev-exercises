# Interfaces
Exercise practicing interface definition and implementation in C#.

## Task
Define two interfaces, `IWorkable` and `IManageable`. Create a `Manager` class implementing both interfaces and an `Employee` class implementing only `IWorkable`. Write a standalone `DoWork(IWorkable worker)` method that works with any object implementing `IWorkable`, regardless of its concrete type.

## Features
- `IWorkable` interface with a `Work()` method
- `IManageable` interface with a `ManageTeam()` method
- `Manager` class implementing both interfaces
- `Employee` class implementing only `IWorkable`
- Standalone `DoWork()` method demonstrating polymorphic behavior via interfaces

## Example Output
``` 
Manager is working.
Employee is working.
Manager is managing the team.
```

## Exercise
Classes & OOP

## Topics Practiced
- Interface definition
- Interface implementation
- Implementing multiple interfaces in one class
- Passing interface types as method parameters
- Difference between class members and standalone (top-level) methods