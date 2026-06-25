# TryParse Demo

Demonstrates the use of TryParse for safe string-to-number conversion.

## Features
- Parses a valid numeric string to int
- Attempts to parse an invalid string to int
- Outputs success status and resulting value for each attempt

## Example Output
```
=== TryParse Demo ===
Input: "9823"   → Success: True  | Value: 9823
Input: "Rudeus" → Success: False | Value: 0
```

## Exercise
C# Basics – Type Conversion

## Topics Practiced
- int.TryParse()
- out variables
- Handling invalid input safely
bashgit add README.md
git commit -m "docs(type-conversion): add tryparse demo readme"
git push