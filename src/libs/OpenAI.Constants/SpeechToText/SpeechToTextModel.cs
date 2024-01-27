// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct SpeechToTextModel(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="SpeechToTextModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(SpeechToTextModel model)
    {
        return model.Value;
    }
}