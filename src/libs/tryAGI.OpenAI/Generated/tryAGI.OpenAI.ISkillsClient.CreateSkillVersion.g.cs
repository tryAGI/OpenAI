#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Create a new immutable skill version.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillVersionResource> CreateSkillVersionAsync(
            string skillId,

            global::tryAGI.OpenAI.CreateSkillVersionBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new immutable skill version.
        /// </summary>
        /// <param name="skillId">
        /// Example: skill_123
        /// </param>
        /// <param name="files"></param>
        /// <param name="default">
        /// Whether to set this version as the default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillVersionResource> CreateSkillVersionAsync(
            string skillId,
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]> files,
            bool? @default = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}