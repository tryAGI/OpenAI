#nullable enable

namespace tryAGI.OpenAI
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an agent session<br/>
        /// Updates session tools, vaults, metadata, model, reasoning effort, service tier, or the default prompt cache lifetime. Model settings apply to subsequent turns. Omitted fields are unchanged. See [managing sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions/manage).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionResource> UpdateAgentSessionAsync(
            string sessionId,

            global::tryAGI.OpenAI.UpdateAgentSessionParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent session<br/>
        /// Updates session tools, vaults, metadata, model, reasoning effort, service tier, or the default prompt cache lifetime. Model settings apply to subsequent turns. Omitted fields are unchanged. See [managing sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions/manage).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::tryAGI.OpenAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.AutoSDKHttpResponse<global::tryAGI.OpenAI.SessionResource>> UpdateAgentSessionAsResponseAsync(
            string sessionId,

            global::tryAGI.OpenAI.UpdateAgentSessionParams request,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent session<br/>
        /// Updates session tools, vaults, metadata, model, reasoning effort, service tier, or the default prompt cache lifetime. Model settings apply to subsequent turns. Omitted fields are unchanged. See [managing sessions](https://developers.openai.com/api/docs/guides/agents-api/sessions/manage).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="accessPrograms">
        /// Cyber program for subsequent turns. Send null to restore the model default.
        /// </param>
        /// <param name="promptCacheOptions">
        /// Default prompt cache lifetime for future turns. Send null to clear the session default.
        /// </param>
        /// <param name="vaultIds">
        /// Replaces the session's referenced vaults. Omit to retain them; null or [] clears them.
        /// </param>
        /// <param name="review">
        /// Default action review for new root turns. Existing turns and their subagents keep their review mode.
        /// </param>
        /// <param name="spendControl">
        /// Omit to retain the limit; null or a null limit removes it without resetting spend.
        /// </param>
        /// <param name="agent">
        /// Agent settings to update on this session. Omitted fields stay unchanged.
        /// </param>
        /// <param name="metadata">
        /// Replaces all metadata. Omit to leave unchanged, or pass null or {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::tryAGI.OpenAI.SessionResource> UpdateAgentSessionAsync(
            string sessionId,
            global::tryAGI.OpenAI.AccessProgramsUpdateParam? accessPrograms = default,
            global::tryAGI.OpenAI.PromptCacheOptionsParam2? promptCacheOptions = default,
            global::System.Collections.Generic.IList<string>? vaultIds = default,
            global::tryAGI.OpenAI.SessionReviewParam? review = default,
            global::tryAGI.OpenAI.SessionBudgetControlParams? spendControl = default,
            global::tryAGI.OpenAI.UpdateSessionAgentParam? agent = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::tryAGI.OpenAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}