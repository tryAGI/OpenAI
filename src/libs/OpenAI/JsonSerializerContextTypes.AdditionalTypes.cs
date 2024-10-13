namespace OpenAI;

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