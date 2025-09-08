
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a session and client secret for the Realtime API. The request can specify<br/>
    /// either a realtime or a transcription session configuration.<br/>
    /// [Learn more about the Realtime API](https://platform.openai.com/docs/guides/realtime).
    /// </summary>
    public sealed partial class RealtimeCreateClientSecretRequest
    {
        /// <summary>
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Session configuration to use for the client secret. Choose either a realtime<br/>
        /// session or a transcription session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionJsonConverter))]
        public global::tryAGI.OpenAI.Session? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCreateClientSecretRequest" /> class.
        /// </summary>
        /// <param name="expiresAfter">
        /// Configuration for the client secret expiration. Expiration refers to the time after which<br/>
        /// a client secret will no longer be valid for creating sessions. The session itself may<br/>
        /// continue after that time once started. A secret can be used to create multiple sessions<br/>
        /// until it expires.
        /// </param>
        /// <param name="session">
        /// Session configuration to use for the client secret. Choose either a realtime<br/>
        /// session or a transcription session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCreateClientSecretRequest(
            global::tryAGI.OpenAI.RealtimeCreateClientSecretRequestExpiresAfter? expiresAfter,
            global::tryAGI.OpenAI.Session? session)
        {
            this.ExpiresAfter = expiresAfter;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCreateClientSecretRequest" /> class.
        /// </summary>
        public RealtimeCreateClientSecretRequest()
        {
        }
    }
}