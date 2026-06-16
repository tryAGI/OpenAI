
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminApiKeysCreateRequest
    {
        /// <summary>
        /// Example: New Admin Key
        /// </summary>
        /// <example>New Admin Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The number of seconds until the API key expires. Omit this field for a key that does not expire.<br/>
        /// Example: 2592000
        /// </summary>
        /// <example>2592000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: New Admin Key
        /// </param>
        /// <param name="expiresInSeconds">
        /// The number of seconds until the API key expires. Omit this field for a key that does not expire.<br/>
        /// Example: 2592000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKeysCreateRequest(
            string name,
            int? expiresInSeconds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKeysCreateRequest" /> class.
        /// </summary>
        public AdminApiKeysCreateRequest()
        {
        }

    }
}