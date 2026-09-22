
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Options for prompt caching. Supported for `gpt-5.6` and later models. By default, OpenAI automatically chooses one implicit cache breakpoint. You can add explicit breakpoints to content blocks with `prompt_cache_breakpoint`. Each request can write up to four breakpoints. For cache matching, OpenAI considers up to the latest 80 breakpoints in the conversation, without a content-block lookback limit. Set `mode` to `explicit` to disable the implicit breakpoint. The `ttl` defaults to `30m`, which is currently the only supported value. See the [prompt caching guide](https://developers.openai.com/api/docs/guides/prompt-caching) for current details.
    /// </summary>
    public sealed partial class ResponsePromptCacheOptionsParam
    {
        /// <summary>
        /// The minimum lifetime applied to every implicit and explicit cache breakpoint written by the request. Defaults to `30m`, which is currently the only supported value. The backend may retain cache entries for longer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheTTLEnumJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheTTLEnum? Ttl { get; set; }

        /// <summary>
        /// Controls whether OpenAI automatically creates an implicit cache breakpoint. Defaults to `implicit`. With `implicit`, OpenAI creates one implicit breakpoint and writes up to the latest three explicit breakpoints in the request. With `explicit`, OpenAI does not create an implicit breakpoint and writes up to the latest four explicit breakpoints. If there are no explicit breakpoints, the request does not use prompt caching.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheModeEnumJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheModeEnum? Mode { get; set; }

        /// <summary>
        /// Prepares the prompt cache without generating output. Defaults to `false`. When set to `true`, overrides the `generate` field to `false`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prewarm")]
        public bool? Prewarm { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_response_id")]
        public string? ComparisonResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePromptCacheOptionsParam" /> class.
        /// </summary>
        /// <param name="ttl">
        /// The minimum lifetime applied to every implicit and explicit cache breakpoint written by the request. Defaults to `30m`, which is currently the only supported value. The backend may retain cache entries for longer.
        /// </param>
        /// <param name="mode">
        /// Controls whether OpenAI automatically creates an implicit cache breakpoint. Defaults to `implicit`. With `implicit`, OpenAI creates one implicit breakpoint and writes up to the latest three explicit breakpoints in the request. With `explicit`, OpenAI does not create an implicit breakpoint and writes up to the latest four explicit breakpoints. If there are no explicit breakpoints, the request does not use prompt caching.
        /// </param>
        /// <param name="prewarm">
        /// Prepares the prompt cache without generating output. Defaults to `false`. When set to `true`, overrides the `generate` field to `false`.
        /// </param>
        /// <param name="comparisonResponseId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsePromptCacheOptionsParam(
            global::tryAGI.OpenAI.PromptCacheTTLEnum? ttl,
            global::tryAGI.OpenAI.PromptCacheModeEnum? mode,
            bool? prewarm,
            string? comparisonResponseId)
        {
            this.Ttl = ttl;
            this.Mode = mode;
            this.Prewarm = prewarm;
            this.ComparisonResponseId = comparisonResponseId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsePromptCacheOptionsParam" /> class.
        /// </summary>
        public ResponsePromptCacheOptionsParam()
        {
        }

    }
}