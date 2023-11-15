using OpenAI.Chat;

namespace tryAGI.OpenAI;

/// <summary>
/// 
/// </summary>
public static class ResponseMessageExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="message"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static ChatRequest AsRequestMessage(this Message message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        
        return new ChatRequest(
            messages: new []{ message });
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static Message GetFirstChoiceMessage(this ChatResponse response)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        
        return response.Choices[0].Message ??
               throw new ArgumentException("No message in the first choice.");
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static Delta GetFirstChoiceDelta(this ChatResponse response)
    {
        response = response ?? throw new ArgumentNullException(nameof(response));
        
        return response.Choices[0].Delta ??
               throw new ArgumentException("No delta in the first choice.");
    }
}