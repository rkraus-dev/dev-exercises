# Player Profile

Displays a player profile with nullable fields using null-handling operators.

## Features
- Uses ?? to provide fallback values for null strings
- Uses ?. combined with ?? to safely handle nullable int
- Safely accesses string length on a nullable string

## Example Output
```
=== Player Profile ===
Name:         Kazuma Satou
Title:        No Title
Guild ID:     No Guild
Location:     Unknown
Title Length: 0
```

## Exercise
C# Basics – Nullability & Null-Checks

## Topics Practiced
- Nullable reference types (string?)
- Nullable value types (int?)
- Null-coalescing operator (??)
- Null-conditional operator (?.)
- Fallback values for null