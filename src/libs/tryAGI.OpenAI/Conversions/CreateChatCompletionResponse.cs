using System.Diagnostics.CodeAnalysis;

namespace tryAGI.OpenAI;

public partial class CreateChatCompletionResponse
{
    /// <inheritdoc />
    public override string ToString()
    {
        return Choices.ElementAtOrDefault(0)?.Message.Content ?? string.Empty;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    [SuppressMessage("Design", "CA1062:Validate arguments of public methods",
        Justification = "This is a conversion operator.")]
    public static implicit operator string(CreateChatCompletionResponse response)
    {
        return response.ToString();
    }
}