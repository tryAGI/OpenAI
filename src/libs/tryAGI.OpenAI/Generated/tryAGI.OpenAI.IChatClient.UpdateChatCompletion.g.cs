#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IChatClient
    {
        /// <summary>
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
        /// Modify a stored chat completion. Only Chat Completions that have been<br/>
        /// created with the `store` parameter set to `true` can be modified. Currently,<br/>
        /// the only supported modification is to update the `metadata` field.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CreateChatCompletionResponse> UpdateChatCompletionAsync(
            string completionId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}