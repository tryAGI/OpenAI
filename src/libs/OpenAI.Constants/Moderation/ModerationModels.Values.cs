// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/api-reference/moderations
/// Two content moderation models are available: text-moderation-stable and text-moderation-latest.
/// </summary>
public readonly partial record struct ModerationModels
{
    /// <summary>
    /// If you use text-moderation-stable, we will provide advanced notice before updating the model. <br/>
    /// Accuracy of text-moderation-stable may be slightly lower than for text-moderation-latest. <br/>
    /// </summary>
    internal const string StableId = "text-moderation-stable";
    
    /// <summary>
    /// The default is text-moderation-latest which will be automatically upgraded over time. <br/>
    /// This ensures you are always using our most accurate model. <br/>
    /// </summary>
    internal const string LatestId = "text-moderation-latest";
    
    /// <inheritdoc cref="StableId"/>
    public static ModerationModels Stable { get; } = new(StableId);
    
    /// <inheritdoc cref="LatestId"/>
    public static ModerationModels Latest { get; } = new(LatestId);
}