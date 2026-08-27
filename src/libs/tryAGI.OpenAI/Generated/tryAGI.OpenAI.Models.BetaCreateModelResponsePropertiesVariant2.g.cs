
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCreateModelResponsePropertiesVariant2
    {
        /// <summary>
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](/docs/guides/prompt-caching) for current details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_options")]
        public global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? PromptCacheOptions { get; set; }

        /// <summary>
        /// An integer between 0 and 20 specifying the maximum number of most likely<br/>
        /// tokens to return at each token position, each with an associated log<br/>
        /// probability. In some cases, the number of returned tokens may be fewer than<br/>
        /// requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateModelResponsePropertiesVariant2" /> class.
        /// </summary>
        /// <param name="promptCacheOptions">
        /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](/docs/guides/prompt-caching) for current details.
        /// </param>
        /// <param name="topLogprobs">
        /// An integer between 0 and 20 specifying the maximum number of most likely<br/>
        /// tokens to return at each token position, each with an associated log<br/>
        /// probability. In some cases, the number of returned tokens may be fewer than<br/>
        /// requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateModelResponsePropertiesVariant2(
            global::tryAGI.OpenAI.BetaPromptCacheOptionsParam? promptCacheOptions,
            int? topLogprobs)
        {
            this.PromptCacheOptions = promptCacheOptions;
            this.TopLogprobs = topLogprobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateModelResponsePropertiesVariant2" /> class.
        /// </summary>
        public BetaCreateModelResponsePropertiesVariant2()
        {
        }

    }
}