using OpenAI;
using OpenAI.Chat;

namespace tryAGI.OpenAI;

/// <summary>
/// 
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message AsSystemMessage(this string content)
    {
        return new Message(Role.System, content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message AsUserMessage(this string content)
    {
        return new Message(Role.User, content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static Message AsAssistantMessage(this string content)
    {
        return new Message(Role.Assistant, content);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="json"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    public static Message AsFunctionMessage(this string json, string name, string toolCallId)
    {
        return new Message(new Tool(new Function(name))
        {
            Id = toolCallId,
        }, json);
    }
}