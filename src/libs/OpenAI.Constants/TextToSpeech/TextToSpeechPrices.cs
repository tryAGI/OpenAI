namespace OpenAI.Constants;

/// <summary>
/// All prices in USD. <br/>
/// According https://openai.com/pricing/ <br/>
/// </summary>
public static class TextToSpeechPrices
{
    /// <inheritdoc cref="TextToSpeechPrices"/>
    /// <param name="model"></param>
    /// <param name="characters"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public static double? TryGet(
        TextToSpeechModel model,
        int characters)
    {
        var pricePerCharacter = model.Value switch
        {
            TextToSpeechModel.Tts1Value => 0.015 * 0.001,
            TextToSpeechModel.Tts1HdValue => 0.030 * 0.001,
            
            _ => -1.0,
        };
        if (pricePerCharacter < 0.0)
        {
            return null;
        }
        
        return characters * pricePerCharacter;
    }
    
    /// <inheritdoc cref="TryGet(TextToSpeechModel, int)"/>
    public static double Get(
        TextToSpeechModel model,
        int characters)
    {
        return TryGet(
                   model: model,
                   characters: characters) ??
               throw new NotImplementedException();
    }
}