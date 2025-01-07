
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for input audio transcription. Can be set to null to turn off.
    /// </summary>
    public sealed partial class RealtimeSessionInputAudioTranscription
    {
        /// <summary>
        /// Whether transcription is enabled.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The model to use for transcription.<br/>
        /// Example: whisper-1
        /// </summary>
        /// <example>whisper-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether transcription is enabled.<br/>
        /// Example: true
        /// </param>
        /// <param name="model">
        /// The model to use for transcription.<br/>
        /// Example: whisper-1
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeSessionInputAudioTranscription(
            bool? enabled,
            string? model)
        {
            this.Enabled = enabled;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeSessionInputAudioTranscription()
        {
        }
    }
}