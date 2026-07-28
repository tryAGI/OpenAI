
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioTranscriptionResponse
    {
        /// <summary>
        /// The model used for transcription. Current options are `whisper-1`, `gpt-transcribe`, `gpt-live-transcribe`, `gpt-4o-mini-transcribe`, `gpt-4o-mini-transcribe-2025-12-15`, `gpt-4o-transcribe`, `gpt-4o-transcribe-diarize`, and `gpt-realtime-whisper`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.AnyOfJsonConverter<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponseModel?>))]
        public global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponseModel?>? Model { get; set; }

        /// <summary>
        /// The language of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// The possible input audio languages configured for transcription, in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// The prompt configured for input audio transcription, when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionResponse" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used for transcription. Current options are `whisper-1`, `gpt-transcribe`, `gpt-live-transcribe`, `gpt-4o-mini-transcribe`, `gpt-4o-mini-transcribe-2025-12-15`, `gpt-4o-transcribe`, `gpt-4o-transcribe-diarize`, and `gpt-realtime-whisper`.
        /// </param>
        /// <param name="language">
        /// The language of the input audio.
        /// </param>
        /// <param name="languages">
        /// The possible input audio languages configured for transcription, in [ISO-639-1](https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes) format.
        /// </param>
        /// <param name="prompt">
        /// The prompt configured for input audio transcription, when present.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioTranscriptionResponse(
            global::tryAGI.OpenAI.Realtime.AnyOf<string, global::tryAGI.OpenAI.Realtime.AudioTranscriptionResponseModel?>? model,
            string? language,
            global::System.Collections.Generic.IList<string>? languages,
            string? prompt)
        {
            this.Model = model;
            this.Language = language;
            this.Languages = languages;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioTranscriptionResponse" /> class.
        /// </summary>
        public AudioTranscriptionResponse()
        {
        }

    }
}