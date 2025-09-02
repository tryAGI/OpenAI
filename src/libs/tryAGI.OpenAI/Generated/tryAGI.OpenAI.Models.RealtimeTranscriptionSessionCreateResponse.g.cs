
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime transcription session configuration object.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponse
    {
        /// <summary>
        /// Configuration for input audio for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudio? Audio { get; set; }

        /// <summary>
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// - `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseIncludeItem>? Include { get; set; }

        /// <summary>
        /// The object type. Always `realtime.transcription_session`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponse" /> class.
        /// </summary>
        /// <param name="audio">
        /// Configuration for input audio for the session.
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </param>
        /// <param name="include">
        /// Additional fields to include in server outputs.<br/>
        /// - `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </param>
        /// <param name="object">
        /// The object type. Always `realtime.transcription_session`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponse(
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseAudio? audio,
            int? expiresAt,
            string? id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseIncludeItem>? include,
            string? @object)
        {
            this.Audio = audio;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.Include = include;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponse" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponse()
        {
        }
    }
}