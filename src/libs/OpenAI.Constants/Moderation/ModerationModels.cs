// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ModerationModels(string Id)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="ModerationModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ModerationModels model)
    {
        return model.Id;
    }
}