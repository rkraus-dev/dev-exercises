# Item Lookup

Displays an item profile with nullable fields using null-handling operators.

## Features
- Uses ?. to safely call ToString() on nullable value types
- Uses ?? to provide fallback strings for null values
- Uses ?. combined with ?? to safely access string length

## Example Output
```
=== Item Lookup ===
Item Name:   Excalibur
Item ID:     No ID
Price:       No Price
Discounted:  No Price
Description: No description available
Name Length: 9
```

## Exercise
C# Basics – Nullability & Null-Checks

## Topics Practiced
- Nullable reference types (string?)
- Nullable value types (int?, decimal?)
- Null-coalescing operator (??)
- Null-conditional operator (?.)
- Safe property access on nullable types