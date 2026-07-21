# JsonSerializerOptions
Exercise practicing JsonSerializerOptions for formatting and naming conventions in C#.

## Task
Serialize an object without options, then with `WriteIndented` and `PropertyNamingPolicy.CamelCase` combined, comparing the output. Deserialize a hand-written camelCase JSON string using `PropertyNameCaseInsensitive` to correctly map it to a PascalCase class.

## Features
- Default serialization (compact, PascalCase)
- Serialization with `WriteIndented = true` and `PropertyNamingPolicy = JsonNamingPolicy.CamelCase`
- Deserialization of camelCase JSON using `PropertyNameCaseInsensitive = true`

## Example Output
```
Serialize without options: {"Name":"Sword","Amount":1,"IsRare":true}
Serialize with options: {
"name": "Sword",
"amount": 1,
"isRare": true
}
Sword, 1, True
```

## Exercise
JSON

## Topics Practiced
- JsonSerializerOptions
- WriteIndented
- PropertyNamingPolicy.CamelCase
- PropertyNameCaseInsensitive