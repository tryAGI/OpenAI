
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection. Can be set to null to turn off.
    /// </summary>
    public sealed partial class RealtimeSessionTurnDetection
    {
        /// <summary>
        /// The type of turn detection.<br/>
        /// Example: server_vad
        /// </summary>
        /// <example>server_vad</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionTurnDetectionTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionTurnDetectionType? Type { get; set; }

        /// <summary>
        /// Activation threshold for VAD (0.0 to 1.0).<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Amount of audio to include before speech starts (in milliseconds).<br/>
        /// Example: 300
        /// </summary>
        /// <example>300</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Duration of silence to detect speech stop (in milliseconds).<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionTurnDetection" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of turn detection.<br/>
        /// Example: server_vad
        /// </param>
        /// <param name="threshold">
        /// Activation threshold for VAD (0.0 to 1.0).<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Amount of audio to include before speech starts (in milliseconds).<br/>
        /// Example: 300
        /// </param>
        /// <param name="silenceDurationMs">
        /// Duration of silence to detect speech stop (in milliseconds).<br/>
        /// Example: 200
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionTurnDetection(
            global::tryAGI.OpenAI.RealtimeSessionTurnDetectionType? type,
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
        /// Initializes a new instance of the <see cref="RealtimeSessionTurnDetection" /> class.
        /// </summary>
        public RealtimeSessionTurnDetection()
        {
        }
    }
}