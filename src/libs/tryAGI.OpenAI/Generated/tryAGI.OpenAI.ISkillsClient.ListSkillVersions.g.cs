#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// List skill versions for a skill.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after">
        /// Example: skillver_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillVersionListResource> ListSkillVersionsAsync(
            string skillId,
            int? limit = default,
            global::tryAGI.OpenAI.OrderEnum? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List skill versions for a skill.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="limit"></param>
        /// <param name="order"></param>
        /// <param name="after">
        /// Example: skillver_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.SkillVersionListResource>> ListSkillVersionsAsResponseAsync(
            string skillId,
            int? limit = default,
            global::tryAGI.OpenAI.OrderEnum? order = default,
            string? after = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps ListSkillVersionsAsync as an IAsyncEnumerable&lt;global::tryAGI.OpenAI.SkillVersionResource&gt; that auto-pages over the response.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="limit"></param>
        /// <param name="order"></param> 
        /// <param name="after">Initial cursor to start enumerating from. Defaults to null (first page).</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::tryAGI.OpenAI.SkillVersionResource> ListSkillVersionsAutoPagingAsync(
            string skillId,             int? limit = default,
            global::tryAGI.OpenAI.OrderEnum? order = default,
            string? after = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}