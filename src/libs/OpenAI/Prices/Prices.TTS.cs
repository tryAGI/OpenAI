// ReSharper disable once CheckNamespace
namespace OpenAI;

public static partial class Prices
{
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="model"></param>
    /// <param name="characters"></param>
    /// <returns></returns>
    public static double GetPriceInUsd(
        this CreateSpeechRequestModel model,
        int characters)
    {
        var pricePerCharacterInUsd = model switch
        {
            CreateSpeechRequestModel.Tts1 =>   15.0 * UsdPerMillionTokens,
            CreateSpeechRequestModel.Tts1Hd => 30.0 * UsdPerMillionTokens,
            
            _ => throw new NotImplementedException(),
        };
        
        return characters * pricePerCharacterInUsd;
    }
}