
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A reasoning item produced by the agent.
    /// </summary>
    public sealed partial class ReasoningItemResource
    {
        /// <summary>
        /// The item type. Always `reasoning`.<br/>
        /// Default Value: reasoning
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ReasoningItemResourceType.Reasoning</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningItemResourceType Type { get; set; } = global::tryAGI.OpenAI.ReasoningItemResourceType.Reasoning;

        /// <summary>
        /// The ID of the reasoning item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the turn that contains this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TurnId { get; set; }

        /// <summary>
        /// The reasoning summaries produced by the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource> Summary { get; set; }

        /// <summary>
        /// The status of the reasoning item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::tryAGI.OpenAI.OutputItemStatusResource? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the reasoning item.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn that contains this item.
        /// </param>
        /// <param name="summary">
        /// The reasoning summaries produced by the agent.
        /// </param>
        /// <param name="status">
        /// The status of the reasoning item.
        /// </param>
        /// <param name="type">
        /// The item type. Always `reasoning`.<br/>
        /// Default Value: reasoning
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItemResource(
            string id,
            string turnId,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SummaryTextResource> summary,
            global::tryAGI.OpenAI.OutputItemStatusResource? status,
            global::tryAGI.OpenAI.ReasoningItemResourceType type = global::tryAGI.OpenAI.ReasoningItemResourceType.Reasoning)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TurnId = turnId ?? throw new global::System.ArgumentNullException(nameof(turnId));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItemResource" /> class.
        /// </summary>
        public ReasoningItemResource()
        {
        }

    }
}