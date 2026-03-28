
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscription
    {
        /// <summary>
        /// The model to use for transcription. Current options are `whisper-1`, `gpt-4o-mini-transcribe`, `gpt-4o-mini-transcribe-2025-12-15`, `gpt-4o-transcribe`, and `gpt-4o-transcribe-diarize`. Use `gpt-4o-transcribe-diarize` when you need diarization with speaker labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>))]
        public global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>? Model { get; set; }

        /// <summary>
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment.<br/>
        /// For `whisper-1`, the [prompt is a list of keywords](/docs/guides/speech-to-text#prompting).<br/>
        /// For `gpt-4o-transcribe` models (excluding `gpt-4o-transcribe-diarize`), the prompt is a free text string, for example "expect words related to technology".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscription" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for transcription. Current options are `whisper-1`, `gpt-4o-mini-transcribe`, `gpt-4o-mini-transcribe-2025-12-15`, `gpt-4o-transcribe`, and `gpt-4o-transcribe-diarize`. Use `gpt-4o-transcribe-diarize` when you need diarization with speaker labels.
        /// </param>
        /// <param name="language">
        /// The language of the input audio. Supplying the input language in<br/>
        /// [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) (e.g. `en`) format<br/>
        /// will improve accuracy and latency.
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio<br/>
        /// segment.<br/>
        /// For `whisper-1`, the [prompt is a list of keywords](/docs/guides/speech-to-text#prompting).<br/>
        /// For `gpt-4o-transcribe` models (excluding `gpt-4o-transcribe-diarize`), the prompt is a free text string, for example "expect words related to technology".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscription(
            global::tryAGI.OpenAI.AnyOf<string, global::tryAGI.OpenAI.AudioTranscriptionModel?>? model,
            string? language,
            string? prompt)
        {
            this.Model = model;
            this.Language = language;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscription" /> class.
        /// </summary>
        public AudioTranscription()
        {
        }
    }
}