// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ModerationModel(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ModerationModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ModerationModel model)
    {
        return model.Value;
    }
}