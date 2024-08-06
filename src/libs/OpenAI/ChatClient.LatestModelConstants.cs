namespace OpenAI;

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
}