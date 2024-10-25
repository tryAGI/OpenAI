#nullable enable

namespace OpenAI
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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::OpenAI.ListVectorStoreFilesResponse> ListVectorStoreFilesAsync(
            string vectorStoreId,
            int? limit = default,
            global::OpenAI.ListVectorStoreFilesOrder? order = default,
            string? after = default,
            string? before = default,
            global::OpenAI.ListVectorStoreFilesFilter? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}