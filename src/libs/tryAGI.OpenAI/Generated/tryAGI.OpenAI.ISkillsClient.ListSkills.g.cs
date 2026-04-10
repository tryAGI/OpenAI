#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// List all skills for the current project.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after">
        /// Identifier for the last item from the previous pagination request
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillListResource> ListSkillsAsync(
            int? limit = default,
            global::tryAGI.OpenAI.OrderEnum? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}