#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Create voice consent<br/>
        /// Upload a voice consent recording.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentResource> CreateVoiceConsentAsync(

            global::tryAGI.OpenAI.CreateVoiceConsentRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice consent<br/>
        /// Upload a voice consent recording.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VoiceConsentResource>> CreateVoiceConsentAsResponseAsync(

            global::tryAGI.OpenAI.CreateVoiceConsentRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice consent<br/>
        /// Upload a voice consent recording.
        /// </summary>
        /// <param name="name">
        /// The label to use for this consent recording.
        /// </param>
        /// <param name="recording">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="recordingname">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="language">
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentResource> CreateVoiceConsentAsync(
            string name,
            byte[] recording,
            string recordingname,
            string language,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create voice consent<br/>
        /// Upload a voice consent recording.
        /// </summary>
        /// <param name="name">
        /// The label to use for this consent recording.
        /// </param>
        /// <param name="recording">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="recordingname">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="language">
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentResource> CreateVoiceConsentAsync(
            string name,
            global::System.IO.Stream recording,
            string recordingname,
            string language,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create voice consent<br/>
        /// Upload a voice consent recording.
        /// </summary>
        /// <param name="name">
        /// The label to use for this consent recording.
        /// </param>
        /// <param name="recording">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="recordingname">
        /// The consent audio recording file. Maximum size is 10 MiB.<br/>
        /// Supported MIME types:<br/>
        /// `audio/mpeg`, `audio/wav`, `audio/x-wav`, `audio/ogg`, `audio/aac`, `audio/flac`, `audio/webm`, `audio/mp4`.
        /// </param>
        /// <param name="language">
        /// The BCP 47 language tag for the consent phrase (for example, `en-US`).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VoiceConsentResource>> CreateVoiceConsentAsResponseAsync(
            string name,
            global::System.IO.Stream recording,
            string recordingname,
            string language,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}