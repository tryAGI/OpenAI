
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Optional input noise reduction.
    /// </summary>
    public sealed partial class RealtimeTranslationSessionAudioInputNoiseReduction
    {
        /// <summary>
        /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NoiseReductionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.NoiseReductionType Type { get; set; }

        /// <summary>
        /// Input noise suppression strength. Higher values apply more suppression.<br/>
        /// Defaults to 1 when noise reduction is first enabled. Omitting strength<br/>
        /// from a session update preserves the current strength.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionAudioInputNoiseReduction" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of noise reduction. `near_field` is for close-talking microphones such as headphones, `far_field` is for far-field microphones such as laptop or conference room microphones.
        /// </param>
        /// <param name="strength">
        /// Input noise suppression strength. Higher values apply more suppression.<br/>
        /// Defaults to 1 when noise reduction is first enabled. Omitting strength<br/>
        /// from a session update preserves the current strength.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionAudioInputNoiseReduction(
            global::tryAGI.OpenAI.NoiseReductionType type,
            double? strength)
        {
            this.Type = type;
            this.Strength = strength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionAudioInputNoiseReduction" /> class.
        /// </summary>
        public RealtimeTranslationSessionAudioInputNoiseReduction()
        {
        }

    }
}