namespace H.Generators;

public readonly record struct SchemaData(
    string Name,
    string Description,
    string Type,
    string SchemaType,
    string? Format,
    IReadOnlyCollection<string> EnumValues,
    IReadOnlyCollection<SchemaData> Properties,
    IReadOnlyCollection<SchemaData> ArrayItem,
    bool IsRequired,
    bool IsNullable,
    string DefaultValue);