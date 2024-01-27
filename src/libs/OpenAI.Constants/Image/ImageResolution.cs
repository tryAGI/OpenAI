// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageResolution(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageResolution"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageResolution model)
    {
        return model.Value;
    }
}