
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Append an input item for future decisions without starting an evaluation or changing Live voice context.<br/>
    /// Example: {"type":"decision.item.create","event_id":"browser_1","item":{"type":"message","role":"user","content":[{"type":"input_text","text":"Wikipedia is open."}]}}
    /// </summary>
    public sealed partial class LiveDecisionItemCreateParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Default Value: decision.item.create
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionItemCreateParamType.DecisionItemCreate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionItemCreateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionItemCreateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionItemCreateParamType.DecisionItemCreate;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionInputItemParam Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemCreateParam" /> class.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// Default Value: decision.item.create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionItemCreateParam(
            global::tryAGI.OpenAI.LiveDecisionInputItemParam item,
            string? eventId,
            global::tryAGI.OpenAI.LiveDecisionItemCreateParamType type = global::tryAGI.OpenAI.LiveDecisionItemCreateParamType.DecisionItemCreate)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionItemCreateParam" /> class.
        /// </summary>
        public LiveDecisionItemCreateParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionItemCreateParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionItemCreateParam FromItem(global::tryAGI.OpenAI.LiveDecisionInputItemParam item)
        {
            return new LiveDecisionItemCreateParam
            {
                Item = item,
            };
        }

    }
}