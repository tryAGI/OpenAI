// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/text-to-speech
/// </summary>
/// <param name="Id">Id of the model.</param>
/// <param name="PricePerCharacterInUsd">Price per character in USD.</param>
public readonly partial record struct TextToSpeechModels(
    string Id,
    double PricePerCharacterInUsd)
{
    /// <inheritdoc/>
    public override string ToString()
    {
        return Id;
    }

    /// <summary>
    /// Implicitly converts <see cref="TextToSpeechModels"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(TextToSpeechModels model)
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

    /// <summary>
    /// Returns <see cref="TextToSpeechModels"/> by <paramref name="id"/>. <br/>
    /// Returns <see langword="null"/> if <paramref name="id"/> is not found.
    /// </summary>
    /// <param name="id">Id of the model.</param>
    /// <returns></returns>
    public static TextToSpeechModels? ById(string id)
    {
        return id switch
        {
            Tts1Id => Tts1,
            Tts1HdId => Tts1Hd,
    
            _ => null,
        };
    }
}