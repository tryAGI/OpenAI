
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Ephemeral key returned by the API.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseGAClientSecret
    {
        /// <summary>
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        /// Ephemeral key usable in client environments to authenticate connections to the Realtime API. Use this in client-side environments rather than a standard API token, which should only be used server-side.
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
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGAClientSecret" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </param>
        /// <param name="value">
        /// Ephemeral key usable in client environments to authenticate connections to the Realtime API. Use this in client-side environments rather than a standard API token, which should only be used server-side.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeSessionCreateResponseGAClientSecret(
            int expiresAt,
            string value)
        {
            this.ExpiresAt = expiresAt;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseGAClientSecret" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseGAClientSecret()
        {
        }
    }
}