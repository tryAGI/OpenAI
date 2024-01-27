// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageModel(string Id)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageModel model)
    {
        return model.Id;
    }
}