#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Generates audio from the input text.<br/>
        /// Returns the audio file content, or a stream of audio events.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent> CreateSpeechAsStreamAsync(

            global::tryAGI.OpenAI.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates audio from the input text.<br/>
        /// Returns the audio file content, or a stream of audio events.
        /// </summary>
        /// <param name="model">
        /// One of the available [TTS models](/docs/models#tts): `tts-1`, `tts-1-hd`, `gpt-4o-mini-tts`, or `gpt-4o-mini-tts-2025-12-15`.
        /// </param>
        /// <param name="input">
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </param>
        /// <param name="instructions">
        /// Control the voice of your generated audio with additional instructions. Does not work with `tts-1` or `tts-1-hd`.
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. Supported built-in voices are `alloy`, `ash`, `ballad`, `coral`, `echo`, `fable`, `onyx`, `nova`, `sage`, `shimmer`, `verse`, `marin`, and `cedar`. You may also provide a custom voice object with an `id`, for example `{ "id": "voice_1234" }`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.CreateSpeechResponseStreamEvent> CreateSpeechAsStreamAsync(
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateSpeechRequestModel?> model,
            string input,
            global::tryAGI.OpenAI.VoiceIdsOrCustomVoice voice,
            string? instructions = default,
            global::tryAGI.OpenAI.CreateSpeechRequestResponseFormat? responseFormat = default,
            double? speed = default,
            global::tryAGI.OpenAI.CreateSpeechRequestStreamFormat? streamFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}