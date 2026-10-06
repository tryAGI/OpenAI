#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IDecisionsClient
    {
        /// <summary>
        /// Create a decision<br/>
        /// Evaluate ordered classification and scoring questions against shared input. Answers are returned in question order.<br/>
        /// Supply input as a string or user messages containing text and inline images. Only user messages with `input_text` and `input_image` parts are supported; non-user roles, function calls, files, audio, and item references are not supported. Images require a data URL, not an external URL or file ID. At most 128 images are allowed across the request.<br/>
        /// Each question can return a refusal instead of a scored answer. A refusal has type `refusal` and the corresponding question name, or null if unnamed.
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
        /// Evaluate ordered classification and scoring questions against shared input. Answers are returned in question order.<br/>
        /// Supply input as a string or user messages containing text and inline images. Only user messages with `input_text` and `input_image` parts are supported; non-user roles, function calls, files, audio, and item references are not supported. Images require a data URL, not an external URL or file ID. At most 128 images are allowed across the request.<br/>
        /// Each question can return a refusal instead of a scored answer. A refusal has type `refusal` and the corresponding question name, or null if unnamed.
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
        /// Evaluate ordered classification and scoring questions against shared input. Answers are returned in question order.<br/>
        /// Supply input as a string or user messages containing text and inline images. Only user messages with `input_text` and `input_image` parts are supported; non-user roles, function calls, files, audio, and item references are not supported. Images require a data URL, not an external URL or file ID. At most 128 images are allowed across the request.<br/>
        /// Each question can return a refusal instead of a scored answer. A refusal has type `refusal` and the corresponding question name, or null if unnamed.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input">
        /// Shared evidence, as a string or an array of user messages containing text and inline images. Non-user roles, function calls, function-call outputs, files, audio, and item references are not supported. At most 128 image parts are allowed across all messages in one request.
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