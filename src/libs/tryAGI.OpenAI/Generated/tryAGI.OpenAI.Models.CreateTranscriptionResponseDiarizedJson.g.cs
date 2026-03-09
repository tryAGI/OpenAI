
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a diarized transcription response returned by the model, including the combined transcript and speaker-segment annotations.
    /// </summary>
    public sealed partial class CreateTranscriptionResponseDiarizedJson
    {
        /// <summary>
        /// The type of task that was run. Always `transcribe`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonTaskJsonConverter))]
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask Task { get; set; }

        /// <summary>
        /// Duration of the input audio in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// The concatenated transcript text for the entire audio input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Segments of the transcript annotated with timestamps and speaker labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment> Segments { get; set; }

        /// <summary>
        /// Token or duration usage statistics for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateTranscriptionResponseDiarizedJsonUsageJsonConverter))]
        public global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseDiarizedJson" /> class.
        /// </summary>
        /// <param name="task">
        /// The type of task that was run. Always `transcribe`.
        /// </param>
        /// <param name="duration">
        /// Duration of the input audio in seconds.
        /// </param>
        /// <param name="text">
        /// The concatenated transcript text for the entire audio input.
        /// </param>
        /// <param name="segments">
        /// Segments of the transcript annotated with timestamps and speaker labels.
        /// </param>
        /// <param name="usage">
        /// Token or duration usage statistics for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTranscriptionResponseDiarizedJson(
            double duration,
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionDiarizedSegment> segments,
            global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonTask task,
            global::tryAGI.OpenAI.CreateTranscriptionResponseDiarizedJsonUsage? usage)
        {
            this.Duration = duration;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Segments = segments ?? throw new global::System.ArgumentNullException(nameof(segments));
            this.Task = task;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTranscriptionResponseDiarizedJson" /> class.
        /// </summary>
        public CreateTranscriptionResponseDiarizedJson()
        {
        }
    }
}