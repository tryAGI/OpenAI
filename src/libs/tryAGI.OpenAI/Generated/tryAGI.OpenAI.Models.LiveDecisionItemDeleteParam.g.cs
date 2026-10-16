
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Delete an input item from future decisions without starting an evaluation or changing Live voice context.<br/>
    /// Example: {"type":"decision.item.delete","event_id":"remove_browser_1","item_id":"msg_browser_1"}
    /// </summary>
    public sealed partial class LiveDecisionItemDeleteParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Default Value: decision.item.delete
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType.DecisionItemDelete</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionItemDeleteParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType.DecisionItemDelete;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemDeleteParam" /> class.
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// Default Value: decision.item.delete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionItemDeleteParam(
            string itemId,
            string? eventId,
            global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType type = global::tryAGI.OpenAI.LiveDecisionItemDeleteParamType.DecisionItemDelete)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemDeleteParam" /> class.
        /// </summary>
        public LiveDecisionItemDeleteParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionItemDeleteParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionItemDeleteParam FromItemId(string itemId)
        {
            return new LiveDecisionItemDeleteParam
            {
                ItemId = itemId,
            };
        }

    }
}