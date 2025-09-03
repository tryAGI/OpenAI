
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The PCM audio format. Only a 24kHz sample rate is supported.
    /// </summary>
    public sealed partial class RealtimeAudioFormatsVariant1
    {
        /// <summary>
        /// The sample rate of the audio. Always `24000`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// The audio format. Always `audio/pcm`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsVariant1TypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsVariant1" /> class.
        /// </summary>
        /// <param name="rate">
        /// The sample rate of the audio. Always `24000`.
        /// </param>
        /// <param name="type">
        /// The audio format. Always `audio/pcm`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioFormatsVariant1(
            int? rate,
            global::tryAGI.OpenAI.RealtimeAudioFormatsVariant1Type? type)
        {
            this.Rate = rate;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsVariant1" /> class.
        /// </summary>
        public RealtimeAudioFormatsVariant1()
        {
        }
    }
}