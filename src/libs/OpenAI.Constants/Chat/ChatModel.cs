namespace OpenAI.Constants;

// ReSharper disable InconsistentNaming
#pragma warning disable CA1707

/// <summary>
/// According https://platform.openai.com/docs/models/
/// <remarks>
/// GPT-4 is currently in a limited beta and only accessible to those who have been granted access. Please join the waitlist to get access. <br/>
/// OpenAI models are non-deterministic, meaning that identical inputs can yield different outputs.
/// Setting temperature to 0 will make the outputs mostly deterministic, but a small amount of variability may remain.
/// </remarks>
/// </summary>
public readonly record struct ChatModel(string Value)
{
    /// <inheritdoc cref="Gpt4_0613Value"/>
    /// <remarks>Currently points to gpt-4-0613.</remarks>
    internal const string Gpt4Value = "gpt-4";
    
    /// <summary>
    /// Snapshot of gpt-4 from June 13th 2023 with improved function calling support. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 8,192 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt4_0613Value = "gpt-4-0613";
    
    /// <inheritdoc cref="Gpt4_32k_0613Value"/>
    /// <remarks>Currently points to gpt-4-32k-0613</remarks>
    internal const string Gpt4_32kValue = "gpt-4-32";
    
    /// <summary>
    /// Snapshot of gpt-4-32k from June 13th 2023 with improved function calling support. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 32,768 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt4_32k_0613Value = "gpt-4-32k-0613";
    
    /// <summary>
    /// The latest GPT-4 model with improved instruction following, JSON mode, reproducible outputs, parallel function calling, and more. Returns a maximum of 4,096 output tokens. This preview model is not yet suited for production traffic. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 128,000 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4_1106_PreviewValue = "gpt-4-1106-preview";
    
    /// <summary>
    /// Ability to understand images, in addition to all other GPT-4 Turbo capabilties. Returns a maximum of 4,096 output tokens. This is a preview model version and not suited yet for production traffic. <br/>
    /// According https://platform.openai.com/docs/models/gpt-4-and-gpt-4-turbo <br/>
    /// Max tokens: 128,000 tokens <br/>
    /// Training data: Up to Apr 2023 <br/>
    /// </summary>
    internal const string Gpt4VisionPreviewValue = "gpt-4-vision-preview";
    
    /// <summary>
    /// Most capable GPT-3.5 model and optimized for chat at 1/10th the cost of text-davinci-003. <br/>
    /// Will be updated with our latest model iteration 2 weeks after it is released. <br/>
    /// Max tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// <remarks>On June 27th, 2023, gpt-3.5-turbo will be updated to point from gpt-3.5-turbo-0301 to gpt-3.5-turbo-0613.</remarks>
    /// </summary>
    internal const string Gpt35TurboValue = "gpt-3.5-turbo";
    
    /// <summary>
    /// Snapshot of gpt-3.5-turbo from June 13th 2023 with function calling data. <br/>
    /// Unlike gpt-3.5-turbo, this model will not receive updates, and will be deprecated 3 months after a new version is released. <br/>
    /// Max tokens: 4,096 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_0613Value = "gpt-3.5-turbo-0613";
    
    /// <summary>
    /// Same capabilities as the standard gpt-3.5-turbo model but with 4 times the context. <br/>
    /// Max tokens: 16,384 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_16kValue = "gpt-3.5-turbo-16k";
    
    /// <summary>
    /// Snapshot of gpt-3.5-turbo-16k from June 13th 2023. <br/>
    /// Unlike gpt-3.5-turbo-16k, this model will not receive updates, and will be deprecated 3 months after a new version is released. <br/>
    /// Max tokens: 16,384 tokens <br/>
    /// Training data: Up to Sep 2021 <br/>
    /// </summary>
    internal const string Gpt35Turbo_16k_0613Value = "gpt-3.5-turbo-16k-0613";
    
    /// <inheritdoc cref="Gpt4Value"/>
    public static ChatModel Gpt4 { get; } = new(Gpt4Value);
    
    /// <inheritdoc cref="Gpt4_0613Value"/>
    public static ChatModel Gpt4_0613 { get; } = new(Gpt4_0613Value);
    
    /// <inheritdoc cref="Gpt4_32kValue"/>
    public static ChatModel Gpt4_32k { get; } = new(Gpt4_32kValue);
    
    /// <inheritdoc cref="Gpt4_32k_0613Value"/>
    public static ChatModel Gpt4_32k_0613 { get; } = new(Gpt4_32k_0613Value);
    
    /// <inheritdoc cref="Gpt4_1106_PreviewValue"/>
    public static ChatModel Gpt4_1106_Preview { get; } = new(Gpt4_1106_PreviewValue);
    
    /// <inheritdoc cref="Gpt4VisionPreviewValue"/>
    public static ChatModel Gpt4VisionPreview { get; } = new(Gpt4VisionPreviewValue);
    
    /// <inheritdoc cref="Gpt35TurboValue"/>
    public static ChatModel Gpt35Turbo { get; } = new(Gpt35TurboValue);
    
    /// <inheritdoc cref="Gpt35Turbo_0613Value"/>
    public static ChatModel Gpt35Turbo_0613 { get; } = new(Gpt35Turbo_0613Value);
    
    /// <inheritdoc cref="Gpt35Turbo_16kValue"/>
    public static ChatModel Gpt35Turbo_16k { get; } = new(Gpt35Turbo_16kValue);
    
    /// <inheritdoc cref="Gpt35Turbo_16k_0613Value"/>
    public static ChatModel Gpt35Turbo_16k_0613 { get; } = new(Gpt35Turbo_16k_0613Value);

    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ChatModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ChatModel model)
    {
        return model.Value;
    }
}