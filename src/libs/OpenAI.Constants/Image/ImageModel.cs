// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageModel(string Value)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageModel model)
    {
        return model.Value;
    }
}