#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Returns a list of input items for a given response.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ResponseItemList> ListInputItemsAsync(
            string responseId,
            int? limit = default,
            global::tryAGI.OpenAI.ListInputItemsOrder? order = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}