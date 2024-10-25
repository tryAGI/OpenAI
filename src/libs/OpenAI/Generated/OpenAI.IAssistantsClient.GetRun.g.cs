#nullable enable

namespace OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieves a run.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::OpenAI.RunObject> GetRunAsync(
            string threadId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}