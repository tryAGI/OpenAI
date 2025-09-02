
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Response from creating a session and client secret for the Realtime API.
    /// </summary>
    public sealed partial class RealtimeCreateClientSecretResponse
    {
        /// <summary>
        /// Expiration timestamp for the client secret, in seconds since epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        /// The session configuration for either a realtime or transcription session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateResponse, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponse, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse> Session { get; set; }

        /// <summary>
        /// The generated client secret value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCreateClientSecretResponse" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Expiration timestamp for the client secret, in seconds since epoch.
        /// </param>
        /// <param name="session">
        /// The session configuration for either a realtime or transcription session.
        /// </param>
        /// <param name="value">
        /// The generated client secret value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeCreateClientSecretResponse(
            int expiresAt,
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateResponse, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateResponse> session,
            string value)
        {
            this.ExpiresAt = expiresAt;
            this.Session = session;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeCreateClientSecretResponse" /> class.
        /// </summary>
        public RealtimeCreateClientSecretResponse()
        {
        }
    }
}