// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// Calculates the maximum number of tokens possible to generate for a model. <br/>
/// Returns the maximum input number of tokens for a embedding model. <br/>
/// According https://platform.openai.com/docs/models/overview <br/>
/// </summary>
public static class ContextLengths
{
    /// <inheritdoc cref="ContextLengths"/>
    /// <param name="model"></param>
    /// <returns></returns>
    public static int? TryGet(ChatModel model)
    {
        return model.Value switch
        {
            // GPT models
            ChatModel.Gpt4Value => 8_192,
            ChatModel.Gpt4_0613Value => 8_192,
            
            ChatModel.Gpt4_32kValue => 32_768,
            ChatModel.Gpt4_32k_0613Value => 32_768,
            
            ChatModel.Gpt4_1106_PreviewValue => 128_000,
            ChatModel.Gpt4VisionPreviewValue => 128_000,
            
            ChatModel.Gpt35TurboValue => 4_096,
            ChatModel.Gpt35Turbo_0613Value => 4_096,
            
            ChatModel.Gpt35Turbo_16kValue => 16_384,
            ChatModel.Gpt35Turbo_16k_0613Value => 16_384,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGet(ChatModel)"/>
    public static int Get(ChatModel model)
    {
        return TryGet(model) ??
               throw new NotImplementedException();
    }
    
    /// <inheritdoc cref="ContextLengths"/>
    /// <param name="model"></param>
    /// <returns></returns>
    public static int? TryGet(EmbeddingModel model)
    {
        return model.Value switch
        {
            // GPT models
            EmbeddingModel.Ada002Value => 8_191,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGet(EmbeddingModel)"/>
    public static int Get(EmbeddingModel model)
    {
        return TryGet(model) ??
               throw new NotImplementedException();
    }
    
    /// <inheritdoc cref="ContextLengths"/>
    /// <param name="model"></param>
    /// <returns></returns>
    public static int? TryGet(string model)
    {
        return model switch
        {
            "ada" or "text-ada-001" => 2_049,
            "text-babbage-001" => 2_040,
            "babbage" => 2_049,
            "text-curie-001" => 2_049,
            "curie" => 2_049,
            "davinci" => 2_049,
            "text-davinci-003" => 4_097,
            "text-davinci-002" => 4_097,
            "code-davinci-002" => 8_001,
            "code-davinci-001" => 8_001,
            "code-cushman-002" => 2_048,
            "code-cushman-001" => 2_048,
            
            _ => null,
        };
    }
    
    /// <inheritdoc cref="TryGet(string)"/>
    public static int Get(string model)
    {
        return TryGet(model) ??
               throw new NotImplementedException();
    }
}