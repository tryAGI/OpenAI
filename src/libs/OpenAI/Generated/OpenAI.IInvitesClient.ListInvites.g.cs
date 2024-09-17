#nullable enable

namespace OpenAI
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Returns a list of invites in the organization.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="after"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.InviteListResponse> ListInvitesAsync(
            int? limit = 20,
            string? after = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}