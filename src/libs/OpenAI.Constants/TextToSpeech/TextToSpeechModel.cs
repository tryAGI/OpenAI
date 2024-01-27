// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct TextToSpeechModel(
    string Id,
    double PricePerCharacterInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="TextToSpeechModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(TextToSpeechModel model)
    {
        return model.Id;
    }
    
    /// <summary>
    /// According https://openai.com/pricing/ <br/>
    /// </summary>
    /// <param name="characters"></param>
    /// <returns></returns>
    public double GetPriceInUsd(
        int characters)
    {
        return characters * PricePerCharacterInUsd;
    }
}