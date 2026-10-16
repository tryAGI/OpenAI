
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveDecisionTriggerInputParam2
    {
        /// <summary>
        /// Default Value: decisions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2Type.Decisions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionTriggerInputParam2TypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2Type Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2Type.Decisions;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionTriggerInputParam2EventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2EventType EventType { get; set; }

        /// <summary>
        /// Questions evaluated using the current transcript and the session's shared Decision items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("decisions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam2 Decisions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionTriggerInputParam2" /> class.
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
        public LiveDecisionTriggerInputParam2(
            global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2EventType eventType,
            global::tryAGI.OpenAI.LiveDecisionQuestionsInputParam2 decisions,
            global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2Type type = global::tryAGI.OpenAI.LiveDecisionTriggerInputParam2Type.Decisions)
        {
            this.Type = type;
            this.EventType = eventType;
            this.Decisions = decisions ?? throw new global::System.ArgumentNullException(nameof(decisions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionTriggerInputParam2" /> class.
        /// </summary>
        public LiveDecisionTriggerInputParam2()
        {
        }

    }
}