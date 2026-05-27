#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Returns a list of voice consent recordings.<br/>
        /// List consent recordings available to your organization for creating custom voices.<br/>
        /// See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.VoiceConsentListResource> ListVoiceConsentsAsync(
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns a list of voice consent recordings.<br/>
        /// List consent recordings available to your organization for creating custom voices.<br/>
        /// See the [custom voices guide](/docs/guides/text-to-speech#custom-voices). Custom voices are limited to eligible customers.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.VoiceConsentListResource>> ListVoiceConsentsAsResponseAsync(
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListVoiceConsentsAsync as an IAsyncEnumerable<global::tryAGI.OpenAI.VoiceConsentResource> that auto-pages over the response.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.VoiceConsentResource> ListVoiceConsentsAutoPagingAsync(
              int? limit = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}