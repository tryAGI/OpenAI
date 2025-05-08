#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Get an evaluation by ID.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Eval> GetEvalAsync(
            string evalId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}