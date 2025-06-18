namespace tryAGI.OpenAI;

public partial class ChatClient
{
    /// <summary>
    /// Always points to the latest smart model.
    /// </summary>
    public const ModelIdsSharedEnum LatestSmartModel = ModelIdsSharedEnum.Gpt41;
    
    /// <summary>
    /// Always points to the latest fast model.
    /// </summary>
    public const ModelIdsSharedEnum LatestFastModel = ModelIdsSharedEnum.Gpt41Mini;
    
    /// <summary>
    /// Always points to the latest smart reasoning model.
    /// </summary>
    public const ModelIdsSharedEnum LatestSmartReasoningModel = ModelIdsSharedEnum.O3;
    
    /// <summary>
    /// Always points to the latest fast reasoning model.
    /// </summary>
    public const ModelIdsSharedEnum LatestFastReasoningModel = ModelIdsSharedEnum.O4Mini;
}