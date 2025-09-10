
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime transcription session configuration object.
    /// </summary>
    public sealed partial class RealtimeTranscriptionSessionCreateResponseGA
    {
        /// <summary>
        /// Configuration for input audio for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? Audio { get; set; }

        /// <summary>
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional fields to include in server outputs.<br/>
        /// - `item.input_audio_transcription.logprobs`: Include logprobs for input audio transcription.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? Include { get; set; }

        /// <summary>
        /// The object type. Always `realtime.transcription_session`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The type of session. Always `transcription` for transcription sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranscriptionSessionCreateResponseGATypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGA" /> class.
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
        /// <param name="type">
        /// The type of session. Always `transcription` for transcription sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranscriptionSessionCreateResponseGA(
            string id,
            string @object,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAAudio? audio,
            int? expiresAt,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAIncludeItem>? include,
            global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponseGAType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.Audio = audio;
            this.ExpiresAt = expiresAt;
            this.Include = include;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranscriptionSessionCreateResponseGA" /> class.
        /// </summary>
        public RealtimeTranscriptionSessionCreateResponseGA()
        {
        }
    }
}