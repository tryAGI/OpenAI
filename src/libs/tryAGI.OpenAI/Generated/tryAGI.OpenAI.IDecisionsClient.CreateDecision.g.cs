#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IDecisionsClient
    {
        /// <summary>
        /// Create a decision<br/>
        /// Use this endpoint to quickly answer classification or scoring questions about some input. You can ask multiple questions in one request.
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
        /// Use this endpoint to quickly answer classification or scoring questions about some input. You can ask multiple questions in one request.
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
        /// Use this endpoint to quickly answer classification or scoring questions about some input. You can ask multiple questions in one request.
        /// </summary>
        /// <param name="model">
        /// The model to use. Only `gpt-6-luna` is supported.
        /// </param>
        /// <param name="input">
        /// The input to evaluate for every question. Provide a text string or an ordered array of messages, function calls and outputs, or custom tool calls and outputs. Each tool output must identify a matching call by call ID.
        /// </param>
        /// <param name="questions">
        /// Ask 1–400 questions about the input. Each question can be a predicate, choice, or score. Answers come back in the same order.
        /// </param>
        /// <param name="safetyIdentifier">
        /// Opaque caller-provided end-user identifier, scoped by the verified org. Match Responses' limit; this is never the authenticated user identity.
        /// </param>
        /// <param name="promptCacheKey">
        /// Partition prompt cache reuse by caller-provided key.
        /// </param>
        /// <param name="promptCacheOptions">
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DecisionResponse> CreateDecisionAsync(
            string model,
            global::tryAGI.OpenAI.DecisionInput input,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.QuestionParam> questions,
            string? safetyIdentifier = default,
            string? promptCacheKey = default,
            global::tryAGI.OpenAI.DecisionRequestPromptCacheOptions? promptCacheOptions = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}