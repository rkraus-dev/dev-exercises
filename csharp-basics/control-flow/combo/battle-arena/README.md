# Battle Arena
Combining control flow structures: for loop, if/else if/else, switch expression, ternary operator, and do-while loop.

## Task
Simulate a 5-round battle arena. Each round generates random damage and categorizes the hit. After all rounds, evaluate the hero's rank based on critical hits, determine victory or defeat, and ask the user to play again.

## Approach
Used a for loop for the 5 rounds with random damage generation. If/else if/else categorizes each hit. A switch expression maps critical hit count to a rank using the or keyword for multiple cases. A ternary operator determines the final result. A do-while loop wraps everything to allow replaying, resetting the counter before each new game.

## Example Output
```
Round 1: 92 - Critical Hit!
Round 2: 45 - Weak Hit!
Round 3: 67 - Normal Hit!
Round 4: 88 - Critical Hit!
Round 5: 55 - Normal Hit!

Critical Hits: 2
Rank: Rookie
Result: Defeat!

Play again? (y/n):
``` 

## Time Complexity
O(1) — fixed 5 rounds regardless of input.
