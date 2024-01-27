// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct TextToSpeechModel(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="TextToSpeechModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(TextToSpeechModel model)
    {
        return model.Value;
    }
}