using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;
using CSharpToJsonSchema;

namespace tryAGI.OpenAI;

/// <summary>
/// 
/// </summary>
public static class TypeToSchemaHelpers2
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <param name="strict"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
#if NET6_0_OR_GREATER
    [RequiresUnreferencedCode("This method uses reflection to generate a JSON schema. Use overload with JsonTypeInfo parameter to avoid this")]
#endif
    public static ResponseFormatJsonSchemaJsonSchema AsResponseFormat(System.Type type, bool strict)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
            
        return new ResponseFormatJsonSchemaJsonSchema
        {
            Description = string.Empty,
            Name = type.Name,
            Strict = strict,
            Schema = TypeToSchemaHelpers.AsJsonSchema(type, strict),
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="typeInfo"></param>
    /// <param name="strict"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static ResponseFormatJsonSchemaJsonSchema AsResponseFormat(JsonTypeInfo typeInfo, bool strict)
    {
        typeInfo = typeInfo ?? throw new ArgumentNullException(nameof(typeInfo));
        var resolver = typeInfo.OriginatingResolver ?? throw new InvalidOperationException("OriginatingResolver is required.");
        
        return new ResponseFormatJsonSchemaJsonSchema
        {
            Description = string.Empty,
            Name = typeInfo.Type.Name,
            Strict = strict,
#pragma warning disable IL2026
            Schema = TypeToSchemaHelpers.AsJsonSchema(typeInfo.Type, strict, resolver, typeInfo.Options),
#pragma warning restore IL2026
        };
    }
}