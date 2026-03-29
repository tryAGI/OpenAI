
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server-side voice activity detection (VAD) which flips on when user speech is detected and off after a period of silence.
    /// </summary>
    public sealed partial class RealtimeTurnDetectionRealtimeTurnDetection1ServerVad
    {
        /// <summary>
        /// Type of turn detection, `server_vad` to turn on simple Server VAD.<br/>
        /// Default Value: server_vad
        /// </summary>
        /// <default>"server_vad"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "server_vad";

        /// <summary>
        /// Used only for `server_vad` mode. Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A<br/>
        /// higher threshold will require louder audio to activate the model, and<br/>
        /// thus might perform better in noisy environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

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
        /// Whether or not to automatically generate a response when a VAD stop event occurs. If `interrupt_response` is set to `false` this may fail to create a response if the model is already responding.<br/>
        /// If both `create_response` and `interrupt_response` are set to `false`, the model will never respond automatically but VAD events will still be emitted.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        /// Whether or not to automatically interrupt (cancel) any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs. If `true` then the response will be cancelled, otherwise it will continue until complete.<br/>
        /// If both `create_response` and `interrupt_response` are set to `false`, the model will never respond automatically but VAD events will still be emitted.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_response")]
        public bool? InterruptResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_timeout_ms")]
        public int? IdleTimeoutMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTurnDetectionRealtimeTurnDetection1ServerVad" /> class.
        /// </summary>
        /// <param name="threshold">
        /// Used only for `server_vad` mode. Activation threshold for VAD (0.0 to 1.0), this defaults to 0.5. A<br/>
        /// higher threshold will require louder audio to activate the model, and<br/>
        /// thus might perform better in noisy environments.
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
        /// <param name="createResponse">
        /// Whether or not to automatically generate a response when a VAD stop event occurs. If `interrupt_response` is set to `false` this may fail to create a response if the model is already responding.<br/>
        /// If both `create_response` and `interrupt_response` are set to `false`, the model will never respond automatically but VAD events will still be emitted.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="interruptResponse">
        /// Whether or not to automatically interrupt (cancel) any ongoing response with output to the default<br/>
        /// conversation (i.e. `conversation` of `auto`) when a VAD start event occurs. If `true` then the response will be cancelled, otherwise it will continue until complete.<br/>
        /// If both `create_response` and `interrupt_response` are set to `false`, the model will never respond automatically but VAD events will still be emitted.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="idleTimeoutMs"></param>
        /// <param name="type">
        /// Type of turn detection, `server_vad` to turn on simple Server VAD.<br/>
        /// Default Value: server_vad
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTurnDetectionRealtimeTurnDetection1ServerVad(
            double? threshold,
            int? prefixPaddingMs,
            int? silenceDurationMs,
            bool? createResponse,
            bool? interruptResponse,
            int? idleTimeoutMs,
            string type = "server_vad")
        {
            this.Type = type;
            this.Threshold = threshold;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.CreateResponse = createResponse;
            this.InterruptResponse = interruptResponse;
            this.IdleTimeoutMs = idleTimeoutMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTurnDetectionRealtimeTurnDetection1ServerVad" /> class.
        /// </summary>
        public RealtimeTurnDetectionRealtimeTurnDetection1ServerVad()
        {
        }
    }
}