namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/text-to-speech
/// </summary>
public readonly record struct TextToSpeechModel(string Value)
{
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    internal const string Tts1Value = "tts-1";
    
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    internal const string Tts1HdValue = "tts-1-hd";
    
    /// <inheritdoc cref="Tts1Value"/>
    public static TextToSpeechModel Tts1 { get; } = new(Tts1Value);
    
    /// <inheritdoc cref="Tts1HdValue"/>
    public static TextToSpeechModel Tts1Hd { get; } = new(Tts1HdValue);

    /// <inheritdoc/>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Implicitly converts <see cref="TextToSpeechModel"/> to <see cref="string"/>.
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public static implicit operator string(TextToSpeechModel model)
    {
        return model.Value;
    }
}