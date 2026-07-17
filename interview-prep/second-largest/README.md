# Second Largest
Practicing single-pass array scanning with tracker variables and nullable types.

## Task
Find the second highest distinct value in an unsorted integer array without sorting it.
Duplicates of the maximum do not count as second place (in { 90, 90, 75 } the answer is 75).
Arrays with fewer than two distinct values must be handled gracefully.

## Approach
The array is scanned exactly once with a foreach loop while two tracker variables
(highest and secondHighest) are updated on the fly. When a new maximum appears, the
old maximum is demoted to secondHighest before being replaced. Both trackers are
nullable (int?) so that null cleanly represents "no value found yet" and the method
can return null when no second place exists - avoiding misleading sentinel values like 0.

## Example Output
```
=== Tournament of Silberklamm ===
Scores: 34, 78, 91, 78, 12, 56
Champion: 91 | Silver Sword goes to: 78

Scores: 90, 90, 75
Champion: 90 | Silver Sword goes to: 75

Scores: 7, 7, 7
No second place - the Silver Sword stays in the vault!
```

## Time Complexity
O(n) - the array is traversed exactly once, and each element is processed in constant time.