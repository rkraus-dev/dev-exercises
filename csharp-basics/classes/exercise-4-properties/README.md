# Bank Account
Exercise practicing properties, auto-properties, and property validation in C#.

## Task
Create a `BankAccount` class with an auto-property for the owner, a full property for the balance with validation preventing negative values, and a read-only (externally) property for the account ID set only in the constructor. Test setting a valid balance, an invalid negative balance, and reading the account ID from outside the class.

## Features
- `Owner` as an auto-property (`get; set;`)
- `Balance` as a full property with validation: negative values are reset to `0`
- `AccountId` as a property with `get; private set;`, settable only within the class
- Constructor setting `Owner` and `AccountId`

## Example Output
```
999.99
0
1234
```

## Exercise
Classes & OOP

## Topics Practiced
- Auto-properties
- Full properties with get/set
- Property validation using `value`
- Restricted property access with `private set`
- Access modifiers on constructors
