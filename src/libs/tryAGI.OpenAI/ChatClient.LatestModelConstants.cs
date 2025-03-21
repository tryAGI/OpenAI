namespace tryAGI.OpenAI;

public partial class ChatClient
{
    /// <summary>
    /// Always points to the latest smart model.
    /// </summary>
    public const ModelIdsEnum LatestSmartModel = ModelIdsEnum.Gpt4o;
    
    /// <summary>
    /// Always points to the latest fast model.
    /// </summary>
    public const ModelIdsEnum LatestFastModel = ModelIdsEnum.Gpt4oMini;
    
    /// <summary>
    /// Always points to the latest smart reasoning model.
    /// </summary>
    public const ModelIdsEnum LatestSmartReasoningModel = ModelIdsEnum.O1Preview;
    
    /// <summary>
    /// Always points to the latest fast reasoning model.
    /// </summary>
    public const ModelIdsEnum LatestFastReasoningModel = ModelIdsEnum.O1Mini;
}