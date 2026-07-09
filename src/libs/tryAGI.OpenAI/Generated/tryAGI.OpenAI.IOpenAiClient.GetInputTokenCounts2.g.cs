#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Returns input token counts of the request.<br/>
        /// Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count.
        /// </summary>
        /// <param name="openaiBeta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.BetaTokenCountsResource> GetInputTokenCounts2Async(

            global::tryAGI.OpenAI.BetaTokenCountsBody request,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? openaiBeta = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns input token counts of the request.<br/>
        /// Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count.
        /// </summary>
        /// <param name="openaiBeta"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.BetaTokenCountsResource>> GetInputTokenCounts2AsResponseAsync(

            global::tryAGI.OpenAI.BetaTokenCountsBody request,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? openaiBeta = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Returns input token counts of the request.<br/>
        /// Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count.
        /// </summary>
        /// <param name="openaiBeta"></param>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="tools"></param>
        /// <param name="text"></param>
        /// <param name="reasoning"></param>
        /// <param name="instructions"></param>
        /// <param name="personality">
        /// A model-owned style preset to apply to this request. Omit this parameter to use the model's default style. Supported values may expand over time. Values must be at most 64 characters.
        /// </param>
        /// <param name="conversation"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.BetaTokenCountsResource> GetInputTokenCounts2Async(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaGetinputtokencountsOpenaiBetaItem>? openaiBeta = default,
            string? model = default,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaInputItem>>? input = default,
            string? previousResponseId = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaTool>? tools = default,
            global::tryAGI.OpenAI.BetaResponseTextParam? text = default,
            global::tryAGI.OpenAI.BetaReasoning? reasoning = default,
            string? instructions = default,
            global::tryAGI.OpenAI.BetaPersonalityEnum? personality = default,
            global::tryAGI.OpenAI.BetaConversationParam? conversation = default,
            global::tryAGI.OpenAI.BetaToolChoiceParam? toolChoice = default,
            bool? parallelToolCalls = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}