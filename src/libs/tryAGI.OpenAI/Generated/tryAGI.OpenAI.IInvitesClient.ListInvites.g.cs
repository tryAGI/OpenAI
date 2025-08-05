#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// List invites<br/>
        /// Returns a list of invites in the organization.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.InviteListResponse> ListInvitesAsync(
            int? limit = default,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}