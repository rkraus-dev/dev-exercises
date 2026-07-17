# Exercise 10 – Weapon Shop
Practicing class definition with private fields, manual properties, validation, constructor, and methods.

## Task
Define a Weapon class with private fields for name, damage, and price. Expose all three via manual properties with getters and setters. Add validation for negative damage and price values. Implement a constructor, a DisplayInfo method, and an ApplyDiscount method.

## Approach
Used private fields with underscore prefix for all three properties. Damage and Price setters reject negative values and print an error message. ApplyDiscount calculates the new price using double division to avoid integer truncation. The constructor sets all values via properties to reuse validation logic.

## Example Output
```
Name: Sword | Damage: 50 | Price: 100
Name: Bow | Damage: 50 | Price: 80

Applying 20% discount to Sword...
Name: Sword | Damage: 50 | Price: 80
Invalid value!
````

## Time Complexity
O(1) — all operations are constant time.