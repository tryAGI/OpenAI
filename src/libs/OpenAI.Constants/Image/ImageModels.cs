// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ImageModels(string Id)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="ImageModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ImageModels model)
    {
        return model.Id;
    }
}