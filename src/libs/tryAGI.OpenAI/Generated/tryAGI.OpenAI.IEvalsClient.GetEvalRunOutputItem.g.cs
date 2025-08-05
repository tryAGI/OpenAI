#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get an output item of an eval run<br/>
        /// Get an evaluation run output item by ID.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="outputItemId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalRunOutputItem> GetEvalRunOutputItemAsync(
            string evalId,
            string runId,
            string outputItemId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}