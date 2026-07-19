# Custom Exceptions
Exercise practicing custom exception classes in C#.

## Task
Create a custom `InsufficientFundsException` class inheriting from `Exception`. Build a `BankAccount` class with a `Withdraw` method that throws the custom exception when the requested amount exceeds the balance. Test both a valid and an invalid withdrawal attempt.

## Features
- `InsufficientFundsException` custom exception class using `: base(message)`
- `BankAccount` class with a `Balance` property and a `Withdraw(double)` method
- Valid withdrawal reducing the balance normally
- Invalid withdrawal caught specifically via `catch (InsufficientFundsException ex)`

## Example Output
```
Cannot withdraw 150, only 20 available.
```

## Exercise
Error Handling

## Topics Practiced
- Creating custom exception classes
- Inheriting from System.Exception
- Throwing exceptions with throw
- Catching specific custom exception types