#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RunObject> CreateThreadAndRunAsync(
            global::tryAGI.OpenAI.CreateThreadAndRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a thread and run it in one request.
        /// </summary>
        /// <param name="assistantId">
        /// The ID of the [assistant](/docs/api-reference/assistants) to use to execute this run.
        /// </param>
        /// <param name="thread">
        /// Options to create a new thread. If no thread is provided when running a <br/>
        /// request, an empty thread will be created.
        /// </param>
        /// <param name="model">
        /// The ID of the [Model](/docs/api-reference/models) to be used to execute this run. If a value is provided here, it will override the model associated with the assistant. If not, the model associated with the assistant will be used.<br/>
        /// Example: gpt-4o
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
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
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
        /// <param name="responseFormat"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RunObject> CreateThreadAndRunAsync(
            string assistantId,
            global::tryAGI.OpenAI.CreateThreadRequest? thread = default,
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.CreateThreadAndRunRequestModel?>? model = default,
            string? instructions = default,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ToolsItem5>? tools = default,
            global::tryAGI.OpenAI.CreateThreadAndRunRequestToolResources? toolResources = default,
            object? metadata = default,
            double? temperature = default,
            double? topP = default,
            bool? stream = default,
            int? maxPromptTokens = default,
            int? maxCompletionTokens = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.TruncationObject, object>? truncationStrategy = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiToolChoiceOption?, object>? toolChoice = default,
            bool? parallelToolCalls = default,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.AssistantsApiResponseFormatOption?, object>? responseFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}