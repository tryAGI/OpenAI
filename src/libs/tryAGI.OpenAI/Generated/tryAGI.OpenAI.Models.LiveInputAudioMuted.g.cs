
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a session.input_audio.mute command is accepted. Input audio is no longer sent to the model; sideband audio reflection continues.<br/>
    /// Example: {"type":"session.input_audio.muted","event_id":"evt_muted_001","client_event_id":"evt_mute_001"}
    /// </summary>
    public sealed partial class LiveInputAudioMuted
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
        /// The event type, always `session.input_audio.muted`.<br/>
        /// Default Value: session.input_audio.muted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInputAudioMutedType.SessionInputAudioMuted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInputAudioMutedTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInputAudioMutedType Type { get; set; } = global::tryAGI.OpenAI.LiveInputAudioMutedType.SessionInputAudioMuted;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioMuted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="type">
        /// The event type, always `session.input_audio.muted`.<br/>
        /// Default Value: session.input_audio.muted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInputAudioMuted(
            string eventId,
            string? clientEventId,
            global::tryAGI.OpenAI.LiveInputAudioMutedType type = global::tryAGI.OpenAI.LiveInputAudioMutedType.SessionInputAudioMuted)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioMuted" /> class.
        /// </summary>
        public LiveInputAudioMuted()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveInputAudioMuted"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveInputAudioMuted FromEventId(string eventId)
        {
            return new LiveInputAudioMuted
            {
                EventId = eventId,
            };
        }

    }
}