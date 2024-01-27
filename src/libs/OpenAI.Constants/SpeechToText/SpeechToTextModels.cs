// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/speech-to-text
/// </summary>
/// <param name="Id">Id of the model.</param>
/// <param name="PricePerMinuteInUsd">Price per minute in USD.</param>
public readonly partial record struct SpeechToTextModels(
    string Id,
    double PricePerMinuteInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="SpeechToTextModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(SpeechToTextModels model)
    {
        return model.Id;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="seconds">rounded to the nearest second</param>
    /// <returns></returns>
    public double GetPriceInUsd(
        int seconds)
    {
        return seconds * PricePerMinuteInUsd / 60.0;
    }

    /// <summary>
    /// Returns <see cref="SpeechToTextModels"/> by <paramref name="id"/>. <br/>
    /// Returns <see langword="null"/> if <paramref name="id"/> is not found.
    /// </summary>
    /// <param name="id">Id of the model.</param>
    /// <returns></returns>
    public static SpeechToTextModels? ById(string id)
    {
        return id switch
        {
            Whisper1Id => Whisper1,
    
            _ => null,
        };
    }
}