
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionTriggerInputParam
    {
        /// <summary>
        /// Default Value: decisions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType.Decisions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionTriggerInputParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType.Decisions;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionTriggerInputParamEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionTriggerInputParamEventType EventType { get; set; }

        /// <summary>
        /// Questions evaluated using the current transcript and the session's shared Decision items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam Decisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionTriggerInputParam" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="decisions">
        /// Questions evaluated using the current transcript and the session's shared Decision items.
        /// </param>
        /// <param name="type">
        /// Default Value: decisions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionTriggerInputParam(
            global::tryAGI.OpenAI.LiveDecisionTriggerInputParamEventType eventType,
            global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam decisions,
            global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType type = global::tryAGI.OpenAI.LiveDecisionTriggerInputParamType.Decisions)
        {
            this.Type = type;
            this.EventType = eventType;
            this.Decisions = decisions ?? throw new global::System.ArgumentNullException(nameof(decisions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionTriggerInputParam" /> class.
        /// </summary>
        public LiveDecisionTriggerInputParam()
        {
        }

    }
}