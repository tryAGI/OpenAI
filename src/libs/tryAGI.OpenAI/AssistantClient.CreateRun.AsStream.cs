using System.Linq;
using System.Net.ServerSentEvents;
using System.Runtime.CompilerServices;

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
            
            await foreach (SseItem<string> sseEvent in SseParser.Create(stream)
                               .EnumerateAsync(cancellationToken)
                               .ConfigureAwait(false))
            {
                if (sseEvent.Data == "[DONE]")
                {
                    yield break;
                }

                var partialResponse = 
                    global::System.Text.Json.JsonSerializer.Deserialize(sseEvent.Data, global::tryAGI.OpenAI.SourceGenerationContext.Default.NullableAssistantStreamEvent) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{sseEvent.Data}\" ");

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
        /// <param name="reasoningEffort">
        /// **o-series models only** <br/>
        /// Constrains effort on reasoning for <br/>
        /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
        /// Currently supported values are `low`, `medium`, and `high`. Reducing<br/>
        /// reasoning effort can result in faster responses and fewer tokens used<br/>
        /// on reasoning in a response.<br/>
        /// Default Value: medium
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
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
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
        /// <param name="stream">
        /// If `true`, returns a stream of events that happen during the Run as server-sent events, terminating when the Run enters a terminal state with a `data: [DONE]` message.
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
        /// Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use.
        /// </param>
        /// <param name="responseFormat">
        /// Specifies the format that the model must output. Compatible with [GPT-4o](/docs/models#gpt-4o), [GPT-4 Turbo](/docs/models#gpt-4-turbo-and-gpt-4), and all GPT-3.5 Turbo models since `gpt-3.5-turbo-1106`.<br/>
        /// Setting to `{ "type": "json_schema", "json_schema": {...} }` enables Structured Outputs which ensures the model will match your supplied JSON schema. Learn more in the [Structured Outputs guide](/docs/guides/structured-outputs).<br/>
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which ensures the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
#endif
        public async IAsyncEnumerable<global::tryAGI.OpenAI.AssistantStreamEvent> CreateRunAsStreamAsync(
            string threadId,
            string assistantId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateRunIncludeItem>? include = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AssistantSupportedModels?>? model = default,
            global::tryAGI.OpenAI.ReasoningEffort? reasoningEffort = default,
            string? instructions = default,
            string? additionalInstructions = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? additionalMessages = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.AssistantToolsCode, global::tryAGI.OpenAI.AssistantToolsFileSearch, global::tryAGI.OpenAI.AssistantToolsFunction>>? tools = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            double? temperature = default,
            double? topP = default,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? truncationStrategy = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::tryAGI.OpenAI.AssistantsApiResponseFormatOption? responseFormat = default,
            [EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::tryAGI.OpenAI.CreateRunRequest
            {
                AssistantId = assistantId,
                Model = model,
                ReasoningEffort = reasoningEffort,
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
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
            };

            await foreach (var response in CreateRunAsStreamAsync(
               threadId: threadId,
               include: include,
               request: __request,
               cancellationToken: cancellationToken).ConfigureAwait(false))
            {
                yield return response;
            }
        }
    }
}