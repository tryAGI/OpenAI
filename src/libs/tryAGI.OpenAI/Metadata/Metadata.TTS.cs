// ReSharper disable once CheckNamespace
namespace tryAGI.OpenAI;

public static partial class Metadata
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="characters"></param>
    /// <returns></returns>
    public static double? TryGetPriceInUsd(
        this CreateSpeechRequestModel model,
        int characters)
    {
        var pricePerCharacterInUsd = model switch
        {
            CreateSpeechRequestModel.Tts1 =>   15.0 * UsdPerMillionTokens,
            CreateSpeechRequestModel.Tts1Hd => 30.0 * UsdPerMillionTokens,
            
            _ => double.NaN,
        };
        if (double.IsNaN(pricePerCharacterInUsd))
        {
            return null;
        }
        
        return characters * pricePerCharacterInUsd;
    }
    
    /// <inheritdoc cref="TryGetPriceInUsd(CreateSpeechRequestModel, int)"/>
    /// <exception cref="InvalidOperationException"></exception>
    public static double GetPriceInUsd(
        this CreateSpeechRequestModel model,
        int characters)
    {
        return model.TryGetPriceInUsd(characters) ??
               throw new InvalidOperationException(
                   $"Prices are not available for {model.ToValueString()}.");
    }
}