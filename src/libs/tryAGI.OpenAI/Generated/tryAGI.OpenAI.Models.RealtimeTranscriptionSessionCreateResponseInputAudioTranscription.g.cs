
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration of the transcription model.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseInputAudioTranscription
    {
        /// <summary>
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The model to use for transcription. Can be `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, or `whisper-1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModelJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel? Model { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment. The [prompt](https://platform.openai.com/docs/guides/speech-to-text#prompting) should match<br/>
        /// the audio language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseInputAudioTranscription" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </param>
        /// <param name="model">
        /// The model to use for transcription. Can be `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, or `whisper-1`.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment. The [prompt](https://platform.openai.com/docs/guides/speech-to-text#prompting) should match<br/>
        /// the audio language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseInputAudioTranscription(
            string? language,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseInputAudioTranscriptionModel? model,
            string? prompt)
        {
            this.Language = language;
            this.Model = model;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseInputAudioTranscription" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseInputAudioTranscription()
        {
        }
    }
}