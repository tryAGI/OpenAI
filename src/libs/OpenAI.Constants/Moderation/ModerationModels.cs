// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/api-reference/moderations
/// Two content moderation models are available: text-moderation-stable and text-moderation-latest.
/// </summary>
/// <param name="Id">Id of the model.</param>
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