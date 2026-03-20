#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IOpenAiClient
    {
        /// <summary>
        /// Compact a conversation. Returns a compacted response object.<br/>
        /// Learn when and how to compact long-running conversations in the [conversation state guide](/docs/guides/conversation-state#managing-the-context-window). For ZDR-compatible compaction details, see [Compaction (advanced)](/docs/guides/conversation-state#compaction-advanced).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CompactResource> CompactconversationAsync(

            global::tryAGI.OpenAI.CompactResponseMethodPublicBody request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compact a conversation. Returns a compacted response object.<br/>
        /// Learn when and how to compact long-running conversations in the [conversation state guide](/docs/guides/conversation-state#managing-the-context-window). For ZDR-compatible compaction details, see [Compaction (advanced)](/docs/guides/conversation-state#compaction-advanced).
        /// </summary>
        /// <param name="model">
        /// Model ID used to generate the response, like `gpt-5` or `o3`. OpenAI offers a wide range of models with different capabilities, performance characteristics, and price points. Refer to the [model guide](/docs/models) to browse and compare available models.
        /// </param>
        /// <param name="input"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="instructions"></param>
        /// <param name="promptCacheKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.CompactResource> CompactconversationAsync(
            global::tryAGI.OpenAI.ModelIdsCompaction model,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? input = default,
            string? previousResponseId = default,
            string? instructions = default,
            string? promptCacheKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}