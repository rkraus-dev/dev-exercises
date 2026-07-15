# Exercise 5 – Number Guessing Loop
Practicing do-while loops, input validation, and conditional logic.

## Task
The program picks a hardcoded target number between 1 and 10. The user guesses until correct. Invalid input (non-numeric or out of range) is rejected with a message. Each valid attempt is counted and displayed at the end.

## Approach
Used a do-while loop that runs until the correct number is guessed. Input is read as a string and validated with int.TryParse. Range validation is handled separately from the guess logic. The counter only increments on valid guesses.

## Example Output
```
Guess a number between 1 and 10: 3
Too low!
Guess a number between 1 and 10: 9
Too high!
Guess a number between 1 and 10: 7
Correct! You guessed it in 3 attempts.
``` 

## Time Complexity
O(n) — depends on the number of guesses made.