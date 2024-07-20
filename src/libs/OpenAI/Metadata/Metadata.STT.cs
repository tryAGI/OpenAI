// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Metadata
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="seconds">rounded to the nearest second</param>
    /// <returns></returns>
    public static double? GetPriceInUsd(
        this CreateTranscriptionRequestModel model,
        int seconds)
    {
        var pricePerMinuteInUsd = model switch
        {
            CreateTranscriptionRequestModel.Whisper1 => 0.006,
            
            _ => double.NaN,
        };
        if (double.IsNaN(pricePerMinuteInUsd))
        {
            return null;
        }
        
        return seconds * pricePerMinuteInUsd / 60.0;
    }
    
    /// <inheritdoc cref="TryGetPriceInUsd(CreateSpeechRequestModel, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double TryGetPriceInUsd(
        this CreateTranscriptionRequestModel model,
        int seconds)
    {
        return model.GetPriceInUsd(seconds) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }
}