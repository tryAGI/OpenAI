#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Retrieves an invite.
        /// </summary>
        /// <param name="inviteId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Invite> RetrieveInviteAsync(
            string inviteId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}