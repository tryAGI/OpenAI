#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Creates a new group in the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupResponse> CreateGroupAsync(

            global::tryAGI.OpenAI.CreateGroupBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new group in the organization.
        /// </summary>
        /// <param name="name">
        /// Human readable name for the group.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupResponse> CreateGroupAsync(
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}