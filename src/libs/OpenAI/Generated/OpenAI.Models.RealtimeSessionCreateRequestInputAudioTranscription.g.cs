
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Configuration for input audio transcription, defaults to off and can be <br/>
    /// set to `null` to turn off once on. Input audio transcription is not native <br/>
    /// to the model, since the model consumes audio directly. Transcription runs <br/>
    /// asynchronously through Whisper and should be treated as rough guidance <br/>
    /// rather than the representation understood by the model.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestInputAudioTranscription
    {
        /// <summary>
        /// The model to use for transcription, `whisper-1` is the only currently <br/>
        /// supported model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for transcription, `whisper-1` is the only currently <br/>
        /// supported model.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeSessionCreateRequestInputAudioTranscription(
            string? model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestInputAudioTranscription()
        {
        }
    }
}