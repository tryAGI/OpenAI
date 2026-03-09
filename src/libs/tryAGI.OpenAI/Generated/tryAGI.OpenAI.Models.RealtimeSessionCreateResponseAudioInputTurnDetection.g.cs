
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseAudioInputTurnDetection
    {
        /// <summary>
        /// Type of turn detection, only `server_vad` is currently supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInputTurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of turn detection, only `server_vad` is currently supported.
        /// </param>
        /// <param name="threshold"></param>
        /// <param name="prefixPaddingMs"></param>
        /// <param name="silenceDurationMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseAudioInputTurnDetection(
            string? type,
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs)
        {
            this.Type = type;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInputTurnDetection" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseAudioInputTurnDetection()
        {
        }
    }
}