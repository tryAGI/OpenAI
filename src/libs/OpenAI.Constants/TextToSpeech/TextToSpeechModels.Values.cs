// ReSharper disable once CheckNamespace
namespace OpenAI.Constants;

public readonly partial record struct TextToSpeechModels
{
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    internal const string Tts1Id = "tts-1";
    
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    internal const string Tts1HdId = "tts-1-hd";
    
    /// <inheritdoc cref="Tts1Id"/>
    public static TextToSpeechModels Tts1 { get; } = new(
        Id: Tts1Id,
        PricePerCharacterInUsd: 15.0 * UsdPerMillionTokens);
    
    /// <inheritdoc cref="Tts1HdId"/>
    public static TextToSpeechModels Tts1Hd { get; } = new(
        Id: Tts1HdId,
        PricePerCharacterInUsd: 30.0 * UsdPerMillionTokens);
}