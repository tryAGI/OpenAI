
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Type of turn detection, only `server_vad` is currently supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection" /> class.
        /// </summary>
        /// <param name="prefixPaddingMs"></param>
        /// <param name="silenceDurationMs"></param>
        /// <param name="threshold"></param>
        /// <param name="type">
        /// Type of turn detection, only `server_vad` is currently supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection(
            int? prefixPaddingMs,
            int? silenceDurationMs,
            double? threshold,
            string? type)
        {
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.Threshold = threshold;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseAudioInputTurnDetection()
        {
        }
    }
}