# Merge Strings Alternately
**LeetCode:** https://leetcode.com/problems/merge-strings-alternately/
**Difficulty:** Easy · **Source:** LeetCode 75

## Task
Merge two strings by adding letters in alternating order, starting with
word1. If one string is longer, append its remaining letters to the end.

## Approach
Three phases: (1) A zipper loop up to the length of the shorter word,
appending one letter from each word per round. (2) + (3) One remainder loop
per word, running from the shorter length to the end of that word. The loop
of the exhausted word runs zero times (its condition is false immediately),
so no branching is needed to determine which word is longer.

## Example Output
```
apbqcrfsg
apbqrs
apbqcd
``` 

## Complexity
Time: O(n + m) · Space: O(n + m)
(strictly speaking quadratic with `+=` on string due to copying on every
concatenation – StringBuilder would be the clean variant)

## Learnings
- Difference of lengths ≠ minimum of lengths – the zipper needs the minimum
- for loops check their condition BEFORE the first iteration: remainder
  loops disable themselves when a word is exhausted, no IndexOutOfRange
- A loop condition must check against the length of the word being accessed
- Strings are immutable → `+=` copies everything on each call, StringBuilder avoids this