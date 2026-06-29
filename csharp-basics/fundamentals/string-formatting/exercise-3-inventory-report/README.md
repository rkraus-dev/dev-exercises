# Inventory Report

Displays a formatted inventory table with item prices, quantities, and a grand total.

## Features
- Left-aligns item names using negative width alignment
- Right-aligns quantities, prices, and totals
- Calculates total value per item and grand total
- Outputs a separator line using new string()

## Example Output
```
=== Inventory Report ===
Item                 | Qty  | Price/Unit  | Total
Healing Potion       | 15   |        5,99 |      89,85
Mana Crystal         | 8    |       24,99 |     199,92
Teleport Scroll      | 3    |       99,99 |     299,97
─────────────────────────────────────────────────────
Grand Total:                                   589,74
```

## Exercise
C# Basics – String Interpolation & Formatting

## Topics Practiced
- String interpolation ($"")
- Left and right alignment ({value,-N}, {value,N})
- Decimal formatting (:N2)
- new string() for separator lines
- Calculated totals with decimal