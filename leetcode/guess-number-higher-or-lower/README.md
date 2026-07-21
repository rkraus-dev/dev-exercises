# Guess Number Higher or Lower
Practicing Binary Search (LeetCode 374, Easy)

## Task
A number between 1 and n has been picked. Each guess is answered by a
predefined API `guess(num)` that returns 0 (correct), -1 (guess is too
high) or 1 (guess is too low). Find the picked number with as few
guesses as possible.

## Approach
Classic binary search: keep a search range `[low, high]`, check the
middle element and use the API feedback to discard the half that
cannot contain the answer. The midpoint is calculated as
`low + (high - low) / 2` instead of `(low + high) / 2` to avoid
integer overflow when both bounds are close to `int.MaxValue`.

For local testing, the hidden `GuessGame` base class was rebuilt with
a constructor so each test case can set its own picked number.

## Example Output
```
6
1
1702766719
```

## Time Complexity
O(log n) — the search range is halved with every guess, so even for
n ≈ 2.1 billion the answer is found in at most ~31 guesses.