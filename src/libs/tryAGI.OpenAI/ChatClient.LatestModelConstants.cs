namespace tryAGI.OpenAI;

public partial class ChatClient
{
    /// <summary>
    /// Always points to the latest smart model.
    /// </summary>
    public const CreateChatCompletionRequestModel LatestSmartModel = CreateChatCompletionRequestModel.Gpt4o;
    
    /// <summary>
    /// Always points to the latest fast model.
    /// </summary>
    public const CreateChatCompletionRequestModel LatestFastModel = CreateChatCompletionRequestModel.Gpt4oMini;
    
    /// <summary>
    /// Always points to the latest smart reasoning model.
    /// </summary>
    public const CreateChatCompletionRequestModel LatestSmartReasoningModel = CreateChatCompletionRequestModel.O1Preview;
    
    /// <summary>
    /// Always points to the latest fast reasoning model.
    /// </summary>
    public const CreateChatCompletionRequestModel LatestFastReasoningModel = CreateChatCompletionRequestModel.O1Mini;
}