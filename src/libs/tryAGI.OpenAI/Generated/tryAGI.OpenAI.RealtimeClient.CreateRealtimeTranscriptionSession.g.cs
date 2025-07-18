
#nullable enable

namespace tryAGI.OpenAI
{
    public partial class RealtimeClient
    {
        partial void PrepareCreateRealtimeTranscriptionSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest request);
        partial void PrepareCreateRealtimeTranscriptionSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest request);
        partial void ProcessCreateRealtimeTranscriptionSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRealtimeTranscriptionSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API specifically for realtime transcriptions. <br/>
        /// Can be configured with the same session parameters as the `transcription_session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse> CreateRealtimeTranscriptionSessionAsync(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRealtimeTranscriptionSessionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::tryAGI.OpenAI.PathBuilder(
                path: "/realtime/transcription_sessions",
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
            PrepareCreateRealtimeTranscriptionSessionRequest(
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
            ProcessCreateRealtimeTranscriptionSessionResponse(
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
                ProcessCreateRealtimeTranscriptionSessionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create an ephemeral API token for use in client-side applications with the<br/>
        /// Realtime API specifically for realtime transcriptions. <br/>
        /// Can be configured with the same session parameters as the `transcription_session.update` client event.<br/>
        /// It responds with a session object, plus a `client_secret` key which contains<br/>
        /// a usable ephemeral API token that can be used to authenticate browser clients<br/>
        /// for the Realtime API.
        /// </summary>
        /// <param name="clientSecret">
        /// Configuration options for the generated client secret.
        /// </param>
        /// <param name="include">
        /// The set of items to include in the transcription. Current available items are:<br/>
        /// - `item.input_audio_transcription.logprobs`
        /// </param>
        /// <param name="inputAudioFormat">
        /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
        /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate,<br/>
        /// single channel (mono), and little-endian byte order.<br/>
        /// Default Value: pcm16
        /// </param>
        /// <param name="inputAudioNoiseReduction">
        /// Configuration for input audio noise reduction. This can be set to `null` to turn off.<br/>
        /// Noise reduction filters audio added to the input audio buffer before it is sent to VAD and the model.<br/>
        /// Filtering the audio can improve VAD and turn detection accuracy (reducing false positives) and model performance by improving perception of the input audio.
        /// </param>
        /// <param name="inputAudioTranscription">
        /// Configuration for input audio transcription. The client can optionally set the language and prompt for transcription, these offer additional guidance to the transcription service.
        /// </param>
        /// <param name="modalities">
        /// The set of modalities the model can respond with. To disable audio,<br/>
        /// set this to ["text"].
        /// </param>
        /// <param name="turnDetection">
        /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
        /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
        /// Semantic VAD is more advanced and uses a turn detection model (in conjuction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse> CreateRealtimeTranscriptionSessionAsync(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestClientSecret? clientSecret = default,
            global::System.Collections.Generic.IList<string>? include = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioFormat? inputAudioFormat = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioNoiseReduction? inputAudioNoiseReduction = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestInputAudioTranscription? inputAudioTranscription = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestModalitie>? modalities = default,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestTurnDetection? turnDetection = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequest
            {
                ClientSecret = clientSecret,
                Include = include,
                InputAudioFormat = inputAudioFormat,
                InputAudioNoiseReduction = inputAudioNoiseReduction,
                InputAudioTranscription = inputAudioTranscription,
                Modalities = modalities,
                TurnDetection = turnDetection,
            };

            return await CreateRealtimeTranscriptionSessionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}