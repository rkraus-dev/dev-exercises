# Exercise 15 – HashSet Intersect
Practicing HashSet set operations: finding common elements and elements unique to one set.

## Task
Given two HashSets of guild members, find the members that appear in both guilds and the members that appear only in the first guild.

## Approach
Created copies of guild1 before performing set operations since IntersectWith and ExceptWith modify the HashSet in place. Used IntersectWith on the first copy to find common members, and ExceptWith on the second copy to find members exclusive to guild1.

## Example Output
```
Guild 1: Archer Mage Warrior Healer
Guild 2: Mage Paladin Warrior Rogue

Common members: Mage Warrior
Only in Guild 1: Archer Healer
```

## Time Complexity
O(n) — linear for set operations and iteration.