
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Ephemeral key returned by the API.
    /// </summary>
    public sealed partial class RealtimeSessionCreateResponseClientSecret
    {
        /// <summary>
        /// Ephemeral key usable in client environments to authenticate connections<br/>
        /// to the Realtime API. Use this in client-side environments rather than<br/>
        /// a standard API token, which should only be used server-side.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseClientSecret" /> class.
        /// </summary>
        /// <param name="value">
        /// Ephemeral key usable in client environments to authenticate connections<br/>
        /// to the Realtime API. Use this in client-side environments rather than<br/>
        /// a standard API token, which should only be used server-side.
        /// </param>
        /// <param name="expiresAt">
        /// Timestamp for when the token expires. Currently, all tokens expire<br/>
        /// after one minute.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeSessionCreateResponseClientSecret(
            string? value,
            int? expiresAt)
        {
            this.Value = value;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeSessionCreateResponseClientSecret" /> class.
        /// </summary>
        public RealtimeSessionCreateResponseClientSecret()
        {
        }
    }
}