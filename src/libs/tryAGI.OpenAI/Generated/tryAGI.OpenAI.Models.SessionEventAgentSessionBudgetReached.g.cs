
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a session pauses because its spending limit was reached.
    /// </summary>
    public sealed partial class SessionEventAgentSessionBudgetReached
    {
        /// <summary>
        /// The type of the object. Always `agent.session.budget_reached`.<br/>
        /// Default Value: agent.session.budget_reached
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType.AgentSessionBudgetReached</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionBudgetReachedTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType.AgentSessionBudgetReached;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The paused session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionResource Session { get; set; }

        /// <summary>
        /// Random alphanumeric padding. Present when stream obfuscation is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obfuscation")]
        public string? Obfuscation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionBudgetReached" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="session">
        /// The paused session.
        /// </param>
        /// <param name="obfuscation">
        /// Random alphanumeric padding. Present when stream obfuscation is enabled.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.budget_reached`.<br/>
        /// Default Value: agent.session.budget_reached
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionBudgetReached(
            string eventId,
            global::tryAGI.OpenAI.SessionResource session,
            string? obfuscation,
            global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType type = global::tryAGI.OpenAI.SessionEventAgentSessionBudgetReachedType.AgentSessionBudgetReached)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Obfuscation = obfuscation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionBudgetReached" /> class.
        /// </summary>
        public SessionEventAgentSessionBudgetReached()
        {
        }

    }
}