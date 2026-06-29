# Status Report

Displays a formatted status report for a game character using various string formatting techniques.

## Features
- Left-aligns name using negative width alignment
- Calculates and formats HP as a percentage
- Formats gold using currency format
- Formats play time with thousands separator
- Displays a file path using verbatim string

## Example Output
```
=== Status Report ===
Name:      Kirito
HP:        85,5 %
Gold:      1.500,75 €
Play Time: 4.250,0 hrs
Save Path: C:\SAO\Players\Kirito\save.dat
``` 

## Exercise
C# Basics – String Interpolation & Formatting

## Topics Practiced
- String interpolation ($"")
- Negative width alignment ({value,-N})
- Number formatting (:F1, :C, :N1)
- Verbatim strings (@"")
- Percentage calculation inline