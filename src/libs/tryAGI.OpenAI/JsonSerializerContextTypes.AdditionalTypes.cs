namespace tryAGI.OpenAI;

using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

public sealed partial class JsonSerializerContextTypes
{
    /// <summary>
    /// To fix issue with LogitBias.
    /// </summary>
    public Dictionary<string, double>? StringDoubleDictionary { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public CreateChatCompletionStreamResponse? CreateChatCompletionStreamResponse { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public CSharpToJsonSchema.OpenApiSchema? OpenApiSchema { get; set; }
}

public sealed partial class SourceGenerationContext
{
    /// <summary>
    /// JSON metadata for OpenAPI schema payloads used by tool/function helpers.
    /// </summary>
    public JsonTypeInfo<CSharpToJsonSchema.OpenApiSchema> OpenApiSchema =>
        AdditionalSourceGenerationContext.Default.OpenApiSchema;

    /// <summary>
    /// JSON metadata for response format JSON schema payloads.
    /// </summary>
    public JsonTypeInfo<ResponseFormatJsonSchemaSchema> ResponseFormatJsonSchemaSchema =>
        (JsonTypeInfo<ResponseFormatJsonSchemaSchema>)GetTypeInfo(typeof(ResponseFormatJsonSchemaSchema))!;

    /// <summary>
    /// JSON metadata for function parameter schema payloads.
    /// </summary>
    public JsonTypeInfo<FunctionParameters> FunctionParameters =>
        (JsonTypeInfo<FunctionParameters>)GetTypeInfo(typeof(FunctionParameters))!;
}

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(CSharpToJsonSchema.OpenApiSchema))]
internal sealed partial class AdditionalSourceGenerationContext : JsonSerializerContext;
