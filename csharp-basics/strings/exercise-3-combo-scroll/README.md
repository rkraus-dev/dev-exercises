# Exercise 3 – Combo Scroll
Combining StringBuilder, string methods, and manual string manipulation.

## Task
Build a text from multiple parts efficiently, search for a word, replace it, reverse the full text, and check if it is a palindrome.

## Approach
Used StringBuilder to concatenate parts without string concatenation overhead. Contains is checked before Replace to capture the original state. After Replace, the result is converted to a string for further operations. The text is reversed manually using a for loop from the last index to zero.

## Example Output
``` 
Scroll: The ancient dragon guards the hidden treasure of the lost kingdom.
Contains 'dragon': True
After replace: The ancient wizard guards the hidden treasure of the lost kingdom.
Reversed: .modgnik tsol eht fo erusaert neddih eht sdraug draziw tneicna ehT
Is palindrome: False
``` 

## Time Complexity
O(n) — single pass for building, replacing, and reversing.