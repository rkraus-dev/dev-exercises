# Second Largest v2
Practicing single-pass array scanning with tracker variables, nullable types and out parameters.

## Task
Find the second highest distinct value in an unsorted integer array in a single pass,
without sorting. Duplicates of the maximum do not count as second place. Edge cases
(null array, fewer than two elements, all elements equal) must be handled gracefully.

## Approach
The array is traversed once with a foreach loop while two nullable tracker variables
(highest and second) are updated on the fly: a new maximum demotes the old one to
second place before replacing it, and values between the two trackers replace second.
A guard clause rejects null or too-small arrays early, and int? is used so that null
cleanly signals "no second place exists". The maximum is returned via an out parameter
so the caller gets both values from one pass.

## Example Output
``` 
=== Vault of Vorgash ===
Gems: 120, 870, 450, 870, 300
Cursed gem: 870 | The guild takes: 450

Gems: 500, 500, 320
Cursed gem: 500 | The guild takes: 320

Gems: 999
Too risky - the guild leaves empty-handed!
```

## Time Complexity
O(n) - the array is traversed exactly once, and each element is checked in constant time.