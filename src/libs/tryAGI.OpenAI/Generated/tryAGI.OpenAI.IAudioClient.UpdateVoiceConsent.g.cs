#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Updates a voice consent recording (metadata only).<br/>
        /// Update consent recording metadata used for creating custom voices. This endpoint updates metadata only and does not replace the underlying audio.<br/>
        /// See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
        /// </summary>
        /// <param name="consentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentResource> UpdateVoiceConsentAsync(
            string consentId,

            global::tryAGI.OpenAI.UpdateVoiceConsentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates a voice consent recording (metadata only).<br/>
        /// Update consent recording metadata used for creating custom voices. This endpoint updates metadata only and does not replace the underlying audio.<br/>
        /// See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
        /// </summary>
        /// <param name="consentId"></param>
        /// <param name="name">
        /// The updated label for this consent recording.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentResource> UpdateVoiceConsentAsync(
            string consentId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}