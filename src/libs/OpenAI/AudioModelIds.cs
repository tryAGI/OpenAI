namespace tryAGI.OpenAI;

/// <summary>
/// According https://platform.openai.com/docs/guides/speech-to-text
/// </summary>
public static class AudioModelIds
{ 
    /// <summary>
    /// Transcribe audio into whatever language the audio is in. <br/>
    /// File uploads are currently limited to 25 MB and the following input file types are supported: mp3, mp4, mpeg, mpga, m4a, wav, and webm. <br/>
    /// </summary>
    public const string Whisper1 = "whisper-1";
}