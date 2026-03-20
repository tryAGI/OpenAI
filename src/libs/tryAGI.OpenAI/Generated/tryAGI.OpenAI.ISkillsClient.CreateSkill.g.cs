#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface ISkillsClient
    {
        /// <summary>
        /// Create a new skill.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillResource> CreateSkillAsync(

            global::tryAGI.OpenAI.CreateSkillBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new skill.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SkillResource> CreateSkillAsync(
            global::tryAGI.OpenAI.OneOf<global::System.Collections.Generic.IList<byte[]>, byte[]> files,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}