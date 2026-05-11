
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when translated output audio is available. Output audio deltas are<br/>
    /// 200 ms frames of PCM16 audio.
    /// </summary>
    public sealed partial class RealtimeTranslationServerEventSessionOutputAudioDelta
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `session.output_audio.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputAudioDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType Type { get; set; }

        /// <summary>
        /// Base64-encoded translated audio data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Sample rate of the audio delta.<br/>
        /// Default Value: 24000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// Number of audio channels.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// Audio encoding for `delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationServerEventSessionOutputAudioDeltaFormatJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elapsed_ms")]
        public int? ElapsedMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionOutputAudioDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="delta">
        /// Base64-encoded translated audio data.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.output_audio.delta`.
        /// </param>
        /// <param name="sampleRate">
        /// Sample rate of the audio delta.<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="channels">
        /// Number of audio channels.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="format">
        /// Audio encoding for `delta`.
        /// </param>
        /// <param name="elapsedMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationServerEventSessionOutputAudioDelta(
            string eventId,
            string delta,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaType type,
            int? sampleRate,
            int? channels,
            global::tryAGI.OpenAI.RealtimeTranslationServerEventSessionOutputAudioDeltaFormat? format,
            int? elapsedMs)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.SampleRate = sampleRate;
            this.Channels = channels;
            this.Format = format;
            this.ElapsedMs = elapsedMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationServerEventSessionOutputAudioDelta" /> class.
        /// </summary>
        public RealtimeTranslationServerEventSessionOutputAudioDelta()
        {
        }

    }
}