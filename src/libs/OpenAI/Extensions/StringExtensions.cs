// ReSharper disable once CheckNamespace

using System.Diagnostics.CodeAnalysis;

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
    public static ChatCompletionRequestMessage AsSystemMessage(
        this string content,
        string? name = null)
    {
        return new ChatCompletionRequestSystemMessage
        {
            Content = content,
            Role = ChatCompletionRequestSystemMessageRole.System,
            Name = name,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsUserMessage(
        this string content,
        string? name = null)
    {
        return new ChatCompletionRequestUserMessage
        {
            Content = content,
            Role = ChatCompletionRequestUserMessageRole.User,
            Name = name,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static ChatCompletionRequestMessage AsAssistantMessage(
        this string content,
        string? name = null)
    {
        return new ChatCompletionRequestAssistantMessage
        {
            Content = content,
            Role = ChatCompletionRequestAssistantMessageRole.Assistant,
            Name = name,
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
                ? (OneOf<string, IList<ChatCompletionRequestAssistantMessageContentPart>>?)null
                : new OneOf<string, IList<ChatCompletionRequestAssistantMessageContentPart>>(message.Content),
            Role = ChatCompletionRequestAssistantMessageRole.Assistant,
            ToolCalls = message.ToolCalls,
        };
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="mimeType"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    [SuppressMessage("Design", "CA1055:URI-like return values should not be strings",
        Justification = "System.Uri doesn't support data URLs.")]
    public static string AsDataUrl(this byte[] bytes, string mimeType)
    {
        bytes = bytes ?? throw new ArgumentNullException(nameof(bytes));
        
        return $"data:{mimeType};base64,{Convert.ToBase64String(bytes)}";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bytes"></param>
    /// <param name="mimeType"></param>
    /// <param name="detail"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public static ChatCompletionRequestMessage AsUserMessage(
        this byte[] bytes,
        string mimeType,
        ChatCompletionRequestMessageContentPartImageImageUrlDetail detail = ChatCompletionRequestMessageContentPartImageImageUrlDetail.Auto)
    {
        bytes = bytes ?? throw new ArgumentNullException(nameof(bytes));
        
        return ChatCompletionRequestMessage.FromDataUri(bytes, mimeType, detail);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tools"></param>
    /// <returns></returns>
    public static IList<ChatCompletionTool> AsOpenAiTools(
        this IList<CSharpToJsonSchema.Tool> tools)
    {
        return tools
            .Select(x => new ChatCompletionTool
            {
                Type = ChatCompletionToolType.Function,
                Function = new FunctionObject
                {
                    Name = x.Name!,
                    Description = x.Description,
                    Strict = x.Strict,
                    Parameters = x.Parameters,
                },
            })
            .ToList();
    }
}