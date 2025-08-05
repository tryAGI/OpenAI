#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IInvitesClient
    {
        /// <summary>
        /// Create invite<br/>
        /// Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Invite> InviteUserAsync(
            global::tryAGI.OpenAI.InviteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create invite<br/>
        /// Create an invite for a user to the organization. The invite must be accepted by the user before they have access to the organization.
        /// </summary>
        /// <param name="email">
        /// Send an email to this address
        /// </param>
        /// <param name="projects">
        /// An array of projects to which membership is granted at the same time the org invite is accepted. If omitted, the user will be invited to the default project for compatibility with legacy behavior.
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Invite> InviteUserAsync(
            string email,
            global::tryAGI.OpenAI.InviteRequestRole role,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteRequestProject>? projects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}