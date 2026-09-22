
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PromptCacheUnavailableDiagnosticsBody
    {
        /// <summary>
        /// Default Value: unavailable
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType.Unavailable</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PromptCacheUnavailableDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType.Unavailable;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheUnavailableDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCacheUnavailableDiagnosticsBody(
            global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType type = global::tryAGI.OpenAI.PromptCacheUnavailableDiagnosticsBodyType.Unavailable)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCacheUnavailableDiagnosticsBody" /> class.
        /// </summary>
        public PromptCacheUnavailableDiagnosticsBody()
        {
        }

    }
}