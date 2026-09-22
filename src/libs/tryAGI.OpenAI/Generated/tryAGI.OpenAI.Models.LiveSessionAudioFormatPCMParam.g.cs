
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Raw, mono 16-bit little-endian PCM audio for a Live WebSocket connection.
    /// </summary>
    public sealed partial class LiveSessionAudioFormatPCMParam
    {
        /// <summary>
        /// The audio encoding. Always `audio/pcm`.<br/>
        /// Default Value: audio/pcm
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType.AudioPcm</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionAudioFormatPCMParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType.AudioPcm;

        /// <summary>
        /// Audio sample rate in hertz. Live WebSocket PCM audio supports 16000 or 24000 Hz.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionAudioFormatPCMParam" /> class.
        /// </summary>
        /// <param name="rate">
        /// Audio sample rate in hertz. Live WebSocket PCM audio supports 16000 or 24000 Hz.
        /// </param>
        /// <param name="type">
        /// The audio encoding. Always `audio/pcm`.<br/>
        /// Default Value: audio/pcm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionAudioFormatPCMParam(
            int rate,
            global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType type = global::tryAGI.OpenAI.LiveSessionAudioFormatPCMParamType.AudioPcm)
        {
            this.Type = type;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionAudioFormatPCMParam" /> class.
        /// </summary>
        public LiveSessionAudioFormatPCMParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionAudioFormatPCMParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionAudioFormatPCMParam FromRate(int rate)
        {
            return new LiveSessionAudioFormatPCMParam
            {
                Rate = rate,
            };
        }

    }
}