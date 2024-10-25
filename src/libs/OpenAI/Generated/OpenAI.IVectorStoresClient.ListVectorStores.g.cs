#nullable enable

namespace OpenAI
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Returns a list of vector stores.
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
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::OpenAI.ListVectorStoresResponse> ListVectorStoresAsync(
            int? limit = default,
            global::OpenAI.ListVectorStoresOrder? order = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}