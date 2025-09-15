#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IEvalsClient
    {
        /// <summary>
        /// Update an eval<br/>
        /// Update certain properties of an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Eval> UpdateEvalAsync(
            string evalId,
            global::tryAGI.OpenAI.UpdateEvalRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an eval<br/>
        /// Update certain properties of an evaluation.
        /// </summary>
        /// <param name="evalId"></param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard.<br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="name">
        /// Rename the evaluation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.Eval> UpdateEvalAsync(
            string evalId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}