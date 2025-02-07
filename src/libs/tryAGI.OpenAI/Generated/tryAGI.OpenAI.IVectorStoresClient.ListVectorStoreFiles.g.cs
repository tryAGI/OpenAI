#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector store files.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int? limit = default,
            global::tryAGI.OpenAI.ListVectorStoreFilesOrder? order = default,
            string? after = default,
            string? before = default,
            global::tryAGI.OpenAI.ListVectorStoreFilesFilter? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}