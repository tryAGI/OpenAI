namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/api-reference/moderations
/// Two content moderations models are available: text-moderation-stable and text-moderation-latest.
/// </summary>
public readonly record struct ModerationModel(string Value)
{
    /// <summary>
    /// If you use text-moderation-stable, we will provide advanced notice before updating the model. <br/>
    /// Accuracy of text-moderation-stable may be slightly lower than for text-moderation-latest. <br/>
    /// </summary>
    internal const string StableValue = "text-moderation-stable";
    
    /// <summary>
    /// The default is text-moderation-latest which will be automatically upgraded over time. <br/>
    /// This ensures you are always using our most accurate model. <br/>
    /// </summary>
    internal const string LatestValue = "text-moderation-latest";
    
    /// <inheritdoc cref="StableValue"/>
    public static ModerationModel Stable { get; } = new(StableValue);
    
    /// <inheritdoc cref="LatestValue"/>
    public static ModerationModel Latest { get; } = new(LatestValue);

    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ModerationModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ModerationModel model)
    {
        return model.Value;
    }
}