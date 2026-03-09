#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Download a skill version zip bundle.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="version">
        /// The skill version number.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> GetSkillVersionContentAsync(
            string skillId,
            string version,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}