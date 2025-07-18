#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::tryAGI.OpenAI.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="input">
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </param>
        /// <param name="instructions">
        /// Control the voice of your generated audio with additional instructions. Does not work with `tts-1` or `tts-1-hd`.
        /// </param>
        /// <param name="model">
        /// One of the available [TTS models](/docs/models#tts): `tts-1`, `tts-1-hd` or `gpt-4o-mini-tts`.
        /// </param>
        /// <param name="responseFormat">
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="streamFormat">
        /// The format to stream the audio in. Supported formats are `sse` and `audio`. `sse` is not supported for `tts-1` or `tts-1-hd`.<br/>
        /// Default Value: audio
        /// </param>
        /// <param name="voice">
        /// Example: ash
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            string input,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?> model,
            global::tryAGI.OpenAI.VoiceIdsShared voice,
            string? instructions = default,
            global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? responseFormat = default,
            double? speed = default,
            global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat? streamFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}