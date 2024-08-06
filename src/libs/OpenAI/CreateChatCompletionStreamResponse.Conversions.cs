namespace OpenAI;

public partial class CreateChatCompletionStreamResponse
{
    /// <inheritdoc />
    public override string ToString()
    {
        return Choices.ElementAtOrDefault(0)?.Delta.Content ?? string.Empty;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="response"></param>
    /// <returns></returns>
    public static implicit operator string(CreateChatCompletionStreamResponse response)
    {
#pragma warning disable CA1062
        return response.ToString();
#pragma warning restore CA1062
    }
}