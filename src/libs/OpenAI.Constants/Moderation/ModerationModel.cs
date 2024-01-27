// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct ModerationModel(string Id)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="ModerationModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(ModerationModel model)
    {
        return model.Id;
    }
}