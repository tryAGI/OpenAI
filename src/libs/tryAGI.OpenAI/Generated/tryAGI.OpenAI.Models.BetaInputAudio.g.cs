
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An audio input to the model.
    /// </summary>
    public sealed partial class BetaInputAudio
    {
        /// <summary>
        /// The type of the input item. Always `input_audio`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputAudioTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputAudioType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaInputAudioInputAudio InputAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputAudio" /> class.
        /// </summary>
        /// <param name="inputAudio"></param>
        /// <param name="type">
        /// The type of the input item. Always `input_audio`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputAudio(
            global::tryAGI.OpenAI.BetaInputAudioInputAudio inputAudio,
            global::tryAGI.OpenAI.BetaInputAudioType type)
        {
            this.Type = type;
            this.InputAudio = inputAudio ?? throw new global::System.ArgumentNullException(nameof(inputAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputAudio" /> class.
        /// </summary>
        public BetaInputAudio()
        {
        }

    }
}