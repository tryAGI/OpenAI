
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class AssistantsClient
    {


        private static readonly global::tryAGI.OpenAI.EndPointSecurityRequirement s_CreateThreadAndRunAsStreamSecurityRequirement0 =
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
        private static readonly global::tryAGI.OpenAI.EndPointSecurityRequirement[] s_CreateThreadAndRunAsStreamSecurityRequirements =
            new global::tryAGI.OpenAI.EndPointSecurityRequirement[]
            {                s_CreateThreadAndRunAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateThreadAndRunAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.CreateThreadAndRunRequest request);
        partial void PrepareCreateThreadAndRunAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.CreateThreadAndRunRequest request);
        partial void ProcessCreateThreadAndRunAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Create thread and run<br/>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.AssistantStreamEvent> CreateThreadAndRunAsStreamAsync(

            global::tryAGI.OpenAI.CreateThreadAndRunRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::tryAGI.OpenAI.CreateThreadAndRunRequest
            {
                AssistantId = request.AssistantId,
                Thread = request.Thread,
                Model = request.Model,
                Instructions = request.Instructions,
                Tools = request.Tools,
                ToolResources = request.ToolResources,
                Metadata = request.Metadata,
                Temperature = request.Temperature,
                TopP = request.TopP,
                Stream = true,
                MaxPromptTokens = request.MaxPromptTokens,
                MaxCompletionTokens = request.MaxCompletionTokens,
                TruncationStrategy = request.TruncationStrategy,
                ToolChoice = request.ToolChoice,
                ParallelToolCalls = request.ParallelToolCalls,
                ResponseFormat = request.ResponseFormat,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateThreadAndRunAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::tryAGI.OpenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateThreadAndRunAsStreamSecurityRequirements,
                operationName: "CreateThreadAndRunAsStreamAsync");

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
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                                path: "/threads/runs",
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

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "text/event-stream");

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
                PrepareCreateThreadAndRunAsStreamRequest(
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
                                operationId: "CreateThreadAndRunAsStream",
                                methodName: "CreateThreadAndRunAsStreamAsync",
                                pathTemplate: "\"/threads/runs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateThreadAndRunAsStream",
                                methodName: "CreateThreadAndRunAsStreamAsync",
                                pathTemplate: "\"/threads/runs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateThreadAndRunAsStream",
                                methodName: "CreateThreadAndRunAsStreamAsync",
                                pathTemplate: "\"/threads/runs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessCreateThreadAndRunAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateThreadAndRunAsStream",
                                methodName: "CreateThreadAndRunAsStreamAsync",
                                pathTemplate: "\"/threads/runs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateThreadAndRunAsStream",
                                methodName: "CreateThreadAndRunAsStreamAsync",
                                pathTemplate: "\"/threads/runs\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest ?? throw new global::System.InvalidOperationException("The HTTP request was not created before invoking a request hook."),
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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

                                throw global::tryAGI.OpenAI.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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

                                var __streamedResponse = global::tryAGI.OpenAI.AssistantStreamEvent.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::tryAGI.OpenAI.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

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
        /// Create thread and run<br/>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="assistantId">
        /// The ID of the [assistant](https://developers.openai.com/api/docs/assistants/migration) to use to execute this run.
        /// </param>
        /// <param name="thread">
        /// Options to create a new thread. If no thread is provided when running a<br/>
        /// request, an empty thread will be created.
        /// </param>
        /// <param name="model">
        /// The ID of the [Model](https://developers.openai.com/api/reference/resources/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.<br/>
        /// Example: gpt-4.1
        /// </param>
        /// <param name="instructions">
        /// Override the default system message of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="tools">
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="toolResources">
        /// A set of resources that are used by the assistant's tools. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="temperature">
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.<br/>
        /// We generally recommend altering this or temperature but not both.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="maxPromptTokens">
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](https://developers.openai.com/api/docs/guides/function-calling#parallel-function-calling) during tool use.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](https://developers.openai.com/api/docs/models/gpt-4o), [GPT-4 Turbo](https://developers.openai.com/api/docs/models/gpt-4-turbo), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](https://developers.openai.com/api/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.AssistantStreamEvent> CreateThreadAndRunAsStreamAsync(
            string assistantId,
            global::tryAGI.OpenAI.CreateThreadRequest? thread = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>? model = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>? tools = default,
            global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources? toolResources = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            double? temperature = default,
            double? topP = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? truncationStrategy = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? responseFormat = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.CreateThreadAndRunRequest
            {
                AssistantId = assistantId,
                Thread = thread,
                Model = model,
                Instructions = instructions,
                Tools = tools,
                ToolResources = toolResources,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                Stream = true,
                MaxPromptTokens = maxPromptTokens,
                MaxCompletionTokens = maxCompletionTokens,
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
            };

            var __enumerable = CreateThreadAndRunAsStreamAsync(
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