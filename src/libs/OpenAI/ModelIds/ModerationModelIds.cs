namespace tryAGI.OpenAI;

/// <summary>
/// According https://platform.openai.com/docs/api-reference/moderations
/// Two content moderations models are available: text-moderation-stable and text-moderation-latest.
/// </summary>
public static class ModerationModelIds
{ 
    /// <summary>
    /// If you use text-moderation-stable, we will provide advanced notice before updating the model. <br/>
    /// Accuracy of text-moderation-stable may be slightly lower than for text-moderation-latest. <br/>
    /// </summary>
    public const string Stable = "text-moderation-stable";
    
    /// <summary>
    /// The default is text-moderation-latest which will be automatically upgraded over time. <br/>
    /// This ensures you are always using our most accurate model. <br/>
    /// </summary>
    public const string Latest = "text-moderation-latest";
}