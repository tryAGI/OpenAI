
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The G.711 μ-law format.
    /// </summary>
    public sealed partial class RealtimeAudioFormatsVariant2
    {
        /// <summary>
        /// The audio format. Always `audio/pcmu`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeAudioFormatsVariant2TypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2Type? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// The audio format. Always `audio/pcmu`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeAudioFormatsVariant2(
            global::tryAGI.OpenAI.RealtimeAudioFormatsVariant2Type? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeAudioFormatsVariant2" /> class.
        /// </summary>
        public RealtimeAudioFormatsVariant2()
        {
        }
    }
}