
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for turn detection, ether Server VAD or Semantic VAD. This can be set to `null` to turn off, in which case the client must manually trigger model response.<br/>
    /// Server VAD means that the model will detect the start and end of speech based on audio volume and respond at the end of user speech.<br/>
    /// Semantic VAD is more advanced and uses a turn detection model (in conjunction with VAD) to semantically estimate whether the user has finished speaking, then dynamically sets a timeout based on this probability. For example, if user audio trails off with "uhhm", the model will score a low probability of turn end and wait longer for the user to continue speaking. This can be useful for more natural conversations, but may have a higher latency.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestGAAudioInputTurnDetection
    {
        /// <summary>
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eagerness")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagernessJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness? Eagerness { get; set; }

        /// <summary>
        /// Optional idle timeout after which turn detection will auto-timeout when<br/>
        /// no additional audio is received and emits a `timeout_triggered` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_ms")]
        public int? IdleTimeoutMs { get; set; }

        /// <summary>
        /// Whether or not to automatically interrupt any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_response")]
        public bool? InterruptResponse { get; set; }

        /// <summary>
        /// Used only for `server_vad` mode. Amount of audio to include before the VAD detected speech (in<br/>
        /// milliseconds). Defaults to 300ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix_padding_ms")]
        public int? PrefixPaddingMs { get; set; }

        /// <summary>
        /// Used only for `server_vad` mode. Duration of silence to detect speech stop (in milliseconds). Defaults<br/>
        /// to 500ms. With shorter values the model will respond more quickly,<br/>
        /// but may jump in on short pauses from the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silence_duration_ms")]
        public int? SilenceDurationMs { get; set; }

        /// <summary>
        /// Used only for `server_vad` mode. Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A<br/>
        /// higher threshold will require louder audio to activate the model, and<br/>
        /// thus might perform better in noisy environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Type of turn detection.<br/>
        /// Default Value: server_vad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateRequestGAAudioInputTurnDetectionTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputTurnDetectionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudioInputTurnDetection" /> class.
        /// </summary>
        /// <param name="createResponse">
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="eagerness">
        /// Used only for `semantic_vad` mode. The eagerness of the model to respond. `low` will wait longer for the user to continue speaking, `high` will respond more quickly. `auto` is the default and is equivalent to `medium`. `low`, `medium`, and `high` have max timeouts of 8s, 4s, and 2s respectively.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="idleTimeoutMs">
        /// Optional idle timeout after which turn detection will auto-timeout when<br/>
        /// no additional audio is received and emits a `timeout_triggered` event.
        /// </param>
        /// <param name="interruptResponse">
        /// Whether or not to automatically interrupt any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="prefixPaddingMs">
        /// Used only for `server_vad` mode. Amount of audio to include before the VAD detected speech (in<br/>
        /// milliseconds). Defaults to 300ms.
        /// </param>
        /// <param name="silenceDurationMs">
        /// Used only for `server_vad` mode. Duration of silence to detect speech stop (in milliseconds). Defaults<br/>
        /// to 500ms. With shorter values the model will respond more quickly,<br/>
        /// but may jump in on short pauses from the user.
        /// </param>
        /// <param name="threshold">
        /// Used only for `server_vad` mode. Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A<br/>
        /// higher threshold will require louder audio to activate the model, and<br/>
        /// thus might perform better in noisy environments.
        /// </param>
        /// <param name="type">
        /// Type of turn detection.<br/>
        /// Default Value: server_vad
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestGAAudioInputTurnDetection(
            bool? createResponse,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputTurnDetectionEagerness? eagerness,
            int? idleTimeoutMs,
            bool? interruptResponse,
            int? prefixPaddingMs,
            int? silenceDurationMs,
            double? threshold,
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestGAAudioInputTurnDetectionType? type)
        {
            this.CreateResponse = createResponse;
            this.Eagerness = eagerness;
            this.IdleTimeoutMs = idleTimeoutMs;
            this.InterruptResponse = interruptResponse;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.Threshold = threshold;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestGAAudioInputTurnDetection" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestGAAudioInputTurnDetection()
        {
        }
    }
}