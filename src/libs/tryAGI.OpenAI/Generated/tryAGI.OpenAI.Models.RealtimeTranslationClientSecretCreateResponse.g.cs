
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Response from creating a translation session and client secret for the Realtime API.
    /// </summary>
    public sealed partial class RealtimeTranslationClientSecretCreateResponse
    {
        /// <summary>
        /// The generated client secret value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Expiration timestamp for the client secret, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        /// A Realtime translation session. Translation sessions continuously translate input<br/>
        /// audio into the configured output language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranslationSession Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientSecretCreateResponse" /> class.
        /// </summary>
        /// <param name="value">
        /// The generated client secret value.
        /// </param>
        /// <param name="expiresAt">
        /// Expiration timestamp for the client secret, in seconds since epoch.
        /// </param>
        /// <param name="session">
        /// A Realtime translation session. Translation sessions continuously translate input<br/>
        /// audio into the configured output language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationClientSecretCreateResponse(
            string value,
            int expiresAt,
            global::tryAGI.OpenAI.RealtimeTranslationSession session)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ExpiresAt = expiresAt;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientSecretCreateResponse" /> class.
        /// </summary>
        public RealtimeTranslationClientSecretCreateResponse()
        {
        }
    }
}