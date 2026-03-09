#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Get a skill by its ID.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillResource> GetSkillAsync(
            string skillId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}