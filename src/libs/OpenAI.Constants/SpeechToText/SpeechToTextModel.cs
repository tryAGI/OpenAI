namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/speech-to-text
/// </summary>
public readonly record struct SpeechToTextModel(string Value)
{
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    internal const string Whisper1Value = "whisper-1";
    
    /// <inheritdoc cref="Whisper1Value"/>
    public static SpeechToTextModel Whisper1 { get; } = new(Whisper1Value);

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
}