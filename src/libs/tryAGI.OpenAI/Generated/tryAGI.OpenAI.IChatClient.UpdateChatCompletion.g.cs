#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Update chat completion<br/>
        /// Modify a stored chat completion. Only Chat Completions that have been<br/>
        /// created with the `store` parameter set to `true` can be modified. Currently,<br/>
        /// the only supported modification is to update the `metadata` field.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateChatCompletionResponse> UpdateChatCompletionAsync(
            string completionId,
            global::tryAGI.OpenAI.UpdateChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update chat completion<br/>
        /// Modify a stored chat completion. Only Chat Completions that have been<br/>
        /// created with the `store` parameter set to `true` can be modified. Currently,<br/>
        /// the only supported modification is to update the `metadata` field.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateChatCompletionResponse> UpdateChatCompletionAsync(
            string completionId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}