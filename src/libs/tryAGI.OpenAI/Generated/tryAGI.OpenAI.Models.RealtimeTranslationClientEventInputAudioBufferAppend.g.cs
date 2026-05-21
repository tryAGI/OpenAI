
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to append audio bytes to the translation session input audio buffer.<br/>
    /// WebSocket translation sessions accept base64-encoded 24 kHz PCM16 mono<br/>
    /// little-endian raw audio bytes. Unsupported websocket audio formats return a<br/>
    /// validation error because lower-quality audio materially degrades translation<br/>
    /// quality.<br/>
    /// Translation consumes 200 ms engine frames. For best realtime behavior, append<br/>
    /// audio in 200 ms chunks. If a chunk is shorter, the server buffers it until it<br/>
    /// has enough audio for one frame. If a chunk is longer, the server splits it into<br/>
    /// 200 ms frames and enqueues them back-to-back.<br/>
    /// Keep appending silence while the session is active. If a client stops sending<br/>
    /// audio and later resumes, model time treats the resumed audio as contiguous with<br/>
    /// the previous audio rather than as a real-world pause.
    /// </summary>
    public sealed partial class RealtimeTranslationClientEventInputAudioBufferAppend
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.input_audio_buffer.append`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationClientEventInputAudioBufferAppendTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppendType Type { get; set; }

        /// <summary>
        /// Base64-encoded 24 kHz PCM16 mono audio bytes.
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
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientEventInputAudioBufferAppend" /> class.
        /// </summary>
        /// <param name="audio">
        /// Base64-encoded 24 kHz PCM16 mono audio bytes.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.input_audio_buffer.append`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationClientEventInputAudioBufferAppend(
            string audio,
            string? eventId,
            global::tryAGI.OpenAI.RealtimeTranslationClientEventInputAudioBufferAppendType type)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientEventInputAudioBufferAppend" /> class.
        /// </summary>
        public RealtimeTranslationClientEventInputAudioBufferAppend()
        {
        }

    }
}