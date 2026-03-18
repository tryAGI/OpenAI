
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class RealtimeClient
    {
        partial void PrepareCreateRealtimeClientSecretArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest request);
        partial void PrepareCreateRealtimeClientSecretRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest request);
        partial void ProcessCreateRealtimeClientSecretResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRealtimeClientSecretResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Realtime client secret with an associated session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime API without<br/>
        /// leaking your main API key. You can configure a custom TTL for each client secret.<br/>
        /// You can also attach session configuration options to the client secret, which will be<br/>
        /// applied to any sessions created using that client secret, but these can also be overridden<br/>
        /// by the client connection.<br/>
        /// [Learn more about authentication with client secrets over WebRTC](/docs/guides/realtime-webrtc).<br/>
        /// Returns the created client secret and the effective session object. The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse> CreateRealtimeClientSecretAsync(

            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRealtimeClientSecretArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                path: "/realtime/client_secrets",
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
            PrepareCreateRealtimeClientSecretRequest(
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
            ProcessCreateRealtimeClientSecretResponse(
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
                ProcessCreateRealtimeClientSecretResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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

        /// <summary>
        /// Create a Realtime client secret with an associated session configuration.<br/>
        /// Client secrets are short-lived tokens that can be passed to a client app,<br/>
        /// such as a web frontend or mobile client, which grants access to the Realtime API without<br/>
        /// leaking your main API key. You can configure a custom TTL for each client secret.<br/>
        /// You can also attach session configuration options to the client secret, which will be<br/>
        /// applied to any sessions created using that client secret, but these can also be overridden<br/>
        /// by the client connection.<br/>
        /// [Learn more about authentication with client secrets over WebRTC](/docs/guides/realtime-webrtc).<br/>
        /// Returns the created client secret and the effective session object. The client secret is a string that looks like `ek_1234`.
        /// </summary>
        /// <param name="expiresAfter">
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </param>
        /// <param name="session">
        /// Session configuration to use for the client secret. Choose either a realtime<br/>
        /// session or a transcription session.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeCreateClientSecretResponse> CreateRealtimeClientSecretAsync(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? expiresAfter = default,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.RealtimeCreateClientSecretRequest
            {
                ExpiresAfter = expiresAfter,
                Session = session,
            };

            return await CreateRealtimeClientSecretAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}