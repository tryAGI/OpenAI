
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual Admin API key in an org.
    /// </summary>
    public sealed partial class AdminApiKey
    {
        /// <summary>
        /// The object type, which is always `organization.admin_api_key`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AdminApiKeyObjectJsonConverter))]
        public global::tryAGI.OpenAI.AdminApiKeyObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: key_abc
        /// </summary>
        /// <example>key_abc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the API key<br/>
        /// Example: Administration Key
        /// </summary>
        /// <example>Administration Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The redacted value of the API key<br/>
        /// Example: sk-admin...def
        /// </summary>
        /// <example>sk-admin...def</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedactedValue { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the API key was created<br/>
        /// Example: 1711471533
        /// </summary>
        /// <example>1711471533</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public int? LastUsedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AdminApiKeyOwner Owner { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints<br/>
        /// Example: key_abc
        /// </param>
        /// <param name="redactedValue">
        /// The redacted value of the API key<br/>
        /// Example: sk-admin...def
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the API key was created<br/>
        /// Example: 1711471533
        /// </param>
        /// <param name="owner"></param>
        /// <param name="object">
        /// The object type, which is always `organization.admin_api_key`
        /// </param>
        /// <param name="name">
        /// The name of the API key<br/>
        /// Example: Administration Key
        /// </param>
        /// <param name="lastUsedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AdminApiKey(
            string id,
            string redactedValue,
            int createdAt,
            global::tryAGI.OpenAI.AdminApiKeyOwner owner,
            global::tryAGI.OpenAI.AdminApiKeyObject @object,
            string? name,
            int? lastUsedAt)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.RedactedValue = redactedValue ?? throw new global::System.ArgumentNullException(nameof(redactedValue));
            this.CreatedAt = createdAt;
            this.LastUsedAt = lastUsedAt;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminApiKey" /> class.
        /// </summary>
        public AdminApiKey()
        {
        }
    }
}