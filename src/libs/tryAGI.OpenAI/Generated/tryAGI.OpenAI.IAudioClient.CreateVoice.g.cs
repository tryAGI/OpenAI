#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create voice<br/>
        /// Creates a voice from a text prompt or from a consent recording and an audio sample.<br/>
        /// For prompt-based creation, send `type: "prompt"` with a `name` and `prompt` as JSON or multipart form data. For creation from an audio sample, send `type: "audio_sample"` with a `name`, `audio_sample`, and `consent` recording ID as multipart form data. The type defaults to `audio_sample` when omitted.<br/>
        /// Returns the saved voice's metadata. Voices created from text prompts are supported only in Live, not in Realtime or the speech endpoint. The response does not include preview audio.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceResource> CreateVoiceAsync(

            global::tryAGI.OpenAI.CreateVoicePromptRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Creates a voice from a text prompt or from a consent recording and an audio sample.<br/>
        /// For prompt-based creation, send `type: "prompt"` with a `name` and `prompt` as JSON or multipart form data. For creation from an audio sample, send `type: "audio_sample"` with a `name`, `audio_sample`, and `consent` recording ID as multipart form data. The type defaults to `audio_sample` when omitted.<br/>
        /// Returns the saved voice's metadata. Voices created from text prompts are supported only in Live, not in Realtime or the speech endpoint. The response does not include preview audio.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VoiceResource>> CreateVoiceAsResponseAsync(

            global::tryAGI.OpenAI.CreateVoicePromptRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice<br/>
        /// Creates a voice from a text prompt or from a consent recording and an audio sample.<br/>
        /// For prompt-based creation, send `type: "prompt"` with a `name` and `prompt` as JSON or multipart form data. For creation from an audio sample, send `type: "audio_sample"` with a `name`, `audio_sample`, and `consent` recording ID as multipart form data. The type defaults to `audio_sample` when omitted.<br/>
        /// Returns the saved voice's metadata. Voices created from text prompts are supported only in Live, not in Realtime or the speech endpoint. The response does not include preview audio.
        /// </summary>
        /// <param name="type">
        /// Set to `prompt` to create a voice from a text description.
        /// </param>
        /// <param name="name">
        /// The name of the new voice.
        /// </param>
        /// <param name="prompt">
        /// A description of the desired voice. Must not contain only whitespace.
        /// </param>
        /// <param name="scriptHint">
        /// Optional text for the voice to speak during creation. If omitted, a script is generated from the prompt. Must not be blank after trimming whitespace; scripts that are too short are rejected.
        /// </param>
        /// <param name="model">
        /// The voice creation model to use. Defaults to `auto`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceResource> CreateVoiceAsync(
            string name,
            string prompt,
            global::tryAGI.OpenAI.CreateVoicePromptRequestType type = default,
            string? scriptHint = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateVoicePromptRequestModel?>? model = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}