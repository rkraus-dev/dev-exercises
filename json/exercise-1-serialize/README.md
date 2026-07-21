# JSON Serialization
Exercise practicing JsonSerializer.Serialize() in C#.

## Task
Create a `Player` class with multiple public properties of different types and a private field. Serialize a single object and a list of objects using `JsonSerializer.Serialize()`, demonstrating that only public members are included in the output.

## Features
- `Player` class with `Name`, `Level`, `IsOnline`, `Inventory` public properties
- Private field `realName` excluded from serialization
- Single object serialized to a JSON string
- `List<Player>` serialized to a JSON array of objects

## Example Output
```
{"Name":"Hairo","Level":3,"IsOnline":true,"Inventory":["Coins","Potion","Stones"]}
[{"Name":"Kinoas","Level":5,"IsOnline":false,"Inventory":["Sword"]},{"Name":"Katletka","Level":8,"IsOnline":true,"Inventory":["Shield","Potion"]}]
```

## Exercise
JSON

## Topics Practiced
- JsonSerializer.Serialize()
- Public vs. private members in serialization
- Serializing single objects vs. lists of objects