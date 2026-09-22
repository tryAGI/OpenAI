
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Raw, mono G.711 μ-law audio for a Live WebSocket connection.
    /// </summary>
    public sealed partial class LiveSessionAudioFormatPCMUParam
    {
        /// <summary>
        /// The audio encoding. Always `audio/pcmu`.<br/>
        /// Default Value: audio/pcmu
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType.AudioPcmu</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionAudioFormatPCMUParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType.AudioPcmu;

        /// <summary>
        /// Audio sample rate in hertz. G.711 audio uses 8000 Hz.
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
        /// Initializes a new instance of the <see cref="LiveSessionAudioFormatPCMUParam" /> class.
        /// </summary>
        /// <param name="rate">
        /// Audio sample rate in hertz. G.711 audio uses 8000 Hz.
        /// </param>
        /// <param name="type">
        /// The audio encoding. Always `audio/pcmu`.<br/>
        /// Default Value: audio/pcmu
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionAudioFormatPCMUParam(
            int rate,
            global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType type = global::tryAGI.OpenAI.LiveSessionAudioFormatPCMUParamType.AudioPcmu)
        {
            this.Type = type;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionAudioFormatPCMUParam" /> class.
        /// </summary>
        public LiveSessionAudioFormatPCMUParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionAudioFormatPCMUParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionAudioFormatPCMUParam FromRate(int rate)
        {
            return new LiveSessionAudioFormatPCMUParam
            {
                Rate = rate,
            };
        }

    }
}