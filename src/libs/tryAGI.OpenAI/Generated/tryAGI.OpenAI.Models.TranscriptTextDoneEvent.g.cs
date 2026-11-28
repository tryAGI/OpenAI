
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when the transcription is complete. Contains the complete transcription text. Only emitted when you [create a transcription](https://developers.openai.com/api/reference/resources/audio/subresources/transcriptions/methods/create) with the `Stream` parameter set to `true`.
    /// </summary>
    public sealed partial class TranscriptTextDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `transcript.text.done`.
        /// </summary>
        /// <default>"transcript.text.done"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "transcript.text.done";

        /// <summary>
        /// The text that was transcribed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The languages detected in the audio. Returned by `gpt-transcribe`. An empty array indicates that no language could be reliably detected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>? Languages { get; set; }

        /// <summary>
        /// The log probabilities of the individual tokens in the transcription. Only included if you [create a transcription](https://developers.openai.com/api/reference/resources/audio/subresources/transcriptions/methods/create) with the `include[]` parameter set to `logprobs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? Logprobs { get; set; }

        /// <summary>
        /// Usage statistics for models billed by token usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::tryAGI.OpenAI.TranscriptTextUsageTokens? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDoneEvent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text that was transcribed.
        /// </param>
        /// <param name="languages">
        /// The languages detected in the audio. Returned by `gpt-transcribe`. An empty array indicates that no language could be reliably detected.
        /// </param>
        /// <param name="logprobs">
        /// The log probabilities of the individual tokens in the transcription. Only included if you [create a transcription](https://developers.openai.com/api/reference/resources/audio/subresources/transcriptions/methods/create) with the `include[]` parameter set to `logprobs`.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for models billed by token usage.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `transcript.text.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptTextDoneEvent(
            string text,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptionLanguage>? languages,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.TranscriptTextDoneEventLogprob>? logprobs,
            global::tryAGI.OpenAI.TranscriptTextUsageTokens? usage,
            string type = "transcript.text.done")
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Languages = languages;
            this.Logprobs = logprobs;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptTextDoneEvent" /> class.
        /// </summary>
        public TranscriptTextDoneEvent()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TranscriptTextDoneEvent"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TranscriptTextDoneEvent FromText(string text)
        {
            return new TranscriptTextDoneEvent
            {
                Text = text,
            };
        }

    }
}