
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The G.711 A-law format.
    /// </summary>
    public sealed partial class RealtimeAudioFormatsPcmaAudioFormat
    {
        /// <summary>
        /// The audio format. Always `audio/pcma`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeAudioFormatsPcmaAudioFormatTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormatType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsPcmaAudioFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The audio format. Always `audio/pcma`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioFormatsPcmaAudioFormat(
            global::tryAGI.OpenAI.Realtime.RealtimeAudioFormatsPcmaAudioFormatType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsPcmaAudioFormat" /> class.
        /// </summary>
        public RealtimeAudioFormatsPcmaAudioFormat()
        {
        }
    }
}