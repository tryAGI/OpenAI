#nullable enable

namespace OpenAI
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Invite> InviteUserAsync(
            global::OpenAI.InviteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.
        /// </summary>
        /// <param name="email">
        /// Send an email to this address
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Invite> InviteUserAsync(
            string email,
            global::OpenAI.InviteRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}