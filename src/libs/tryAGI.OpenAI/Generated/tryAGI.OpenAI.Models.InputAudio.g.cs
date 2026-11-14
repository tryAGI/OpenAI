
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An audio input to the model.
    /// </summary>
    public sealed partial class InputAudio
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
        public required global::tryAGI.OpenAI.InputAudioInputAudio1 InputAudio1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        /// <param name="inputAudio1"></param>
        /// <param name="type">
        /// The type of the input item. Always `input_audio`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputAudio(
            global::tryAGI.OpenAI.InputAudioInputAudio1 inputAudio1,
            string type = "input_audio")
        {
            this.Type = type;
            this.InputAudio1 = inputAudio1 ?? throw new global::System.ArgumentNullException(nameof(inputAudio1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudio" /> class.
        /// </summary>
        public InputAudio()
        {
        }

        /// <summary>
        /// Creates a new <see cref="InputAudio"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static InputAudio FromInputAudio1(global::tryAGI.OpenAI.InputAudioInputAudio1 inputAudio1)
        {
            return new InputAudio
            {
                InputAudio1 = inputAudio1,
            };
        }

    }
}