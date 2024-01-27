// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageResolutions(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageResolutions"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageResolutions model)
    {
        return model.Value;
    }
}