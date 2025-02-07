#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieves a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.RunObject> GetRunAsync(
            string threadId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}