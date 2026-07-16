# Exercise 8 – Counter
Practicing static fields, properties, and methods vs instance members.

## Task
Define a Hero class with a static counter that tracks how many heroes have been created. Each time a new hero is instantiated, the counter increments. A static method prints the current count.

## Approach
Used a private static field _heroCount to store the count across all instances. A static read-only property HeroCount exposes it. The constructor increments the counter on every new Hero. PrintCount is static because it only accesses class-level data, not instance data.

## Example Output
``` 
Arthur joined the guild.
Total heroes: 1
Merlin joined the guild.
Total heroes: 2
Lancelot joined the guild.
Total heroes: 3
``` 

## Time Complexity
O(1) — all operations are constant time.