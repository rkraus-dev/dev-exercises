# Palindrome Check
Checking whether a word is a palindrome using a two-pointer approach without Reverse() or LINQ.

## Task
Read a word from the user and determine whether it reads the same forwards and backwards. The check is case-insensitive and ignores leading/trailing whitespace.

## Approach
Used a for loop iterating from both ends toward the middle. At each step, the character at position i is compared with the character at the mirrored position. If any mismatch is found, the loop exits early with break. The word is lowercased and trimmed before the check to handle casing and whitespace.

## Example Output
``` 
Enter a word: racecar
racecar is a palindrome!
Enter a word: hello
hello is not a palindrome!
``` 

## Time Complexity
O(n) — at most half the characters are visited. Early exit on first mismatch.