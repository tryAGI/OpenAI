using System.Net.ServerSentEvents;
using System.Runtime.CompilerServices;

// ReSharper disable RedundantNameQualifier

namespace tryAGI.OpenAI
{
    public partial class ChatClient
    {
        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async IAsyncEnumerable<global::tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
            global::tryAGI.OpenAI.CreateChatCompletionRequest request,
            [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            if (request.Value2 != null){
                request.Value2.Stream = true;
            }

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateChatCompletionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChatCompletionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            __response.EnsureSuccessStatusCode();
            
            using var stream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            
            await foreach (SseItem<string> sseEvent in SseParser.Create(stream)
                               .EnumerateAsync(cancellationToken)
                               .ConfigureAwait(false))
            {
                if (sseEvent.Data == "[DONE]")
                {
                    yield break;
                }
                
                var partialResponse = 
                    global::System.Text.Json.JsonSerializer.Deserialize(sseEvent.Data, global::tryAGI.OpenAI.SourceGenerationContext.Default.CreateChatCompletionStreamResponse) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{sseEvent.Data}\" ");

                yield return partialResponse;
            }
        }
    }
}
