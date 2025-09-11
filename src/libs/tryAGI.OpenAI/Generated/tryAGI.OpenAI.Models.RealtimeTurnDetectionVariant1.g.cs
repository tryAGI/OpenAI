
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Server-side voice activity detection (VAD) which flips on when user speech is detected and off after a period of silence.
    /// </summary>
    public sealed partial class RealtimeTurnDetectionVariant1
    {
        /// <summary>
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_response")]
        public bool? CreateResponse { get; set; }

        /// <summary>
        /// Optional timeout after which a model response will be triggered automatically. This is<br/>
        /// useful for situations in which a long pause from the user is unexpected, such as a phone<br/>
        /// call. The model will effectively prompt the user to continue the conversation based<br/>
        /// on the current context.<br/>
        /// The timeout value will be applied after the last model response's audio has finished playing,<br/>
        /// i.e. it's set to the `response.done` time plus audio playback duration.<br/>
        /// An `input_audio_buffer.timeout_triggered` event (plus events<br/>
        /// associated with the Response) will be emitted when the timeout is reached.<br/>
        /// Idle timeout is currently only supported for `server_vad` mode.
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
        /// Type of turn detection, `server_vad` to turn on simple Server VAD.<br/>
        /// Default Value: server_vad
        /// </summary>
        /// <default>global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1Type.ServerVad</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTurnDetectionVariant1TypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1Type Type { get; set; } = global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1Type.ServerVad;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTurnDetectionVariant1" /> class.
        /// </summary>
        /// <param name="createResponse">
        /// Whether or not to automatically generate a response when a VAD stop event occurs.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="idleTimeoutMs">
        /// Optional timeout after which a model response will be triggered automatically. This is<br/>
        /// useful for situations in which a long pause from the user is unexpected, such as a phone<br/>
        /// call. The model will effectively prompt the user to continue the conversation based<br/>
        /// on the current context.<br/>
        /// The timeout value will be applied after the last model response's audio has finished playing,<br/>
        /// i.e. it's set to the `response.done` time plus audio playback duration.<br/>
        /// An `input_audio_buffer.timeout_triggered` event (plus events<br/>
        /// associated with the Response) will be emitted when the timeout is reached.<br/>
        /// Idle timeout is currently only supported for `server_vad` mode.
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
        /// Type of turn detection, `server_vad` to turn on simple Server VAD.<br/>
        /// Default Value: server_vad
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTurnDetectionVariant1(
            bool? createResponse,
            int? idleTimeoutMs,
            bool? interruptResponse,
            int? prefixPaddingMs,
            int? silenceDurationMs,
            double? threshold,
            global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1Type type = global::tryAGI.OpenAI.RealtimeTurnDetectionVariant1Type.ServerVad)
        {
            this.CreateResponse = createResponse;
            this.IdleTimeoutMs = idleTimeoutMs;
            this.InterruptResponse = interruptResponse;
            this.PrefixPaddingMs = prefixPaddingMs;
            this.SilenceDurationMs = silenceDurationMs;
            this.Threshold = threshold;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTurnDetectionVariant1" /> class.
        /// </summary>
        public RealtimeTurnDetectionVariant1()
        {
        }
    }
}