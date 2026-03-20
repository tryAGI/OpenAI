#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Modifies a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ThreadObject> ModifyThreadAsync(
            string threadId,

            global::tryAGI.OpenAI.ModifyThreadRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modifies a thread.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="toolResources"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ThreadObject> ModifyThreadAsync(
            string threadId,
            global::tryAGI.OpenAI.ModifyThreadRequestToolResources2? toolResources = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}