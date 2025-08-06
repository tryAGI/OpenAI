#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// List evals<br/>
        /// List evaluations for a project.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="order">
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.EvalList> ListEvalsAsync(
            string? after = default,
            int? limit = default,
            global::tryAGI.OpenAI.ListEvalsOrder? order = default,
            global::tryAGI.OpenAI.ListEvalsOrderBy? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}