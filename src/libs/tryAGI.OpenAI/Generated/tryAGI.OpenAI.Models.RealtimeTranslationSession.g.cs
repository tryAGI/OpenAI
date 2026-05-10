
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Realtime translation session. Translation sessions continuously translate input<br/>
    /// audio into the configured output language.
    /// </summary>
    public sealed partial class RealtimeTranslationSession
    {
        /// <summary>
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The session type. Always `translation` for Realtime translation sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeTranslationSessionTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeTranslationSessionType Type { get; set; }

        /// <summary>
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        /// The Realtime translation model used for this session. This field is set at<br/>
        /// session creation and cannot be changed with `session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Configuration for translation input and output audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranslationSessionAudio Audio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSession" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the session that looks like `sess_1234567890abcdef`.
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp for the session, in seconds since epoch.
        /// </param>
        /// <param name="model">
        /// The Realtime translation model used for this session. This field is set at<br/>
        /// session creation and cannot be changed with `session.update`.
        /// </param>
        /// <param name="audio">
        /// Configuration for translation input and output audio.
        /// </param>
        /// <param name="type">
        /// The session type. Always `translation` for Realtime translation sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationSession(
            string id,
            int expiresAt,
            string model,
            global::tryAGI.OpenAI.RealtimeTranslationSessionAudio audio,
            global::tryAGI.OpenAI.RealtimeTranslationSessionType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.ExpiresAt = expiresAt;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationSession" /> class.
        /// </summary>
        public RealtimeTranslationSession()
        {
        }

    }
}