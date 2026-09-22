
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a session.input_audio.unmute command is accepted. Input audio is sent to the model again.<br/>
    /// Example: {"type":"session.input_audio.unmuted","event_id":"evt_unmuted_001","client_event_id":"evt_unmute_001"}
    /// </summary>
    public sealed partial class LiveInputAudioUnmuted
    {
        /// <summary>
        /// The unique ID of the Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event_id of the client command associated with this server event, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// The event type, always `session.input_audio.unmuted`.<br/>
        /// Default Value: session.input_audio.unmuted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInputAudioUnmutedType.SessionInputAudioUnmuted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInputAudioUnmutedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInputAudioUnmutedType Type { get; set; } = global::tryAGI.OpenAI.LiveInputAudioUnmutedType.SessionInputAudioUnmuted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioUnmuted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.input_audio.unmuted`.<br/>
        /// Default Value: session.input_audio.unmuted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInputAudioUnmuted(
            string eventId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveInputAudioUnmutedType type = global::tryAGI.OpenAI.LiveInputAudioUnmutedType.SessionInputAudioUnmuted)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioUnmuted" /> class.
        /// </summary>
        public LiveInputAudioUnmuted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveInputAudioUnmuted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveInputAudioUnmuted FromEventId(string eventId)
        {
            return new LiveInputAudioUnmuted
            {
                EventId = eventId,
            };
        }

    }
}