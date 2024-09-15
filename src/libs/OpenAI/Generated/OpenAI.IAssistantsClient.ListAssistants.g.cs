#nullable enable

namespace OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Returns a list of assistants.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::OpenAI.ListAssistantsResponse> ListAssistantsAsync(
            int limit = 20,
            global::OpenAI.ListAssistantsOrder? order = global::OpenAI.ListAssistantsOrder.Desc,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}