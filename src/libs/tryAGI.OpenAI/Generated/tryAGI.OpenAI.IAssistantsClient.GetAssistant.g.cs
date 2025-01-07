#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAssistantsClient
    {
        /// <summary>
        /// Retrieves an assistant.
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "TRYAGI_OPENAI_BETA_001")]
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AssistantObject> GetAssistantAsync(
            string assistantId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}