
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration options for the generated client secret.
    /// </summary>
    public sealed partial class RealtimeSessionCreateRequestClientSecret
    {
        /// <summary>
        /// Configuration for the ephemeral token expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecretExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestClientSecret" /> class.
        /// </summary>
        /// <param name="expiresAfter">
        /// Configuration for the ephemeral token expiration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateRequestClientSecret(
            global::tryAGI.OpenAI.RealtimeSessionCreateRequestClientSecretExpiresAfter? expiresAfter)
        {
            this.ExpiresAfter = expiresAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateRequestClientSecret" /> class.
        /// </summary>
        public RealtimeSessionCreateRequestClientSecret()
        {
        }
    }
}