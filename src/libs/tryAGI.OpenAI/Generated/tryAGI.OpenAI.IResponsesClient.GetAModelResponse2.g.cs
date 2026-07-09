#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Retrieves a model response with the given ID.
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="include"></param>
        /// <param name="stream"></param>
        /// <param name="startingAfter"></param>
        /// <param name="includeObfuscation"></param>
        /// <param name="openaiBeta"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.BetaResponse> GetAModelResponse2Async(
            string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? include = default,
            bool? stream = default,
            int? startingAfter = default,
            bool? includeObfuscation = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? openaiBeta = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieves a model response with the given ID.
        /// </summary>
        /// <param name="responseId">
        /// Example: resp_677efb5139a88190b512bc3fef8e535d
        /// </param>
        /// <param name="include"></param>
        /// <param name="stream"></param>
        /// <param name="startingAfter"></param>
        /// <param name="includeObfuscation"></param>
        /// <param name="openaiBeta"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.BetaResponse>> GetAModelResponse2AsResponseAsync(
            string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaIncludeEnum>? include = default,
            bool? stream = default,
            int? startingAfter = default,
            bool? includeObfuscation = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetResponseOpenaiBetaItem>? openaiBeta = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}