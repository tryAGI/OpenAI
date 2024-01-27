// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ChatModel(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ChatModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ChatModel model)
    {
        return model.Value;
    }
}