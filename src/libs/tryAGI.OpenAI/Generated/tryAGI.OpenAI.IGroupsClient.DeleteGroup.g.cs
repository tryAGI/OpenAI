#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Deletes a group from the organization.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupDeletedResource> DeleteGroupAsync(
            string groupId,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}