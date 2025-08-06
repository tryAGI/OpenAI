#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Delete eval run<br/>
        /// Delete an eval run.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeleteEvalRunResponse> DeleteEvalRunAsync(
            string evalId,
            string runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}