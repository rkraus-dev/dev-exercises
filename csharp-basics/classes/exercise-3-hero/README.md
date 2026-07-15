# Exercise 3 – Hero Profile
Practicing class definition, constructors, access modifiers, and static vs instance members.

## Task
Define a Hero class with private fields, a constructor, an instance method, and a static counter that tracks how many heroes have been created.

## Approach
Used private fields with the underscore prefix convention. The constructor sets name and age via this keyword and increments the static counter. Introduce() is an instance method since it works with instance data. PrintHeroCount() is static since it belongs to the class, not any single instance.

## Example Output
```
Hi, my name is Arthur and I am 25 years old.
Hi, my name is Merlin and I am 47 years old.
Hi, my name is Lancelot and I am 30 years old.
Total heroes: 3
``` 

## Time Complexity
O(1) — all operations are constant time.