// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

/// <summary>
/// According https://platform.openai.com/docs/guides/text-to-speech
/// </summary>
public readonly partial record struct TextToSpeechModel
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
    public static TextToSpeechModel Tts1 { get; } = new(
        Value: Tts1Value,
        PricePerCharacterInUsd: 0.015 * 0.001);
    
    /// <inheritdoc cref="Tts1HdValue"/>
    public static TextToSpeechModel Tts1Hd { get; } = new(
        Value: Tts1HdValue,
        PricePerCharacterInUsd: 0.030 * 0.001);
}