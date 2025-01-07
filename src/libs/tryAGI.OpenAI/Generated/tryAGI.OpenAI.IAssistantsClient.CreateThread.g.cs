#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Create a thread.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ThreadObject> CreateThreadAsync(
            global::tryAGI.OpenAI.CreateThreadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a thread.
        /// </summary>
        /// <param name="messages">
        /// A list of [messages](/docs/api-reference/messages) to start the thread with.
        /// </param>
        /// <param name="toolResources">
        /// A set of resources that are made available to the assistant's tools in this thread. The resources are specific to the type of tool. For example, the `code_interpreter` tool requires a list of file IDs, while the `file_search` tool requires a list of vector store IDs.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ThreadObject> CreateThreadAsync(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.CreateMessageRequest>? messages = default,
            global::tryAGI.OpenAI.CreateThreadRequestToolResources? toolResources = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}