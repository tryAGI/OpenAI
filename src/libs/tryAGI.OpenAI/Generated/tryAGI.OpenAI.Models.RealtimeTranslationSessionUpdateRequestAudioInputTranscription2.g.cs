
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Optional source-language transcription. When configured, the server emits<br/>
    /// `session.input_transcript.delta` events. Translation itself still runs from<br/>
    /// the input audio stream.
    /// </summary>
    public sealed partial class RealtimeTranslationSessionUpdateRequestAudioInputTranscription2
    {
        /// <summary>
        /// The transcription model to use for source transcript deltas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequestAudioInputTranscription2" /> class.
        /// </summary>
        /// <param name="model">
        /// The transcription model to use for source transcript deltas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSessionUpdateRequestAudioInputTranscription2(
            string model)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSessionUpdateRequestAudioInputTranscription2" /> class.
        /// </summary>
        public RealtimeTranslationSessionUpdateRequestAudioInputTranscription2()
        {
        }

    }
}