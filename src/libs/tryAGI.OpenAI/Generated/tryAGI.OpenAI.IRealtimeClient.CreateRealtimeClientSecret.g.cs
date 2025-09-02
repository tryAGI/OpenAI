#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IRealtimeClient
    {
        /// <summary>
        /// Create realtime session<br/>
        /// Create a Realtime session and client secret for either realtime or transcription.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse> CreateRealtimeClientSecretAsync(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create realtime session<br/>
        /// Create a Realtime session and client secret for either realtime or transcription.
        /// </summary>
        /// <param name="expiresAfter">
        /// Configuration for the ephemeral token expiration.
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