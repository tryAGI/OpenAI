
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Represents a verbose json transcription response returned by model, based on the provided input.
    /// </summary>
    public sealed partial class CreateTranscriptionResponseVerboseJson
    {
        /// <summary>
        /// The language of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// The duration of the input audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// The transcribed text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Extracted words and their corresponding timestamps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<global::OpenAI.TranscriptionWord>? Words { get; set; }

        /// <summary>
        /// Segments of the transcribed text and their corresponding details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::OpenAI.TranscriptionSegment>? Segments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseVerboseJson" /> class.
        /// </summary>
        /// <param name="language">
        /// The language of the input audio.
        /// </param>
        /// <param name="duration">
        /// The duration of the input audio.
        /// </param>
        /// <param name="text">
        /// The transcribed text.
        /// </param>
        /// <param name="words">
        /// Extracted words and their corresponding timestamps.
        /// </param>
        /// <param name="segments">
        /// Segments of the transcribed text and their corresponding details.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateTranscriptionResponseVerboseJson(
            string language,
            string duration,
            string text,
            global::System.Collections.Generic.IList<global::OpenAI.TranscriptionWord>? words,
            global::System.Collections.Generic.IList<global::OpenAI.TranscriptionSegment>? segments)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Words = words;
            this.Segments = segments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseVerboseJson" /> class.
        /// </summary>
        public CreateTranscriptionResponseVerboseJson()
        {
        }
    }
}