# Word Counter

Reads a user-provided sentence, counts word occurrences using a Dictionary, and identifies duplicates using a HashSet.

## Task

Prompt the user for a sentence, split it into words, and count how often each word appears. Collect all words that appear more than once into a HashSet and display both results.

## Approach

Used a do-while loop to validate user input. The input is trimmed, lowercased, and split by spaces before processing. A Dictionary stores each word as a key with its count as the value. A HashSet is populated with words whose count exceeds one.

## Example Output
```
Please enter a sentence: the fox and the fox

Word Counts:
the: 2
fox: 2
and: 1

Duplicates:
the
fox
```

## Time Complexity
O(n) — single pass to count words, single pass to find duplicates.