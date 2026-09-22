
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send audio to a Live session over its primary WebSocket. WebRTC and SIP sessions send audio over their media transport.<br/>
    /// Example: {"type":"session.input_audio.append","audio":"AACAAIAAAIAAAP9/AIAAgA=="}
    /// </summary>
    public sealed partial class LiveInputAudioAppendEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The Live client event type. Always `session.input_audio.append`.<br/>
        /// Default Value: session.input_audio.append
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveInputAudioAppendEventType.SessionInputAudioAppend</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveInputAudioAppendEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveInputAudioAppendEventType Type { get; set; } = global::tryAGI.OpenAI.LiveInputAudioAppendEventType.SessionInputAudioAppend;

        /// <summary>
        /// Base64-encoded raw audio in the startup-selected format, without a WAV or other container header. Primary WebSocket only; media transports use their audio track. Audio appends have no acknowledgment. Reflected sideband server events reuse this event type and audio key, with no timestamps or event_id; their audio is always mono PCM16LE at 24 kHz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioAppendEvent" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded raw audio in the startup-selected format, without a WAV or other container header. Primary WebSocket only; media transports use their audio track. Audio appends have no acknowledgment. Reflected sideband server events reuse this event type and audio key, with no timestamps or event_id; their audio is always mono PCM16LE at 24 kHz.
        /// </param>
        /// <param name="eventId"></param>
        /// <param name="type">
        /// The Live client event type. Always `session.input_audio.append`.<br/>
        /// Default Value: session.input_audio.append
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveInputAudioAppendEvent(
            string audio,
            string? eventId,
            global::tryAGI.OpenAI.LiveInputAudioAppendEventType type = global::tryAGI.OpenAI.LiveInputAudioAppendEventType.SessionInputAudioAppend)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveInputAudioAppendEvent" /> class.
        /// </summary>
        public LiveInputAudioAppendEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveInputAudioAppendEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveInputAudioAppendEvent FromAudio(string audio)
        {
            return new LiveInputAudioAppendEvent
            {
                Audio = audio,
            };
        }

    }
}