#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Delete an eval<br/>
        /// Delete an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.DeleteEvalResponse> DeleteEvalAsync(
            string evalId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}