#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Update the default version pointer for a skill.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillResource> UpdateSkillDefaultVersionAsync(
            string skillId,

            global::tryAGI.OpenAI.SetDefaultSkillVersionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update the default version pointer for a skill.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="defaultVersion">
        /// The skill version number to set as default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillResource> UpdateSkillDefaultVersionAsync(
            string skillId,
            string defaultVersion,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}