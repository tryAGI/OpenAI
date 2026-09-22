
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Raw, mono G.711 A-law audio for a Live WebSocket connection.
    /// </summary>
    public sealed partial class LiveSessionAudioFormatPCMAParam
    {
        /// <summary>
        /// The audio encoding. Always `audio/pcma`.<br/>
        /// Default Value: audio/pcma
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType.AudioPcma</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveSessionAudioFormatPCMAParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType Type { get; set; } = global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType.AudioPcma;

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
        /// Initializes a new instance of the <see cref="LiveSessionAudioFormatPCMAParam" /> class.
        /// </summary>
        /// <param name="rate">
        /// Audio sample rate in hertz. G.711 audio uses 8000 Hz.
        /// </param>
        /// <param name="type">
        /// The audio encoding. Always `audio/pcma`.<br/>
        /// Default Value: audio/pcma
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveSessionAudioFormatPCMAParam(
            int rate,
            global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType type = global::tryAGI.OpenAI.LiveSessionAudioFormatPCMAParamType.AudioPcma)
        {
            this.Type = type;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveSessionAudioFormatPCMAParam" /> class.
        /// </summary>
        public LiveSessionAudioFormatPCMAParam()
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiveSessionAudioFormatPCMAParam"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static LiveSessionAudioFormatPCMAParam FromRate(int rate)
        {
            return new LiveSessionAudioFormatPCMAParam
            {
                Rate = rate,
            };
        }

    }
}