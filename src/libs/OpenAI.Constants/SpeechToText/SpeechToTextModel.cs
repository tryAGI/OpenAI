// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct SpeechToTextModel(
    string Value,
    double PricePerMinuteInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="SpeechToTextModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(SpeechToTextModel model)
    {
        return model.Value;
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
}