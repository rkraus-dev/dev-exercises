# Constructors
Exercise practicing constructors, constructor overloading, and constructor chaining in C#.

## Task
Create an `Item` class with private fields and two constructors: a full constructor accepting all values, and a simplified constructor accepting fewer parameters that chains to the full constructor via `: this(...)` with sensible default values. Create objects using both constructors and print their info.

## Features
- `Item` class with fields `name`, `damage`, and `resistance`
- Full constructor `Item(string, int, int)` using `this.` to distinguish fields from parameters
- Simplified constructor `Item(string)` chaining to the full constructor via `: this(...)`
- `PrintInfo()` method printing formatted item data

## Example Output
```
Name: Sword, Damage: 54, Resistance: 10
Name: Wand, Damage: 10, Resistance: 5
```

## Exercise
Classes & OOP

## Topics Practiced
- Constructors
- Constructor overloading
- The `this` keyword
- Constructor chaining with `: this(...)`
- Target-typed new expressions


