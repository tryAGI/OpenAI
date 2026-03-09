#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Returns input token counts of the request.<br/>
        /// Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.TokenCountsResource> GetinputtokencountsAsync(

            global::tryAGI.OpenAI.TokenCountsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns input token counts of the request.<br/>
        /// Returns an object with `object` set to `response.input_tokens` and an `input_tokens` count.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="input"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="tools"></param>
        /// <param name="text"></param>
        /// <param name="reasoning"></param>
        /// <param name="truncation">
        /// The truncation strategy to use for the model response. - `auto`: If the input to this Response exceeds the model's context window size, the model will truncate the response to fit the context window by dropping items from the beginning of the conversation. - `disabled` (default): If the input size will exceed the context window size for a model, the request will fail with a 400 error.
        /// </param>
        /// <param name="instructions"></param>
        /// <param name="conversation"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.TokenCountsResource> GetinputtokencountsAsync(
            string? model = default,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? input = default,
            string? previousResponseId = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Tool>? tools = default,
            global::tryAGI.OpenAI.ResponseTextParam? text = default,
            global::tryAGI.OpenAI.Reasoning? reasoning = default,
            global::tryAGI.OpenAI.TruncationEnum? truncation = default,
            string? instructions = default,
            global::tryAGI.OpenAI.ConversationParam? conversation = default,
            global::tryAGI.OpenAI.ToolChoiceParam? toolChoice = default,
            bool? parallelToolCalls = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}