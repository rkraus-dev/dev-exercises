# Exercise 13 – Spellbook
Practicing Dictionary operations: adding, updating, searching, and finding the maximum value.

## Task
Manage a spellbook stored as a Dictionary with spell names as keys and mana costs as values. Add a new spell, upgrade an existing one, check if a spell exists, find the most expensive spell, and print the updated spellbook.

## Approach
Used Dictionary<string, int> for key-value storage. Added a new entry with Add, updated an existing value via index access. ContainsKey checks membership. The most expensive spell is found using the same min/max pattern — iterating through KeyValuePairs and tracking the highest value.

## Example Output
``` 
Spells:
Fireball: 30 mana
Ice Spike: 20 mana
Thunder: 45 mana
Heal: 15 mana

Adding Meteor...
Upgrading Fireball...

Shadow in spellbook: False

Most expensive spell: Meteor (60 mana)

Updated Spells:
Fireball: 35 mana
Ice Spike: 20 mana
Thunder: 45 mana
Heal: 15 mana
Meteor: 60 mana
``` 

## Time Complexity
O(n) — linear pass for iteration and max search. O(1) for Add, Remove, ContainsKey.