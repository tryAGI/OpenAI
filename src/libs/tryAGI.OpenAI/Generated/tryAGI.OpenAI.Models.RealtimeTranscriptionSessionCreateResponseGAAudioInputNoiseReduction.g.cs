
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input audio noise reduction.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction
    {
        /// <summary>
        /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeJsonConverter))]
        public global::tryAGI.OpenAI.NoiseReductionType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction(
            global::tryAGI.OpenAI.NoiseReductionType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseGAAudioInputNoiseReduction()
        {
        }
    }
}