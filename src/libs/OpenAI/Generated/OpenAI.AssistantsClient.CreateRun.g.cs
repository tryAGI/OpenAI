
#nullable enable

namespace OpenAI
{
    public partial class AssistantsClient
    {
        partial void PrepareCreateRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string threadId,
            global::OpenAI.CreateRunRequest request);
        partial void PrepareCreateRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string threadId,
            global::OpenAI.CreateRunRequest request);
        partial void ProcessCreateRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.RunObject> CreateRunAsync(
            string threadId,
            global::OpenAI.CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateRunArguments(
                httpClient: _httpClient,
                threadId: ref threadId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/threads/{threadId}/runs", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateRunRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateRunRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                threadId: threadId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateRunResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::OpenAI.SourceGenerationContext.Default.RunObject) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="assistantId">
        /// The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.
        /// </param>
        /// <param name="model">
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.<br/>
        /// Example: gpt-4-turbo
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
        /// Setting to `{ "type": "json_object" }` enables JSON mode, which guarantees the message the model generates is valid JSON.<br/>
        /// **Important:** when using JSON mode, you **must** also instruct the model to produce JSON yourself via a system or user message. Without this, the model may generate an unending stream of whitespace until the generation reaches the token limit, resulting in a long-running and seemingly "stuck" request. Also note that the message content may be partially cut off if `finish_reason="length"`, which indicates the generation exceeded `max_tokens` or the conversation exceeded the max context length.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.RunObject> CreateRunAsync(
            string threadId,
            string assistantId,
            global::System.AnyOf<string?, global::OpenAI.CreateRunRequestModel?>? model = default,
            string? instructions = default,
            string? additionalInstructions = default,
            global::System.Collections.Generic.IList<global::OpenAI.CreateMessageRequest>? additionalMessages = default,
            global::System.Collections.Generic.IList<global::System.OneOf<global::OpenAI.AssistantToolsCode?, global::OpenAI.AssistantToolsFileSearch?, global::OpenAI.AssistantToolsFunction?>?>? tools = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::OpenAI.TruncationObject? truncationStrategy = default,
            global::System.OneOf<global::OpenAI.CreateRunRequestToolChoice?, global::OpenAI.AssistantsNamedToolChoice?>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::System.OneOf<global::OpenAI.CreateRunRequestResponseFormat?, global::OpenAI.AssistantsApiResponseFormat?>? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateRunRequest
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
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
            };

            return await CreateRunAsync(
                threadId: threadId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}