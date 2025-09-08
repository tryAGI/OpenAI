#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create client secret<br/>
        /// Create a Realtime client secret with an associated session configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse> CreateRealtimeClientSecretAsync(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create client secret<br/>
        /// Create a Realtime client secret with an associated session configuration.
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
            global::tryAGI.OpenAI.Session? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}