#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create chat completion<br/>
        /// **Starting a new project?** We recommend trying [Responses](https://developers.openai.com/api/reference/resources/responses)<br/>
        /// to take advantage of the latest OpenAI platform features. Compare<br/>
        /// [Chat Completions with Responses](https://developers.openai.com/api/docs/guides/migrate-to-responses?api-mode=responses).<br/>
        /// ---<br/>
        /// Creates a model response for the given chat conversation. Learn more in the<br/>
        /// [text generation](https://developers.openai.com/api/docs/guides/text), [vision](https://developers.openai.com/api/docs/guides/images-vision),<br/>
        /// and [audio](https://developers.openai.com/api/docs/guides/audio) guides.<br/>
        /// Parameter support can differ depending on the model used to generate the<br/>
        /// response, particularly for newer reasoning models. Parameters that are only<br/>
        /// supported for reasoning models are noted below. For the current state of<br/>
        /// unsupported parameters in reasoning models,<br/>
        /// [refer to the reasoning guide](https://developers.openai.com/api/docs/guides/reasoning).<br/>
        /// Returns a chat completion object, or a streamed sequence of chat completion<br/>
        /// chunk objects if the request is streamed.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(

            global::tryAGI.OpenAI.CreateChatCompletionRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create chat completion<br/>
        /// **Starting a new project?** We recommend trying [Responses](https://developers.openai.com/api/reference/resources/responses)<br/>
        /// to take advantage of the latest OpenAI platform features. Compare<br/>
        /// [Chat Completions with Responses](https://developers.openai.com/api/docs/guides/migrate-to-responses?api-mode=responses).<br/>
        /// ---<br/>
        /// Creates a model response for the given chat conversation. Learn more in the<br/>
        /// [text generation](https://developers.openai.com/api/docs/guides/text), [vision](https://developers.openai.com/api/docs/guides/images-vision),<br/>
        /// and [audio](https://developers.openai.com/api/docs/guides/audio) guides.<br/>
        /// Parameter support can differ depending on the model used to generate the<br/>
        /// response, particularly for newer reasoning models. Parameters that are only<br/>
        /// supported for reasoning models are noted below. For the current state of<br/>
        /// unsupported parameters in reasoning models,<br/>
        /// [refer to the reasoning guide](https://developers.openai.com/api/docs/guides/reasoning).<br/>
        /// Returns a chat completion object, or a streamed sequence of chat completion<br/>
        /// chunk objects if the request is streamed.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}