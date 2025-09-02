
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input audio noise reduction.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseAudioInputNoiseReduction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeSessionCreateResponseAudioInputNoiseReductionTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReductionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInputNoiseReduction" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseAudioInputNoiseReduction(
            global::tryAGI.OpenAI.RealtimeSessionCreateResponseAudioInputNoiseReductionType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInputNoiseReduction" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseAudioInputNoiseReduction()
        {
        }
    }
}