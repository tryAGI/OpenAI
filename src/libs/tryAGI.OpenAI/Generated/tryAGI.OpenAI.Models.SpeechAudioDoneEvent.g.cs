
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the speech synthesis is complete and all audio has been streamed.
    /// </summary>
    public sealed partial class SpeechAudioDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `speech.audio.done`.
        /// </summary>
        /// <default>"speech.audio.done"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "speech.audio.done";

        /// <summary>
        /// Token usage statistics for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SpeechAudioDoneEventUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDoneEvent" /> class.
        /// </summary>
        /// <param name="usage">
        /// Token usage statistics for the request.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `speech.audio.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpeechAudioDoneEvent(
            global::tryAGI.OpenAI.SpeechAudioDoneEventUsage usage,
            string type = "speech.audio.done")
        {
            this.Type = type;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechAudioDoneEvent" /> class.
        /// </summary>
        public SpeechAudioDoneEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SpeechAudioDoneEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SpeechAudioDoneEvent FromUsage(global::tryAGI.OpenAI.SpeechAudioDoneEventUsage usage)
        {
            return new SpeechAudioDoneEvent
            {
                Usage = usage,
            };
        }

    }
}