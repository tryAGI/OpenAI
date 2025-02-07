#nullable enable

namespace tryAGI.OpenAI
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
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.ListVectorStoresResponse> ListVectorStoresAsync(
            int? limit = default,
            global::tryAGI.OpenAI.ListVectorStoresOrder? order = default,
            string? after = default,
            string? before = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}