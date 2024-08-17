using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization.Metadata;

namespace OpenAI;

/// <summary>
/// 
/// </summary>
public static class TypeToSchemaHelpers
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="typeInfo"></param>
    /// <param name="strict"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    /// <exception cref="InvalidOperationException"></exception>
    public static ResponseFormatJsonSchemaSchema AsJsonSchema(
        JsonTypeInfo typeInfo,
        bool strict)
    {
        typeInfo = typeInfo ?? throw new ArgumentNullException(nameof(typeInfo));
        var resolver = typeInfo.OriginatingResolver ?? throw new InvalidOperationException("OriginatingResolver is required.");
        
#pragma warning disable IL2026
        return AsJsonSchema(typeInfo.Type, strict, resolver, typeInfo.Options);
#pragma warning restore IL2026
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <param name="strict"></param>
    /// <param name="jsonTypeInfoResolver"></param>
    /// <param name="options"></param>
    /// <returns></returns>
#if NET6_0_OR_GREATER
    [RequiresUnreferencedCode("This method uses reflection to generate a JSON schema. Use overload with IJsonTypeInfoResolver parameter to avoid this")]
#endif
    public static ResponseFormatJsonSchemaSchema AsJsonSchema(
        Type type,
        bool strict,
        IJsonTypeInfoResolver? jsonTypeInfoResolver = null,
        JsonSerializerOptions? options = null)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
            
        var schema = Create(type, strict);
        if (schema.Type == "object")
        {
            var properties = new Dictionary<string, OpenApiSchema>();
            if (jsonTypeInfoResolver is not null)
            {
                var jsonTypeInfo = jsonTypeInfoResolver.GetTypeInfo(
                    type,
                    options ?? throw new InvalidOperationException("options is required.")) ??
                    throw new InvalidOperationException($"JsonTypeInfo for {type.FullName} is not found.");
                
                foreach (var property in jsonTypeInfo.Properties)
                {
                    properties.Add(property.Name, AsJsonSchema(property.PropertyType, strict, jsonTypeInfoResolver, options));
                }
            }
            else
            {
                foreach (var property in type.GetProperties())
                {
                    properties.Add(property.Name, AsJsonSchema(property.PropertyType, strict));
                }
            }
            schema.Properties = properties;
            schema.Required = properties.Keys.ToArray();
        }
        else if (schema.Type == "array")
        {
            schema.Items = AsJsonSchema(
                type.GetElementType() ?? throw new InvalidOperationException("Array type must have an element type."),
                strict: strict,
                jsonTypeInfoResolver,
                options);
        }
            
        return schema;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static (string Type, string? Format) ToOpenApiTypeAndFormat(Type type)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
            
        if (type.FullName == "System.String")
        {
            return ("string", null);
        }
        if (type.FullName == "System.Int64")
        {
            return ("integer", "int64");
        }
        if (type.FullName == "System.Int32")
        {
            return ("integer", "int32");
        }
        if (type.FullName == "System.Single")
        {
            return ("number", "float");
        }
        if (type.FullName == "System.Double")
        {
            return ("number", "double");
        }
        if (type.FullName == "System.DateTime")
        {
            return ("string", "date-time");
        }
        if (type.FullName == "System.Boolean")
        {
            return ("boolean", null);
        }
        if (type.IsEnum)
        {
            return ("string", null);
        }
        if (type.IsArray)
        {
            return ("array", null);
        }
            
        return ("object", null);
    }


    private static ResponseFormatJsonSchemaSchema Create(Type type, bool strict)
    {
        var (schemaType, format) = ToOpenApiTypeAndFormat(type);
        var schema = new ResponseFormatJsonSchemaSchema
        {
            Type = schemaType,
            Format = strict ? null : format,
        };
        if (type.IsEnum)
        {
            schema.Enum = type.GetEnumNames();
        }
        
        return schema;
    }
    
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
    public static ResponseFormatJsonSchemaJsonSchema AsResponseFormat(Type type, bool strict)
    {
        type = type ?? throw new ArgumentNullException(nameof(type));
            
        return new ResponseFormatJsonSchemaJsonSchema
        {
            Description = string.Empty,
            Name = type.Name,
            Strict = strict,
            Schema = AsJsonSchema(type, strict),
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
            Schema = AsJsonSchema(typeInfo.Type, strict, resolver, typeInfo.Options),
#pragma warning restore IL2026
        };
    }
}