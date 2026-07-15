# Inheritance
Exercise practicing inheritance, base/derived classes, and method overriding in C#.

## Task
Create a `Vehicle` base class with a virtual `Describe()` method. Create at least two derived classes (`Car`, `Motorcycle`) that inherit from `Vehicle`, forward constructor parameters via `base(...)`, and override `Describe()` while still calling the base implementation.

## Features
- `Vehicle` base class with `Brand` and `Speed` properties and a virtual `Describe()` method
- `Car` derived class with an additional `NumberOfDoors` property
- `Motorcycle` derived class with an additional `HasSideCar` property
- Constructor chaining via `: base(...)`
- Overridden `Describe()` methods calling `base.Describe()` and adding class-specific output

## Example Output
```
Brandname: BMW, Speed: 230 kmh
The Car have 4 Doors
Brandname: Duccati, Speed: 240 kmh
Does Motorcylce has a sidecar?: False
```

## Exercise
Classes & OOP

## Topics Practiced
- Inheritance (base class, derived class)
- Constructor chaining with base()
- virtual and override
- Calling base class methods with base.MethodName()