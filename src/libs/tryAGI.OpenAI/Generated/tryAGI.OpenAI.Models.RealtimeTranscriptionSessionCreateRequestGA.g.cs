
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Realtime transcription session object configuration.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestGA
    {
        /// <summary>
        /// Configuration for input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? Audio { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Include { get; set; }

        /// <summary>
        /// The type of session to create. Always `transcription` for transcription sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGA" /> class.
        /// </summary>
        /// <param name="audio">
        /// Configuration for input and output audio.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </param>
        /// <param name="type">
        /// The type of session to create. Always `transcription` for transcription sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequestGA(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAAudio? audio,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? include,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGAType type)
        {
            this.Audio = audio;
            this.Include = include;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGA" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestGA()
        {
        }
    }
}