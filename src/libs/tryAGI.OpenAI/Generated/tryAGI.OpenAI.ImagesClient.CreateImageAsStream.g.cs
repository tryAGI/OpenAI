
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ImagesClient
    {


        private static readonly global::tryAGI.OpenAI.EndPointSecurityRequirement s_CreateImageAsStreamSecurityRequirement0 =
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
        private static readonly global::tryAGI.OpenAI.EndPointSecurityRequirement[] s_CreateImageAsStreamSecurityRequirements =
            new global::tryAGI.OpenAI.EndPointSecurityRequirement[]
            {                s_CreateImageAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateImageAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.CreateImageRequest request);
        partial void PrepareCreateImageAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.CreateImageRequest request);
        partial void ProcessCreateImageAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Creates an image given a prompt. [Learn more](/docs/guides/images).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ImageGenStreamEvent> CreateImageAsStreamAsync(

            global::tryAGI.OpenAI.CreateImageRequest request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::tryAGI.OpenAI.CreateImageRequest
            {
                Prompt = request.Prompt,
                Model = request.Model,
                N = request.N,
                Quality = request.Quality,
                ResponseFormat = request.ResponseFormat,
                OutputFormat = request.OutputFormat,
                OutputCompression = request.OutputCompression,
                Stream = true,
                PartialImages = request.PartialImages,
                Size = request.Size,
                Moderation = request.Moderation,
                Background = request.Background,
                Style = request.Style,
                User = request.User,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateImageAsStreamArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::tryAGI.OpenAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateImageAsStreamSecurityRequirements,
                operationName: "CreateImageAsStreamAsync");

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
                                path: "/images/generations",
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
                PrepareCreateImageAsStreamRequest(
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
                                operationId: "CreateImageAsStream",
                                methodName: "CreateImageAsStreamAsync",
                                pathTemplate: "\"/images/generations\"",
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
                                operationId: "CreateImageAsStream",
                                methodName: "CreateImageAsStreamAsync",
                                pathTemplate: "\"/images/generations\"",
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
                                operationId: "CreateImageAsStream",
                                methodName: "CreateImageAsStreamAsync",
                                pathTemplate: "\"/images/generations\"",
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
                ProcessCreateImageAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::tryAGI.OpenAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateImageAsStream",
                                methodName: "CreateImageAsStreamAsync",
                                pathTemplate: "\"/images/generations\"",
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
                                operationId: "CreateImageAsStream",
                                methodName: "CreateImageAsStreamAsync",
                                pathTemplate: "\"/images/generations\"",
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

                                var __streamedResponse = global::tryAGI.OpenAI.ImageGenStreamEvent.FromJson(__content, JsonSerializerContext) ??
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
        /// Creates an image given a prompt. [Learn more](/docs/guides/images).
        /// </summary>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 32000 characters for the GPT image models, 1000 characters for `dall-e-2` and 4000 characters for `dall-e-3`.<br/>
        /// Example: A cute baby sea otter
        /// </param>
        /// <param name="model">
        /// The model to use for image generation. One of `dall-e-2`, `dall-e-3`, or a GPT image model (`gpt-image-1`, `gpt-image-1-mini`, `gpt-image-1.5`). Defaults to `dall-e-2` unless a parameter specific to the GPT image models is used.<br/>
        /// Default Value: dall-e-2<br/>
        /// Example: gpt-image-1.5
        /// </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is supported.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated.<br/>
        /// - `auto` (default value) will automatically select the best quality for the given model.<br/>
        /// - `high`, `medium` and `low` are supported for the GPT image models.<br/>
        /// - `hd` and `standard` are supported for `dall-e-3`.<br/>
        /// - `standard` is the only option for `dall-e-2`.<br/>
        /// Default Value: auto<br/>
        /// Example: medium
        /// </param>
        /// <param name="responseFormat">
        /// The format in which generated images with `dall-e-2` and `dall-e-3` are returned. Must be one of `url` or `b64_json`. URLs are only valid for 60 minutes after the image has been generated. This parameter isn't supported for the GPT image models, which always return base64-encoded images.<br/>
        /// Default Value: url<br/>
        /// Example: url
        /// </param>
        /// <param name="outputFormat">
        /// The format in which the generated images are returned. This parameter is only supported for the GPT image models. Must be one of `png`, `jpeg`, or `webp`.<br/>
        /// Default Value: png<br/>
        /// Example: png
        /// </param>
        /// <param name="outputCompression">
        /// The compression level (0-100%) for the generated images. This parameter is only supported for the GPT image models with the `webp` or `jpeg` output formats, and defaults to 100.<br/>
        /// Default Value: 100<br/>
        /// Example: 100
        /// </param>
        /// <param name="partialImages"></param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `1024x1024`, `1536x1024` (landscape), `1024x1536` (portrait), or `auto` (default value) for the GPT image models, one of `256x256`, `512x512`, or `1024x1024` for `dall-e-2`, and one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3`.<br/>
        /// Default Value: auto<br/>
        /// Example: 1024x1024
        /// </param>
        /// <param name="moderation">
        /// Control the content-moderation level for images generated by the GPT image models. Must be either `low` for less restrictive filtering or `auto` (default value).<br/>
        /// Default Value: auto<br/>
        /// Example: low
        /// </param>
        /// <param name="background">
        /// Allows to set transparency for the background of the generated image(s).<br/>
        /// This parameter is only supported for the GPT image models. Must be one of<br/>
        /// `transparent`, `opaque` or `auto` (default value). When `auto` is used, the<br/>
        /// model will automatically determine the best background for the image.<br/>
        /// If `transparent`, the output format needs to support transparency, so it<br/>
        /// should be set to either `png` (default value) or `webp`.<br/>
        /// Default Value: auto<br/>
        /// Example: transparent
        /// </param>
        /// <param name="style">
        /// The style of the generated images. This parameter is only supported for `dall-e-3`. Must be one of `vivid` or `natural`. Vivid causes the model to lean towards generating hyper-real and dramatic images. Natural causes the model to produce more natural, less hyper-real looking images.<br/>
        /// Default Value: vivid<br/>
        /// Example: vivid
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids).<br/>
        /// Example: user-1234
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.ImageGenStreamEvent> CreateImageAsStreamAsync(
            string prompt,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateImageRequestModel?>? model = default,
            int? n = default,
            global::tryAGI.OpenAI.CreateImageRequestQuality? quality = default,
            global::tryAGI.OpenAI.CreateImageRequestResponseFormat? responseFormat = default,
            global::tryAGI.OpenAI.CreateImageRequestOutputFormat? outputFormat = default,
            int? outputCompression = default,
            int? partialImages = default,
            global::tryAGI.OpenAI.CreateImageRequestSize? size = default,
            global::tryAGI.OpenAI.CreateImageRequestModeration? moderation = default,
            global::tryAGI.OpenAI.CreateImageRequestBackground? background = default,
            global::tryAGI.OpenAI.CreateImageRequestStyle? style = default,
            string? user = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.CreateImageRequest
            {
                Prompt = prompt,
                Model = model,
                N = n,
                Quality = quality,
                ResponseFormat = responseFormat,
                OutputFormat = outputFormat,
                OutputCompression = outputCompression,
                Stream = true,
                PartialImages = partialImages,
                Size = size,
                Moderation = moderation,
                Background = background,
                Style = style,
                User = user,
            };

            var __enumerable = CreateImageAsStreamAsync(
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