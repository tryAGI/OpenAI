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
    }
}