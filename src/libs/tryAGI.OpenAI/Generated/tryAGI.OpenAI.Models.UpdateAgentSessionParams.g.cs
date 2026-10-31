
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Fields to update on an existing session.
    /// </summary>
    public sealed partial class UpdateAgentSessionParams
    {
        /// <summary>
        /// Default action review for new root turns. Existing turns and their subagents keep their review mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("review")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionReviewParamJsonConverter))]
        public global::tryAGI.OpenAI.SessionReviewParam? Review { get; set; }

        /// <summary>
        /// Agent settings to update on this session. Omitted fields stay unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.UpdateSessionAgentParam? Agent { get; set; }

        /// <summary>
        /// Replaces all metadata. Omit to leave unchanged, or pass null or {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSessionParams" /> class.
        /// </summary>
        /// <param name="review">
        /// Default action review for new root turns. Existing turns and their subagents keep their review mode.
        /// </param>
        /// <param name="agent">
        /// Agent settings to update on this session. Omitted fields stay unchanged.
        /// </param>
        /// <param name="metadata">
        /// Replaces all metadata. Omit to leave unchanged, or pass null or {} to clear it. Up to 16 string key-value pairs, with keys up to 64 and values up to 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentSessionParams(
            global::tryAGI.OpenAI.SessionReviewParam? review,
            global::tryAGI.OpenAI.UpdateSessionAgentParam? agent,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Review = review;
            this.Agent = agent;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentSessionParams" /> class.
        /// </summary>
        public UpdateAgentSessionParams()
        {
        }

    }
}