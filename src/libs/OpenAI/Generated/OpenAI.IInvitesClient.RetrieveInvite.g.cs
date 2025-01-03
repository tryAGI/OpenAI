#nullable enable

namespace OpenAI
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Retrieves an invite.
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.Invite> RetrieveInviteAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}