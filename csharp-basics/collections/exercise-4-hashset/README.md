# HashSet<T>
Exercise practicing HashSet<T> and set operations in C#.

## Task
Create two HashSets representing fruits with some overlapping values. Demonstrate that duplicate values are ignored, then use copies of the sets to find the shared fruits (intersection) and the fruits unique to the first set (difference), without modifying the original set.

## Features
- Two `HashSet<string>` instances with partially overlapping values
- Duplicate `Add()` call demonstrating that duplicates are ignored
- `IntersectWith()` applied to a copy to find shared fruits
- `ExceptWith()` applied to a separate copy to find fruits unique to the first set
- Original set left unmodified by working on copies

## Example Output
```
3
Apple
Kiwi
Banana
``` 

## Exercise
Arrays & Collections

## Topics Practiced
- HashSet<T> creation and uniqueness behavior
- Add and duplicate handling
- Copying a HashSet
- IntersectWith and ExceptWith set operations