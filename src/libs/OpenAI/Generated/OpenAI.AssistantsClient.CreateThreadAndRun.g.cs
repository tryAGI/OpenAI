
#nullable enable

namespace OpenAI
{
    public partial class AssistantsClient
    {
        /// <summary>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.RunObject> CreateThreadAndRunAsync(
            global::OpenAI.CreateThreadAndRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/threads/runs", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, global::OpenAI.SourceGenerationContext.Default.CreateThreadAndRunRequest);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="thread"></param>
        /// <param name="model"></param>
        /// <param name="instructions"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="temperature"></param>
        /// <param name="topP"></param>
        /// <param name="stream"></param>
        /// <param name="maxPromptTokens"></param>
        /// <param name="maxCompletionTokens"></param>
        /// <param name="truncationStrategy"></param>
        /// <param name="toolChoice"></param>
        /// <param name="parallelToolCalls"></param>
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::OpenAI.RunObject> CreateThreadAndRunAsync(
            string assistantId,
            global::OpenAI.CreateThreadRequest? thread = default,
            global::System.AnyOf<string?, global::OpenAI.CreateThreadAndRunRequestModel?>? model = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::System.OneOf<global::OpenAI.AssistantToolsCode?, global::OpenAI.AssistantToolsFileSearch?, global::OpenAI.AssistantToolsFunction?>?>? tools = default,
            global::OpenAI.CreateThreadAndRunRequestToolResources? toolResources = default,
            object? metadata = default,
            double? temperature = 1,
            double? topP = 1,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::OpenAI.TruncationObject? truncationStrategy = default,
            global::System.OneOf<global::OpenAI.CreateThreadAndRunRequestToolChoice?, global::OpenAI.AssistantsNamedToolChoice?>? toolChoice = default,
            bool? parallelToolCalls = true,
            global::System.OneOf<global::OpenAI.CreateThreadAndRunRequestResponseFormat?, global::OpenAI.AssistantsApiResponseFormat?>? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::OpenAI.CreateThreadAndRunRequest
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
                Stream = stream,
                MaxPromptTokens = maxPromptTokens,
                MaxCompletionTokens = maxCompletionTokens,
                TruncationStrategy = truncationStrategy,
                ToolChoice = toolChoice,
                ParallelToolCalls = parallelToolCalls,
                ResponseFormat = responseFormat,
            };

            return await CreateThreadAndRunAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}