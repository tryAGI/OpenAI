#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get eval runs<br/>
        /// Get a list of runs for an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalRunList> GetEvalRunsAsync(
            string evalId,
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.GetEvalRunsOrder? order = default,
            global::tryAGI.OpenAI.GetEvalRunsStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}