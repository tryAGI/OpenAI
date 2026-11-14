
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
        /// <default>"input_audio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "input_audio";

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
            string type = "input_audio")
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

        /// <summary>
        /// Creates a new <see cref="BetaInputAudio"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaInputAudio FromInputAudio(global::tryAGI.OpenAI.BetaInputAudioInputAudio inputAudio)
        {
            return new BetaInputAudio
            {
                InputAudio = inputAudio,
            };
        }

    }
}