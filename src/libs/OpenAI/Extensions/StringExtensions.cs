// ReSharper disable once CheckNamespace
namespace OpenAI;

/// <summary>
/// 
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsSystemMessage(this string content, string? name = null)
    {
        return new ChatCompletionRequestSystemMessage
        {
            Content = content,
            Role = ChatCompletionRequestSystemMessageRole.System,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsUserMessage(this string content)
    {
        return new ChatCompletionRequestUserMessage
        {
            Content = content,
            Role = ChatCompletionRequestUserMessageRole.User,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsAssistantMessage(this string content)
    {
        return new ChatCompletionRequestAssistantMessage
        {
            Content = content,
            Role = ChatCompletionRequestAssistantMessageRole.Assistant,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="json"></param>
    /// <param name="toolCallId"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsToolMessage(this string json, string toolCallId)
    {
        return new ChatCompletionRequestToolMessage
        {
            Content = json,
            Role = ChatCompletionRequestToolMessageRole.Tool,
            ToolCallId = toolCallId,
        };
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static ChatCompletionRequestMessage AsRequestMessage(this ChatCompletionResponseMessage message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        
        return new ChatCompletionRequestAssistantMessage
        {
            Content = message.Content == null
                ? (OneOf<string?, IList<ChatCompletionRequestAssistantMessageContentPart>>?)null
                : new OneOf<string?, IList<ChatCompletionRequestAssistantMessageContentPart>>(message.Content),
            Role = ChatCompletionRequestAssistantMessageRole.Assistant,
            ToolCalls = message.ToolCalls,
        };
    }
}