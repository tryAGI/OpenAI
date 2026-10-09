#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IDecisionsClient
    {
        /// <summary>
        /// Create a decision<br/>
        /// Use this endpoint to ask classification or scoring questions about the same input. You’ll get the answers back in the order you asked the questions.<br/>
        /// For text, you can pass a string. You can also send user messages containing `input_text` and `input_image` parts, with up to 128 images per request. Images can be base64 data URLs or publicly accessible HTTP(S) URLs. File IDs aren’t accepted. Other message roles, function calls, files, audio, and item references aren’t supported.<br/>
        /// Sometimes a question returns a refusal instead of an answer. The result has type `refusal` and includes the question’s name, or `null` if you didn’t give it one.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DecisionResponse> CreateDecisionAsync(

            global::tryAGI.OpenAI.DecisionRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a decision<br/>
        /// Use this endpoint to ask classification or scoring questions about the same input. You’ll get the answers back in the order you asked the questions.<br/>
        /// For text, you can pass a string. You can also send user messages containing `input_text` and `input_image` parts, with up to 128 images per request. Images can be base64 data URLs or publicly accessible HTTP(S) URLs. File IDs aren’t accepted. Other message roles, function calls, files, audio, and item references aren’t supported.<br/>
        /// Sometimes a question returns a refusal instead of an answer. The result has type `refusal` and includes the question’s name, or `null` if you didn’t give it one.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.DecisionResponse>> CreateDecisionAsResponseAsync(

            global::tryAGI.OpenAI.DecisionRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a decision<br/>
        /// Use this endpoint to ask classification or scoring questions about the same input. You’ll get the answers back in the order you asked the questions.<br/>
        /// For text, you can pass a string. You can also send user messages containing `input_text` and `input_image` parts, with up to 128 images per request. Images can be base64 data URLs or publicly accessible HTTP(S) URLs. File IDs aren’t accepted. Other message roles, function calls, files, audio, and item references aren’t supported.<br/>
        /// Sometimes a question returns a refusal instead of an answer. The result has type `refusal` and includes the question’s name, or `null` if you didn’t give it one.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// The text or images to evaluate for every question. Provide a text string or user messages containing text and images. Images can be base64 data URLs or publicly accessible HTTP(S) URLs; at most 128 images are allowed across all messages in one request. Files, audio, tools, and item references are not supported.
        /// </param>
        /// <param name="questions"></param>
        /// <param name="safetyIdentifier">
        /// Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DecisionResponse> CreateDecisionAsync(
            string model,
            global::tryAGI.OpenAI.DecisionInput input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> questions,
            string? safetyIdentifier = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}