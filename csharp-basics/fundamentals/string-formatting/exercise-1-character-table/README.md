# Character Table

Displays a formatted character table with aligned columns using string interpolation and formatting.

## Features
- Left-aligns names and levels using negative width alignment
- Formats mana and gold with thousands separator and two decimal places
- Outputs a clean, readable table to the console

## Example Output
```
=== Character Table ===
Name                 | Level    | Mana       | Gold
Rudeus Greyrat       | 42       |   9.823,77 | 1.500,75 G
Eris Boreas          | 38       |   4.200,00 |   800,50 G
Roxy Migurdia        | 55       |  15.000,00 | 3.200,25 G
```

## Exercise
C# Basics – String Interpolation & Formatting

## Topics Practiced
- String interpolation ($"")
- Alignment with PadRight() and negative width ({value,-N})
- Number formatting (:N2)
- Console table layout
bashgit add README.md
git commit -m "docs(string-formatting): add character table readme"
git push