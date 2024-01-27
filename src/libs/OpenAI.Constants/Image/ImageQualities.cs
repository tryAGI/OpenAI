// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageQualities(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageQualities"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageQualities model)
    {
        return model.Value;
    }
}