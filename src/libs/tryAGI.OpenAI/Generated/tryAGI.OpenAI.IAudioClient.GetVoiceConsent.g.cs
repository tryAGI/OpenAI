#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Retrieves a voice consent recording.<br/>
        /// Retrieve consent recording metadata used for creating custom voices.<br/>
        /// See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
        /// </summary>
        /// <param name="consentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentResource> GetVoiceConsentAsync(
            string consentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}