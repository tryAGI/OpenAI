
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCacheOptionsParam2
    {
        /// <summary>
        /// Minimum lifetime for new prompt cache entries. Defaults to 30 minutes.<br/>
        /// Default Value: 30m
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheTtlParamJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheTtlParam? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheOptionsParam2" /> class.
        /// </summary>
        /// <param name="ttl">
        /// Minimum lifetime for new prompt cache entries. Defaults to 30 minutes.<br/>
        /// Default Value: 30m
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheOptionsParam2(
            global::tryAGI.OpenAI.PromptCacheTtlParam? ttl)
        {
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheOptionsParam2" /> class.
        /// </summary>
        public PromptCacheOptionsParam2()
        {
        }

    }
}