
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class ProjectsClient
    {
        partial void PrepareUpdateProjectRateLimitsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string rateLimitId,
            global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest request);
        partial void PrepareUpdateProjectRateLimitsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string rateLimitId,
            global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest request);
        partial void ProcessUpdateProjectRateLimitsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateProjectRateLimitsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Updates a project rate limit.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rateLimitId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectRateLimit> UpdateProjectRateLimitsAsync(
            string projectId,
            string rateLimitId,
            global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateProjectRateLimitsArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                rateLimitId: ref rateLimitId,
                request: request);

            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                path: $"/organization/projects/{projectId}/rate_limits/{rateLimitId}",
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
            PrepareUpdateProjectRateLimitsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                rateLimitId: rateLimitId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateProjectRateLimitsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Error response for various conditions.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::tryAGI.OpenAI.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::tryAGI.OpenAI.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_400 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = await global::tryAGI.OpenAI.ErrorResponse.FromJsonStreamAsync(__contentStream_400, JsonSerializerContext).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::tryAGI.OpenAI.ApiException<global::tryAGI.OpenAI.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessUpdateProjectRateLimitsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::tryAGI.OpenAI.ProjectRateLimit.FromJson(__content, JsonSerializerContext) ??
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
                        await global::tryAGI.OpenAI.ProjectRateLimit.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::tryAGI.OpenAI.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Updates a project rate limit.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="rateLimitId"></param>
        /// <param name="batch1DayMaxInputTokens">
        /// The maximum batch input tokens per day. Only relevant for certain models.
        /// </param>
        /// <param name="maxAudioMegabytesPer1Minute">
        /// The maximum audio megabytes per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxImagesPer1Minute">
        /// The maximum images per minute. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Day">
        /// The maximum requests per day. Only relevant for certain models.
        /// </param>
        /// <param name="maxRequestsPer1Minute">
        /// The maximum requests per minute.
        /// </param>
        /// <param name="maxTokensPer1Minute">
        /// The maximum tokens per minute.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ProjectRateLimit> UpdateProjectRateLimitsAsync(
            string projectId,
            string rateLimitId,
            int? batch1DayMaxInputTokens = default,
            int? maxAudioMegabytesPer1Minute = default,
            int? maxImagesPer1Minute = default,
            int? maxRequestsPer1Day = default,
            int? maxRequestsPer1Minute = default,
            int? maxTokensPer1Minute = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.ProjectRateLimitUpdateRequest
            {
                Batch1DayMaxInputTokens = batch1DayMaxInputTokens,
                MaxAudioMegabytesPer1Minute = maxAudioMegabytesPer1Minute,
                MaxImagesPer1Minute = maxImagesPer1Minute,
                MaxRequestsPer1Day = maxRequestsPer1Day,
                MaxRequestsPer1Minute = maxRequestsPer1Minute,
                MaxTokensPer1Minute = maxTokensPer1Minute,
            };

            return await UpdateProjectRateLimitsAsync(
                projectId: projectId,
                rateLimitId: rateLimitId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}