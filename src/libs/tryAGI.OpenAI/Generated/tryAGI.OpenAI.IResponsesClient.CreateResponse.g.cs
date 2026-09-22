#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide [text](https://developers.openai.com/api/docs/guides/text) or<br/>
        /// [image](https://developers.openai.com/api/docs/guides/images-vision) inputs to generate [text](https://developers.openai.com/api/docs/guides/text)<br/>
        /// or [JSON](https://developers.openai.com/api/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](https://developers.openai.com/api/docs/guides/function-calling) or use built-in<br/>
        /// [tools](https://developers.openai.com/api/docs/guides/tools) like [web search](https://developers.openai.com/api/docs/guides/tools-web-search)<br/>
        /// or [file search](https://developers.openai.com/api/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> CreateResponseAsync(

            global::tryAGI.OpenAI.CreateResponse request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide [text](https://developers.openai.com/api/docs/guides/text) or<br/>
        /// [image](https://developers.openai.com/api/docs/guides/images-vision) inputs to generate [text](https://developers.openai.com/api/docs/guides/text)<br/>
        /// or [JSON](https://developers.openai.com/api/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](https://developers.openai.com/api/docs/guides/function-calling) or use built-in<br/>
        /// [tools](https://developers.openai.com/api/docs/guides/tools) like [web search](https://developers.openai.com/api/docs/guides/tools-web-search)<br/>
        /// or [file search](https://developers.openai.com/api/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.Response>> CreateResponseAsResponseAsync(

            global::tryAGI.OpenAI.CreateResponse request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide [text](https://developers.openai.com/api/docs/guides/text) or<br/>
        /// [image](https://developers.openai.com/api/docs/guides/images-vision) inputs to generate [text](https://developers.openai.com/api/docs/guides/text)<br/>
        /// or [JSON](https://developers.openai.com/api/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](https://developers.openai.com/api/docs/guides/function-calling) or use built-in<br/>
        /// [tools](https://developers.openai.com/api/docs/guides/tools) like [web search](https://developers.openai.com/api/docs/guides/tools-web-search)<br/>
        /// or [file search](https://developers.openai.com/api/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> CreateResponseAsync(
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}