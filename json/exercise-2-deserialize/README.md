# JSON Deserialization
Exercise practicing JsonSerializer.Deserialize<T>() in C#.

## Task
Create an `Item` class and deserialize a single JSON object into an instance of it. Deserialize a JSON array into a `List<Item>` and print each element. Additionally, attempt to deserialize intentionally broken JSON and handle the resulting JsonException.

## Features
- `Item` class with `Name`, `Amount`, and `IsRare` properties
- Single object deserialized via `JsonSerializer.Deserialize<Item>()`
- JSON array deserialized via `JsonSerializer.Deserialize<List<Item>>()`
- Broken JSON caught with `try`/`catch` for `JsonException`

## Example Output
```
Wand, 1, False
Wand, 1, False
Sword, 1, True
Failed to parse JSON: '{' is invalid after a single JSON value...
```

## Exercise
JSON

## Topics Practiced
- JsonSerializer.Deserialize<T>()
- Deserializing single objects vs. lists
- Raw string literals for JSON
- Handling JsonException