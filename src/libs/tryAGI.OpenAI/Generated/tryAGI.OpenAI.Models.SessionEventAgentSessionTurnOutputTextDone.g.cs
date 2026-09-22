
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an output text content part is complete.
    /// </summary>
    public sealed partial class SessionEventAgentSessionTurnOutputTextDone
    {
        /// <summary>
        /// The type of the object. Always `agent.session.turn.output_text.done`.<br/>
        /// Default Value: agent.session.turn.output_text.done
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType.AgentSessionTurnOutputTextDone</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventAgentSessionTurnOutputTextDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType Type { get; set; } = global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType.AgentSessionTurnOutputTextDone;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the session associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The ID of the turn associated with the event, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_id")]
        public string? TurnId { get; set; }

        /// <summary>
        /// The ID of the message item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the item in the turn output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long OutputIndex { get; set; }

        /// <summary>
        /// The index of the content part in the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long ContentIndex { get; set; }

        /// <summary>
        /// The complete output text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnOutputTextDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the message item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the item in the turn output.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the message.
        /// </param>
        /// <param name="text">
        /// The complete output text.
        /// </param>
        /// <param name="turnId">
        /// The ID of the turn associated with the event, when applicable.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `agent.session.turn.output_text.done`.<br/>
        /// Default Value: agent.session.turn.output_text.done
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventAgentSessionTurnOutputTextDone(
            string eventId,
            string sessionId,
            string itemId,
            long outputIndex,
            long contentIndex,
            string text,
            string? turnId,
            global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType type = global::tryAGI.OpenAI.SessionEventAgentSessionTurnOutputTextDoneType.AgentSessionTurnOutputTextDone)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.TurnId = turnId;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventAgentSessionTurnOutputTextDone" /> class.
        /// </summary>
        public SessionEventAgentSessionTurnOutputTextDone()
        {
        }

    }
}