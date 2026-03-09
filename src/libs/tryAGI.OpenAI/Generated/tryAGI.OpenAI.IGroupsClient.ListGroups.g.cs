#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IGroupsClient
    {
        /// <summary>
        /// Lists all groups in the organization.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="after"></param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.GroupListResource> ListGroupsAsync(
            int? limit = default,
            string? after = default,
            global::tryAGI.OpenAI.ListGroupsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}