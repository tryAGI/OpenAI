
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ResponsesClient
    {
        partial void PrepareGetAModelResponseArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include,
            ref bool? stream,
            ref int? startingAfter,
            ref bool? includeObfuscation);
        partial void PrepareGetAModelResponseRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include,
            bool? stream,
            int? startingAfter,
            bool? includeObfuscation);
        partial void ProcessGetAModelResponseResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAModelResponseResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Response> GetAModelResponseAsync(
            string responseId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.IncludeEnum>? include = default,
            bool? stream = default,
            int? startingAfter = default,
            bool? includeObfuscation = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAModelResponseArguments(
                httpClient: HttpClient,
                responseId: ref responseId,
                include: include,
                stream: ref stream,
                startingAfter: ref startingAfter,
                includeObfuscation: ref includeObfuscation);

            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                path: $"/responses/{responseId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("include", include, selector: static x => x.ToValueString(), delimiter: ",", explode: true)
                .AddOptionalParameter("stream", stream?.ToString().ToLowerInvariant())
                .AddOptionalParameter("starting_after", startingAfter?.ToString())
                .AddOptionalParameter("include_obfuscation", includeObfuscation?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetAModelResponseRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                responseId: responseId,
                include: include,
                stream: stream,
                startingAfter: startingAfter,
                includeObfuscation: includeObfuscation);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAModelResponseResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetAModelResponseResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::tryAGI.OpenAI.Response.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::tryAGI.OpenAI.Response.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}