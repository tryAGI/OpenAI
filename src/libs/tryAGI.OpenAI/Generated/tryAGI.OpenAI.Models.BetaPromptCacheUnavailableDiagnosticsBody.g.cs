
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPromptCacheUnavailableDiagnosticsBody
    {
        /// <summary>
        /// Default Value: unavailable
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType.Unavailable</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaPromptCacheUnavailableDiagnosticsBodyTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType Type { get; set; } = global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType.Unavailable;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheUnavailableDiagnosticsBody" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: unavailable
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPromptCacheUnavailableDiagnosticsBody(
            global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType type = global::tryAGI.OpenAI.BetaPromptCacheUnavailableDiagnosticsBodyType.Unavailable)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPromptCacheUnavailableDiagnosticsBody" /> class.
        /// </summary>
        public BetaPromptCacheUnavailableDiagnosticsBody()
        {
        }

    }
}