using System.Linq;
using System.Runtime.CompilerServices;
using tryAGI.OpenAI.Extensions;

#nullable enable

namespace tryAGI.OpenAI
{
    public partial class AssistantsClient
    {
        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="include"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async IAsyncEnumerable<global::tryAGI.OpenAI.AssistantStreamEvent> CreateRunAsStreamAsync(
            string threadId,
            global::tryAGI.OpenAI.CreateRunRequest request,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? include = default,
            [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            request.Stream = true;

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRunArguments(
                httpClient: HttpClient,
                threadId: ref threadId,
                include: include,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/threads/{threadId}/runs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in Authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: httpRequest);
            PrepareCreateRunRequest(
                httpClient: HttpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                include: include,
                request: request);

            using var response = await HttpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: response);
            ProcessCreateRunResponse(
                httpClient: HttpClient,
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

                var partialResponse = 
                    global::System.Text.Json.JsonSerializer.Deserialize(eventData, global::tryAGI.OpenAI.SourceGenerationContext.Default.NullableAssistantStreamEvent) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{eventData}\" ");

                yield return partialResponse;
            }
        }

        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="include"></param>
        /// <param name="assistantId">
        /// The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.
        /// </param>
        /// <param name="model">
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="instructions">
        /// Overrides the [instructions](/docs/api-reference/assistants/createAssistant) of the assistant. This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="additionalInstructions">
        /// Appends additional instructions at the end of the instructions for the run. This is useful for modifying the behavior on a per-run basis without overriding other instructions.
        /// </param>
        /// <param name="additionalMessages">
        /// Adds additional messages to the thread before creating the run.
        /// </param>
        /// <param name="tools">
        /// Override the tools the assistant can use for this run. This is useful for modifying the behavior on a per-run basis.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maxium of 512 characters long.
        /// </param>
        /// <param name="temperature">
        /// empty<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="topP">
        /// empty<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="stream">
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
        /// </param>
        /// <param name="maxPromptTokens">
        /// The maximum number of prompt tokens that may be used over the course of the run. The run will make a best effort to use only the number of prompt tokens specified, across multiple turns of the run. If the run exceeds the number of prompt tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// The maximum number of completion tokens that may be used over the course of the run. The run will make a best effort to use only the number of completion tokens specified, across multiple turns of the run. If the run exceeds the number of completion tokens specified, the run will end with status `incomplete`. See `incomplete_details` for more info.
        /// </param>
        /// <param name="truncationStrategy">
        /// Controls for how a thread will be truncated prior to the run. Use this to control the intial context window of the run.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.<br/>
        /// `none` means the model will not call any tools and instead generates a message.<br/>
        /// `auto` is the default value and means the model can pick between generating a message or calling one or more tools.<br/>
        /// `required` means the model must call one or more tools before responding to the user.<br/>
        /// Specifying a particular tool like `{"type": "file_search"}` or `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable [parallel function calling](/docs/guides/function-calling/parallel-function-calling) during tool use.
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models/gpt-4o), [GPT-4 Turbo](/docs/models/gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which guarantees the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async IAsyncEnumerable<global::tryAGI.OpenAI.AssistantStreamEvent> CreateRunAsStreamAsync(
            string threadId,
            string assistantId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? include = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateRunRequestModel?>? model = default,
            string? instructions = default,
            string? additionalInstructions = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? additionalMessages = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem4>? tools = default,
            global::tryAGI.OpenAI.CreateRunRequestMetadata? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::tryAGI.OpenAI.TruncationObject? truncationStrategy = default,
            global::tryAGI.OpenAI.AssistantsApiToolChoiceOption? toolChoice = default,
            bool? parallelToolCalls = default,
            global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? responseFormat = default,
            [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::tryAGI.OpenAI.CreateRunRequest
            {
                AssistantId = assistantId,
                Model = model,
                Instructions = instructions,
                AdditionalInstructions = additionalInstructions,
                AdditionalMessages = additionalMessages,
                Tools = tools,
                Metadata = metadata,
                Temperature = temperature,
                TopP = topP,
                Stream = stream,
                MaxPromptTokens = maxPromptTokens,
                MaxCompletionTokens = maxCompletionTokens,
                TruncationStrategy = truncationStrategy != null
                    ? (global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>?)truncationStrategy
                    : null,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
            };

            await foreach (var response in CreateRunAsStreamAsync(
               threadId: threadId,
               include: include,
               request: request,
               cancellationToken: cancellationToken).ConfigureAwait(false))
            {
                yield return response;
            }
        }
    }
}