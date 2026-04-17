
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Realtime transcription session object configuration.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateRequestGA
    {
        /// <summary>
        /// The type of session to create. Always `transcription` for transcription sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.RealtimeTranscriptionSessionCreateRequestGATypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAType Type { get; set; }

        /// <summary>
        /// Configuration for input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudio? Audio { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? Include { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGA" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of session to create. Always `transcription` for transcription sessions.
        /// </param>
        /// <param name="audio">
        /// Configuration for input and output audio.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in server outputs.<br/>
        /// `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateRequestGA(
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAType type,
            global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAAudio? audio,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Realtime.RealtimeTranscriptionSessionCreateRequestGAIncludeItem>? include)
        {
            this.Type = type;
            this.Audio = audio;
            this.Include = include;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateRequestGA" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateRequestGA()
        {
        }
    }
}