#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Delete voice<br/>
        /// Deletes a voice created from a text prompt or an audio sample.<br/>
        /// Requires voice write permission and access to the voice's project. Access to voices created from recordings is limited to eligible customers. See the [custom voices guide](https://developers.openai.com/api/docs/guides/custom-voices).<br/>
        /// Deleting a voice does not delete its consent recording. Deleting an already deleted voice returns a 404 error.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceDeletedResource> DeleteVoiceAsync(
            string voiceId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete voice<br/>
        /// Deletes a voice created from a text prompt or an audio sample.<br/>
        /// Requires voice write permission and access to the voice's project. Access to voices created from recordings is limited to eligible customers. See the [custom voices guide](https://developers.openai.com/api/docs/guides/custom-voices).<br/>
        /// Deleting a voice does not delete its consent recording. Deleting an already deleted voice returns a 404 error.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VoiceDeletedResource>> DeleteVoiceAsResponseAsync(
            string voiceId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}