#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ILiveClient
    {
        /// <summary>
        /// Download recording<br/>
        /// Get Live session content
        /// </summary>
        /// <param name="sessionId">
        /// The ID of the stored Live session to download. Use the session ID returned when the session started with storage enabled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadLiveRecordingAsync(
            string sessionId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download recording<br/>
        /// Get Live session content
        /// </summary>
        /// <param name="sessionId">
        /// The ID of the stored Live session to download. Use the session ID returned when the session started with storage enabled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> DownloadLiveRecordingAsStreamAsync(
            string sessionId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Download recording<br/>
        /// Get Live session content
        /// </summary>
        /// <param name="sessionId">
        /// The ID of the stored Live session to download. Use the session ID returned when the session started with storage enabled.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<byte[]>> DownloadLiveRecordingAsResponseAsync(
            string sessionId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}