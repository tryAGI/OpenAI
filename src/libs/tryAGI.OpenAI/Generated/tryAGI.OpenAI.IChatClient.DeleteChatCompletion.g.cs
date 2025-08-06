#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Delete chat completion<br/>
        /// Delete a stored chat completion. Only Chat Completions that have been<br/>
        /// created with the `store` parameter set to `true` can be deleted.
        /// </summary>
        /// <param name="completionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ChatCompletionDeleted> DeleteChatCompletionAsync(
            string completionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}