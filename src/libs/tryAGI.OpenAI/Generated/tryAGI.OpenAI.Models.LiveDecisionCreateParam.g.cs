
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Evaluate the configured questions using the current conversation and Decision inputs. Reusing an event_id is rejected for the lifetime of the session.<br/>
    /// Example: {"type":"decision.create","event_id":"decision_1"}
    /// </summary>
    public sealed partial class LiveDecisionCreateParam
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// Default Value: decision.create
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionCreateParamType.DecisionCreate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionCreateParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionCreateParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionCreateParamType.DecisionCreate;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionCreateParam" /> class.
        /// </summary>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// Default Value: decision.create
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionCreateParam(
            string eventId,
            global::tryAGI.OpenAI.LiveDecisionCreateParamType type = global::tryAGI.OpenAI.LiveDecisionCreateParamType.DecisionCreate)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionCreateParam" /> class.
        /// </summary>
        public LiveDecisionCreateParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveDecisionCreateParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveDecisionCreateParam FromEventId(string eventId)
        {
            return new LiveDecisionCreateParam
            {
                EventId = eventId,
            };
        }

    }
}