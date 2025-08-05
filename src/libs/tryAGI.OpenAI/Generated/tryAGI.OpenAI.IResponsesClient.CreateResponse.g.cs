#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide [text](https://platform.openai.com/docs/guides/text) or<br/>
        /// [image](https://platform.openai.com/docs/guides/images) inputs to generate [text](https://platform.openai.com/docs/guides/text)<br/>
        /// or [JSON](https://platform.openai.com/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](https://platform.openai.com/docs/guides/function-calling) or use built-in<br/>
        /// [tools](https://platform.openai.com/docs/guides/tools) like [web search](https://platform.openai.com/docs/guides/tools-web-search)<br/>
        /// or [file search](https://platform.openai.com/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> CreateResponseAsync(
            global::tryAGI.OpenAI.CreateResponse request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide [text](https://platform.openai.com/docs/guides/text) or<br/>
        /// [image](https://platform.openai.com/docs/guides/images) inputs to generate [text](https://platform.openai.com/docs/guides/text)<br/>
        /// or [JSON](https://platform.openai.com/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](https://platform.openai.com/docs/guides/function-calling) or use built-in<br/>
        /// [tools](https://platform.openai.com/docs/guides/tools) like [web search](https://platform.openai.com/docs/guides/tools-web-search)<br/>
        /// or [file search](https://platform.openai.com/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> CreateResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}