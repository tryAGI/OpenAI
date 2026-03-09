#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create a Realtime client secret with an associated session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime API without<br/>
        /// leaking your main API key. You can configure a custom TTL for each client secret.<br/>
        /// You can also attach session configuration options to the client secret, which will be<br/>
        /// applied to any sessions created using that client secret, but these can also be overridden<br/>
        /// by the client connection.<br/>
        /// [Learn more about authentication with client secrets over WebRTC](/docs/guides/realtime-webrtc).<br/>
        /// Returns the created client secret and the effective session object. The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse> CreateRealtimeClientSecretAsync(

            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a Realtime client secret with an associated session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime API without<br/>
        /// leaking your main API key. You can configure a custom TTL for each client secret.<br/>
        /// You can also attach session configuration options to the client secret, which will be<br/>
        /// applied to any sessions created using that client secret, but these can also be overridden<br/>
        /// by the client connection.<br/>
        /// [Learn more about authentication with client secrets over WebRTC](/docs/guides/realtime-webrtc).<br/>
        /// Returns the created client secret and the effective session object. The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="expiresAfter">
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </param>
        /// <param name="session">
        /// Session configuration to use for the client secret. Choose either a realtime<br/>
        /// session or a transcription session.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse> CreateRealtimeClientSecretAsync(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? expiresAfter = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}