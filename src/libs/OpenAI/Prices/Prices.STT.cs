// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Prices
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="seconds">rounded to the nearest second</param>
    /// <returns></returns>
    public static double GetPriceInUsd(
        this CreateTranscriptionRequestModel model,
        int seconds)
    {
        var pricePerMinuteInUsd = model switch
        {
            CreateTranscriptionRequestModel.Whisper1 => 0.006,
            
            _ => throw new NotImplementedException(),
        };
        
        return seconds * pricePerMinuteInUsd / 60.0;
    }
}