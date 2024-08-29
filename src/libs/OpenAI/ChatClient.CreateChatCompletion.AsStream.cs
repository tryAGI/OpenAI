using System.Runtime.CompilerServices;
using OpenAI.Extensions;

// ReSharper disable RedundantNameQualifier

namespace OpenAI
{
    public partial class ChatClient
    {
        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async IAsyncEnumerable<global::OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
            global::OpenAI.CreateChatCompletionRequest request,
            [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            request.Stream = true;

            PrepareArguments(
                client: _httpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/chat/completions", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateChatCompletionRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateChatCompletionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateChatCompletionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            response.EnsureSuccessStatusCode();
            
            using var stream = await response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            using var reader = new StreamReader(stream);
            
#if NET8_0_OR_GREATER
            while (await reader.ReadLineAsync(cancellationToken).ConfigureAwait(false) is { } streamData)
#else
            while (await reader.ReadLineAsync().ConfigureAwait(false) is { } streamData)
#endif
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (!streamData.TryGetEventStreamData(out var eventData)) { continue; }
                if (string.IsNullOrWhiteSpace(eventData)) { continue; }

                ProcessCreateChatCompletionResponseContent(
                    httpClient: _httpClient,
                    httpResponseMessage: response,
                    content: ref eventData);

                var partialResponse = 
                    global::System.Text.Json.JsonSerializer.Deserialize(eventData, global::OpenAI.SourceGenerationContext.Default.CreateChatCompletionStreamResponse) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{eventData}\" ");

                yield return partialResponse;
            }
        }

        /// <summary>
        /// Creates a model response for the given chat conversation.
        /// </summary>
        /// <param name="messages"></param>
        /// <param name="model"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="logitBias"></param>
        /// <param name="logprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="maxTokens"></param>
        /// <param name="n"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="responseFormat"></param>
        /// <param name="seed"></param>
        /// <param name="serviceTier"></param>
        /// <param name="stop"></param>
        /// <param name="stream"></param>
        /// <param name="streamOptions"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="tools"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async IAsyncEnumerable<global::OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
            global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionRequestMessage> messages,
            global::System.AnyOf<string, global::OpenAI.CreateChatCompletionRequestModel?> model,
            double? frequencyPenalty = 0,
            global::OpenAI.CreateChatCompletionRequestLogitBias? logitBias = default,
            bool? logprobs = false,
            int? topLogprobs = default,
            int? maxTokens = default,
            int? n = 1,
            double? presencePenalty = 0,
            global::System.OneOf<global::OpenAI.ResponseFormatText, global::OpenAI.ResponseFormatJsonObject, global::OpenAI.ResponseFormatJsonSchema>? responseFormat = default,
            int? seed = default,
            global::OpenAI.CreateChatCompletionRequestServiceTier? serviceTier = default,
            global::System.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? stream = false,
            global::OpenAI.ChatCompletionStreamOptions? streamOptions = default,
            double? temperature = 1,
            double? topP = 1,
            global::System.Collections.Generic.IList<global::OpenAI.ChatCompletionTool>? tools = default,
            global::OpenAI.ChatCompletionToolChoiceOption? toolChoice = default,
            bool? parallelToolCalls = default,
            string? user = default,
            [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateChatCompletionRequest
            {
                Messages = messages,
                Model = model,
                FrequencyPenalty = frequencyPenalty,
                LogitBias = logitBias,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                MaxTokens = maxTokens,
                N = n,
                PresencePenalty = presencePenalty,
                ResponseFormat = responseFormat,
                Seed = seed,
                ServiceTier = serviceTier,
                Stop = stop,
                Stream = stream,
                StreamOptions = streamOptions,
                Temperature = temperature,
                TopP = topP,
                Tools = tools,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                User = user,
            };

            await foreach (var response in CreateChatCompletionAsStreamAsync(request, cancellationToken))
            {
                yield return response;
            }
        }
    }
}
