namespace OpenAI;

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
    public static implicit operator string(CreateChatCompletionResponse response)
    {
#pragma warning disable CA1062
        return response.ToString();
#pragma warning restore CA1062
    }
}