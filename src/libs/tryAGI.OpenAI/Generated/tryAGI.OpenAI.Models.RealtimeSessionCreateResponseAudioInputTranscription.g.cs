
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input audio transcription.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseAudioInputTranscription
    {
        /// <summary>
        /// The language of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The model to use for transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Optional text to guide the model's style or continue a previous audio segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInputTranscription" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the input audio.
        /// </param>
        /// <param name="model">
        /// The model to use for transcription.
        /// </param>
        /// <param name="prompt">
        /// Optional text to guide the model's style or continue a previous audio segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseAudioInputTranscription(
            string? language,
            string? model,
            string? prompt)
        {
            this.Language = language;
            this.Model = model;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseAudioInputTranscription" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseAudioInputTranscription()
        {
        }
    }
}