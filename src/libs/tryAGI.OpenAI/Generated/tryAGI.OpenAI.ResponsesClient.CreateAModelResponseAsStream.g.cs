
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ResponsesClient
    {


        private static readonly global::tryAGI.OpenAI.EndPointSecurityRequirement s_CreateAModelResponseAsStreamSecurityRequirement0 =
            new global::tryAGI.OpenAI.EndPointSecurityRequirement
            {
                Authorizations = new global::tryAGI.OpenAI.EndPointAuthorizationRequirement[]
                {                    new global::tryAGI.OpenAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "ApiKeyAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::tryAGI.OpenAI.EndPointSecurityRequirement[] s_CreateAModelResponseAsStreamSecurityRequirements =
            new global::tryAGI.OpenAI.EndPointSecurityRequirement[]
            {                s_CreateAModelResponseAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateAModelResponseAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.CreateResponse request);
        partial void PrepareCreateAModelResponseAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.CreateResponse request);
        partial void ProcessCreateAModelResponseAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Creates a model response. Provide [text](/docs/guides/text) or<br/>
        /// [image](/docs/guides/images) inputs to generate [text](/docs/guides/text)<br/>
        /// or [JSON](/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](/docs/guides/function-calling) or use built-in<br/>
        /// [tools](/docs/guides/tools) like [web search](/docs/guides/tools-web-search)<br/>
        /// or [file search](/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ResponseStreamEvent> CreateAModelResponseAsStreamAsync(

            global::tryAGI.OpenAI.CreateResponse request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCreateAModelResponseAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::tryAGI.OpenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAModelResponseAsStreamSecurityRequirements,
                operationName: "CreateAModelResponseAsStreamAsync");

            using var __timeoutCancellationTokenSource = global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                                path: "/responses",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAModelResponseAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAModelResponseAsStream",
                                methodName: "CreateAModelResponseAsStreamAsync",
                                pathTemplate: "\"/responses\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAModelResponseAsStream",
                                methodName: "CreateAModelResponseAsStreamAsync",
                                pathTemplate: "\"/responses\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAModelResponseAsStream",
                                methodName: "CreateAModelResponseAsStreamAsync",
                                pathTemplate: "\"/responses\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateAModelResponseAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAModelResponseAsStream",
                                methodName: "CreateAModelResponseAsStreamAsync",
                                pathTemplate: "\"/responses\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateAModelResponseAsStream",
                                methodName: "CreateAModelResponseAsStreamAsync",
                                pathTemplate: "\"/responses\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
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

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::tryAGI.OpenAI.ResponseStreamEvent.FromJson(__content, JsonSerializerContext) ??
                                                       throw new global::tryAGI.OpenAI.ApiException(
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           statusCode: __response.StatusCode)
                                                       {
                                                           ResponseBody = __content,
                                                           ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value),
                                                       };

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Creates a model response. Provide [text](/docs/guides/text) or<br/>
        /// [image](/docs/guides/images) inputs to generate [text](/docs/guides/text)<br/>
        /// or [JSON](/docs/guides/structured-outputs) outputs. Have the model call<br/>
        /// your own [custom code](/docs/guides/function-calling) or use built-in<br/>
        /// [tools](/docs/guides/tools) like [web search](/docs/guides/tools-web-search)<br/>
        /// or [file search](/docs/guides/tools-file-search) to use your own data<br/>
        /// as input for the model's response.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ResponseStreamEvent> CreateAModelResponseAsStreamAsync(
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.CreateResponse
            {
            };

            var __enumerable = CreateAModelResponseAsStreamAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}