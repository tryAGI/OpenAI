namespace H.Generators;

public readonly record struct MethodData(
    string Name,
    string Description,
    bool IsAsync,
    bool IsVoid,
    SchemaData Parameters);