#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// List all organization and project API keys.<br/>
        /// List organization API keys
        /// </summary>
        /// <param name="after">
        /// Return keys with IDs that come after this ID in the pagination order.
        /// </param>
        /// <param name="order">
        /// Order results by creation time, ascending or descending.<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="limit">
        /// Maximum number of keys to return.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ApiKeyList> AdminApiKeysListAsync(
            string? after = default,
            global::tryAGI.OpenAI.AdminApiKeysListOrder? order = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}