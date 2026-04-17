
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The PCM audio format. Only a 24kHz sample rate is supported.
    /// </summary>
    public sealed partial class RealtimeAudioFormatsPcmAudioFormat
    {
        /// <summary>
        /// The audio format. Always `audio/pcm`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmAudioFormatTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormatType? Type { get; set; }

        /// <summary>
        /// The sample rate of the audio. Always `24000`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public int? Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsPcmAudioFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The audio format. Always `audio/pcm`.
        /// </param>
        /// <param name="rate">
        /// The sample rate of the audio. Always `24000`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioFormatsPcmAudioFormat(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmAudioFormatType? type,
            int? rate)
        {
            this.Type = type;
            this.Rate = rate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsPcmAudioFormat" /> class.
        /// </summary>
        public RealtimeAudioFormatsPcmAudioFormat()
        {
        }
    }
}