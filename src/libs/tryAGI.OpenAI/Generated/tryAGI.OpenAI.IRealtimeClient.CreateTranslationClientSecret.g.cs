#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create a Realtime translation client secret with an associated translation session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime<br/>
        /// Translation API without leaking your main API key. You can configure a custom<br/>
        /// TTL for each client secret.<br/>
        /// Returns the created client secret and the effective translation session object.<br/>
        /// The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse> CreateTranslationClientSecretAsync(

            global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Realtime translation client secret with an associated translation session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime<br/>
        /// Translation API without leaking your main API key. You can configure a custom<br/>
        /// TTL for each client secret.<br/>
        /// Returns the created client secret and the effective translation session object.<br/>
        /// The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse>> CreateTranslationClientSecretAsResponseAsync(

            global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Realtime translation client secret with an associated translation session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime<br/>
        /// Translation API without leaking your main API key. You can configure a custom<br/>
        /// TTL for each client secret.<br/>
        /// Returns the created client secret and the effective translation session object.<br/>
        /// The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="expiresAfter">
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </param>
        /// <param name="session">
        /// Realtime translation session configuration. Translation sessions stream source<br/>
        /// audio in and translated audio plus transcript deltas out continuously.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateResponse> CreateTranslationClientSecretAsync(
            global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest session,
            global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? expiresAfter = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}