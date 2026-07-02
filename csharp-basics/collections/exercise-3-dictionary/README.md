# Dictionary<TKey, TValue>
Exercise practicing Dictionary<TKey, TValue> operations in C#.

## Task
Build a small product price list using `Dictionary<string, double>`. Add a new entry, update an existing price via indexer syntax, remove an entry, safely look up a non-existing product with `TryGetValue`, and print all remaining entries.

## Features
- Initial dictionary populated with starting products and prices
- `Add()` used to add a new product
- Indexer syntax used to update an existing price
- `Remove()` used to remove a product
- `TryGetValue()` used to safely check for a non-existing product
- `foreach` loop printing all remaining key-value pairs

## Example Output
``` 
Product not found
Bread: 1.1
Milk: 0.5
Flour: 0.39
```

## Exercise
Arrays & Collections

## Topics Practiced
- Dictionary<TKey, TValue> creation and initialization
- Add, indexer update, Remove
- TryGetValue for safe key lookup
- Dictionary iteration with foreach and KeyValuePair