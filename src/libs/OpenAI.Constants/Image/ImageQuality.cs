// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageQuality(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageQuality"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageQuality model)
    {
        return model.Value;
    }
}