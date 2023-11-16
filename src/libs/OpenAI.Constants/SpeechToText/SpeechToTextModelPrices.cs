namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// </summary>
public static class AudioPrices
{
    /// <inheritdoc cref="AudioPrices"/>
    /// <param name="model"></param>
    /// <param name="seconds">rounded to the nearest second</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        SpeechToTextModel model,
        int seconds)
    {
        var pricePerMinute = model.Value switch
        {
            SpeechToTextModel.Whisper1Value => 0.006,
            
            _ => -1.0,
        };
        if (pricePerMinute < 0.0)
        {
            return null;
        }
        
        return seconds * pricePerMinute / 60.0;
    }
    
    /// <inheritdoc cref="TryGet(SpeechToTextModel, int)"/>
    public static double Get(
        SpeechToTextModel model,
        int seconds)
    {
        return TryGet(
                   model: model,
                   seconds: seconds) ??
               throw new NotImplementedException();
    }
}