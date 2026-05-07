
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a translation session and client secret for the Realtime API.
    /// </summary>
    public sealed partial class RealtimeTranslationClientSecretCreateRequest
    {
        /// <summary>
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Realtime translation session configuration. Translation sessions stream source<br/>
        /// audio in and translated audio plus transcript deltas out continuously.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientSecretCreateRequest" /> class.
        /// </summary>
        /// <param name="session">
        /// Realtime translation session configuration. Translation sessions stream source<br/>
        /// audio in and translated audio plus transcript deltas out continuously.
        /// </param>
        /// <param name="expiresAfter">
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeTranslationClientSecretCreateRequest(
            global::tryAGI.OpenAI.RealtimeTranslationSessionCreateRequest session,
            global::tryAGI.OpenAI.RealtimeTranslationClientSecretCreateRequestExpiresAfter? expiresAfter)
        {
            this.ExpiresAfter = expiresAfter;
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeTranslationClientSecretCreateRequest" /> class.
        /// </summary>
        public RealtimeTranslationClientSecretCreateRequest()
        {
        }
    }
}